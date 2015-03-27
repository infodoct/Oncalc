Public Class Biocalc
    ' Clairance :
    '============
    ' Clairance créatinine (homme) = Poids(kg) x [140-âge(ans)] / Créatinine(mg/l) x 7,2  
    ' Clairance Créatinine (femme) = 0,85 x Poids(kg) x [140-âge(ans)] / Créatinine(mg/l) x 7,2 
    ' Conditions de l'utilisation de cette formule :
    '   âge : entre 18 et 110 ans
    '   poids entre 35 et 120 kg
    '   serum creatinine : 6 et 70 mg/l
    '============
    ' SC :
    '============
    ' Surface corporelle (m²) = 0.20247 x Taille(m)0.725 x Poids(kg)0.425
    '==========================
    Public Shared Function SC(ByVal Taille As Double, ByVal Poids As Double) As Double
        Return 0.20248 * Math.Pow(Taille, 0.725) * Math.Pow(Poids, 0.425)

    End Function

    Public Shared Function Clairance(ByVal K As Decimal, ByVal Poids As Double, ByVal Age As Integer, ByVal Creat As Double) As Double
        Return (K * Poids * (140 - Age)) / (Creat * 7.2)

    End Function

    Public Shared Function DoseCarbo(ByVal AUC As Integer, ByVal Clair As Double) As Double
        Return AUC * (Clair + 25)
    End Function
    Public Shared Function DoseCarbo(ByVal Auc As Integer, ByVal K As Decimal, ByVal Poids As Double, ByVal Age As Double, ByVal Creat As Double)
        Return AUC * (Clairance(K, Poids, Age, Creat) + 25)
    End Function




End Class
