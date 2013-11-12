; -- Example1.iss --
; Demonstrates copying 3 files and creating an icon.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

[Setup]
AppName=亿道生产工具箱
AppVersion=1.0
DefaultDirName={pf}\Emdoor\亿道生产工具箱
DefaultGroupName=亿道生产工具箱
UninstallDisplayIcon={app}\BarcodeTools.exe
Compression=lzma2
SolidCompression=yes
ShowLanguageDialog=yes
OutputDir=.
AppCopyright=Copyright (C) 2013 Emdoor,Ltd.



[Languages]
Name: chs; MessagesFile: compiler:Default.isl


[Files]
Source: "..\IMEI_Reader\bin\Release\BarcodeTools.exe"; DestDir: "{app}";Flags:ignoreversion
Source: "..\IMEI_Reader\bin\Release\Common.dll"; DestDir: "{app}";Flags:ignoreversion
Source: "..\IMEI_Reader\bin\Release\Managed.AndroidDebugBridge.dll"; DestDir: "{app}";Flags:ignoreversion
Source: "barcode.ico"; DestDir: "{app}";Flags:ignoreversion
Source: "download.ico"; DestDir: "{app}";Flags:ignoreversion
Source: "setting.ico"; DestDir: "{app}";Flags:ignoreversion
Source: "../bin/adb.exe"; DestDir: "{app}";Flags:ignoreversion
Source: "../bin/AdbWinApi.dll"; DestDir: "{app}";Flags:ignoreversion
Source: "../bin/AdbWinUsbApi.dll"; DestDir: "{app}";Flags:ignoreversion
Source: "../bin/TSCLib.dll"; DestDir: "{app}";Flags:ignoreversion
Source: "../bin/UL.PCX"; DestDir: "{app}";Flags:ignoreversion
Source: "readme.txt"; DestDir: "{app}"; Flags:ignoreversion isreadme


[Icons]
Name: "{group}\条码打印(Marvell)"; Filename: "{app}\BarcodeTools.exe";IconFilename:"{app}\barcode.ico"
Name: "{group}\USB连接设置"; Filename: "{app}\BarcodeTools.exe";Parameters:"usb_config";IconFilename:"{app}\setting.ico";Name: "{group}\串号烧录(Marvell)"; Filename: "{app}\BarcodeTools.exe";Parameters:"write";IconFilename:"{app}\download.ico"
Name: "{group}\卸载"; Filename: "{app}\unins000.exe"
Name: "{commondesktop}\条码打印(Marvell)"; Filename: "{app}\BarcodeTools.exe";IconFilename:"{app}\barcode.ico";Name: "{commondesktop}\串号烧录(Marvell)"; Filename: "{app}\BarcodeTools.exe";Parameters:"write";IconFilename:"{app}\download.ico"

[Code]

function InitializeSetup: Boolean;

    var Path:string ;

    ResultCode: Integer;

    dotNetV2RegPath:string;

    dotNetV2DownUrl:string;

    dotNetV2PackFile:string;

begin

  dotNetV2RegPath:='SOFTWARE\Microsoft\.NETFramework\policy\v2.0';

  dotNetV2DownUrl:='http://www.xxx.com/down/dotNetFx_v2.0(x86).exe';

  dotNetV2PackFile:='{src}/dotnetfx.exe';

  if RegKeyExists(HKLM, dotNetV2RegPath) then

  begin

    Result := true;

  end

  else

  begin

    if MsgBox('系统检测到您没有安装.Net Framework2.0运行环境，是否立即安装？', mbConfirmation, MB_YESNO) = idYes then

    begin



      Path := ExpandConstant(dotNetV2PackFile);

      if(FileOrDirExists(Path)) then

      begin

        Exec(Path, '/q', '', SW_SHOWNORMAL, ewWaitUntilTerminated, ResultCode);

        if RegKeyExists(HKLM, dotNetV2RegPath) then

        begin

           Result := true;

        end

        else

        begin

           MsgBox('未能成功安装.Net Framework2.0运行环境，系统将无法运行，本安装程序即将退出！',mbInformation,MB_OK);

        end

      end

      else

      begin

        if MsgBox('软件安装目录中没有包含.Net Framework的安装程序，是否立即下载后安装？', mbConfirmation, MB_YESNO) = idYes then

        begin

          Path := ExpandConstant('{pf}/Internet Explorer/iexplore.exe');

          Exec(Path, dotNetV2DownUrl , '', SW_SHOWNORMAL, ewWaitUntilTerminated, ResultCode);

          MsgBox('请安装好.Net Framework2.0环境后，再运行本安装包程序！',mbInformation,MB_OK);

          Result := false;

        end

        else

        begin

          MsgBox('不下载安装.Net Framework2.0运行环境，系统将无法运行，本安装程序即将退出！',mbInformation,MB_OK);

          Result := false;

        end

      end

    end

    else

    begin

      MsgBox('没有安装.Net Framework2.0运行环境，系统将无法运行，本安装程序即将退出！',mbInformation,MB_OK);

      Result := false;

    end;

  end;

end;

