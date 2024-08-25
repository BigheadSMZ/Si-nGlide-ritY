# Si-nGlide-ritY
Configurator + launcher for nGlide, localizing a configuration to a single game instead of all games using global settings. Si-nGlide-ritY (pronounced sing-la-dare-it-ee) contains two executables, one to configure/launch a game with specific settings, and one to simply launch using those settings. The idea is to make it more portable akin to something like dgVoodoo.

![image](https://github.com/user-attachments/assets/0069ac57-1607-4d5d-8ebb-d5cd9d6e7971)

# Purpose
To convert nGlide into a portable installation and localize nGlide settings to a single game, much in the way dgVoodoo and some other Glide wrappers work. As you may already know, when installing nGlide it is installed into the Windows **System32** or **SysWOW64** folder, depending on whether or not you have a 32-bit or 64-bit operating system. Older games that used the Glide API, that do not have the required DLL file (glide.dll, glide2x.dll, or glide3x.dll) within the game folder, will load nGlide from one of the Windows folders mentioned previously. As you may also already know, nGlide stores its configuration settings in the registry. All of this means, nGlide will use the same settings for all games regardless if you want individual settings for each game. That's where this program comes in.

So what you may not know, is that nGlide also allows setting environment variables before launching a game that will temporarily override the settings stored in the registry. This can be accomplished with a batch file, but I went for a somewhat more elegant approach, which is this program **Si-nGlide-ritY**. It works by storing the game's configuration settings in an INI file, loading those settings just before launching the game, and setting them to the appropriate environment variables. The game must be launched using **nGlideConfig.exe** or **nGLideLaunch.exe**, the executable that is loaded is stored in the INI file.

# How to Use
This section explains how to create/store a "portable" version of nGlide.
- Install [nGlide](https://www.zeus-software.com/downloads/nglide) (the latest as of writing is v2.10).
- Download Si-nGlide-ritY from this repo. Extract the 7z to a folder.
- Grab **glide.dll**, **glide2x.dll**, and **glide3x.dll** from the **System32** or **SysWOW64** folder and drop them in the same folder as Si-nGlide-ritY. You now have a "portable" nGlide to use with whatever game you choose.
- Put this folder somewhere safe so you can use it later when installing a game that uses Glide.
- Now that you have the DLL files, you may want to uninstall the "global" nGlide if desired.

![361245860-24ef91d5-c1e5-4043-9538-2594fdb66a64](https://github.com/user-attachments/assets/2c5e7f0b-4172-4f05-9ccc-ab1cce720d72)

This section explains how to install/use it with a game.
- Drop the files **nGlideConfig.exe**, **nGLideLaunch.exe**, **nGlideConfig.ini**, and the **glide#.dll** the game uses into the same folder as the game's executable. If you don't know which DLL file to use, it may take some trial and error.
- This makes it so the game loads the DLL file from its install folder instead instead of the Windows folder.
- Load **nGlideConfig.exe** which will allow you to configure settings which are stored in **nGlideConfig.ini**.
- Select the path to the game's executable. This is what will be launched when pressing **Launch** or when using **nGLideLaunch.exe**.
- Now just launch the game using either **nGlideConfig.exe** or **nGLideLaunch.exe** and it will use the local settings.
- You can create a shortcut to **nGLideLaunch.exe**, change its icon, and rename it to obfuscate that it's the Si-nGlide-ritY executable.

# Caveats/Shortcomings
I always like to do this section as nothing is perfect. While there isn't many caveats to Si-nGlide-ritY, the one I can think of is having to use **nGlideConfig.exe** or **nGLideLaunch.exe** to launch the game. This is not much of a problem as a shortcut can be created to either, renamed, and a new icon chosen that matches the game to make it appear as if you are launching the game's executable. If the game is not launched using either of the Si-nGlide-ritY executables, the INI file will not be loaded and nGlide will instead use the global configuration settings from the registry (a.k.a. its normal behavior).

# Why I Created It
I'm not a fan of any software that tries to do things "globally", and it is somewhat annoying that all games use the same configuration. What if I want different settings per game? I much prefer the way dgVoodoo handles things, having a localized configurator + INI settings. But there is no denying that nGlide is one of the best, if not the best Glide wrapper out there. It works with some games that dgVoodoo struggles with (like Pandemonium and Pandemonimum 2 just to name an example).

# Credits
- **[Modern FolderSelectDialog](https://stackoverflow.com/questions/66823581/use-the-upgraded-folderbrowserdialog-vista-style-in-powershell):** Ben Philipp at stackoverflow
