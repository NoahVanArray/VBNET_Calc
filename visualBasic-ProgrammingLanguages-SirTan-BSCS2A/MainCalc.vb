Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class MainCalc

#Region "BOOL BUTTON PRESSED STATE"
    Private boolButton0 As Boolean = False
    Private boolButton1 As Boolean = False
    Private boolButton2 As Boolean = False
    Private boolButton3 As Boolean = False
    Private boolButton4 As Boolean = False
    Private boolButton5 As Boolean = False
    Private boolButton6 As Boolean = False
    Private boolButton7 As Boolean = False
    Private boolButton8 As Boolean = False
    Private boolButton9 As Boolean = False
    Private boolButtonAdd As Boolean = False
    Private boolButtonSub As Boolean = False
    Private boolButtonMul As Boolean = False
    Private boolButtonDiv As Boolean = False
    Private boolButtonDot As Boolean = False
    Private boolButtonClear As Boolean = False
    Private boolButtonEqual As Boolean = False
    Private btnActive As Boolean = True
#End Region

    Private isAdd As Boolean = False
    Private isSub As Boolean = False
    Private isMul As Boolean = False
    Private isDiv As Boolean = False

    Private isEqualed As Boolean = False
    Private clearText As Boolean = True
    Private doAdd As Boolean = False

    Private sum As Decimal = 0
    Private b As Decimal = 0

    Private afe As Decimal = 0

