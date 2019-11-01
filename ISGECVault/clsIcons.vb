Imports System.Runtime.InteropServices
Public Class getIconFrmReg
  Public Declare Function ExtractIconEx Lib "shell32.dll" (ByVal lpszFile As String, ByVal nIconIndex As IntPtr, ByRef phiconLarge As IntPtr, ByRef phiconSmall As IntPtr, ByVal nIcons As Integer) As IntPtr
  Dim regKey As String = My.Computer.Registry.ClassesRoot.ToString & "\"
  Shared Function getIconFromEx(ByVal file As String, ByVal index As Integer)
    Dim iconPtr As IntPtr
    Dim myicon As Icon
    ExtractIconEx(file, index, iconPtr, Nothing, 1)
    myicon = Icon.FromHandle(iconPtr)
    Return myicon
  End Function
  Function getIcon(ByVal ext As String) As Icon
    'Get the register value for the specified key
    Dim regVal As String = My.Computer.Registry.GetValue(regKey & ext, "", Nothing)
    Dim iconVal As String = ""
    Dim filen As String
    Dim nIndex As Integer
    Try
      'Specify the icon for .exe files
      If ext = ".exe" Then
        iconVal = "shell32.dll,2"

        'Specifi the common procedure
      ElseIf regVal <> "" Then
        If Not My.Computer.Registry.GetValue(regKey & regVal & "\DefaultIcon", "", Nothing) = Nothing Then
          iconVal = My.Computer.Registry.GetValue(regKey & regVal & "\DefaultIcon", "", Nothing)
        Else
          iconVal = "shell32.dll,0"
        End If

      ElseIf ext = "dir" Then
        iconVal = "shell32.dll,4"
      End If

      If iconVal.Length < 5 Then
        iconVal = "shell32.dll,0"
      End If
    Catch ex As Exception
      MsgBox("Error in icon")
    End Try

    Dim splt() As String = iconVal.Split(",")

    filen = splt(0).Trim(" ").Trim(Char.ConvertFromUtf32(34))
    nIndex = splt(1).Trim(" ")
    Dim icon As Icon
    icon = getIconFromEx(filen, nIndex)

    Return icon
  End Function
End Class
Public Class getIconFromFile
  Private Const SHGFI_ICON As Integer = &H100
  Private Const SHGFI_LARGEICON As Integer = &H0
  Private Const SHGFI_SMALLICON As Integer = &H1

  <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.[Unicode])>
  Public Structure SHFILEINFOW
    Public hIcon As IntPtr
    Public iIcon As Integer
    Public dwAttributes As Integer
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> Public szDisplayName As String
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> Public szTypeName As String
  End Structure
  <DllImport("shell32.dll", EntryPoint:="SHGetFileInfoW")>
  Private Shared Function SHGetFileInfoW(<InAttribute(), MarshalAs(UnmanagedType.LPTStr)> ByVal pszPath As String, ByVal dwFileAttributes As Integer, ByRef psfi As SHFILEINFOW, ByVal cbFileInfo As Integer, ByVal uFlags As Integer) As Integer
  End Function
  <DllImport("user32.dll", EntryPoint:="DestroyIcon")>
  Private Shared Function DestroyIcon(ByVal hIcon As System.IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
  End Function
  Public Function GetBmp(ByVal PathName As String, ByVal LargeIco As Boolean) As Bitmap
    Dim fi As New SHFILEINFOW
    fi = New SHFILEINFOW
    If LargeIco Then
      SHGetFileInfoW(PathName, 0, fi, Marshal.SizeOf(fi), SHGFI_ICON Or SHGFI_LARGEICON)
    Else
      SHGetFileInfoW(PathName, 0, fi, Marshal.SizeOf(fi), SHGFI_ICON Or SHGFI_SMALLICON)
    End If
    Dim bm As Bitmap = Icon.FromHandle(fi.hIcon).ToBitmap
    DestroyIcon(fi.hIcon)
    Return bm
  End Function
  Public Function GetIcon(ByVal PathName As String, ByVal LargeIco As Boolean) As Icon
    Dim fi As New SHFILEINFOW
    fi = New SHFILEINFOW
    If LargeIco Then
      SHGetFileInfoW(PathName, 0, fi, Marshal.SizeOf(fi), SHGFI_ICON Or SHGFI_LARGEICON)
    Else
      SHGetFileInfoW(PathName, 0, fi, Marshal.SizeOf(fi), SHGFI_ICON Or SHGFI_SMALLICON)
    End If
    Dim ico As Icon = Icon.FromHandle(fi.hIcon)
    DestroyIcon(fi.hIcon)
    Return ico
  End Function
End Class
