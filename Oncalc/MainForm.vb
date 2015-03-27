Public Class MainForm
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDoseCarbo.Click
        Dim K As Decimal
        Dim AUC As Integer
        Dim Creat, Age, Poids, Taille, SC, Clairance, DoseCarbo As Double
        Age = Double.Parse(tAge.Text)
        Taille = Double.Parse(tTaille.Text)
        Poids = Double.Parse(tPoids.Text)
        Creat = Double.Parse(tCreat.Text)

        If rHomme.Checked Then K = 1
        If rFemme.Checked Then K = 0.85

        If r4.Checked Then AUC = 4
        If r5.Checked Then AUC = 5
        If r6.Checked Then AUC = 6
        If r7.Checked Then AUC = 7
        If r8.Checked Then AUC = 8

        SC = Biocalc.SC(Taille, Poids)
        Clairance = Biocalc.Clairance(K, Poids, Age, Creat)
        DoseCarbo = Biocalc.DoseCarbo(AUC, Clairance)


        tDoseTotale.Text = DoseCarbo.ToString("#.##")

    End Sub

    Private Sub bClairance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClairance.Click
        Dim K As Decimal
        Dim Creat, Age, Poids, Clairance As Double
        Age = Double.Parse(tAge.Text)

        Poids = Double.Parse(tPoids.Text)
        Creat = Double.Parse(tCreat.Text)

        If rHomme.Checked Then K = 1
        If rFemme.Checked Then K = 0.85

        Clairance = Biocalc.Clairance(K, Poids, Age, Creat)
        tClair.Text = Math.Round(Clairance).ToString

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Poids, Taille, SC As Double

        Taille = Double.Parse(tTaille.Text)
        Poids = Double.Parse(tPoids.Text)

        SC = Biocalc.SC(Taille, Poids)

        tSC.Text = SC.ToString("#.##")


    End Sub
End Class
