import 'package:analyzer/analyzer.dart';
import 'package:analyzer/dart/element/element.dart';

import '../naming.dart';
import '../comments.dart';
import 'methods.dart';

class Delegates {
  static String printDelegate(FunctionTypeAliasElement element) {
    var returnType = Naming.getReturnType(element);
    var methodName = Naming.nameWithTypeParameters(element, false);
    var parameter = Methods.printParameter(element, element, null);

    var code = new StringBuffer();
    Comments.appendComment(code, element);
    code.write("public delegate ${returnType} ${methodName}(${parameter});");

    return code.toString();
  }
}