#Region "BUTTON DESIGNS"

    'BUTTON 0
    Private Sub Button0_Paint(sender As Object, e As PaintEventArgs) Handles Button0.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
       SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
       SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
       SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
       SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButton0 = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub Button0_MouseDown(sender As Object, e As MouseEventArgs) Handles Button0.MouseDown
        boolButton0 = True
    End Sub

    Private Sub Button0_MouseUp(sender As Object, e As MouseEventArgs) Handles Button0.MouseUp
        boolButton0 = False
    End Sub


    'BUTTON 1
    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButton1 = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        boolButton1 = True
    End Sub
    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        boolButton1 = False
    End Sub


    'BUTTON 2
    Private Sub Button2_Paint(sender As Object, e As PaintEventArgs) Handles Button2.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButton2 = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        boolButton2 = True
    End Sub

    Private Sub Button2_MouseUp(sender As Object, e As MouseEventArgs) Handles Button2.MouseUp
        boolButton2 = False
    End Sub


    'BUTTON 3
    Private Sub Button3_Paint(sender As Object, e As PaintEventArgs) Handles Button3.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButton3 = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        boolButton3 = True
    End Sub

    Private Sub Button3_MouseUp(sender As Object, e As MouseEventArgs) Handles Button3.MouseUp
        boolButton3 = False
    End Sub


    'BUTTON 4
    Private Sub Button4_Paint(sender As Object, e As PaintEventArgs) Handles Button4.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButton4 = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub Button4_MouseDown(sender As Object, e As MouseEventArgs) Handles Button4.MouseDown
        boolButton4 = True
    End Sub

    Private Sub Button4_MouseUp(sender As Object, e As MouseEventArgs) Handles Button4.MouseUp
        boolButton4 = False
    End Sub


    'BUTTON 5
    Private Sub Button5_Paint(sender As Object, e As PaintEventArgs) Handles Button5.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButton5 = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub Button5_MouseDown(sender As Object, e As MouseEventArgs) Handles Button5.MouseDown
        boolButton5 = True
    End Sub

    Private Sub Button5_MouseUp(sender As Object, e As MouseEventArgs) Handles Button5.MouseUp
        boolButton5 = False
    End Sub

    'BUTTON 6
    Private Sub Button6_Paint(sender As Object, e As PaintEventArgs) Handles Button6.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButton6 = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub Button6_MouseDown(sender As Object, e As MouseEventArgs) Handles Button6.MouseDown
        boolButton6 = True
    End Sub

    Private Sub Button6_MouseUp(sender As Object, e As MouseEventArgs) Handles Button6.MouseUp
        boolButton6 = False
    End Sub

    'BUTTON 7
    Private Sub Button7_Paint(sender As Object, e As PaintEventArgs) Handles Button7.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButton7 = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub Button7_MouseDown(sender As Object, e As MouseEventArgs) Handles Button7.MouseDown
        boolButton7 = True
    End Sub

    Private Sub Button7_MouseUp(sender As Object, e As MouseEventArgs) Handles Button7.MouseUp
        boolButton7 = False
    End Sub


    'BUTTON 8
    Private Sub Button8_Paint(sender As Object, e As PaintEventArgs) Handles Button8.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButton8 = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub Button8_MouseDown(sender As Object, e As MouseEventArgs) Handles Button8.MouseDown
        boolButton8 = True
    End Sub

    Private Sub Button8_MouseUp(sender As Object, e As MouseEventArgs) Handles Button8.MouseUp
        boolButton8 = False
    End Sub


    'BUTTON 9
    Private Sub Button9_Paint(sender As Object, e As PaintEventArgs) Handles Button9.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButton9 = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub Button9_MouseDown(sender As Object, e As MouseEventArgs) Handles Button9.MouseDown
        boolButton9 = True
    End Sub

    Private Sub Button9_MouseUp(sender As Object, e As MouseEventArgs) Handles Button9.MouseUp
        boolButton9 = False
    End Sub


    'ADDITION BUTTON
    Private Sub addBtn_Paint(sender As Object, e As PaintEventArgs) Handles addBtn.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButtonAdd = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub addBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles addBtn.MouseDown
        boolButtonAdd = True
    End Sub

    Private Sub addBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles addBtn.MouseUp
        boolButtonAdd = False
    End Sub


    'SUBTRACTION BUTTON
    Private Sub subtractBtn_Paint(sender As Object, e As PaintEventArgs) Handles subtractBtn.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButtonSub = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub subtractBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles subtractBtn.MouseDown
        boolButtonSub = True
    End Sub

    Private Sub subtractBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles subtractBtn.MouseUp
        boolButtonSub = False
    End Sub


    'MULTIPLICATION BUTTON
    Private Sub multiplyBtn_Paint(sender As Object, e As PaintEventArgs) Handles multiplyBtn.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButtonMul = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub multiplyBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles multiplyBtn.MouseDown
        boolButtonMul = True
    End Sub

    Private Sub multiplyBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles multiplyBtn.MouseUp
        boolButtonMul = False
    End Sub


    'DIVISION BUTTON
    Private Sub divideBtn_Paint(sender As Object, e As PaintEventArgs) Handles divideBtn.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButtonDiv = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub divideBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles divideBtn.MouseDown
        boolButtonDiv = True
    End Sub

    Private Sub divideBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles divideBtn.MouseUp
        boolButtonDiv = False
    End Sub


    'DOT BUTTON
    Private Sub dotBtn_Paint(sender As Object, e As PaintEventArgs) Handles dotBtn.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButtonDot = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub dotBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles dotBtn.MouseDown
        boolButtonDot = True
    End Sub

    Private Sub dotBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles dotBtn.MouseUp
        boolButtonDot = False
    End Sub


    'CLEAR BUTTON
    Private Sub clearBtn_Paint(sender As Object, e As PaintEventArgs) Handles clearBtn.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButtonClear = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub
    Private Sub clearBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles clearBtn.MouseDown
        boolButtonClear = True
    End Sub

    Private Sub clearBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles clearBtn.MouseUp
        boolButtonClear = False
    End Sub


    'EQUAL BUTTON
    Private Sub equalButton_Paint(sender As Object, e As PaintEventArgs) Handles equalButton.Paint
        ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        If boolButtonEqual = False Then
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Outset)

        Else
            ControlPaint.DrawBorder(e.Graphics, Button1.ClientRectangle,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset,
            SystemColors.ControlLightLight, 3.5, ButtonBorderStyle.Inset)
        End If
    End Sub

    Private Sub equalButton_MouseDown(sender As Object, e As MouseEventArgs) Handles equalButton.MouseDown
        boolButtonEqual = True
    End Sub

    Private Sub equalButton_MouseUp(sender As Object, e As MouseEventArgs) Handles equalButton.MouseUp
        boolButtonEqual = False
    End Sub

