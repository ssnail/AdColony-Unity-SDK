##Change Log (2015/04/20):
* Added Support for IAP Promo Adds

##Change Log (2015/02/23):
* Change Log split from README
* Removed Support for Unity Pre4.3
* Removed iOS post processing
* Simplified Samples directory.
* AdColony-iOS-SDK 2.5.0 integrated
* AdColony-Android-SDK 2.2.1 integrated

##Change Log (2014/11/06):
* iOS SDK 2.4.13 integrated

##Change Log (2014/07/23):
* A new build script has been created in order to facilitate automated integration when building for iOS, using the AdColony-Unity-SDK. This build script is called `AdColonyPostProcessBuild.cs'
  * This will now allow developers, who are targetting an iOS build, using the AdColony-Unity-SDK, to build and run automatically with-in Unity. The `AdColonyPostProcessBuild.cs` will handling linking the correct frameworks, and build settings needed for XCode to run.
* With this new post process build script comes AdColony packages. These packages will be the new method in which developers can import the AdColony-Unity-SDK to their project
  * There are two packages now available, one for users who are still developing with Unity versions less than Unity 4.3, and one package for those who are developing for Unity versions greater than or equal to Unity 4.3
* New sample apps have been added, this is so that more clarity can be found when looking for example use cases.
   * There is now a complex sample app that shows a suggested configuration that other developers might consider using when deciding how to implement their version of the AdColony-Unity-SDK. This is called the `AdColony AdManager`, but its file name is `ADCAdManager.cs`

##Change Log (2014/01/25):
* Android SDK 2.0.6 integrated
* Added `AndroidManifest_Unity43.xml` -- You must use this manifest if you are building with Unity 4.3.x, no change is necessary if you are using Unity 4.2.x and below.

##Change Log (2013/11/26):
* iOS SDK 2.2.4 integrated
* Android SDK 2.0.4 integrated
* Public class methods `StatusForZone` exposed.
* The `OnVideoFinished` delegate signature now includes a boolean parameter. The change requires a small update to existing integrations. For more information, consult the `Updating from Earlier Versions` section of the Unity SDK documentation for your platform (Android or iOS).
* `OnAdAvailabilityChange` delegate has been exposed.

##Change Log (2013/09/23):
* iOS SDK 2.2.2 integrated
* Android SDK 2.0.3 integrated
* Public class methods `SetCustomID` and `GetCustomID` exposed.
