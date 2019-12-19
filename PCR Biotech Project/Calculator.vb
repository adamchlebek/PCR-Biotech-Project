Public Class Calculator
    Private Sub Simulation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        txtRounds.Left = (Me.ClientSize.Width / 2) - (txtRounds.Width / 2)
        btnMinus.Left = (Me.ClientSize.Width / 2) - (txtRounds.Width / 2) - 5 - btnMinus.Width
        btnPlus.Left = (Me.ClientSize.Width / 2) + (txtRounds.Width / 2) + 5
        Label1.Left = (Me.ClientSize.Width / 2) - (Label1.Width / 2)
        Label2.Left = (Me.ClientSize.Width / 2) - (Label2.Width / 2)
        lblAnswer.Left = (Me.ClientSize.Width / 2) - (lblAnswer.Width / 2)
    End Sub

    Private Sub SimulationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationToolStripMenuItem.Click, InformationToolStripMenuItem.Click
        Me.Hide()
        Information.Show()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Sub refreshLabel()
        Dim amount As Decimal

        If txtRounds.Text = Nothing Then
            txtRounds.Text = 0
        ElseIf txtRounds.Text.Contains(".") Then
            txtRounds.Text = 0
        ElseIf txtRounds.Text.Contains("-") Then
            txtRounds.Text = 0
        Else
            If txtRounds.Text > 95 Then
                MessageBox.Show("Please enter number lower than 95.")
            ElseIf txtRounds.Text < 0 Then
                MessageBox.Show("Please enter number more than 0.")
            Else
                amount = 2 ^ txtRounds.Text

                Dim numberString As String = amount.ToString("N0")

                lblAnswer.Text = "After " & txtRounds.Text & " Rounds, you will have " & numberString & " strands of DNA"
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Hide()
        Simulation.Show()
    End Sub

    Private Sub btnMinus_Click_1(sender As Object, e As EventArgs) Handles btnMinus.Click
        If txtRounds.Text > 0 Then
            txtRounds.Text -= 1
            refreshLabel()
        End If
    End Sub

    Private Sub txtRounds_TextChanged_1(sender As Object, e As EventArgs) Handles txtRounds.TextChanged
        refreshLabel()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRounds.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            txtRounds.Text = 0
            e.Handled = True
        End If
    End Sub

    Private Sub btnPlus_Click_1(sender As Object, e As EventArgs) Handles btnPlus.Click
        If txtRounds.Text < 95 Then
            txtRounds.Text += 1
            refreshLabel()
        End If
    End Sub

End Class