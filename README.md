# CyberArkAppLauncherGUI-CSharp
CyberArk Application Launcher - C Sharp

![ScreenShot](https://raw.githubusercontent.com/jef132/CyberArkAppLauncher-CSharp/master/C-Sharp.PNG)


**Overview**

Small App that can be use to allow users to launch applications installed on Cyberark PSM servers written in C#.
RestSharp library is used for REST API calls.

**Details**

This will allow the user to select a Datacenter (AKA PSM) and select the application and then login to Cyberark Privilege Access Security using RADIUS. The app will download the RDP fileto the users TEMP folder and then launch the RDP file. Today the application has 3 browsers configured but this can obviously be adjusted to support your environment.

