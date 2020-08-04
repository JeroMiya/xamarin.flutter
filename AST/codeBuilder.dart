import 'dart:collection';

///
///
class CodeBuilder extends StringBuffer {
  HashSet<String> _hashSet = HashSet<String>();
  void writeCodeLn(String key, [Object obj]) {
    super.writeln(obj);
    _hashSet.add(key);
  }

  bool containsKey(String key) => _hashSet.contains(key);
}
