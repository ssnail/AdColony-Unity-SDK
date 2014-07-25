#AdColony Post Process Build

Logan Knecht

Version 1.0

2014/07/16

---

**Class List**

AdColonyPostProcessBuild

AdColonyPostProcessBuild.Framework

---

##Summary

When building a Unity project for specific platforms a build process needs to occur. Sometimes this build process may not add everything you as a developer need in order to correctly deploy your codebase.

In the case of AdColony's SDK: by default, Unity does not add the correct frameworks and build settings needed to deploy to devices immediately. More specifically this the case for iOS.

While this can be fixed through manual intervention it's been said that:

"If you catch yourself doing something more than three times, it's time to automate."

##### - Joshua Connor

######      - Michael Scott

Because of of this the AdColonyPostProcessBuild script was created. This script will read in the generated pbxproj file that Unity creates. It is created when you build for XCode from within the Unity editor. Once read in it will inject specific frameworks and build settings needed to successfully deploy your project, with AdColony's SDK.

---
##Files

- AdColonyPostProcessBuild.cs

---

##Installation

In order to do this all you will need to do is add the "AdColonyPostProcessBuild.cs" file as a child of your Assets/Editor directory, inside of the project you would like to deploy.

Below are some screen shots demonstrating how your project hierarchy should look.

####ProjectHierarchyConfigurationDefault:

![Project Hierarchy Configuration Default](https://github.com/AdColony/AdColony-Unity-SDK/blob/master/Documentation/AdColonyPostProcessBuild/images/ProjectHierarchyConfigurationDefault.png)

####ProjectHierarchyConfigurationNested:

![Project Hierarchy Configuration Nested](https://github.com/AdColony/AdColony-Unity-SDK/blob/master/Documentation/AdColonyPostProcessBuild/images/ProjectHierarchyConfigurationNested.png)

---

## Class Summaries

###AdColonyPostProcessBuild

This is a script that was created for modifying the generated XCode project created by Unity. This was done in order to add frameworks and build configurations automatically so that the user will not have to worry about deploying the AdColony SDK on iOS.

###Framework
This is a class that was created in order to group all the information needed to add a framework into the pbxproj file. This class is included in the same files as "AdColonyPostProcessBuild.cs"  in order to save space, and make the importing and use of the file easier for other developers.
