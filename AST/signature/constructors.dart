import 'package:analyzer/analyzer.dart';
import 'package:analyzer/dart/element/element.dart';
import 'package:analyzer/src/dart/element/element.dart';
import 'package:analyzer/dart/ast/ast.dart';
import '../implementation/implementation.dart';
import '../naming.dart';
import '../comments.dart';
import 'methods.dart';
import '../config.dart';
import '../codeBuilder.dart';
import 'package:front_end/src/scanner/token.dart';

class Constructors {
  static void printConstructor(
      CodeBuilder code, ConstructorElementImpl constructor, String generics) {
    if (constructor.enclosingElement is ClassElement) {
      var isFactory = constructor.isFactory;
      var className = constructor.enclosingElement.name;
      var constructorName = constructor.name;
      var callsBaseCtor = constructor.redirectedConstructor != null ||
          (constructor.constantInitializers != null &&
              constructor.constantInitializers.length > 0);

      //TODO: handle constructor.redirectedConstructor with 'this' or other type

      Comments.appendComment(code, constructor);

      var node = constructor.computeNode();
      var parameters = Methods.printParameters(constructor, null, null);
      // normal constructors do not have any special key chars
      if (constructorName == '') {
        if (isFactory) {
          code.writeln('public static ${className} CreateNew($parameters)');
        } else {
          code.writeln('public ${className}($parameters)');
        }
      }
      // internal classes start with an underscore in dart
      else if (constructorName == '_') if (isFactory) {
        code.writeln('internal static ${className} CreateNew($parameters)');
      } else {
        code.writeln('internal ${className}($parameters)');
      }
      else // I'm named, hence we are turning into static methods that call private constructors
      {
        var accessibility =
            constructorName.startsWith('_') ? 'internal' : 'public';
        var parameterNames = Methods.printParameterNames(constructor);
        var parametersWithoutDefaultValueForOptionals = Methods.printParameters(
            constructor, null, null,
            printDefaultValueForOptionalParameters: false);

        code.writeln(
            '$accessibility static ${className}$generics ${Naming.upperCamelCase(constructorName)}($parameters)');

        if (!isFactory) {
          //NOTE: In Dart one can create any number of constructors with a different name
          //In C# constructors are only 'unnamed' and must all have different signature
          //for example this is valid in Dart:
          // class Point {
          //   double x, y;
          //   Point(this.x, this.y);
          //   Point.origin() {
          //     x = 0;
          //     y = 0;
          //   }
          //   Point.other() {
          //     x = 12;
          //     y = 22;
          //   }
          // }
          //
          //but not in c#
          // class Point {
          //   double x, y;
          //   Point(this.x, this.y) { .... }
          //   public Origin() => new Point();
          //   Point() {
          //     x = 0;
          //     y = 0;
          //   }
          //   public Other() => new Point();
          //   Point() {
          //     x = 12;
          //     y = 22;
          //   }
          // }
          //the following solution I've found is to create private constructors
          //with dummy parameters
          // class Point {
          //   double x, y;
          //   Point(this.x, this.y) { .... }
          //   public Point Origin() => new Point();
          //   Point() {
          //     x = 0;
          //     y = 0;
          //   }
          //   public Point Other() => new Point(null);
          //   Point(object dummyPar1) {
          //     x = 12;
          //     y = 22;
          //   }
          // }
          var constructorKey =
              '${className}($parametersWithoutDefaultValueForOptionals)';
          int dummyParametersCount = 0;
          String dummyParameters = parametersWithoutDefaultValueForOptionals;
          String customParameterNulls = parameterNames;
          while (code.containsKey(constructorKey)) {
            //we have another constructor with the same signature
            //let's create a dummy signature
            dummyParametersCount++;
            customParameterNulls +=
                (customParameterNulls.isNotEmpty ? ', ' : '') + 'null';
            dummyParameters += (dummyParameters.isNotEmpty ? ', ' : '') +
                'object ___dummy_param___$dummyParametersCount';
            constructorKey = '${className}($dummyParameters)';
          }

          code.writeln(
              '=> new ${className}$generics(${customParameterNulls});');
          code.writeln('');
          code.writeCodeLn(
              constructorKey, 'private ${className}($dummyParameters)');
        }
      }

      // Base class call
      if (callsBaseCtor && !isFactory) {
        code.writeln(': base(${getBaseParameters(constructor)})');
      }

      // Fill out Constructor body
      if (node != null) {
        if (node.body is ExpressionFunctionBody) {
          //handle the case when the body of the constructor is an expression
          //i.e.
          //factory ThemeData.light() => ThemeData(brightness: Brightness.light);
          code.writeln(Implementation.processExpressionFunction(node.body));
          return;
        }

        var body = '{\n';

        // Add auto assignments if any
        var autoAssignment =
            Methods.printAutoParameters(constructor, className);
        if (autoAssignment.isNotEmpty) body += autoAssignment;

        // add logic and closing curly brace
        if (Config.includeConstructorImplementations)
          body += Implementation.MethodBody(node.body).substring(2);
        else
          body += 'throw new NotImplementedException(); }';

        // Normal constructor body
        code.writeln(body);
      } else
        code.writeln('{ }');
    } else
      throw new AssertionError(
          'A constructor is not inside a ClassElement, that should not happen.');
  }

  static String getBaseParameters(ConstructorElement constructor) {
    // Get parameters
    var parameters = "";
    // TODO: I don't think we auto initialize anything when there are other constantIntializers other than a SuperConstructorInvocation
    // Need to add the other code into the method body.
    if (constructor is ConstructorElementImpl &&
        constructor.constantInitializers != null &&
        constructor.constantInitializers
                .where((x) => x is SuperConstructorInvocation)
                .length >
            0) {
      // :)
      var constantInitializer = constructor.constantInitializers
          .where((x) => x is SuperConstructorInvocation)
          .first;
      var argumentList =
          constantInitializer.childEntities.where((x) => x is ArgumentList);
      if (argumentList != null && argumentList.length > 0) {
        ArgumentList list = argumentList.firstWhere((x) => x is ArgumentList);
        int count = 0;
        parameters = list.childEntities
            .where((argument) =>
                argument is! BeginToken && argument is! SimpleToken)
            .map((argument) {
          var parameter =
              Naming.escapeFixedWords(Implementation.processEntity(argument))
                  .trim();
          if (parameter == 'null' &&
              constructor.redirectedConstructor != null &&
              constructor.redirectedConstructor.parameters != null &&
              constructor.redirectedConstructor.parameters[count].type
                      .displayName ==
                  'T') {
            // Can't pass null to generic type in C# (you can in Dart).
            parameter = 'default(T)';
          }
          count += 1;
          return parameter;
        }).join(",");
      }
    }
    return parameters;
  }
}
