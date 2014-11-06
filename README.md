#AdColony Unity Plugin
Modified: September 19th, 2014
Unity Plug-in Version: 2.0.4
iOS SDK Version: 2.4.13 
Android SDK Version: 2.1.1

##Getting Started with AdColony:
First time users should review the [quick start guide](https://github.com/AdColony/AdColony-Unity-SDK/wiki). Returning users should only need to update the AdColony SDK files in their projects (note, iOS developers, that the iOS SDK is now distributed as framework). Also with this release comes an update to the `OnVideoFinished` delegate signature, which now includes a boolean parameter. For returning users this change requires a small update to existing integrations. For more information, consult the `Updating from Earlier Versions` section of the Unity SDK documentation for your platform (Android or iOS).

##To Download:
To download the specific package for importing into Unity, select the following link that correctly matches your desired version. This should trigger the download, or a prompt asking where to save, for the selected package.

[AdColony Pre Unity 4.3 Package](https://github.com/AdColony/AdColony-Unity-SDK/raw/master/Packages/AdColony%20Pre%20Unity%204.3%20Package.unitypackage) 

[AdColony Post Unity 4.3 Package](https://github.com/AdColony/AdColony-Unity-SDK/raw/master/Packages/AdColony%20Post%20Unity%204.3%20Package.unitypackage) 

Previously, The simplest way to obtain the AdColony Unity plugin was to click the `Download ZIP` button located in the right-hand navigation pane of this page. This method is still supported, however unless you're looking to obtain all the files within this repository this method is not suggested.

##To Install
To install the AdColony plug-in all you should need to do is import the package that matches the version of Unity you have. Upon importing, Unity should place the files in the correct location needed to support the AdColony SDK.

If you're not familiar with the package import process with Unity [follow this link to read more about the process](http://docs.unity3d.com/Manual/HOWTO-exportpackage.html)

##Package Contents
###AdColony Pre Unity 4.3 Package Contains:
* Editor
  * `mod_pbxproj.pyc`
  * `PostprocessBuildPlayer`
  * `PostprocessBuildPlayer_ADC`
* Plugins
  * `AdColony.cs`  
  * Android 
    * `adcolony.jar`
    * `AndroidManifest.xml`
    * `unityadc.jar`
  * iOS
    * `AdColony.framework`
    * `UnityADC.mm`
* Scripts
  * AdColony
    * `ADCAdManager.cs`
    * `ADCVideoZone.cs`
    * `ADCVideoZoneType.cs`

###AdColony Post Unity 4.3 Package Contains:
* Editor
  * `AdColonyPostProcessBuild.cs`
* Plugins
  * `AdColony.cs`  
  * Android 
    * `adcolony.jar`
    * `AndroidManifest.xml`
    * `unityadc.jar`
  * iOS
    * `AdColony.framework`
    * `UnityADC.mm`
* Scripts
  * AdColony
    * `ADCAdManager.cs`
    * `ADCVideoZone.cs`
    * `ADCVideoZoneType.cs`   

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

##Sample Application:
Included is an app to use as an example and for help on AdColony integration. AdColony configuration, playing of interstial and V4VC ads.


##Legal Requirements:
By downloading the AdColony SDK, you are granted a limited, non-commercial license to use and review the SDK solely for evaluation purposes.  If you wish to integrate the SDK into any commercial applications, you must register an account with [AdColony](https://clients.adcolony.com/signup) and accept the terms and conditions on the AdColony website.

Note that U.S. based companies will need to complete the W-9 form and send it to us before publisher payments can be issued.

##Contact Us:
For more information, please visit AdColony.com. For questions or assistance, please email us at support@adcolony.com.

