<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tAge = New System.Windows.Forms.TextBox()
        Me.tPoids = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rHomme = New System.Windows.Forms.RadioButton()
        Me.rFemme = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tCreat = New System.Windows.Forms.TextBox()
        Me.bDoseCarbo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tSC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tClair = New System.Windows.Forms.TextBox()
        Me.bClairance = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tTaille = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.r8 = New System.Windows.Forms.RadioButton()
        Me.r6 = New System.Windows.Forms.RadioButton()
        Me.r4 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tDoseTotale = New System.Windows.Forms.TextBox()
        Me.r5 = New System.Windows.Forms.RadioButton()
        Me.r7 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tAge
        '
        Me.tAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAge.Location = New System.Drawing.Point(93, 15)
        Me.tAge.Name = "tAge"
        Me.tAge.Size = New System.Drawing.Size(100, 23)
        Me.tAge.TabIndex = 0
        Me.tAge.Text = "0"
        '
        'tPoids
        '
        Me.tPoids.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPoids.Location = New System.Drawing.Point(93, 42)
        Me.tPoids.Name = "tPoids"
        Me.tPoids.Size = New System.Drawing.Size(100, 23)
        Me.tPoids.TabIndex = 1
        Me.tPoids.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Age"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Poids (Kgs)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Taille (m)"
        '
        'rHomme
        '
        Me.rHomme.AutoSize = True
        Me.rHomme.Location = New System.Drawing.Point(15, 19)
        Me.rHomme.Name = "rHomme"
        Me.rHomme.Size = New System.Drawing.Size(61, 17)
        Me.rHomme.TabIndex = 4
        Me.rHomme.Text = "Homme"
        Me.rHomme.UseVisualStyleBackColor = True
        '
        'rFemme
        '
        Me.rFemme.AutoSize = True
        Me.rFemme.Checked = True
        Me.rFemme.Location = New System.Drawing.Point(15, 54)
        Me.rFemme.Name = "rFemme"
        Me.rFemme.Size = New System.Drawing.Size(59, 17)
        Me.rFemme.TabIndex = 5
        Me.rFemme.TabStop = True
        Me.rFemme.Text = "Femme"
        Me.rFemme.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rHomme)
        Me.GroupBox1.Controls.Add(Me.rFemme)
        Me.GroupBox1.Location = New System.Drawing.Point(213, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 79)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Creat (mg/l)"
        '
        'tCreat
        '
        Me.tCreat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCreat.Location = New System.Drawing.Point(93, 96)
        Me.tCreat.Name = "tCreat"
        Me.tCreat.Size = New System.Drawing.Size(100, 23)
        Me.tCreat.TabIndex = 3
        Me.tCreat.Text = "0"
        '
        'bDoseCarbo
        '
        Me.bDoseCarbo.Location = New System.Drawing.Point(15, 214)
        Me.bDoseCarbo.Name = "bDoseCarbo"
        Me.bDoseCarbo.Size = New System.Drawing.Size(132, 23)
        Me.bDoseCarbo.TabIndex = 11
        Me.bDoseCarbo.Text = "Calcul &dose carbo"
        Me.bDoseCarbo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(269, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Surface (m²)"
        '
        'tSC
        '
        Me.tSC.Enabled = False
        Me.tSC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSC.Location = New System.Drawing.Point(407, 156)
        Me.tSC.Name = "tSC"
        Me.tSC.Size = New System.Drawing.Size(100, 23)
        Me.tSC.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(269, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Clairance (ml/min)"
        '
        'tClair
        '
        Me.tClair.Enabled = False
        Me.tClair.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tClair.Location = New System.Drawing.Point(407, 185)
        Me.tClair.Name = "tClair"
        Me.tClair.Size = New System.Drawing.Size(100, 23)
        Me.tClair.TabIndex = 14
        '
        'bClairance
        '
        Me.bClairance.Location = New System.Drawing.Point(15, 185)
        Me.bClairance.Name = "bClairance"
        Me.bClairance.Size = New System.Drawing.Size(132, 23)
        Me.bClairance.TabIndex = 18
        Me.bClairance.Text = "Calcul &clairance"
        Me.bClairance.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Calcul &surface corporelle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tTaille
        '
        Me.tTaille.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTaille.Location = New System.Drawing.Point(93, 70)
        Me.tTaille.Mask = "#.##"
        Me.tTaille.Name = "tTaille"
        Me.tTaille.Size = New System.Drawing.Size(100, 23)
        Me.tTaille.TabIndex = 2
        Me.tTaille.Text = "000"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.r7)
        Me.GroupBox2.Controls.Add(Me.r5)
        Me.GroupBox2.Controls.Add(Me.r8)
        Me.GroupBox2.Controls.Add(Me.r6)
        Me.GroupBox2.Controls.Add(Me.r4)
        Me.GroupBox2.Location = New System.Drawing.Point(358, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(149, 140)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "AUC (mg/ml/min)"
        '
        'r8
        '
        Me.r8.AutoSize = True
        Me.r8.Location = New System.Drawing.Point(22, 117)
        Me.r8.Name = "r8"
        Me.r8.Size = New System.Drawing.Size(31, 17)
        Me.r8.TabIndex = 2
        Me.r8.Text = "8"
        Me.r8.UseVisualStyleBackColor = True
        '
        'r6
        '
        Me.r6.AutoSize = True
        Me.r6.Location = New System.Drawing.Point(22, 70)
        Me.r6.Name = "r6"
        Me.r6.Size = New System.Drawing.Size(31, 17)
        Me.r6.TabIndex = 1
        Me.r6.Text = "6"
        Me.r6.UseVisualStyleBackColor = True
        '
        'r4
        '
        Me.r4.AutoSize = True
        Me.r4.Checked = True
        Me.r4.Location = New System.Drawing.Point(22, 24)
        Me.r4.Name = "r4"
        Me.r4.Size = New System.Drawing.Size(34, 17)
        Me.r4.TabIndex = 0
        Me.r4.TabStop = True
        Me.r4.Text = "4 "
        Me.r4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(269, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Dose carbo (mg)"
        '
        'tDoseTotale
        '
        Me.tDoseTotale.Enabled = False
        Me.tDoseTotale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDoseTotale.Location = New System.Drawing.Point(407, 242)
        Me.tDoseTotale.Name = "tDoseTotale"
        Me.tDoseTotale.Size = New System.Drawing.Size(100, 23)
        Me.tDoseTotale.TabIndex = 21
        '
        'r5
        '
        Me.r5.AutoSize = True
        Me.r5.Location = New System.Drawing.Point(22, 47)
        Me.r5.Name = "r5"
        Me.r5.Size = New System.Drawing.Size(31, 17)
        Me.r5.TabIndex = 3
        Me.r5.Text = "5"
        Me.r5.UseVisualStyleBackColor = True
        '
        'r7
        '
        Me.r7.AutoSize = True
        Me.r7.Location = New System.Drawing.Point(22, 92)
        Me.r7.Name = "r7"
        Me.r7.Size = New System.Drawing.Size(31, 17)
        Me.r7.TabIndex = 4
        Me.r7.Text = "7"
        Me.r7.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 280)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tDoseTotale)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tTaille)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bClairance)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tClair)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tSC)
        Me.Controls.Add(Me.bDoseCarbo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tCreat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tPoids)
        Me.Controls.Add(Me.tAge)
        Me.Name = "MainForm"
        Me.Text = "Oncalc 2.0 (Dr. M.Z. Soufi)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tAge As System.Windows.Forms.TextBox
    Friend WithEvents tPoids As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rHomme As System.Windows.Forms.RadioButton
    Friend WithEvents rFemme As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tCreat As System.Windows.Forms.TextBox
    Friend WithEvents bDoseCarbo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tSC As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tClair As System.Windows.Forms.TextBox
    Friend WithEvents bClairance As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tTaille As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents r8 As System.Windows.Forms.RadioButton
    Friend WithEvents r6 As System.Windows.Forms.RadioButton
    Friend WithEvents r4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tDoseTotale As System.Windows.Forms.TextBox
    Friend WithEvents r7 As System.Windows.Forms.RadioButton
    Friend WithEvents r5 As System.Windows.Forms.RadioButton

End Class
