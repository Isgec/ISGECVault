
Imports System.Runtime.InteropServices

Public Class IconReader
  Public Enum IconSize
    Large = 0
    Small = 1
  End Enum
  Public Enum FolderType
    Open = 0
    Closed = 1
  End Enum
  Public Shared Function GetFileIcon(name As String, size As IconSize, linkOverlay As Boolean) As System.Drawing.Icon
    Dim shfi As New Shell32.SHFILEINFO()
    Dim flags As UInteger = Shell32.SHGFI_ICON Or Shell32.SHGFI_USEFILEATTRIBUTES
    If True = linkOverlay Then
      flags += Shell32.SHGFI_LINKOVERLAY
    End If
    If IconSize.Small = size Then
      flags += Shell32.SHGFI_SMALLICON
    Else
      flags += Shell32.SHGFI_LARGEICON
    End If
    Shell32.SHGetFileInfo(name, Shell32.FILE_ATTRIBUTE_NORMAL, shfi, CType(System.Runtime.InteropServices.Marshal.SizeOf(shfi), UInteger), flags)
    Dim icon As System.Drawing.Icon = CType(System.Drawing.Icon.FromHandle(shfi.hIcon).Clone(), System.Drawing.Icon)
    User32.DestroyIcon(shfi.hIcon)
    Return icon
  End Function
  Public Shared Function GetFolderIcon(size As IconSize, folderType As FolderType) As System.Drawing.Icon
    Dim flags As UInteger = Shell32.SHGFI_ICON Or Shell32.SHGFI_USEFILEATTRIBUTES
    If FolderType.Open = folderType Then
      flags += Shell32.SHGFI_OPENICON
    End If
    If IconSize.Small = size Then
      flags += Shell32.SHGFI_SMALLICON
    Else
      flags += Shell32.SHGFI_LARGEICON
    End If
    Dim shfi As New Shell32.SHFILEINFO()
    Shell32.SHGetFileInfo("Folder", Shell32.FILE_ATTRIBUTE_DIRECTORY, shfi, CType(System.Runtime.InteropServices.Marshal.SizeOf(shfi), UInteger), flags)
    System.Drawing.Icon.FromHandle(shfi.hIcon)
    Dim icon As System.Drawing.Icon = CType(System.Drawing.Icon.FromHandle(shfi.hIcon).Clone(), System.Drawing.Icon)
    User32.DestroyIcon(shfi.hIcon)
    Return icon
  End Function
  Public Shared Function GetDriveIcon(size As IconSize, folderType As FolderType) As System.Drawing.Icon
    Dim flags As UInteger = Shell32.SHGFI_ICON Or Shell32.SHGFI_USEFILEATTRIBUTES
    If FolderType.Open = folderType Then
      flags += Shell32.SHGFI_OPENICON
    End If
    If IconSize.Small = size Then
      flags += Shell32.SHGFI_SMALLICON
    Else
      flags += Shell32.SHGFI_LARGEICON
    End If
    Dim shfi As New Shell32.SHFILEINFO()
    Shell32.SHGetFileInfo(Nothing, Shell32.FILE_ATTRIBUTE_DIRECTORY, shfi, CType(System.Runtime.InteropServices.Marshal.SizeOf(shfi), UInteger), flags)
    System.Drawing.Icon.FromHandle(shfi.hIcon)
    Dim icon As System.Drawing.Icon = CType(System.Drawing.Icon.FromHandle(shfi.hIcon).Clone(), System.Drawing.Icon)
    User32.DestroyIcon(shfi.hIcon)
    Return icon
  End Function
