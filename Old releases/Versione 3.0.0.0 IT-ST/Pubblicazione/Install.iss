; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Minion One"
#define MyAppVersion "3.0.0.0"
#define MyAppPublisher "MixiM"
#define MyAppURL "http://www.minionone.altervista.org"
#define MyAppExeName "Minion One.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{86FF364F-287E-4A1A-B342-FD2C1C72CCFD}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\MixiM\Minion One
DisableDirPage=yes
DefaultGroupName=\MixiM\Minion One
DisableProgramGroupPage=yes
InfoBeforeFile=C:\Users\Saverio\Documents\MixiM\Software\Minion One\Versione 3.0.0.0 IT-ST\LEGGIMI.txt
InfoAfterFile=C:\Users\Saverio\Documents\MixiM\Software\Minion One\Versione 3.0.0.0 IT-ST\DOPO.txt
OutputDir=C:\Users\Saverio\Documents\MixiM\Software\Minion One\Versione 3.0.0.0 IT-ST\Pubblicazione
OutputBaseFilename=Install
SetupIconFile=C:\Users\Saverio\Documents\MixiM\Software\Minion One\Immagini\MinionOneICO.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"
Name: "italian"; MessagesFile: "compiler:Languages\Italian.isl"
Name: "japanese"; MessagesFile: "compiler:Languages\Japanese.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "C:\Users\Saverio\Documents\MixiM\Software\Minion One\Versione 3.0.0.0 IT-ST\Minion One\Minion One\bin\Debug\Minion One.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Saverio\Documents\MixiM\Software\Minion One\Versione 3.0.0.0 IT-ST\FastColoredTextBox.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

