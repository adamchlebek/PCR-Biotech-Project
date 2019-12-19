Public Class Information
    Private Sub Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub SimulationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimulationToolStripMenuItem.Click
        Me.Hide()
        Simulation.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub YourGenomecomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YourGenomecomToolStripMenuItem.Click
        Process.Start("https://www.yourgenome.org/facts/what-is-pcr-polymerase-chain-reaction")
    End Sub

    Private Sub StudycomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudycomToolStripMenuItem.Click
        Process.Start("http://study.com/academy/lesson/pcr-synthesizing-dna-using-polymerase-chain-reaction.html")
    End Sub

    Private Sub NDSUeduToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NDSUeduToolStripMenuItem.Click
        Process.Start("https://www.ndsu.edu/pubweb/~mcclean/plsc431/cloning/clone9.htm")
    End Sub

    Private Sub BiteSizeBiocomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BiteSizeBiocomToolStripMenuItem.Click
        Process.Start("https://bitesizebio.com/19132/pcr-basics-what-is-pcr/")
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Me.Hide()
        Calculator.Show()
    End Sub
End Class