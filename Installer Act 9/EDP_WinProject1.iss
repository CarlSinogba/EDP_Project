[Setup]
AppName=EDP Finals
AppVersion=1.0
DefaultDirName={pf}\EDP_Act9
OutputDir=.
OutputBaseFilename=EDP_WinProject1
Compression=lzma
SolidCompression=yes

[Files]
; Application executable
Source: "EDP_WinProject1.exe"; DestDir: "{app}"; Flags: ignoreversion

; DLL dependencies
Source: "System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "System.Threading.Tasks.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion

; MySQL setup files
Source: "init_db.sql"; DestDir: "{app}"; Flags: ignoreversion
Source: "MABDemoDB.sql"; DestDir: "{app}"; Flags: ignoreversion
Source: "setup_mysql.bat"; DestDir: "{app}"; Flags: ignoreversion

; MySQL Installer (must be manually placed in the build directory)
Source: "mysql-installer-community-8.0.42.0.msi"; DestDir: "{tmp}"; Flags: ignoreversion

[Run]
; Silent installation of MySQL
Filename: "msiexec.exe"; Parameters: '/i "{tmp}\mysql-installer-community-8.0.42.0.msi" /qn /norestart'; Flags: runhidden waituntilterminated

; Execute MySQL configuration and DB restoration
Filename: "cmd.exe"; Parameters: '/C "{app}\setup_mysql.bat"'; Flags: runhidden waituntilterminated

; Launch the C# application
Filename: "{app}\EDP_WinProject1.exe"; Description: "Launch Application"; Flags: nowait postinstall skipifsilent

[Icons]
Name: "{group}\MAB EDP Demo"; Filename: "{app}\EDP_WinProject1.exe"