End Class
Public Class Shell32
  Public Const MAX_PATH As Integer = 256
  <StructLayout(LayoutKind.Sequential)>
  Public Structure SHITEMID
    Public cb As UShort
    <MarshalAs(UnmanagedType.LPArray)>
    Public abID As Byte()
  End Structure
  <StructLayout(LayoutKind.Sequential)>
  Public Structure ITEMIDLIST
    Public mkid As SHITEMID
  End Structure
  <StructLayout(LayoutKind.Sequential)>
  Public Structure BROWSEINFO
    Public hwndOwner As IntPtr
    Public pidlRoot As IntPtr
    Public pszDisplayName As IntPtr
    <MarshalAs(UnmanagedType.LPTStr)>
    Public lpszTitle As String
    Public ulFlags As UInteger
    Public lpfn As IntPtr
    Public lParam As Integer
    Public iImage As IntPtr
  End Structure
  Public Const BIF_RETURNONLYFSDIRS As UInteger = &H1
  Public Const BIF_DONTGOBELOWDOMAIN As UInteger = &H2
  Public Const BIF_STATUSTEXT As UInteger = &H4
  Public Const BIF_RETURNFSANCESTORS As UInteger = &H8
  Public Const BIF_EDITBOX As UInteger = &H10
  Public Const BIF_VALIDATE As UInteger = &H20
  Public Const BIF_NEWDIALOGSTYLE As UInteger = &H40
  Public Const BIF_USENEWUI As UInteger = (BIF_NEWDIALOGSTYLE Or BIF_EDITBOX)
  Public Const BIF_BROWSEINCLUDEURLS As UInteger = &H80
  Public Const BIF_BROWSEFORCOMPUTER As UInteger = &H1000
  Public Const BIF_BROWSEFORPRINTER As UInteger = &H2000
  Public Const BIF_BROWSEINCLUDEFILES As UInteger = &H4000
  Public Const BIF_SHAREABLE As UInteger = &H8000
  <StructLayout(LayoutKind.Sequential)>
  Public Structure SHFILEINFO
    Public Const NAMESIZE As Integer = 80
    Public hIcon As IntPtr
    Public iIcon As Integer
    Public dwAttributes As UInteger
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=MAX_PATH)>
    Public szDisplayName As String
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=NAMESIZE)>
    Public szTypeName As String
  End Structure
  Public Const SHGFI_ICON As UInteger = &H100
  Public Const SHGFI_DISPLAYNAME As UInteger = &H200
  Public Const SHGFI_TYPENAME As UInteger = &H400
  Public Const SHGFI_ATTRIBUTES As UInteger = &H800
  Public Const SHGFI_ICONLOCATION As UInteger = &H1000
  Public Const SHGFI_EXETYPE As UInteger = &H2000
  Public Const SHGFI_SYSICONINDEX As UInteger = &H4000
  Public Const SHGFI_LINKOVERLAY As UInteger = &H8000
  Public Const SHGFI_SELECTED As UInteger = &H10000
  Public Const SHGFI_ATTR_SPECIFIED As UInteger = &H20000
  Public Const SHGFI_LARGEICON As UInteger = &H0
  Public Const SHGFI_SMALLICON As UInteger = &H1
  Public Const SHGFI_OPENICON As UInteger = &H2
  Public Const SHGFI_SHELLICONSIZE As UInteger = &H4
  Public Const SHGFI_PIDL As UInteger = &H8
  Public Const SHGFI_USEFILEATTRIBUTES As UInteger = &H10
  Public Const SHGFI_ADDOVERLAYS As UInteger = &H20
  Public Const SHGFI_OVERLAYINDEX As UInteger = &H40
  Public Const FILE_ATTRIBUTE_DIRECTORY As UInteger = &H10
  Public Const FILE_ATTRIBUTE_NORMAL As UInteger = &H80
  <DllImport("Shell32.dll")>
  Public Shared Function SHGetFileInfo(pszPath As String, dwFileAttributes As UInteger, ByRef psfi As SHFILEINFO, cbFileInfo As UInteger, uFlags As UInteger) As IntPtr
  End Function
End Class
Public Class User32
  <DllImport("User32.dll")>
  Public Shared Function DestroyIcon(hIcon As IntPtr) As Integer
  End Function
End Class
'Public Class IconReader
'{
'    /// <summary>
'    /// Options to specify the size of icons to return.
'    /// </summary>
'    Public Enum IconSize
'    {
'        /// <summary>
'        /// Specify large icon - 32 pixels by 32 pixels.
'        /// </summary>
'        Large = 0,
'        /// <summary>
'        /// Specify small icon - 16 pixels by 16 pixels.
'        /// </summary>
'        Small = 1
'    }

'    /// <summary>
'    /// Options to specify whether folders should be in the open Or closed state.
'    /// </summary>
'    Public Enum FolderType
'    {
'        /// <summary>
'        /// Specify open folder.
'        /// </summary>
'        Open = 0,
'        /// <summary>
'        /// Specify closed folder.
'        /// </summary>
'        Closed = 1
'    }

'    /// <summary>
'    /// Returns an icon for a given file - indicated by the name parameter.
'    /// </summary>
'    /// <param name="name">Pathname for file.</param>
'    /// <param name="size">Large Or small</param>
'    /// <param name="linkOverlay">Whether to include the link icon</param>
'    /// <returns>System.Drawing.Icon</returns>
'    Public Static System.Drawing.Icon GetFileIcon(String name, IconSize size, bool linkOverlay)
'    {
'        Shell32.SHFILEINFO shfi = New Shell32.SHFILEINFO();
'        uint flags = Shell32.SHGFI_ICON | Shell32.SHGFI_USEFILEATTRIBUTES;

'        If (True == linkOverlay) flags += Shell32.SHGFI_LINKOVERLAY;

