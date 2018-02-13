Imports Microsoft.Win32
Imports System.Text.RegularExpressions

Public Class Wannadecryptor

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim CurrentParams As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            CurrentParams.ClassStyle = CurrentParams.ClassStyle Or CS_NOCLOSE
            Return CurrentParams
        End Get
    End Property
End Class