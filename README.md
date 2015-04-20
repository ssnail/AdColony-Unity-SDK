#AdColony Unity Plugin
Modified: April 20th, 2015  
Unity Plug-in Version: 2.0.6
iOS SDK Version: 2.5.0  
Android SDK Version: 2.2.1  

##Getting Started with AdColony Unity:
First time users should review the [quick start guide](https://github.com/AdColony/AdColony-Unity-SDK/wiki).  
Note for **Unity 5:** 
On iOS, when building the Xcode project, you may get Semantic Issues and Arc Restrictions errors in the UnityADC.mm file. To resolve these issues, add the `-fno-objc-arc` flag to the build process for this file only. To add a flag to a single file navigate **Targets -> Build Phases -> Compile Sources.** Double click on the right column of the UnityADC.mm row.


###AdColony Package Contains:
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

##To Download:
The AdColony Unity SDK Package is [Available Here for download](https://github.com/AdColony/AdColony-Unity-SDK/raw/master/Packages/adcolony.unitypackage)

##To Install
The AdColony Unity SDK Package is a standard .unitypackage that can be imported into your project.
To review importing unity packages please see [this document](http://docs.unity3d.com/Manual/HOWTO-exportpackage.html)

##Sample Applications:
Included are apps to serve as examples for AdColony integration, configuration and playing interstitial and V4VC ads.

##Legal Requirements:
By downloading the AdColony SDK, you are granted a limited, non-commercial license to use and review the SDK solely for evaluation purposes.  If you wish to integrate the SDK into any commercial applications, you must register an account with [AdColony](https://clients.adcolony.com/signup) and accept the terms and conditions on the AdColony website.

Note that U.S. based companies will need to complete the W-9 form and send it to us before publisher payments can be issued.

##Contact Us:
For more information, please visit AdColony.com. For questions or assistance, please email us at support@adcolony.com.

