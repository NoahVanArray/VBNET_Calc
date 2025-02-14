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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        MainLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button0 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        dotBtn = New Button()
        clearBtn = New Button()
        divideBtn = New Button()
        multiplyBtn = New Button()
        addBtn = New Button()
        subtractBtn = New Button()
        equalButton = New Button()
        debug = New Button()
        debuga = New Button()
        debugb = New Button()
        isEqualedBtn = New Button()
        Panel1.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.FromArgb(CByte(151), CByte(171), CByte(70))
        Panel1.Controls.Add(Guna2Panel1)
        Panel1.Controls.Add(TextBox2)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(22, 34)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(555, 79)
        Panel1.TabIndex = 0
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderColor = Color.Silver
        Guna2Panel1.BorderThickness = 2
        Guna2Panel1.Controls.Add(MainLabel)
        Guna2Panel1.CustomizableEdges = CustomizableEdges1
        Guna2Panel1.ForeColor = Color.FromArgb(CByte(143), CByte(159), CByte(72))
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel1.Size = New Size(555, 79)
        Guna2Panel1.TabIndex = 21
        Guna2Panel1.UseTransparentBackground = True
        ' 
        ' MainLabel
        ' 
        MainLabel.AutoSize = False
        MainLabel.BackColor = Color.Transparent
        MainLabel.Font = New Font("DSEG7 Classic", 41F, FontStyle.Bold)
        MainLabel.ForeColor = Color.FromArgb(CByte(34), CByte(41), CByte(11))
        MainLabel.IsSelectionEnabled = False
        MainLabel.Location = New Point(3, 11)
        MainLabel.Name = "MainLabel"
        MainLabel.Size = New Size(546, 57)
        MainLabel.TabIndex = 0
        MainLabel.Text = "0"
        MainLabel.TextAlignment = ContentAlignment.TopRight
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.None
        TextBox2.BackColor = Color.FromArgb(CByte(155), CByte(173), CByte(72))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("DSEG7 Classic", 41F, FontStyle.Bold)
        TextBox2.ForeColor = Color.FromArgb(CByte(139), CByte(157), CByte(59))
        TextBox2.Location = New Point(-2, 11)
        TextBox2.MaxLength = 12
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.RightToLeft = RightToLeft.Yes
        TextBox2.Size = New Size(549, 60)
        TextBox2.TabIndex = 0
        TextBox2.Text = "888888888888"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Trebuchet MS", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        Button1.Location = New Point(63, 283)
        Button1.Name = "Button1"
        Button1.Size = New Size(58, 52)
        Button1.TabIndex = 3
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Trebuchet MS", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        Button2.Location = New Point(175, 283)
        Button2.Name = "Button2"
        Button2.Size = New Size(58, 52)
        Button2.TabIndex = 4
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Trebuchet MS", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        Button3.Location = New Point(280, 283)
        Button3.Name = "Button3"
        Button3.Size = New Size(58, 52)
        Button3.TabIndex = 5
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button0
        ' 
        Button0.Anchor = AnchorStyles.None
        Button0.Cursor = Cursors.Hand
        Button0.FlatAppearance.BorderSize = 0
        Button0.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        Button0.FlatStyle = FlatStyle.Flat
        Button0.Font = New Font("Trebuchet MS", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button0.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        Button0.Location = New Point(175, 356)
        Button0.Name = "Button0"
        Button0.Size = New Size(58, 52)
        Button0.TabIndex = 6
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.None
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Trebuchet MS", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        Button4.Location = New Point(63, 210)
        Button4.Name = "Button4"
        Button4.Size = New Size(58, 52)
        Button4.TabIndex = 7
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.None
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Trebuchet MS", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        Button5.Location = New Point(175, 210)
        Button5.Name = "Button5"
        Button5.Size = New Size(58, 52)
        Button5.TabIndex = 8
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Anchor = AnchorStyles.None
        Button6.Cursor = Cursors.Hand
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Trebuchet MS", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        Button6.Location = New Point(280, 210)
        Button6.Name = "Button6"
        Button6.Size = New Size(58, 52)
        Button6.TabIndex = 9
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Anchor = AnchorStyles.None
        Button7.Cursor = Cursors.Hand
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Trebuchet MS", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        Button7.Location = New Point(63, 140)
        Button7.Name = "Button7"
        Button7.Size = New Size(58, 52)
        Button7.TabIndex = 10
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Anchor = AnchorStyles.None
        Button8.Cursor = Cursors.Hand
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Trebuchet MS", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        Button8.Location = New Point(175, 137)
        Button8.Name = "Button8"
        Button8.Size = New Size(58, 52)
        Button8.TabIndex = 11
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Anchor = AnchorStyles.None
        Button9.Cursor = Cursors.Hand
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Trebuchet MS", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button9.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        Button9.Location = New Point(280, 137)
        Button9.Name = "Button9"
        Button9.Size = New Size(58, 52)
        Button9.TabIndex = 12
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' dotBtn
        ' 
        dotBtn.Anchor = AnchorStyles.None
        dotBtn.Cursor = Cursors.Hand
        dotBtn.FlatAppearance.BorderSize = 0
        dotBtn.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        dotBtn.FlatStyle = FlatStyle.Flat
        dotBtn.Font = New Font("Trebuchet MS", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dotBtn.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        dotBtn.Location = New Point(280, 356)
        dotBtn.Name = "dotBtn"
        dotBtn.Size = New Size(58, 52)
        dotBtn.TabIndex = 17
        dotBtn.Text = "."
        dotBtn.UseVisualStyleBackColor = True
        ' 
        ' clearBtn
        ' 
        clearBtn.Anchor = AnchorStyles.None
        clearBtn.Cursor = Cursors.Hand
        clearBtn.FlatAppearance.BorderSize = 0
        clearBtn.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        clearBtn.FlatStyle = FlatStyle.Flat
        clearBtn.Font = New Font("Trebuchet MS", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clearBtn.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        clearBtn.Location = New Point(382, 283)
        clearBtn.Name = "clearBtn"
        clearBtn.Size = New Size(58, 52)
        clearBtn.TabIndex = 18
        clearBtn.Text = "C"
        clearBtn.UseVisualStyleBackColor = True
        ' 
        ' divideBtn
        ' 
        divideBtn.Anchor = AnchorStyles.None
        divideBtn.Cursor = Cursors.Hand
        divideBtn.FlatAppearance.BorderSize = 0
        divideBtn.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        divideBtn.FlatStyle = FlatStyle.Flat
        divideBtn.Font = New Font("Trebuchet MS", 30F, FontStyle.Bold)
        divideBtn.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        divideBtn.Location = New Point(481, 210)
        divideBtn.Name = "divideBtn"
        divideBtn.Size = New Size(58, 52)
        divideBtn.TabIndex = 16
        divideBtn.Text = "÷"
        divideBtn.UseVisualStyleBackColor = True
        ' 
        ' multiplyBtn
        ' 
        multiplyBtn.Anchor = AnchorStyles.None
        multiplyBtn.Cursor = Cursors.Hand
        multiplyBtn.FlatAppearance.BorderSize = 0
        multiplyBtn.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        multiplyBtn.FlatStyle = FlatStyle.Flat
        multiplyBtn.Font = New Font("Trebuchet MS", 30F, FontStyle.Bold)
        multiplyBtn.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        multiplyBtn.Location = New Point(481, 136)
        multiplyBtn.Name = "multiplyBtn"
        multiplyBtn.Size = New Size(58, 52)
        multiplyBtn.TabIndex = 15
        multiplyBtn.Text = "×"
        multiplyBtn.UseVisualStyleBackColor = True
        ' 
        ' addBtn
        ' 
        addBtn.Anchor = AnchorStyles.None
        addBtn.Cursor = Cursors.Hand
        addBtn.FlatAppearance.BorderSize = 0
        addBtn.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        addBtn.FlatStyle = FlatStyle.Flat
        addBtn.Font = New Font("Trebuchet MS", 30F, FontStyle.Bold)
        addBtn.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        addBtn.Location = New Point(382, 136)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(58, 52)
        addBtn.TabIndex = 13
        addBtn.Text = "+"
        addBtn.UseVisualStyleBackColor = True
        ' 
        ' subtractBtn
        ' 
        subtractBtn.Anchor = AnchorStyles.None
        subtractBtn.Cursor = Cursors.Hand
        subtractBtn.FlatAppearance.BorderSize = 0
        subtractBtn.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        subtractBtn.FlatStyle = FlatStyle.Flat
        subtractBtn.Font = New Font("Trebuchet MS", 30F, FontStyle.Bold)
        subtractBtn.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        subtractBtn.Location = New Point(382, 210)
        subtractBtn.Name = "subtractBtn"
        subtractBtn.Size = New Size(58, 52)
        subtractBtn.TabIndex = 14
        subtractBtn.Text = "−"
        subtractBtn.UseVisualStyleBackColor = True
        ' 
        ' equalButton
        ' 
        equalButton.Anchor = AnchorStyles.None
        equalButton.Cursor = Cursors.Hand
        equalButton.FlatAppearance.BorderSize = 0
        equalButton.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        equalButton.FlatStyle = FlatStyle.Flat
        equalButton.Font = New Font("Trebuchet MS", 30F, FontStyle.Bold)
        equalButton.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        equalButton.Location = New Point(481, 283)
        equalButton.Name = "equalButton"
        equalButton.Size = New Size(58, 52)
        equalButton.TabIndex = 19
        equalButton.Text = "="
        equalButton.UseVisualStyleBackColor = True
        ' 
        ' debug
        ' 
        debug.Anchor = AnchorStyles.None
        debug.Cursor = Cursors.Hand
        debug.FlatAppearance.BorderSize = 0
        debug.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        debug.FlatStyle = FlatStyle.Flat
        debug.Font = New Font("Trebuchet MS", 13F, FontStyle.Bold)
        debug.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        debug.Location = New Point(402, 356)
        debug.Name = "debug"
        debug.Size = New Size(137, 33)
        debug.TabIndex = 20
        debug.Text = "debug"
        debug.UseVisualStyleBackColor = True
        ' 
        ' debuga
        ' 
        debuga.Anchor = AnchorStyles.None
        debuga.Cursor = Cursors.Hand
        debuga.FlatAppearance.BorderSize = 0
        debuga.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        debuga.FlatStyle = FlatStyle.Flat
        debuga.Font = New Font("Trebuchet MS", 13F, FontStyle.Bold)
        debuga.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        debuga.Location = New Point(32, 356)
        debuga.Name = "debuga"
        debuga.Size = New Size(137, 33)
        debuga.TabIndex = 21
        debuga.Text = "debuga"
        debuga.UseVisualStyleBackColor = True
        ' 
        ' debugb
        ' 
        debugb.Anchor = AnchorStyles.None
        debugb.Cursor = Cursors.Hand
        debugb.FlatAppearance.BorderSize = 0
        debugb.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        debugb.FlatStyle = FlatStyle.Flat
        debugb.Font = New Font("Trebuchet MS", 13F, FontStyle.Bold)
        debugb.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        debugb.Location = New Point(32, 395)
        debugb.Name = "debugb"
        debugb.Size = New Size(137, 33)
        debugb.TabIndex = 22
        debugb.Text = "debugb"
        debugb.UseVisualStyleBackColor = True
        ' 
        ' isEqualedBtn
        ' 
        isEqualedBtn.Anchor = AnchorStyles.None
        isEqualedBtn.Cursor = Cursors.Hand
        isEqualedBtn.FlatAppearance.BorderSize = 0
        isEqualedBtn.FlatAppearance.MouseDownBackColor = SystemColors.ControlLight
        isEqualedBtn.FlatStyle = FlatStyle.Flat
        isEqualedBtn.Font = New Font("Trebuchet MS", 13F, FontStyle.Bold)
        isEqualedBtn.ForeColor = Color.FromArgb(CByte(217), CByte(218), CByte(220))
        isEqualedBtn.Location = New Point(402, 395)
        isEqualedBtn.Name = "isEqualedBtn"
        isEqualedBtn.Size = New Size(137, 33)
        isEqualedBtn.TabIndex = 23
        isEqualedBtn.Text = "is equal?"
        isEqualedBtn.UseVisualStyleBackColor = True
        ' 
        ' MainCalc
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(38), CByte(38))
        ClientSize = New Size(599, 450)
        Controls.Add(isEqualedBtn)
        Controls.Add(debugb)
        Controls.Add(debuga)
        Controls.Add(debug)
        Controls.Add(equalButton)
        Controls.Add(Panel1)
        Controls.Add(clearBtn)
        Controls.Add(dotBtn)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button0)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(subtractBtn)
        Controls.Add(addBtn)
        Controls.Add(multiplyBtn)
        Controls.Add(divideBtn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "MainCalc"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculator"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Guna2Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents dotBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents divideBtn As Button
    Friend WithEvents multiplyBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents subtractBtn As Button
    Friend WithEvents equalButton As Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MainLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents debug As Button
    Friend WithEvents debuga As Button
    Friend WithEvents debugb As Button
    Friend WithEvents isEqualedBtn As Button

End Class
