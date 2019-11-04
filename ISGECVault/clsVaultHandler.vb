Namespace SIS.VLT
  Public Class clsVaultHandler
    Implements IDisposable
    Public Property LoadedVaults As List(Of SIS.VLT.clsVault) = Nothing
    Public Sub LoadVault(vaultDB As String, frm As frmVault, vlt As SIS.VLT.Vaults)
      Dim tmp As New clsVault
      tmp.VaultDB = vaultDB
      tmp.frmUI = frm
      tmp.Vault = vlt
      AddHandler frm.cmnuDownload.Click, AddressOf tmp.DownloadMenu_Click
      AddHandler frm.cmnuOpenOriginal.Click, AddressOf tmp.OpenOriginal_Click
      AddHandler frm.hmnuDownload.Click, AddressOf tmp.hDownloadMenu_Click
      AddHandler frm.hmnuOpenOriginal.Click, AddressOf tmp.hOpenOriginal_Click
      LoadedVaults.Add(tmp)
      tmp.Load()
    End Sub

    Sub New()
      LoadedVaults = New List(Of clsVault)
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
      If Not disposedValue Then
        If disposing Then
          ' TODO: dispose managed state (managed objects).
          For Each x As SIS.VLT.clsVault In LoadedVaults
            x.Dispose()
            x = Nothing
          Next
          LoadedVaults = Nothing
        End If

        ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
        ' TODO: set large fields to null.
      End If
      disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
      ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
      Dispose(True)
      ' TODO: uncomment the following line if Finalize() is overridden above.
      ' GC.SuppressFinalize(Me)
    End Sub
#End Region
  End Class
End Namespace
