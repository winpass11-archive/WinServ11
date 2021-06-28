# WinPass11: WinService

🔑 [WinPass11](https://github.com/project-winpass11/) WinService is a tool for loading keys into the registry on startup with the use of Windows Services. Our goal is for the end-user to easily run a single executable and have access to Windows 11 through the dev channel with no worries about your unsupported hardware. There is no installer so **currently** this is not possible. `:(` This program is limited to unsupported processors **only** at the moment.

>There are no service installers at this time in development.

## Prerequisites
* [Microsoft .NET Core 3.1](https://dotnet.microsoft.com/download/dotnet/3.1)
* Our modifyed [registry file](https://project-winpass11.github.io/CPU/CPU.reg). (Place this at the root of the C:\ drive)

## Installation
* Download the [latest release](https://github.com/project-winpass11/WinPass11.WinService/releases).
* Unzip the `netcoreapp3.1.rar` file in file explorer.
* Open a command prompt **as administrator** and change into the directory named `netcoreapp3.1`. This is most likely in downloads.
* In the administrator command promt, run `.\WinPass11.WinService.exe install start`

## Did it work?
Open About this PC in settings. If your processor is listed as an Intel Core i7 (and it wasn't previously), then congrats! It's worked! 🎂

## Contributing
When your machine is ready for development, take a look at CONTRIBUTING.md to see how to get your changes merged in.

For more complete docs on developing with Puppet, take a look at the rest of the developer documents.

## License
WinPass11.WinService is licensed by project-winpass11 under the Apache License. (see LICENSE). The usage of third-party packages and programs is determined by the terms of their individual licenses.
