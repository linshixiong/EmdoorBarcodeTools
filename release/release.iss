; -- Example1.iss --
; Demonstrates copying 3 files and creating an icon.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

[Setup]
AppName=�ڵ�����������
AppVersion=1.0
DefaultDirName={pf}\Emdoor\�ڵ�����������
DefaultGroupName=�ڵ�����������
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
Name: "{group}\�����ӡ(Marvell)"; Filename: "{app}\BarcodeTools.exe";IconFilename:"{app}\barcode.ico"
Name: "{group}\USB��������"; Filename: "{app}\BarcodeTools.exe";Parameters:"usb_config";IconFilename:"{app}\setting.ico";Name: "{group}\������¼(Marvell)"; Filename: "{app}\BarcodeTools.exe";Parameters:"write";IconFilename:"{app}\download.ico"
Name: "{group}\ж��"; Filename: "{app}\unins000.exe"
Name: "{commondesktop}\�����ӡ(Marvell)"; Filename: "{app}\BarcodeTools.exe";IconFilename:"{app}\barcode.ico";Name: "{commondesktop}\������¼(Marvell)"; Filename: "{app}\BarcodeTools.exe";Parameters:"write";IconFilename:"{app}\download.ico"

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

    if MsgBox('ϵͳ��⵽��û�а�װ.Net Framework2.0���л������Ƿ�������װ��', mbConfirmation, MB_YESNO) = idYes then

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

           MsgBox('δ�ܳɹ���װ.Net Framework2.0���л�����ϵͳ���޷����У�����װ���򼴽��˳���',mbInformation,MB_OK);

        end

      end

      else

      begin

        if MsgBox('�����װĿ¼��û�а���.Net Framework�İ�װ�����Ƿ��������غ�װ��', mbConfirmation, MB_YESNO) = idYes then

        begin

          Path := ExpandConstant('{pf}/Internet Explorer/iexplore.exe');

          Exec(Path, dotNetV2DownUrl , '', SW_SHOWNORMAL, ewWaitUntilTerminated, ResultCode);

          MsgBox('�밲װ��.Net Framework2.0�����������б���װ������',mbInformation,MB_OK);

          Result := false;

        end

        else

        begin

          MsgBox('�����ذ�װ.Net Framework2.0���л�����ϵͳ���޷����У�����װ���򼴽��˳���',mbInformation,MB_OK);

          Result := false;

        end

      end

    end

    else

    begin

      MsgBox('û�а�װ.Net Framework2.0���л�����ϵͳ���޷����У�����װ���򼴽��˳���',mbInformation,MB_OK);

      Result := false;

    end;

  end;

end;

