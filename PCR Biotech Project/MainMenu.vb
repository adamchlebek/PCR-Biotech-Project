Public Class MainMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        btnSimulation.Left = (Me.ClientSize.Width / 2) - (btnSimulation.Width / 2)
        btnCalculator.Left = (Me.ClientSize.Width / 2) - (btnCalculator.Width / 2)
        btnInfo.Left = (Me.ClientSize.Width / 2) - (btnInfo.Width / 2)
        btnExit.Left = (Me.ClientSize.Width / 2) - (btnExit.Width / 2)

        lblFact.Text = getFact()
    End Sub

    Public Function getFact()
        Dim fact As String
        Dim rndNum As Integer

        Randomize()
        rndNum = Int(Rnd() * 16) + 1

        Select Case rndNum
            Case 1
                fact = "PCR is routinely used to identify the sources of new infectious diseases. The technology was used during the SARS epidemic in 2002 and 2003 to identify Coronavirus as the culprit and trace its origins -- work which took just one year to complete."
            Case 2
                fact = "DNA fingerprinting, used in paternity testing or to identify criminals, is possible with the smallest amount of genetic material thanks to PCR. Of course, it can also be used to prove innocence. Last year, the 300th prisoner in United States history was exonerated after DNA evidence showed he was convicted in error."
            Case 3
                fact = "Each cell in your body contains about two meters of DNA. If laid end-to-end it would measure 200 billion kilometers. That's long enough to stretch from Earth to the sun 1,333 times. To put that in perspective, it would take 7.4 days for sunlight to travel the same distance.   "
            Case 4
                fact = "You aren't that special. About 99.9% of your DNA is exactly the same as everyone else's. The other 0.1% codes for all of the differences that make us unique."
            Case 5
                fact = "All of the genetic information for every living organism is stored in combinations and sequences of just four molecules -- adenine, cytosine, guanine, and thymine. Differing sequences make up the 24,000 genes found in the human genome.  "
            Case 6
                fact = "Humans shares about 98% of their genes with chimpanzees, 92% with mice, 76% with zebrafish, 51% with fruit flies, 26% with thale cress (a type of weed), and 18% with E. coli bacteria.   "
            Case 7
                fact = "Some of the genetic material that makes you isn't of human origin. Viruses and bacteria can insert their DNA into your genome through a process called horizontal gene transfer, or HGT. Scientists have discovered that HGT is much more common in certain cancer cells than healthy cells, perhaps pointing to possible causes and cures."
            Case 8
                fact = "DNA isn't called the information molecule for nothing. Researchers have stored as much as 700 terabytes of data in a single gram of DNA, while others have produced read-write DNA technology. If scaled properly, all of the information in the entire world -- videos, photos, scientific papers, the Internet, and the like -- would fit in the back of a single van, according to computational biologist Nick Goldman."
            Case 9
                fact = "Scientists at JCVI used first-generation genome engineering technologies, which resulted in many expensive discoveries for many more dead ends. Don't write-off the possibility of building fully synthetic organisms due to costs, however: next-generation genome engineering technologies can create one billion similarly sized genomes for just $9,000. "
            Case 10
                fact = "The world has become pretty good at DNA sequencing since completing The Human Genome Project in 2003 and now sports a sequencing capacity of over 1 trillion kilobases a year. Unfortunately, the world's DNA synthesis capacity is less than 230 million kilobases a year."
            Case 11
                fact = "For instance, Autodesk, the company famous for inventing AutoCAD and now revolutionizing 3-D printing platforms, is developing software design tools for programmable matter in living systems. Currently called Project Cyborg and in beta testing only, scientists will one day be able to design and build human tissues and organs, single cell organisms with novel metabolic pathways, and programmable nanoparticles."
            Case 12
                fact = "Spider dragline silk is incredibly strong and flexible, but impossible to practically mass produce with spiders -- they're simply too territorial. Researchers at the University of Wyoming solved the problem by inserting the silk gene from spiders into more docile creatures: goats."
            Case 13
                fact = "Fermentation is a great way to produce many other foods and chemicals. Renewable oils company Solazyme is commercializing an industrial biotechnology platform using heterotrophic algae to produce a wide range of fatty acid-containing oils."
            Case 14
                fact = "It may sound new or futuristic, but industrial biotechnology has been around since humans began mass producing beer 10,000 years ago. It was all made possible with a species of yeast called Saccharomyces cerevisiae, which translates to sugar fungi Of beer, that is still used today."
            Case 15
                fact = "Wisconsin is so well-known for its cheese and dairy products that lawmakers named Lactococcus lactis the official state microbe in 2010 in a 56 to 41 vote."
            Case 16
                fact = "The European Union continues to be slow to adopt biotech crops. In 2012 only five countries in the EU planted such crops covering an area of just 129,071 hectares. By comparison, the United States planted 69,500,000 hectares of biotech crops last year. "
            Case Else
                fact = "No Fact Available"
        End Select

        Return fact
    End Function

    Private Sub btnSimulation_Click(sender As Object, e As EventArgs) Handles btnSimulation.Click
        Me.Hide()
        Simulation.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Me.Hide()
        Information.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        lblFact.Text = getFact()
    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        Me.Hide()
        Calculator.Show()
    End Sub
End Class
