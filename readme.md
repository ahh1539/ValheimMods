<!-- ABOUT THE PROJECT -->
## About The Project

This is meant to act as a guide for anyone trying to get started with modding in Valheim. I am planning on adding multiple example mods as tutorials for people to follow along with. Hope you enjoy and please leave a star if this helps you.

### Built With

* [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)
* [Visual Studio](https://visualstudio.microsoft.com/vs/older-downloads/)
* [InSlimVLM](https://www.nexusmods.com/valheim/mods/21?tab=description)
* [dnSpy](https://github.com/dnSpy/dnSpy)
* [Valheim](https://store.steampowered.com/app/892970/Valheim/)


<!-- GETTING STARTED -->
## Getting Started

Make sure that you have all of the requirements downloaded onto your pc

### Finding Valheim game files

1) Go to your steam library and right click on Valheim and select manage.
2) Select Local file and then open in file explorer

### Activate InSlimVLM
InSlimVLM is a mod loader that you will need in order to run your mods that you create. Here is a video tutorial by the creater of the tool https://www.youtube.com/watch?v=gBbtVRAxztM
1) Open up the zip file from the InSlimVLM download and select all of the files inside of the zip
2) Copy those files into Valheim game files ```Steam/steamapps/common/Valheim/```
3) Replace the existing files with the new ones when prompted
4) Also download https://cdn.discordapp.com/attachments/811730725900386344/814475805584261140/winhttp.dll
5) Replace ```winhttp.dll``` in ```Steam\steamapps\common\Valheim``` with the new version (This enables logging in ```Steam\steamapps\common\Valheim\InSlimVML\```for debug purposes)
6) Run Valheim and view the homepage to see that VlmSlim is running

### Using DnSpy to decompile the game code
1) Download the latest release zip file from https://github.com/dnSpy/dnSpy
2) Run DnSpy and select all directories shown on the left side and remove them (left side should be clear)
3) Grab the .dll file ```Steam/steamapps/common/Valheim/valheim_Data/Managed/assembly_valheim.dll```
4) Click and drag that file into the left side file explorer of DnSpy and take a look at all of the source code!

### Setting up the mod
1) Fork this repo
2) Open up VS and create new Visual C# Class library .NET Framework based upon the code forked from here
3) Make sure that you are using .NET Framework 4.7.2
4) Comment out ```PostBuildEvent``` in the ```AlexValheimTest.csproj``` file (we will come back to this)
5) On the Solution Explorer view add the following dependencies
    1) ```Steam\steamapps\common\Valheim\InSlimVML\Mods\0Harmony.dll```
    2) ```Steam\steamapps\common\Valheim\valheim_Data\Managed\assembly_valheim.dll```
    3) ```Steam\steamapps\common\Valheim\valheim_Data\Managed\UnityEngine.dll```
	4) ```Steam\steamapps\common\Valheim\valheim_Data\Managed\UnityEngine.CoreModule.dll```
6) Build the project and copy the file path from the output view shown below
7) Find your projects .dll file from the build
8) Go back to Valheim game files ```Steam\steamapps\common\Valheim\InSlimVML\Mods```
9) Copy and paste your generated .dll file into the ```Mods``` directory
10) Run valheim and press f5 to see the running code!
11) Congrats you made your first mod


### Optional Steps
You can automatically have your .dll file go straight into the InSlimVLM folder using a ```PostBuildEvent```
1) Upon building your project, look for the direectory in which the .dll file is saved
2) Copy the filepath for the .dll file (Shift + Right Click on the file name and select Copy as Path)
3) Go back to the ```AlexValheimTest.csproj``` file and uncomment out the ```PostBuildEvent```
4) Copy and paste the file path into the first part
5) Go and copy your ```Steam\steamapps\common\Valheim\InSlimVML\Mods``` filepath in the same way
6) Paste that path into the second set of quotes
7) Now when you build it will automatically save the .dll file to the proper location

<!-- CONTACT -->
## Contact

Alex Hurley - beast1258@gmail.com

Project Link: [https://github.com/ahh1539/ValheimMods](https://github.com/ahh1539/ValheimMods)


<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [GitHub Emoji Cheat Sheet](https://www.webpagefx.com/tools/emoji-cheat-sheet)
* [Night](https://github.com/matt-harp)
