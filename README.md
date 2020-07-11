**INCOMPLETE: While this project is technically feasible, in its current state it is incomplete and not currently functional. It is perhaps several months away from being fully functional, per the original author's (Adam Pedley) estimates. It was abandoned by its original creator, Adam Pedley, as a proof of concept or experiment. I feel the project has value to the community, so I've since cloned the repository and I hope to tinker on it little by little on my own time. If you're interested in contributing to the project, I welcome you! If you're looking for a working version of Flutter for Xamarin, it's not here yet. But, please go ahead and bookmark, star, and follow this repository for future updates. Issues and comments are always welcome, so long as they follow the code of conduct, however note that as a hobby/side-project my capacity to respond to every request is limited. Note: I may close issues that are out of scope in the near term just to keep the issue tracker easier to manage, but I'll see if I can find a way to track long term backlog issues in another way.**

# Flutter for Xamarin

*This project has no affiliation with Microsoft, Google or the Xamarin or Flutter teams.*

The project is designed to make the Flutter SDK available on the .NET Framework, initially with the supported platforms of:

1) Xamarin.Android
2) Xamarin.iOS
3) UWP

There is no reason this couldn't also expand to any place where [SkiaSharp](https://github.com/mono/SkiaSharp) is supported.

This project is never expected to be commercially viable, unless it is picked up or supported by a larger company. As it currently stands, this is just a fun side project, done by a bunch of developers in their spare time. We offer no support for solutions ever built with this framework, or any guarantee of completion.

# Overview

To make this work, numerous components need to come together.

![alt text](https://github.com/adamped/xamarin.flutter/blob/master/XamarinFlutterProject.png?raw=true "Overview of project")

## Transpiler

The transpiler, will convert the existing Flutter SDK (written in Dart) to C#, for consumption in .NET applications.

Using the DartAnalyzer, we analyze the Flutter SDK, and output C#.

## Bindings

Flutter Bindings will include the connection between SkiaSharp and the Flutter SDK. We will not be using the actual Flutter engine, though we may do in the future.

Due to previous exploratory work, the Flutter engine is difficult to integrate with since we need to expose many C++ level APIs. Due to how this is implemented in the Flutter engine currently, it would require certain modifications and would be difficult to keep in sync with the master repository.

Hence, we will map the calls directly to SkiaSharp and Harfbuzz to draw directly on a SkiaCanvas. I could regret this, we shall see :)

## Shell

The Shell, is where the Skia Canvas is initialized and platform level events are collected, and sent through to the Bindings project.

# License

All code here is licensed under the [MIT license](LICENSE)
