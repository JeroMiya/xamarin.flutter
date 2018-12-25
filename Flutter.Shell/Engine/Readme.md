* ENGINE

The Xamarin Flutter Engine has been ported from the [Flutter Engine](https://github.com/flutter/engine)

It is basically split into two sources.  Dart and C++.  Source for both can be found in the [/lib/ui/](https://github.com/flutter/engine/tree/master/lib/ui) folder of the flutter engine.

This is where the Xamarin port will have a lot of benefit as this layer has significantly reduced complexity by having all source in a single language and runtime.

[Skia](skia.org) is still be graphics engine.


FlutterException is used to replace how the Flutter engine passed exceptions info (as a string) from the c++ world to Dart.  Dart would then throw the exception.  
FlutterException cuts out all the middleware plumbing.
