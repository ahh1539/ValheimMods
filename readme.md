[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![MIT License][license-shield]][license-url]

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
    1) placeholder
    2) placeholder
    3) placeholder
6) Build the project and copy the file path from the output view shown below
7) Find your projects .dll file from the build
8) Go back to Valheim game files ```Steam\steamapps\common\Valheim\InSlimVML\Mods```
9) Copy and paste your generated .dll file into the ```Mods``` directory
10) Run valheim and press f5 to see the running code!
11) Congrats you made your first mod

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.


<!-- CONTACT -->
## Contact

Alex Hurley - [@your_twitter](https://twitter.com/your_username) - beast1258@gmail.com

Project Link: [https://github.com/ahh1539/ValheimMods](https://github.com/ahh1539/ValheimMods)


<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [GitHub Emoji Cheat Sheet](https://www.webpagefx.com/tools/emoji-cheat-sheet)
* [Img Shields](https://shields.io)
* [Choose an Open Source License](https://choosealicense.com)
* [GitHub Pages](https://pages.github.com)
* [Animate.css](https://daneden.github.io/animate.css)
* [Loaders.css](https://connoratherton.com/loaders)
* [Slick Carousel](https://kenwheeler.github.io/slick)
* [Smooth Scroll](https://github.com/cferdinandi/smooth-scroll)
* [Sticky Kit](http://leafo.net/sticky-kit)
* [JVectorMap](http://jvectormap.com)
* [Font Awesome](https://fontawesome.com)



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/ahh1539/ValheimMods/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/ahh1539/ValheimMods/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/ahh1539/ValheimMods/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/othneildrew/Best-README-Template/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: images/screenshot.png