#End Region

    Private Sub MainCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.SelectionStart = TextBox2.Text.Length
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim g As Graphics = Panel1.CreateGraphics()

        Dim panelRect As Rectangle = Panel1.ClientRectangle

        Dim p1 As Point = New Point(panelRect.Left, panelRect.Top)  'top left
        Dim p2 As Point = New Point(panelRect.Right + 4, panelRect.Top)  'Top Right
        Dim p3 As Point = New Point(panelRect.Left, panelRect.Bottom + 4)  'Bottom Left
        Dim p4 As Point = New Point(panelRect.Right + 4, panelRect.Bottom + 4)  'Bottom Right

        Dim pen1 As Pen = New Pen(System.Drawing.Color.White)
        Dim pen2 As Pen = New Pen(System.Drawing.Color.Black)

        g.DrawLine(pen1, p1, p2)
        g.DrawLine(pen1, p1, p3)
        g.DrawLine(pen2, p2, p4)
        g.DrawLine(pen2, p3, p4)
    End Sub


    Function typeBtn(value) As String
        If MainLabel.Text.Length < 12 And btnActive = True Then

            If clearText = True Then
                MainLabel.Text = ""
                clearText = False
                happ.Text = "Happening #1"
            End If

            If isEqualed Then
                b = 0
                afe = 0
                happ.Text = "Happening #2"
            End If

            MainLabel.Text += value
            b = Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture)
            afe = b

            debuga.Text = sum.ToString()
            debugb.Text = b.ToString()

            doAdd = True

        End If
    End Function

