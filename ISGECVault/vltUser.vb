Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.IO
Imports System.Web.Script.Serialization
Namespace SIS.VLT
  Public Class vltConf
    Public Property ConfID As Integer = 0
    Public Property Active As Boolean = True
    Public Property FileLimit As String = ""
    Public Property SizeLimit As String = ""
    Public Property OriginalAllowed As Boolean = False
    Public Property PDFAllowed As Boolean = True
    Public Property OriginalWhenNoPDF As Boolean = True
    Public Property BaaNLive As Boolean = True
    Public Property JoomlaLive As Boolean = True
    Public Property VaultLive As Boolean = True
    Public Property ISGECVaultServer As String = ""
    Public Property AutodeskVaultServer As String = ""
    Public Shared Function GetVltConf() As SIS.VLT.vltConf
      Dim mRet As SIS.VLT.vltConf = Nothing
      Dim Sql As String = ""
      Sql &= " SELECT top 1 * "
      Sql &= " FROM VLT_Conf "
      Sql &= " WHERE Active = 1"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Dim rd As SqlDataReader = Cmd.ExecuteReader
          While rd.Read
            mRet = New SIS.VLT.vltConf(rd)
          End While
          rd.Close()
        End Using
      End Using
      Return mRet
    End Function

    Sub New(rd As SqlDataReader)
      SIS.VLT.UI.NewObj(Me, rd)
    End Sub
    Sub New()
      'dummy
    End Sub
  End Class
  <DataObject>
  Public Class vltUser
    Public Property LoginID As String = ""
    Public Property IsAdmin As Boolean = False
    Public Property PW As String = ""
    Public Property FileLimit As String = ""
    Public Property SizeLimit As String = ""
    Public Property OriginalAllowed As Boolean = False
    Public Property PDFAllowed As Boolean = True
    Public Property OriginalWhenNoPDF As Boolean = True
    Public Property OnlyLatestRev As Boolean = True
    Public Property ISGECVaultServer As String = ""
    'Selected Path => Only to store user local workspace 
    Public Property SelectedPath As String = ""
    Public Shared Function GetUser(LoginID As String) As SIS.VLT.vltUser
      Dim mRet As SIS.VLT.vltUser = Nothing
      Dim Sql As String = ""
      Sql &= " SELECT * "
      Sql &= " FROM VLT_User "
      Sql &= " WHERE LoginID ='" & LoginID & "'"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Dim rd As SqlDataReader = Cmd.ExecuteReader
          While rd.Read
            mRet = New SIS.VLT.vltUser(rd)
          End While
          rd.Close()
        End Using
      End Using
      Return mRet
    End Function
    <DataObjectMethod(DataObjectMethodType.Select, True)>
    Public Shared Function SelectList() As List(Of SIS.VLT.vltUser)
      Dim mRet As New List(Of SIS.VLT.vltUser)
      Dim Sql As String = ""
      Sql &= " SELECT * "
      Sql &= " FROM VLT_User "
      Sql &= " Order By LoginID"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Dim rd As SqlDataReader = Cmd.ExecuteReader
          While rd.Read
            mRet.Add(New SIS.VLT.vltUser(rd))
          End While
          rd.Close()
        End Using
      End Using
      Return mRet
    End Function
    Public Shared Function UpdateSelectedPath(LoginID As String, SelectedPath As String) As Boolean
      Dim mRet As Boolean = True
      Dim Sql As String = ""
      Sql &= " update vlt_user "
      Sql &= " set selectedpath='" & SelectedPath & "'"
      Sql &= " where LoginID='" & LoginID & "'"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Try
            Cmd.ExecuteNonQuery()
          Catch ex As Exception
            mRet = False
          End Try
        End Using
      End Using
      Return mRet
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.VLT.vltUser) As SIS.VLT.vltUser
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvltUserInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, Record.LoginID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IsAdmin", SqlDbType.Bit, 3, Record.IsAdmin)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@pw", SqlDbType.NVarChar, 51, IIf(Record.PW = "", Convert.DBNull, Record.PW))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FileLimit", SqlDbType.Int, 11, IIf(Record.FileLimit = "", Convert.DBNull, Record.FileLimit))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SizeLimit", SqlDbType.Int, 11, IIf(Record.SizeLimit = "", Convert.DBNull, Record.SizeLimit))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OriginalAllowed", SqlDbType.Bit, 3, Record.OriginalAllowed)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PDFAllowed", SqlDbType.Bit, 3, Record.PDFAllowed)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OriginalWhenNoPDF", SqlDbType.Bit, 3, Record.OriginalWhenNoPDF)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OnlyLatestRev", SqlDbType.Bit, 3, Record.OnlyLatestRev)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ISGECVaultServer", SqlDbType.NVarChar, 51, IIf(Record.ISGECVaultServer = "", Convert.DBNull, Record.ISGECVaultServer))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SelectedPath", SqlDbType.NVarChar, 501, IIf(Record.SelectedPath = "", Convert.DBNull, Record.SelectedPath))
          Cmd.Parameters.Add("@Return_LoginID", SqlDbType.NVarChar, 9)
          Cmd.Parameters("@Return_LoginID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.LoginID = Cmd.Parameters("@Return_LoginID").Value
        End Using
      End Using
      Return Record
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.VLT.vltUser) As SIS.VLT.vltUser
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvltUserUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_LoginID", SqlDbType.NVarChar, 9, Record.LoginID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, Record.LoginID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IsAdmin", SqlDbType.Bit, 3, Record.IsAdmin)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@pw", SqlDbType.NVarChar, 51, IIf(Record.PW = "", Convert.DBNull, Record.PW))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FileLimit", SqlDbType.Int, 11, IIf(Record.FileLimit = "", Convert.DBNull, Record.FileLimit))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SizeLimit", SqlDbType.Int, 11, IIf(Record.SizeLimit = "", Convert.DBNull, Record.SizeLimit))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OriginalAllowed", SqlDbType.Bit, 3, Record.OriginalAllowed)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PDFAllowed", SqlDbType.Bit, 3, Record.PDFAllowed)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OriginalWhenNoPDF", SqlDbType.Bit, 3, Record.OriginalWhenNoPDF)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OnlyLatestRev", SqlDbType.Bit, 3, Record.OnlyLatestRev)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ISGECVaultServer", SqlDbType.NVarChar, 51, IIf(Record.ISGECVaultServer = "", Convert.DBNull, Record.ISGECVaultServer))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SelectedPath", SqlDbType.NVarChar, 501, IIf(Record.SelectedPath = "", Convert.DBNull, Record.SelectedPath))
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
        End Using
      End Using
      Return Record
    End Function

    Public Shared Function VaultList(LoginID As String) As List(Of SIS.VLT.Vaults)
      Dim mRet As List(Of SIS.VLT.Vaults) = SIS.VLT.Vaults.VaultList()
      Dim tRet As List(Of SIS.VLT.vltUserVault) = SIS.VLT.vltUserVault.UserVaultList(LoginID)
      For I As Integer = mRet.Count - 1 To 0 Step -1
        Dim Found As Boolean = False
        For Each tmp As SIS.VLT.vltUserVault In tRet
          If tmp.VaultID = mRet(I).VaultID Then
            Found = True
            Exit For
          End If
        Next
        If Not Found Then
          mRet.Remove(mRet(I))
        End If
      Next
      Return mRet
    End Function

    Sub New(rd As SqlDataReader)
      SIS.VLT.UI.NewObj(Me, rd)
    End Sub
    Sub New()
      'dummy
    End Sub
  End Class
  Public Class vltUserVault
    Public Property LoginID As String = ""
    Public Property VaultID As Integer = 0

    Public Shared Function Insert(LoginID As String, VaultID As String) As Boolean
      Dim mRet As Boolean = True
      Dim Sql As String = ""
      Sql &= "   INSERT [VLT_UserVault]"
      Sql &= "("
      Sql &= "  [LoginID]"
      Sql &= " , [VaultID]"
      Sql &= "  )"
      Sql &= " VALUES"
      Sql &= "  ("
      Sql &= "   UPPER('" & LoginID & "')"
      Sql &= "  ," & VaultID
      Sql &= "  )"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Try
            Cmd.ExecuteNonQuery()
          Catch ex As Exception
            mRet = False
          End Try
        End Using
      End Using
      Return mRet
    End Function
    Public Shared Function Delete(LoginID As String, VaultID As String) As Boolean
      Dim mRet As Boolean = True
      Dim Sql As String = ""
      Sql &= "   Delete [VLT_UserVault]"
      Sql &= " Where "
      Sql &= "   UPPER(LoginID) = Upper('" & LoginID & "')"
      Sql &= "  and VaultID=" & VaultID
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Try
            Cmd.ExecuteNonQuery()
          Catch ex As Exception
            mRet = False
          End Try
        End Using
      End Using
      Return mRet
    End Function

    Public Shared Function UserVaultList(LoginID As String) As List(Of SIS.VLT.vltUserVault)
      Dim mRet As New List(Of SIS.VLT.vltUserVault)
      Dim Sql As String = ""
      Sql &= " SELECT * "
      Sql &= " FROM VLT_UserVault "
      Sql &= " WHERE LoginID ='" & LoginID & "'"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Dim rd As SqlDataReader = Cmd.ExecuteReader
          While rd.Read
            mRet.Add(New SIS.VLT.vltUserVault(rd))
          End While
          rd.Close()
        End Using
      End Using
      Return mRet
    End Function
    Sub New(rd As SqlDataReader)
      SIS.VLT.UI.NewObj(Me, rd)
    End Sub
    Sub New()
      'dummy
    End Sub
  End Class
  <DataObject>
  Public Class Vaults
    Public Property VaultID As Integer = 0
    Public Property VaultDB As String = ""
    Public Property FileStorePath As String = ""
    <DataObjectMethod(DataObjectMethodType.Select, True)>
    Public Shared Function VaultList() As List(Of SIS.VLT.Vaults)
      Dim mRet As New List(Of SIS.VLT.Vaults)
      Dim Sql As String = ""
      Sql &= " SELECT  "
      Sql &= " vfs.VaultID, "
      Sql &= " vfs.FSPath As FileStorePath, "
      Sql &= " kv.DatabaseName AS VaultDB "
      Sql &= " FROM VaultFilestore As vfs "
      Sql &= " INNER JOIN KnowledgeVault AS kv ON kv.VaultID = vfs.VaultID "
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetVaultConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Dim rd As SqlDataReader = Cmd.ExecuteReader
          While rd.Read
            mRet.Add(New SIS.VLT.Vaults(rd))
          End While
          rd.Close()
        End Using
      End Using
      Return mRet
    End Function
    Sub New(rd As SqlDataReader)
      SIS.VLT.UI.NewObj(Me, rd)
    End Sub
    Sub New()
      'dummy
    End Sub

  End Class

  <DataObject>
  Public Class vltFolder
    Public Property RowIcon As System.Drawing.Icon
      Get
        If ItemType = "File" Then
          If Extension.ToLower = "pdf" Then
            Return Icon.ExtractAssociatedIcon(StartupPath & "\pdf.ico")
          End If
          Return iconExtract.getIcon("." & Extension)
        Else
          Try
            If ParentFolderID = 1 Then
              Return Icon.ExtractAssociatedIcon(StartupPath & "\prj.ico")
            Else
              Return Icon.ExtractAssociatedIcon(StartupPath & "\fld.ico")
            End If
            Return Icon.ExtractAssociatedIcon(StartupPath & "\folder.ico")
            Dim x As Icon = iconExtract.getIcon("dir")
            Dim y As Bitmap = x.ToBitmap
            y.RotateFlip(RotateFlipType.Rotate270FlipNone)
            Return System.Drawing.Icon.FromHandle(y.GetHicon)
          Catch ex As Exception
          End Try
          Return iconExtract.getIcon(".txt")
        End If
      End Get
      Set(value As System.Drawing.Icon)

      End Set
    End Property
    Public Property Description As String
      Get
        If ItemType = "Folder" Then
          Return FolderName
        Else
          Return FileName
        End If
      End Get
      Set(value As String)

      End Set
    End Property
    Public Property FolderID As Long = 0
    Public Property FolderName As String = ""
    Public Property Library As Boolean = False
    Public Property ParentFolderID As Long = 0
    Public Property ItemType As String = "Folder"

    'File Properties
    Public Property FileIterationId As String = ""
    Public Property CreateDate As String = ""
    Public Property CreateUserID As String = ""
    Public Property CreateUserName As String = ""
    Public Property FileMasterID As String = ""
    Public Property IterationNumber As String = ""
    Public Property FileName As String = ""
    Public Property ResourceId As String = ""
    Public Property ResourceVersion As String = ""
    Public Property Extension As String = ""
    Public Property FileSize As String = ""
    Public Property CheckedOut As String = ""
    Public Property CheckoutDate As String = ""
    Public Property LifeCycleStateName As String = ""
    Public Property ISGEC_Rev As String = ""
    Public Property ISGEC_Ttl As String = ""
    Public ReadOnly Property VaultKey As String
      Get
        Return FileMasterID & "_" & ResourceId & "_" & ResourceVersion
      End Get
    End Property
    Public Property VaultBasePath As String = ""
    Public Shared Function FileRevisions(VaultDB As String, MasterID As Long, Iteration As Long) As List(Of SIS.VLT.vltFolder)
      Dim mRet As New List(Of SIS.VLT.vltFolder)
      Dim Sql As String = ""

      Sql &= " declare @rev int, @ttl int "
      Sql &= " select @rev=PropertyDefID from PropertyDef where FriendlyName = 'ISGEC_LATESTREVISION' "
      Sql &= " select @ttl=PropertyDefID from PropertyDef where FriendlyName = 'ISGEC_DRAWINGTITLE' "
      Sql &= "  "
      Sql &= " SELECT   "
      Sql &= "  fi.FileIterationId,   "
      Sql &= "  e.CreateDate,   "
      Sql &= "  e.CreateUserID,   "
      Sql &= "  uf.UserGroupName AS CreateUserName,   "
      Sql &= "  fm.FileMasterID,   "
      Sql &= "  i.IterationNumber,   "
      Sql &= "  fi.FileName,   "
      Sql &= "  fr.ResourceId,   "
      Sql &= "  fr.Version AS ResourceVersion,   "
      Sql &= "  fr.Extension,   "
      Sql &= "  fr.FileSize,   "
      Sql &= "  fm.CheckedOut,   "
      Sql &= "  fm.FolderId,   "
      Sql &= "  fi.CheckoutDate,   "
      Sql &= "  fi.LifeCycleStateName, "
      Sql &= "  (select isnull(value,'') from Property where entityid=fi.FileIterationId and PropertyDefID=@rev) as ISGEC_Rev,  "
      Sql &= "  (select isnull(value,'') from Property where entityid=fi.FileIterationId and PropertyDefID=@ttl) as ISGEC_Ttl   "
      Sql &= " FROM  dbo.FileIteration AS fi   "
      Sql &= "  INNER JOIN dbo.Iteration AS i ON fi.FileIterationId = i.IterationID   "
      Sql &= "  INNER JOIN dbo.FileResource AS fr ON fr.ResourceId = fi.ResourceId   "
      Sql &= "  INNER JOIN dbo.Entity AS e ON i.IterationID = e.EntityId   "
      Sql &= "  INNER JOIN dbo.v_User AS uf ON uf.UserGroupID = e.CreateUserID   "
      Sql &= "  INNER JOIN dbo.Master AS m ON m.MasterID = i.MasterID   "
      Sql &= "  INNER JOIN dbo.FileMaster AS fm ON fm.FileMasterID = m.MasterID   "
      Sql &= "  WHERE fm.FileMasterID =" & MasterID
      Sql &= "  AND fi.LifeCycleStateName = 'Released' "
      Sql &= "  AND (fi.FileIterationId  "
      Sql &= "   < (SELECT max(FileIterationId) "
      Sql &= "      FROM FileIteration AS aa "
      Sql &= "      WHERE (LifeCycleStateName = 'Released') AND (FileName = fi.FileName))) "
      Sql &= "  Order By fi.FileIterationID DESC "

      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetVaultConnectionString(VaultDB))
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Dim rd As SqlDataReader = Cmd.ExecuteReader
          While rd.Read
            Dim tmp As SIS.VLT.vltFolder = New SIS.VLT.vltFolder(rd)
            tmp.ItemType = "File"
            mRet.Add(tmp)
          End While
          rd.Close()
        End Using
      End Using
      Return mRet
    End Function

    Public Shared Function FilesInFolder(VaultDB As String, Optional ParentFolderID As Long = 1, Optional Latest As Boolean = True) As List(Of SIS.VLT.vltFolder)
      Dim mRet As New List(Of SIS.VLT.vltFolder)
      Dim Sql As String = ""

      Sql &= " declare @rev int, @ttl int "
      Sql &= " select @rev=PropertyDefID from PropertyDef where FriendlyName = 'ISGEC_LATESTREVISION' "
      Sql &= " select @ttl=PropertyDefID from PropertyDef where FriendlyName = 'ISGEC_DRAWINGTITLE' "
      Sql &= "  "
      Sql &= " SELECT   "
      Sql &= "  fi.FileIterationId,   "
      Sql &= "  e.CreateDate,   "
      Sql &= "  e.CreateUserID,   "
      Sql &= "  uf.UserGroupName AS CreateUserName,   "
      Sql &= "  fm.FileMasterID,   "
      Sql &= "  i.IterationNumber,   "
      Sql &= "  fi.FileName,   "
      Sql &= "  fr.ResourceId,   "
      Sql &= "  fr.Version AS ResourceVersion,   "
      Sql &= "  fr.Extension,   "
      Sql &= "  fr.FileSize,   "
      Sql &= "  fm.CheckedOut,   "
      Sql &= "  fm.FolderId,   "
      Sql &= "  fi.CheckoutDate,   "
      Sql &= "  fi.LifeCycleStateName, "
      Sql &= "  (select isnull(value,'') from Property where entityid=fi.FileIterationId and PropertyDefID=@rev) as ISGEC_Rev,  "
      Sql &= "  (select isnull(value,'') from Property where entityid=fi.FileIterationId and PropertyDefID=@ttl) as ISGEC_Ttl   "
      Sql &= " FROM  dbo.FileIteration AS fi   "
      Sql &= "  INNER JOIN dbo.Iteration AS i ON fi.FileIterationId = i.IterationID   "
      Sql &= "  INNER JOIN dbo.FileResource AS fr ON fr.ResourceId = fi.ResourceId   "
      Sql &= "  INNER JOIN dbo.Entity AS e ON i.IterationID = e.EntityId   "
      Sql &= "  INNER JOIN dbo.v_User AS uf ON uf.UserGroupID = e.CreateUserID   "
      Sql &= "  INNER JOIN dbo.Master AS m ON m.MasterID = i.MasterID   "
      Sql &= "  INNER JOIN dbo.FileMaster AS fm ON fm.FileMasterID = m.MasterID   "
      Sql &= "  WHERE fm.FolderID =" & ParentFolderID
      Sql &= "  AND (fi.FileIterationId  "
      If Latest Then
        Sql &= "   = (SELECT max(FileIterationId) "
        Sql &= "      FROM FileIteration AS aa "
        Sql &= "      WHERE (LifeCycleStateName = 'Released') AND (FileName = fi.FileName))) "
      Else
        Sql &= "   IN (SELECT FileIterationId "
        Sql &= "      FROM FileIteration AS aa "
        Sql &= "      WHERE (LifeCycleStateName = 'Released') AND (FileName = fi.FileName))) "
      End If
      Sql &= "  Order By fi.FileIterationID DESC "

      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetVaultConnectionString(VaultDB))
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Dim rd As SqlDataReader = Cmd.ExecuteReader
          While rd.Read
            Dim tmp As SIS.VLT.vltFolder = New SIS.VLT.vltFolder(rd)
            tmp.ItemType = "File"
            mRet.Add(tmp)
          End While
          rd.Close()
        End Using
      End Using
      Return mRet
    End Function
    Public Shared Function FolderList(VaultDB As String, Optional ParentFolderID As Long = 1) As List(Of SIS.VLT.vltFolder)
      Dim mRet As New List(Of SIS.VLT.vltFolder)
      Dim Sql As String = ""
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetVaultConnectionString(VaultDB))
        Con.Open()
        Sql &= " SELECT  "
        Sql &= " * "
        Sql &= " FROM Folder "
        Sql &= " WHERE ParentFolderID =" & ParentFolderID
        Sql &= " Order By FolderName "
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Dim rd As SqlDataReader = Cmd.ExecuteReader
          While rd.Read
            mRet.Add(New SIS.VLT.vltFolder(rd))
          End While
          rd.Close()
        End Using
      End Using
      Return mRet
    End Function
    Sub New(rd As SqlDataReader)
      SIS.VLT.UI.NewObj(Me, rd)
    End Sub
    Sub New()
      'dummy
    End Sub

  End Class
  Public Class UI
    Public Shared Function NewObj(this As Object, Reader As SqlDataReader) As Object
      Try
        For Each pi As System.Reflection.PropertyInfo In this.GetType.GetProperties
          If pi.MemberType = Reflection.MemberTypes.Property Then
            Try
              Dim Found As Boolean = False
              For I As Integer = 0 To Reader.FieldCount - 1
                If Reader.GetName(I).ToLower = pi.Name.ToLower Then
                  Found = True
                  Exit For
                End If
              Next
              If Found Then
                If Convert.IsDBNull(Reader(pi.Name)) Then
                  Select Case Reader.GetDataTypeName(Reader.GetOrdinal(pi.Name))
                    Case "decimal"
                      CallByName(this, pi.Name, CallType.Let, "0.00")
                    Case "bit"
                      CallByName(this, pi.Name, CallType.Let, Boolean.FalseString)
                    Case "bigint"
                      CallByName(this, pi.Name, CallType.Let, 0)
                    Case Else
                      CallByName(this, pi.Name, CallType.Let, String.Empty)
                  End Select
                Else
                  CallByName(this, pi.Name, CallType.Let, Reader(pi.Name))
                End If
              End If
            Catch ex As Exception
            End Try
          End If
        Next
      Catch ex As Exception
        Return Nothing
      End Try
      Return this
    End Function
  End Class
  <DataObject>
  Public Class SelectedForDownload
    'Public ReadOnly Property DownloadKey As String
    '  Get
    '    Return FileName & "|" & FileMasterID & "|" & VaultKey
    '  End Get
    'End Property
    Public Property FileName As String = ""
    Public Property FileMasterID As String = ""
    Public Property ResourceId As String = ""
    Public Property ResourceVersion As String = ""
    Public Property FileSize As String = ""
    Public Property ReceivedSize As String = ""
    Private _VaultKey As String = ""
    Public ReadOnly Property VaultKey As String
      Get
        Return FileMasterID & "_" & ResourceId & "_" & ResourceVersion
      End Get
    End Property
    Public Property IsgecVaultKey As String = ""

    Public Property Extension As String = ""

    Public Property VaultDB As String = ""
    Public Property VaultBasePath As String = ""
    Public Property VaultFilePath As String = ""
    Public Property IsgecVaultFilePath As String = ""
    Public Property Marked As Boolean = True
    Public Property SaveAsPath As String = ""
    Public Property PDFAvailable As Boolean = False
    Public Property Original As Boolean = False
    Public Property OriginalCanBeDownloaded As Boolean = False
    Public Property Invalid As Boolean = False
    'Public ReadOnly Property SaveAsFile As String
    '  Get
    '    Return SaveAsPath & "\" & FileName
    '  End Get
    'End Property
    Public Property Downloaded As Boolean = False
    Public Property Downloading As Boolean = False
    Public Shared Function GetString(x As SIS.VLT.SelectedForDownload) As String
      Return (New JavaScriptSerializer).Serialize(x)
      Dim mRet As String = ""
      mRet &= x.FileName & "|"
      mRet &= x.FileMasterID & "|"
      mRet &= x.ResourceId & "|"
      mRet &= x.ResourceVersion & "|"
      mRet &= x.FileSize & "|"
      mRet &= x.ReceivedSize & "|"
      mRet &= x.IsgecVaultKey & "|"
      mRet &= x.Extension & "|"
      mRet &= x.VaultDB & "|"
      mRet &= x.VaultBasePath & "|"
      mRet &= x.VaultFilePath & "|"
      mRet &= x.IsgecVaultFilePath & "|"
      mRet &= x.Marked & "|"
      mRet &= x.SaveAsPath & "|"
      mRet &= x.Downloaded & "|"
      mRet &= x.Downloading
      Return mRet
    End Function
    Public Shared Function GetDN(str As String) As SIS.VLT.SelectedForDownload
      Dim x As New SIS.VLT.SelectedForDownload
      x = (New JavaScriptSerializer).Deserialize(str, GetType(SIS.VLT.SelectedForDownload))
      Return x
      Dim aStr() As String = str.Split("|".ToCharArray)
      x.FileName = aStr(0)
      x.FileMasterID = aStr(1)
      x.ResourceId = aStr(2)
      x.ResourceVersion = aStr(3)
      x.FileSize = aStr(4)
      x.ReceivedSize = aStr(5)
      x.IsgecVaultKey = aStr(6)
      x.Extension = aStr(7)
      x.VaultDB = aStr(8)
      x.VaultBasePath = aStr(9)
      x.VaultFilePath = aStr(10)
      x.IsgecVaultFilePath = aStr(11)
      x.Marked = Convert.ToBoolean(aStr(12))
      x.SaveAsPath = aStr(13)
      x.Downloaded = Convert.ToBoolean(aStr(14))
      x.Downloading = Convert.ToBoolean(aStr(15))
      Return x
    End Function

  End Class
