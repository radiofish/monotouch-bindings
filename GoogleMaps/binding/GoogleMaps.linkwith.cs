using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("GoogleMaps", LinkTarget.Simulator | LinkTarget.ArmV7,"-ObjC -lsqlite3 -lz -licucore -lstdc++",Frameworks = "AVFoundation CoreData CoreLocation CoreText GLKit ImageIO OpenGLES QuartzCore SystemConfiguration", ForceLoad = true)]
