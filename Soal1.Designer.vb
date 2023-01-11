<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Soal1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtxtSoal = New System.Windows.Forms.RichTextBox()
        Me.txtJlh = New System.Windows.Forms.TextBox()
        Me.lblJlh = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPAM3 = New System.Windows.Forms.TextBox()
        Me.lblPAM3 = New System.Windows.Forms.Label()
        Me.txtPAM2 = New System.Windows.Forms.TextBox()
        Me.lblPAM2 = New System.Windows.Forms.Label()
        Me.txtPAM1 = New System.Windows.Forms.TextBox()
        Me.lblPAM1 = New System.Windows.Forms.Label()
        Me.txtPM3 = New System.Windows.Forms.TextBox()
        Me.lblPM3 = New System.Windows.Forms.Label()
        Me.txtPM2 = New System.Windows.Forms.TextBox()
        Me.lblPM2 = New System.Windows.Forms.Label()
        Me.txtPM1 = New System.Windows.Forms.TextBox()
        Me.lblPM1 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtHasilA = New System.Windows.Forms.TextBox()
        Me.lblHasil = New System.Windows.Forms.Label()
        Me.txtHasilB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rtxtSoal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 481)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contoh Soal 1"
        '
        'rtxtSoal
        '
        Me.rtxtSoal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtSoal.Location = New System.Drawing.Point(6, 19)
        Me.rtxtSoal.Name = "rtxtSoal"
        Me.rtxtSoal.ReadOnly = True
        Me.rtxtSoal.Size = New System.Drawing.Size(472, 456)
        Me.rtxtSoal.TabIndex = 0
        Me.rtxtSoal.Text = ""
        '
        'txtJlh
        '
        Me.txtJlh.Location = New System.Drawing.Point(9, 32)
        Me.txtJlh.MaxLength = 10
        Me.txtJlh.Name = "txtJlh"
        Me.txtJlh.Size = New System.Drawing.Size(185, 20)
        Me.txtJlh.TabIndex = 1
        Me.txtJlh.Text = "75"
        '
        'lblJlh
        '
        Me.lblJlh.AutoSize = True
        Me.lblJlh.Location = New System.Drawing.Point(6, 16)
        Me.lblJlh.Name = "lblJlh"
        Me.lblJlh.Size = New System.Drawing.Size(102, 13)
        Me.lblJlh.TabIndex = 2
        Me.lblJlh.Text = "Jumlah Mahasiswa :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPAM3)
        Me.GroupBox2.Controls.Add(Me.lblPAM3)
        Me.GroupBox2.Controls.Add(Me.txtPAM2)
        Me.GroupBox2.Controls.Add(Me.lblPAM2)
        Me.GroupBox2.Controls.Add(Me.txtPAM1)
        Me.GroupBox2.Controls.Add(Me.lblPAM1)
        Me.GroupBox2.Controls.Add(Me.txtPM3)
        Me.GroupBox2.Controls.Add(Me.lblPM3)
        Me.GroupBox2.Controls.Add(Me.txtPM2)
        Me.GroupBox2.Controls.Add(Me.lblPM2)
        Me.GroupBox2.Controls.Add(Me.txtPM1)
        Me.GroupBox2.Controls.Add(Me.lblPM1)
        Me.GroupBox2.Controls.Add(Me.lblJlh)
        Me.GroupBox2.Controls.Add(Me.txtJlh)
        Me.GroupBox2.Location = New System.Drawing.Point(502, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(431, 207)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Variabel"
        '
        'txtPAM3
        '
        Me.txtPAM3.Location = New System.Drawing.Point(240, 174)
        Me.txtPAM3.MaxLength = 10
        Me.txtPAM3.Name = "txtPAM3"
        Me.txtPAM3.Size = New System.Drawing.Size(185, 20)
        Me.txtPAM3.TabIndex = 14
        Me.txtPAM3.Text = "5/10"
        '
        'lblPAM3
        '
        Me.lblPAM3.AutoSize = True
        Me.lblPAM3.Location = New System.Drawing.Point(237, 158)
        Me.lblPAM3.Name = "lblPAM3"
        Me.lblPAM3.Size = New System.Drawing.Size(179, 13)
        Me.lblPAM3.TabIndex = 13
        Me.lblPAM3.Text = "Peluang Mahasiwa 3 Nilai A P(A|M3)"
        '
        'txtPAM2
        '
        Me.txtPAM2.Location = New System.Drawing.Point(240, 135)
        Me.txtPAM2.MaxLength = 10
        Me.txtPAM2.Name = "txtPAM2"
        Me.txtPAM2.Size = New System.Drawing.Size(185, 20)
        Me.txtPAM2.TabIndex = 12
        Me.txtPAM2.Text = "8/15"
        '
        'lblPAM2
        '
        Me.lblPAM2.AutoSize = True
        Me.lblPAM2.Location = New System.Drawing.Point(237, 119)
        Me.lblPAM2.Name = "lblPAM2"
        Me.lblPAM2.Size = New System.Drawing.Size(179, 13)
        Me.lblPAM2.TabIndex = 11
        Me.lblPAM2.Text = "Peluang Mahasiwa 2 Nilai A P(A|M2)"
        '
        'txtPAM1
        '
        Me.txtPAM1.Location = New System.Drawing.Point(240, 96)
        Me.txtPAM1.MaxLength = 10
        Me.txtPAM1.Name = "txtPAM1"
        Me.txtPAM1.Size = New System.Drawing.Size(185, 20)
        Me.txtPAM1.TabIndex = 10
        Me.txtPAM1.Text = "10/50"
        '
        'lblPAM1
        '
        Me.lblPAM1.AutoSize = True
        Me.lblPAM1.Location = New System.Drawing.Point(237, 80)
        Me.lblPAM1.Name = "lblPAM1"
        Me.lblPAM1.Size = New System.Drawing.Size(179, 13)
        Me.lblPAM1.TabIndex = 9
        Me.lblPAM1.Text = "Peluang Mahasiwa 1 Nilai A P(A|M1)"
        '
        'txtPM3
        '
        Me.txtPM3.Location = New System.Drawing.Point(9, 174)
        Me.txtPM3.MaxLength = 10
        Me.txtPM3.Name = "txtPM3"
        Me.txtPM3.Size = New System.Drawing.Size(185, 20)
        Me.txtPM3.TabIndex = 8
        Me.txtPM3.Text = "10/75"
        '
        'lblPM3
        '
        Me.lblPM3.AutoSize = True
        Me.lblPM3.Location = New System.Drawing.Point(6, 158)
        Me.lblPM3.Name = "lblPM3"
        Me.lblPM3.Size = New System.Drawing.Size(142, 13)
        Me.lblPM3.TabIndex = 7
        Me.lblPM3.Text = "Peluang Mahasiswa 1 P(M1)"
        '
        'txtPM2
        '
        Me.txtPM2.Location = New System.Drawing.Point(9, 135)
        Me.txtPM2.MaxLength = 10
        Me.txtPM2.Name = "txtPM2"
        Me.txtPM2.Size = New System.Drawing.Size(185, 20)
        Me.txtPM2.TabIndex = 6
        Me.txtPM2.Text = "15/75"
        '
        'lblPM2
        '
        Me.lblPM2.AutoSize = True
        Me.lblPM2.Location = New System.Drawing.Point(6, 119)
        Me.lblPM2.Name = "lblPM2"
        Me.lblPM2.Size = New System.Drawing.Size(142, 13)
        Me.lblPM2.TabIndex = 5
        Me.lblPM2.Text = "Peluang Mahasiswa 2 P(M2)"
        '
        'txtPM1
        '
        Me.txtPM1.Location = New System.Drawing.Point(9, 96)
        Me.txtPM1.MaxLength = 10
        Me.txtPM1.Name = "txtPM1"
        Me.txtPM1.Size = New System.Drawing.Size(185, 20)
        Me.txtPM1.TabIndex = 4
        Me.txtPM1.Text = "50/75"
        '
        'lblPM1
        '
        Me.lblPM1.AutoSize = True
        Me.lblPM1.Location = New System.Drawing.Point(6, 80)
        Me.lblPM1.Name = "lblPM1"
        Me.lblPM1.Size = New System.Drawing.Size(142, 13)
        Me.lblPM1.TabIndex = 3
        Me.lblPM1.Text = "Peluang Mahasiswa 1 P(M1)"
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(502, 237)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(431, 23)
        Me.btnHitung.TabIndex = 4
        Me.btnHitung.TabStop = False
        Me.btnHitung.Text = "Hitung Teorama Bayes"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'txtHasilA
        '
        Me.txtHasilA.Location = New System.Drawing.Point(511, 302)
        Me.txtHasilA.Name = "txtHasilA"
        Me.txtHasilA.ReadOnly = True
        Me.txtHasilA.Size = New System.Drawing.Size(185, 20)
        Me.txtHasilA.TabIndex = 5
        Me.txtHasilA.TabStop = False
        '
        'lblHasil
        '
        Me.lblHasil.AutoSize = True
        Me.lblHasil.Location = New System.Drawing.Point(508, 285)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(46, 13)
        Me.lblHasil.TabIndex = 6
        Me.lblHasil.Text = "Hasil A :"
        '
        'txtHasilB
        '
        Me.txtHasilB.Location = New System.Drawing.Point(742, 301)
        Me.txtHasilB.Name = "txtHasilB"
        Me.txtHasilB.ReadOnly = True
        Me.txtHasilB.Size = New System.Drawing.Size(185, 20)
        Me.txtHasilB.TabIndex = 7
        Me.txtHasilB.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(739, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Hasil B :"
        '
        'Soal1
        '
        Me.AcceptButton = Me.btnHitung
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 505)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHasilB)
        Me.Controls.Add(Me.lblHasil)
        Me.Controls.Add(Me.txtHasilA)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Soal1"
        Me.Text = "Soal 1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rtxtSoal As RichTextBox
    Friend WithEvents txtJlh As TextBox
    Friend WithEvents lblJlh As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPM1 As TextBox
    Friend WithEvents lblPM1 As Label
    Friend WithEvents txtPM3 As TextBox
    Friend WithEvents lblPM3 As Label
    Friend WithEvents txtPM2 As TextBox
    Friend WithEvents lblPM2 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents lblPAM1 As Label
    Friend WithEvents txtPAM1 As TextBox
    Friend WithEvents txtPAM3 As TextBox
    Friend WithEvents lblPAM3 As Label
    Friend WithEvents txtPAM2 As TextBox
    Friend WithEvents lblPAM2 As Label
    Friend WithEvents txtHasilA As TextBox
    Friend WithEvents lblHasil As Label
    Friend WithEvents txtHasilB As TextBox
    Friend WithEvents Label1 As Label
End Class