End Namespace
'Sql &= " SELECT  "
'Sql &= "  fi.FileIterationId,  "
'Sql &= "  e.CreateDate,  "
'Sql &= "  e.CreateUserID,  "
'Sql &= "  uf.UserGroupName AS CreateUserName,  "
'Sql &= "  fm.FileMasterID,  "
'Sql &= "  i.IterationNumber,  "
'Sql &= "  fi.FileName,  "
'Sql &= "  fr.ResourceId,  "
'Sql &= "  fr.Version AS ResourceVersion,  "
'Sql &= "  fr.Extension,  "
'Sql &= "  fr.FileSize,  "
'Sql &= "  fm.CheckedOut,  "
'Sql &= "  fm.FolderId,  "
'Sql &= "  fi.CheckoutDate,  "
'Sql &= "  fi.LifeCycleStateName "
'Sql &= " FROM  dbo.FileIteration AS fi  "
'Sql &= "  INNER JOIN dbo.FileResource AS fr ON fr.ResourceId = fi.ResourceId  "
'Sql &= "  INNER JOIN dbo.Iteration AS i ON fi.FileIterationId = i.IterationID  "
'Sql &= "  INNER JOIN dbo.Entity AS e ON i.IterationID = e.EntityId  "
'Sql &= "  INNER JOIN dbo.v_User AS uf ON uf.UserGroupID = e.CreateUserID  "
'Sql &= "  INNER JOIN dbo.Master AS m ON m.MasterID = i.MasterID  "
'Sql &= "  INNER JOIN dbo.FileMaster AS fm ON fm.FileMasterID = m.MasterID  "
'Sql &= "  INNER JOIN dbo.FileIteration AS fit ON fit.FileIterationId = m.TipIterationID  "
'Sql &= "  LEFT OUTER JOIN dbo.ContentSourceIndexStatus AS csis ON csis.EntityId = fit.ResourceId  "
'Sql &= "  LEFT OUTER JOIN dbo.Revision AS r ON i.RevisionId = r.RevisionId  "
'Sql &= "  LEFT OUTER JOIN dbo.LifeCycleState AS lcs ON r.LifeCycleStateId = lcs.LifeCycleStateId "
'Sql &= "  WHERE fm.FolderID =" & ParentFolderID
'Sql &= "  Order By fi.FileIterationID DESC "