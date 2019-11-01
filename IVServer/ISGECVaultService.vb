Imports System.Timers
Imports System.Runtime.InteropServices
Public Class ISGECVaultService
  Private WithEvents tmr As Timer = Nothing
  Private eventID As Integer = 0
  Protected Overrides Sub OnStart(ByVal args() As String)
    Dim ServiceStatus As ServiceStatus = New ServiceStatus()
    ServiceStatus.dwCurrentState = ServiceState.SERVICE_START_PENDING
    ServiceStatus.dwWaitHint = 100000
    SetServiceStatus(Me.ServiceHandle, ServiceStatus)
    EventLog1.WriteEntry("ISGEC Vault Server Starting.")
    tmr = New Timer()
    tmr.Interval = 60000   '60 seconds
    tmr.Start()
  End Sub

  Protected Overrides Sub OnStop()
    Dim ServiceStatus As ServiceStatus = New ServiceStatus()
    ServiceStatus.dwCurrentState = ServiceState.SERVICE_STOP_PENDING
    ServiceStatus.dwWaitHint = 100000
    SetServiceStatus(Me.ServiceHandle, ServiceStatus)
    EventLog1.WriteEntry("ISGEC Vault Server Stoping.")

    'When Stopped
    Dim Ss As ServiceStatus = New ServiceStatus()
    Ss.dwCurrentState = ServiceState.SERVICE_RUNNING
    SetServiceStatus(Me.ServiceHandle, Ss)
  End Sub

  Private Sub tmr_Elapsed(sender As Object, e As ElapsedEventArgs) Handles tmr.Elapsed
    eventID += 1
    EventLog1.WriteEntry("Monitoring ISGEC Vault Service", EventLogEntryType.Information, eventID)

    Dim ServiceStatus As ServiceStatus = New ServiceStatus()
    ServiceStatus.dwCurrentState = ServiceState.SERVICE_RUNNING
    SetServiceStatus(Me.ServiceHandle, ServiceStatus)
  End Sub
  Public Enum ServiceState
    SERVICE_STOPPED = 1
    SERVICE_START_PENDING = 2
    SERVICE_STOP_PENDING = 3
    SERVICE_RUNNING = 4
    SERVICE_CONTINUE_PENDING = 5
    SERVICE_PAUSE_PENDING = 6
    SERVICE_PAUSED = 7

  End Enum
  <StructLayout(LayoutKind.Sequential)>
  Public Structure ServiceStatus
    Public dwServiceType As Integer
    Public dwCurrentState As ServiceState
    Public dwControlsAccepted As Integer
    Public dwWin32ExitCode As Integer
    Public dwServiceSpecificExitCode As Integer
    Public dwCheckPoint As Integer
    Public dwWaitHint As Integer
  End Structure

  <DllImport("advapi32.dll", SetLastError:=True)>
  Private Shared Function SetServiceStatus(handle As System.IntPtr, ByRef serviceStatus As ServiceStatus) As Boolean
  End Function
End Class