'        /* Check the size specified for return. */
'        If (IconSize.Small == size)
'        {
'            flags += Shell32.SHGFI_SMALLICON;
'        }
'        Else
'        {
'            flags += Shell32.SHGFI_LARGEICON;
'        }

'        Shell32.SHGetFileInfo(name,
'            Shell32.FILE_ATTRIBUTE_NORMAL,
'            ref shfi,
'            (uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
'            flags);

'        // Copy (clone) the returned icon to a New object, thus allowing us to clean-up properly
'        System.Drawing.Icon icon = (System.Drawing.Icon)System.Drawing.Icon.FromHandle(shfi.hIcon).Clone();
'        User32.DestroyIcon(shfi.hIcon);     // Cleanup
'        Return icon;
'    }

'    /// <summary>
'    /// Used to access system folder icons.
'    /// </summary>
'    /// <param name="size">Specify large Or small icons.</param>
'    /// <param name="folderType">Specify open Or closed FolderType.</param>
'    /// <returns>System.Drawing.Icon</returns>
'    Public Static System.Drawing.Icon GetFolderIcon(IconSize size, FolderType folderType)
'    {
'        // Need to add size check, although errors generated at present!
'        uint flags = Shell32.SHGFI_ICON | Shell32.SHGFI_USEFILEATTRIBUTES;

'        If (FolderType.Open == folderType)
'        {
'            flags += Shell32.SHGFI_OPENICON;
'        }

'        If (IconSize.Small == size)
'        {
'            flags += Shell32.SHGFI_SMALLICON;
'        }
'        Else
'        {
'            flags += Shell32.SHGFI_LARGEICON;
'        }

'        // Get the folder icon
'        Shell32.SHFILEINFO shfi = New Shell32.SHFILEINFO();
'        Shell32.SHGetFileInfo(@"Folder",
'            Shell32.FILE_ATTRIBUTE_DIRECTORY,
'            ref shfi,
'            (uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
'            flags);

'        System.Drawing.Icon.FromHandle(shfi.hIcon); // Load the icon from an HICON handle

'        // Now clone the icon, so that it can be successfully stored in an ImageList
'        System.Drawing.Icon icon = (System.Drawing.Icon)System.Drawing.Icon.FromHandle(shfi.hIcon).Clone();

'        User32.DestroyIcon(shfi.hIcon);     // Cleanup
'        Return icon;
'    }

'    Public Static System.Drawing.Icon GetDriveIcon(IconSize size, FolderType folderType)
'    {
'        // Need to add size check, although errors generated at present!
'        uint flags = Shell32.SHGFI_ICON | Shell32.SHGFI_USEFILEATTRIBUTES;

'        If (FolderType.Open == folderType)
'        {
'            flags += Shell32.SHGFI_OPENICON;
'        }

'        If (IconSize.Small == size)
'        {
'            flags += Shell32.SHGFI_SMALLICON;
'        }
'        Else
'        {
'            flags += Shell32.SHGFI_LARGEICON;
'        }

'        // Get the folder icon
'        Shell32.SHFILEINFO shfi = New Shell32.SHFILEINFO();
'        Shell32.SHGetFileInfo(null,
'            Shell32.FILE_ATTRIBUTE_DIRECTORY,
'            ref shfi,
'            (uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
'            flags);

'        System.Drawing.Icon.FromHandle(shfi.hIcon); // Load the icon from an HICON handle

'        // Now clone the icon, so that it can be successfully stored in an ImageList
'        System.Drawing.Icon icon = (System.Drawing.Icon)System.Drawing.Icon.FromHandle(shfi.hIcon).Clone();

'        User32.DestroyIcon(shfi.hIcon);     // Cleanup
'        Return icon;
'    }
'}

'/// <summary>
'/// Wraps necessary Shell32.dll structures And functions required to retrieve Icon Handles using SHGetFileInfo. Code
'/// courtesy of MSDN Cold Rooster Consulting case study.
'/// </summary>
'/// 

'// This code has been left largely untouched from that in the CRC example. The main changes have been moving
'// the icon reading code over to the IconReader type.
'Public Class Shell32
'{

'    Public Const int MAX_PATH = 256;
'    [StructLayout(LayoutKind.Sequential)]
'    Public struct SHITEMID
'    {
'        Public UShort cb;
'        [MarshalAs(UnmanagedType.LPArray)]
'        Public Byte[] abID;
'    }

'    [StructLayout(LayoutKind.Sequential)]
'    Public struct ITEMIDLIST
'    {
'        Public SHITEMID mkid;
'    }

