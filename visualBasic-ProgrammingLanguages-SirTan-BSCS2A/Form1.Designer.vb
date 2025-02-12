<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainCalc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(151), CByte(171), CByte(70))
        Panel1.Controls.Add(TextBox1)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(73, 70)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(299, 82)
        Panel1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(93, 18)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' MainCalc
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(38), CByte(38))
        ClientSize = New Size(406, 450)
        Controls.Add(Panel1)
        Name = "MainCalc"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculator"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox

End Class
