#AdColony Unity Plugin

Modified: May 29th, 2014  
iOS SDK Version: 2.2.4  
Android SDK Version: 2.0.7

##To Download:
To download specific package for importing into Unity select the following link that correctly matches your desired version. This should trigger the download, or a prompt asking where to save, for the selected package.

[AdColony Pre Unity 4.3 Package](https://github.com/AdColony/AdColony-Unity-SDK/raw/master/Packages/AdColony%20Pre%20Unity%204.3%20Package.unitypackage) 

[AdColony Post Unity 4.3 Package](https://github.com/AdColony/AdColony-Unity-SDK/raw/master/Packages/AdColony%20Post%20Unity%204.3%20Package.unitypackage) 

Previously, The simplest way to obtain the AdColony Unity plugin was to click the `Download ZIP` button located in the right-hand navigation pane of this page. This method is still supported, however unless you're looking to obtain all the files within this repository this method is not suggested.

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

##Getting Started with AdColony:
First time users should review the [quick start guide](https://github.com/AdColony/AdColony-Unity-SDK/wiki). Returning users should only need to update the AdColony SDK files in their projects (note, iOS developers, that the iOS SDK is now distributed as framework). Also with this release comes an update to the `OnVideoFinished` delegate signature, which now includes a boolean parameter. For returning users this change requires a small update to existing integrations. For more information, consult the `Updating from Earlier Versions` section of the Unity SDK documentation for your platform (Android or iOS).

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
You must accept the terms and conditions on the AdColony website by registering in order to legally use the AdColony SDK. U.S. based companies will need to complete the W-9 form and send it to us, as well as complete the section on payment information on clients.adcolony.com, before publisher payments can be issued.

##Contact Us:
For more information, please visit AdColony.com. For questions or assistance, please email us at support@adcolony.com.