'    [StructLayout(LayoutKind.Sequential)]
'    Public struct BROWSEINFO
'    {
'        Public IntPtr hwndOwner;
'        Public IntPtr pidlRoot;
'        Public IntPtr pszDisplayName;
'        [MarshalAs(UnmanagedType.LPTStr)]
'        Public String lpszTitle;
'        Public uint ulFlags;
'        Public IntPtr lpfn;
'        Public int lParam;
'        Public IntPtr iImage;
'    }

'    // Browsing for directory.
'    Public Const uint BIF_RETURNONLYFSDIRS = 0x0001;
'    Public Const uint BIF_DONTGOBELOWDOMAIN = 0x0002;
'    Public Const uint BIF_STATUSTEXT = 0x0004;
'    Public Const uint BIF_RETURNFSANCESTORS = 0x0008;
'    Public Const uint BIF_EDITBOX = 0x0010;
'    Public Const uint BIF_VALIDATE = 0x0020;
'    Public Const uint BIF_NEWDIALOGSTYLE = 0x0040;
'    Public Const uint BIF_USENEWUI = (BIF_NEWDIALOGSTYLE | BIF_EDITBOX);
'    Public Const uint BIF_BROWSEINCLUDEURLS = 0x0080;
'    Public Const uint BIF_BROWSEFORCOMPUTER = 0x1000;
'    Public Const uint BIF_BROWSEFORPRINTER = 0x2000;
'    Public Const uint BIF_BROWSEINCLUDEFILES = 0x4000;
'    Public Const uint BIF_SHAREABLE = 0x8000;

'    [StructLayout(LayoutKind.Sequential)]
'    Public struct SHFILEINFO
'    {
'        Public Const int NAMESIZE = 80;
'        Public IntPtr hIcon;
'        Public int iIcon;
'        Public uint dwAttributes;
'        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
'        Public String szDisplayName;
'        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = NAMESIZE)]
'        Public String szTypeName;
'    };

'    Public Const uint SHGFI_ICON = 0x000000100;     // Get icon
'    Public Const uint SHGFI_DISPLAYNAME = 0x000000200;     // Get display name
'    Public Const uint SHGFI_TYPENAME = 0x000000400;     // Get type name
'    Public Const uint SHGFI_ATTRIBUTES = 0x000000800;     // Get attributes
'    Public Const uint SHGFI_ICONLOCATION = 0x000001000;     // Get icon location
'    Public Const uint SHGFI_EXETYPE = 0x000002000;     // Return exe type
'    Public Const uint SHGFI_SYSICONINDEX = 0x000004000;     // Get system icon index
'    Public Const uint SHGFI_LINKOVERLAY = 0x000008000;     // put a link overlay On icon
'    Public Const uint SHGFI_SELECTED = 0x000010000;     // show icon In selected state
'    Public Const uint SHGFI_ATTR_SPECIFIED = 0x000020000;     // Get only specified attributes
'    Public Const uint SHGFI_LARGEICON = 0x000000000;     // Get large icon
'    Public Const uint SHGFI_SMALLICON = 0x000000001;     // Get small icon
'    Public Const uint SHGFI_OPENICON = 0x000000002;     // Get open icon
'    Public Const uint SHGFI_SHELLICONSIZE = 0x000000004;     // Get shell size icon
'    Public Const uint SHGFI_PIDL = 0x000000008;     // pszPath Is a pidl
'    Public Const uint SHGFI_USEFILEATTRIBUTES = 0x000000010;     // use passed dwFileAttribute
'    Public Const uint SHGFI_ADDOVERLAYS = 0x000000020;     // apply the appropriate overlays
'    Public Const uint SHGFI_OVERLAYINDEX = 0x000000040;     // Get the index Of the overlay

'    Public Const uint FILE_ATTRIBUTE_DIRECTORY = 0x00000010;
'    Public Const uint FILE_ATTRIBUTE_NORMAL = 0x00000080;

'    [DllImport("Shell32.dll")]
'    Public Static extern IntPtr SHGetFileInfo(
'        String pszPath,
'        uint dwFileAttributes,
'        ref SHFILEINFO psfi,
'        uint cbFileInfo,
'        uint uFlags
'        );
'}

'/// <summary>
'/// Wraps necessary functions imported from User32.dll. Code courtesy of MSDN Cold Rooster Consulting example.
'/// </summary>
'Public Class User32
'{
'    /// <summary>
'    /// Provides access to function required to delete handle. This method Is used internally
'    /// And Is Not required to be called separately.
'    /// </summary>
'    /// <param name="hIcon">Pointer to icon handle.</param>
'    /// <returns>N/A</returns>
'    [DllImport("User32.dll")]
'    Public Static extern int DestroyIcon(IntPtr hIcon);
'}