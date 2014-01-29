AdColony Unity Plugin
==================================
Modified: 2014/01/25  
iOS SDK Version: 2.2.4  
Android SDK Version: 2.0.6

To Download:
----------------------------------
The simplest way to obtain the AdColony Unity plugin is to click the `Download ZIP` button located in the right-hand navigation pane of this page. 

Contains:
----------------------------------
* Android
    * Plugins
        * `AdColony.cs`  
        * Android 
            * `adcolony.jar`
            * `AndroidManifest.xml` (use for Unity < 4.3)
            * `AndroidManifest_Unity43.xml` (use for Unity 4.3 and above. Rename this to `AndroidManifest.xml`)
            * `unityadc.jar`
* iOS
    * Editor 
        * `mod_pbxproj.pyc`  
        * `PostprocessBuildPlayer`  
        * `PostprocessBuildPlayer_ADC`  
    * Plugins 
        * `AdColony.cs`  
        * iOS
            * `AdColony.framework`
            * `UnityADC.mm`
* Sample Apps
    * AdColony Sample App - Unity 3.5.6
* W-9 Form.pdf
   

Getting Started with AdColony:
----------------------------------
First time users should review the [quick start guide](https://github.com/AdColony/AdColony-Unity-SDK/wiki). Returning users should only need to update the AdColony SDK files in their projects (note, iOS developers, that the iOS SDK is now distributed as framework). Also with this release comes an update to the `OnVideoFinished` delegate signature, which now includes a boolean parameter. For returning users this change requires a small update to existing integrations. For more information, consult the `Updating from Earlier Versions` section of the Unity SDK documentation for your platform (Android or iOS).

Change Log (2014/01/25):
----------------------------------
* Android SDK 2.0.6 integrated
* Added `AndroidManifest_Unity43.xml` -- You must use this manifest if you are building with Unity 4.3.x, no change is necessary if you are using Unity 4.2.x and below.

Change Log (2013/11/26):
----------------------------------
* iOS SDK 2.2.4 integrated
* Android SDK 2.0.4 integrated
* Public class methods `StatusForZone` exposed.
* The `OnVideoFinished` delegate signature now includes a boolean parameter. The change requires a small update to existing integrations. For more information, consult the `Updating from Earlier Versions` section of the Unity SDK documentation for your platform (Android or iOS).
* `OnAdAvailabilityChange` delegate has been exposed.

Change Log (2013/09/23):
----------------------------------
* iOS SDK 2.2.2 integrated
* Android SDK 2.0.3 integrated
* Public class methods `SetCustomID` and `GetCustomID` exposed.

Sample Application:
----------------------------------
Included is an app to use as an example and for help on AdColony integration. AdColony configuration, playing of interstial and V4VC ads.


Legal Requirements:
----------------------------------
You must accept the terms and conditions on the AdColony website by registering in order to legally use the AdColony SDK. U.S. based companies will need to complete the W-9 form and send it to us, as well as complete the section on payment information on clients.adcolony.com, before publisher payments can be issued.

Contact Us:
----------------------------------
For more information, please visit AdColony.com. For questions or assistance, please email us at support@adcolony.com.

