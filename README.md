# WinPass11: WinService

🔑 [WinPass11](https://github.com/project-winpass11/) WinService is a tool for loading keys into the registry on startup with the use of Windows Services. Our goal is for the end-user to easily run a single executable and have access to Windows 11 through the dev channel with no worries about your unsupported hardware. There is no installer so **currently** this is not possible. `:(` This program is limited to unsupported processors **only** at the moment.

>There are no service installers at this time in development.

## Prequisites
>Microsoft .NET Core 3.1

https://dotnet.microsoft.com/download/dotnet/3.1

>Our modifyed registry file. (Place this at the root of the C:\ drive)

https://project-winpass11.github.io/CPU/CPU.reg

## Installation
>Download the latest release from https://github.com/project-winpass11/WinPass11.WinService/releases/ .

>Unzip the `netcoreapp3.1.rar` file and open it in file explorer.

>Open a command prompt **as administrator** and change into the directory named `netcoreapp3.1`. This is most likely in downloads.

>Run `.\WinPass11.WinService.exe install start`

## Did it work?
Open About this PC in settings. If your processor is listed as an Intel Core i7 (and it wasn't previously), then congrats! It's worked! 🎂
