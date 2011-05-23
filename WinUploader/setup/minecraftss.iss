; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{E3FFCB2B-2D0C-4CE8-8BEF-62E2645E9057}
AppName=MinecraftUploader
AppVersion=1.0
;AppVerName=MinecraftUploader 1.0
AppPublisher=startstop.me
AppPublisherURL=http://www.startstop.me/
AppSupportURL=http://www.startstop.me/
AppUpdatesURL=http://www.startstop.me/
DefaultDirName={pf}\MinecraftUploader
DefaultGroupName=MinecraftUploader
AllowNoIcons=yes
OutputDir=J:\my data\SVN\minecraftss\WinUploader\setup
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "J:\my data\SVN\minecraftss\WinUploader\WinUploader\bin\Debug\WinUploader.exe"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\MinecraftUploader"; Filename: "{app}\WinUploader.exe"
Name: "{group}\{cm:ProgramOnTheWeb,MinecraftUploader}"; Filename: "http://www.startstop.me/"
Name: "{group}\{cm:UninstallProgram,MinecraftUploader}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\MinecraftUploader"; Filename: "{app}\WinUploader.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\WinUploader.exe"; Description: "{cm:LaunchProgram,MinecraftUploader}"; Flags: nowait postinstall skipifsilent
