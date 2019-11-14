Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.VLT
  <DataObject()>
  Public Class vltLog
    Private Shared _RecordCount As Int64
    Public Property LogNo As Int64 = 0
    Public Property IP_Address As String = ""
    Public Property LoginID As String = ""
    Public Property FileName As String = ""
    Public Property LoggedOn As String = ""
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function vltLogGetNewRecord() As SIS.VLT.vltLog
      Return New SIS.VLT.vltLog()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function vltLogGetByID(ByVal LogNo As Int64) As SIS.VLT.vltLog
      Dim Results As SIS.VLT.vltLog = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvltLogSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LogNo", SqlDbType.BigInt, LogNo.ToString.Length, LogNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, "")
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.VLT.vltLog(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function vltLogSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal LoginID As String, ByVal FileName As String, ByVal LoggedOn As String) As List(Of SIS.VLT.vltLog)
      Dim Results As List(Of SIS.VLT.vltLog) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "LogNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spvltLogSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spvltLogSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_LoginID", SqlDbType.NVarChar, 50, IIf(LoginID Is Nothing, String.Empty, LoginID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_FileName", SqlDbType.NVarChar, 50, IIf(FileName Is Nothing, String.Empty, FileName))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_LoggedOn", SqlDbType.NVarChar, 50, IIf(LoggedOn = "", String.Empty, LoggedOn))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, "")
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.VLT.vltLog)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.VLT.vltLog(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function vltLogSelectCount() As Int64
      Return _RecordCount
    End Function
    'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function vltLogGetByID(ByVal LogNo As Int64, ByVal Filter_LoginID As String, ByVal Filter_FileName As String, ByVal Filter_LoggedOn As DateTime) As SIS.VLT.vltLog
      Return vltLogGetByID(LogNo)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)>
    Public Shared Function vltLogInsert(ByVal Record As SIS.VLT.vltLog) As SIS.VLT.vltLog
      Dim _Rec As SIS.VLT.vltLog = SIS.VLT.vltLog.vltLogGetNewRecord()
      With _Rec
        .IP_Address = Record.IP_Address
        .LoginID = Record.LoginID
        .FileName = Record.FileName
        .LoggedOn = Record.LoggedOn
      End With
      Return SIS.VLT.vltLog.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.VLT.vltLog) As SIS.VLT.vltLog
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvltLogInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IP_Address", SqlDbType.NVarChar, 51, IIf(Record.IP_Address = "", Convert.DBNull, Record.IP_Address))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 51, Record.LoginID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FileName", SqlDbType.NVarChar, 51, IIf(Record.FileName = "", Convert.DBNull, Record.FileName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoggedOn", SqlDbType.DateTime, 21, Record.LoggedOn)
          Cmd.Parameters.Add("@Return_LogNo", SqlDbType.BigInt, 20)
          Cmd.Parameters("@Return_LogNo").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.LogNo = Cmd.Parameters("@Return_LogNo").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)>
    Public Shared Function vltLogUpdate(ByVal Record As SIS.VLT.vltLog) As SIS.VLT.vltLog
      Dim _Rec As SIS.VLT.vltLog = SIS.VLT.vltLog.vltLogGetByID(Record.LogNo)
      With _Rec
        .IP_Address = Record.IP_Address
        .LoginID = Record.LoginID
        .FileName = Record.FileName
        .LoggedOn = Record.LoggedOn
      End With
      Return SIS.VLT.vltLog.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.VLT.vltLog) As SIS.VLT.vltLog
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvltLogUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_LogNo", SqlDbType.BigInt, 20, Record.LogNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IP_Address", SqlDbType.NVarChar, 51, IIf(Record.IP_Address = "", Convert.DBNull, Record.IP_Address))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 51, Record.LoginID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FileName", SqlDbType.NVarChar, 51, IIf(Record.FileName = "", Convert.DBNull, Record.FileName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoggedOn", SqlDbType.DateTime, 21, Record.LoggedOn)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Delete, True)>
    Public Shared Function vltLogDelete(ByVal Record As SIS.VLT.vltLog) As Int32
      Dim _Result As Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvltLogDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_LogNo", SqlDbType.BigInt, Record.LogNo.ToString.Length, Record.LogNo)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _RecordCount
    End Function
    Sub New(rd As SqlDataReader)
      SIS.VLT.UI.NewObj(Me, rd)
    End Sub
    Public Sub New()
    End Sub
  End Class

End Namespace
