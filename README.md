# Windows Commander

Windows Commander lets you run commands with ease and written in C#. It provides a simple CLI
but a graphical terminal emulator for it is planned.

![image](https://user-images.githubusercontent.com/78053003/170840882-4aca802d-c9bb-4b35-9504-67ad4ce5fa82.png)

## Install

**Note: Commander is only tested on [Windows 11](https://microsoft.com/windows/windows-11).**

1. Download and install [.NET 6.0 SDK 64-Bit](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-6.0.301-windows-x64-installer).
   * You should also install [the .NET runtime](https://dotnet.microsoft.com/download/dotnet/6.0/runtime).
   * Before installing, if you use **Visual Studio**, you should upgrade to Visual Studio 2022 at [the download page](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030). You can break your current Visual Studio by installing .NET 6.0.
2. Download and install [Git for Windows](https://gitforwindows.org). (Or with Chocolatey, install with `choco install git`.)
3. Get the code from here by running the following in Git Bash: `cd /c/users/USERNAME;git clone https://github.com/Tyler887/Commander`
   * You need to replace "USERNAME" with the username you use in Windows.
5. Exit Git Bash and open a Windows command-line (`powershell`, `cmd`, `pwsh`, etc).
6. Go into the source files:
   * Windows Command Prompt: `CD %USERPROFILE%\Commander`
   * Windows PowerShell (or PowerShell 7): `Set-Location $env:UserProfile\Commander`
7. Open `Commander.sln` in Visual Studio and build it
8. Copy build files to `C:\WINDOWS`, this should not harm Windows but will make it easier to start Commander
   from a command-line
9. enjoy ;)
