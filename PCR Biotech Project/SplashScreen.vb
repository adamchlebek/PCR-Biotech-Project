Public Class SplashScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RectangleShape2.Width += 2
        If RectangleShape2.Width >= 310 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.CenterToScreen()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RectangleShape2.Width += 1
        If RectangleShape2.Width >= 351 Then
            Timer2.Stop()
            Me.Hide()
            MainMenu.Show()
        End If
    End Sub
End Class