#Region "INPUT BUTTONS"
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        typeBtn("0")

        If Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture) = 0 Then
            MainLabel.Text = "0"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        typeBtn("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        typeBtn("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        typeBtn("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        typeBtn("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        typeBtn("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        typeBtn("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        typeBtn("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        typeBtn("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        typeBtn("9")
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        MainLabel.Text = "0"
        sum = 0
        b = 0
        count = 0
        dotCount = 0

        isEqualed = False
        clearText = True
        debug.Text = count.ToString()
        debuga.Text = sum.ToString()
        debugb.Text = b.ToString()

    End Sub

    Private Sub dotBtn_Click(sender As Object, e As EventArgs) Handles dotBtn.Click
        If MainLabel.Text.Length < 12 And Not String.IsNullOrEmpty(MainLabel.Text) And btnActive = True And dotCount = 0 Then
            MainLabel.Text &= "."
            dotCount = 1
        End If
    End Sub

#End Region

#Region "OPERATOR BUTTONS"
    Private count As Int128 = 0
    Private dotCount As Int128 = 0
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        If count = 0 Then
            sum = Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture)
            happ.Text = "Happening #4.1.1"
        End If

        If count = 1 Then
            If doAdd Then
                MainLabel.Text = sum + b
                sum = Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture)

                doAdd = False
                happ.Text = "Happening #4.1.2"
            End If
        End If

        b = 0

        isEqualedBtn.Text = isEqualed.ToString()
        debug.Text = count.ToString()
        debuga.Text = sum.ToString()
        debugb.Text = b.ToString()

        clearText = True

        isAdd = True
        isSub = False
        isMul = False
        isDiv = False

        dotCount = 0
        count = 1
    End Sub

    Private Sub subtractBtn_Click(sender As Object, e As EventArgs) Handles subtractBtn.Click
        If count = 0 Then
            sum = Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture)
            happ.Text = "Happening #4.2.1"
        End If

        If count = 1 Then
            If doAdd Then
                MainLabel.Text = sum - b
                sum = Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture)

                doAdd = False
                happ.Text = "Happening #4.2.2"
            End If
        End If

        b = 0

        isEqualedBtn.Text = isEqualed.ToString()
        debug.Text = count.ToString()
        debuga.Text = sum.ToString()
        debugb.Text = b.ToString()

        clearText = True

        isAdd = False
        isSub = True
        isMul = False
        isDiv = False

        dotCount = 0
        count = 1
    End Sub

    Private Sub multiplyBtn_Click(sender As Object, e As EventArgs) Handles multiplyBtn.Click
        If count = 0 Then
            sum = Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture)
            happ.Text = "Happening #4.3.1"
        End If

        If count = 1 Then
            If doAdd Then
                MainLabel.Text = sum * b
                sum = Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture)

                doAdd = False
                happ.Text = "Happening #4.3.2"
            End If
        End If

        b = 0

        isEqualedBtn.Text = isEqualed.ToString()
        debug.Text = count.ToString()
        debuga.Text = sum.ToString()
        debugb.Text = b.ToString()

        clearText = True

        isAdd = False
        isSub = False
        isMul = True
        isDiv = False

        dotCount = 0
        count = 1
    End Sub

    Private Sub divideBtn_Click(sender As Object, e As EventArgs) Handles divideBtn.Click
        If count = 0 Then
            sum = Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture)
            happ.Text = "Happening #4.4.1"
        End If

        If count = 1 Then
            If doAdd Then
                MainLabel.Text = sum / b
                sum = Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture)

                doAdd = False
                happ.Text = "Happening #4.4.2"
            End If
        End If

        b = 0

        isEqualedBtn.Text = isEqualed.ToString()
        debug.Text = count.ToString()
        debuga.Text = sum.ToString()
        debugb.Text = b.ToString()

        clearText = True

        isAdd = False
        isSub = False
        isMul = False
        isDiv = True

        dotCount = 0
        count = 1
    End Sub

    Private Sub equalButton_Click(sender As Object, e As EventArgs) Handles equalButton.Click
        If isAdd = True Then
            MainLabel.Text = (sum + afe).ToString()
            sum = Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture)
            b = 0

            isEqualed = True

            debug.Text = count.ToString()
            debuga.Text = sum.ToString()
            debugb.Text = b.ToString()
            isEqualedBtn.Text = isEqualed.ToString()
            happ.Text = "Happening #5.1"
        End If
        If isSub = True Then
            MainLabel.Text = (sum - afe).ToString()
            sum = Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture)
            b = 0

            isEqualed = True

            debug.Text = count.ToString()
            debuga.Text = sum.ToString()
            debugb.Text = b.ToString()
            isEqualedBtn.Text = isEqualed.ToString()
            happ.Text = "Happening #5.2"
        End If
        If isMul = True Then
            MainLabel.Text = (sum * afe).ToString()
            sum = Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture)
            b = 0

            isEqualed = True

            debug.Text = count.ToString()
            debuga.Text = sum.ToString()
            debugb.Text = b.ToString()
            isEqualedBtn.Text = isEqualed.ToString()
            happ.Text = "Happening #5.3"
        End If
        If isDiv = True Then
            MainLabel.Text = (sum / afe).ToString()
            sum = Decimal.Parse(MainLabel.Text, System.Globalization.CultureInfo.InvariantCulture)
            b = 0

            isEqualed = True

            debug.Text = count.ToString()
            debuga.Text = sum.ToString()
            debugb.Text = b.ToString()
            isEqualedBtn.Text = isEqualed.ToString()
            happ.Text = "Happening #5.4"
        End If

        clearText = True
        dotCount = 0
    End Sub

#End Region


    Private Sub MainLabel_TextChanged(sender As Object, e As EventArgs) Handles MainLabel.TextChanged
        If MainLabel.Text.Length = 12 Then
            btnActive = False
        ElseIf MainLabel.Text.Length > 12 Then
            MainLabel.Text = "Err_Too_Long"
        Else
            btnActive = True
        End If

    End Sub

End Class
