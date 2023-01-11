<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Soal2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHasilW = New System.Windows.Forms.TextBox()
        Me.lblHasil = New System.Windows.Forms.Label()
        Me.txtHasilWO = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtWOT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWOK = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtWK = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(739, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Hasil 2 :"
        '
        'txtHasilW
        '
        Me.txtHasilW.Location = New System.Drawing.Point(742, 301)
        Me.txtHasilW.Name = "txtHasilW"
        Me.txtHasilW.ReadOnly = True
        Me.txtHasilW.Size = New System.Drawing.Size(185, 20)
        Me.txtHasilW.TabIndex = 14
        Me.txtHasilW.TabStop = False
        '
        'lblHasil
        '
        Me.lblHasil.AutoSize = True
        Me.lblHasil.Location = New System.Drawing.Point(508, 285)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(45, 13)
        Me.lblHasil.TabIndex = 13
        Me.lblHasil.Text = "Hasil 1 :"
        '
        'txtHasilWO
        '
        Me.txtHasilWO.Location = New System.Drawing.Point(511, 302)
        Me.txtHasilWO.Name = "txtHasilWO"
        Me.txtHasilWO.ReadOnly = True
        Me.txtHasilWO.Size = New System.Drawing.Size(185, 20)
        Me.txtHasilWO.TabIndex = 12
        Me.txtHasilWO.TabStop = False
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(502, 237)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(431, 23)
        Me.btnHitung.TabIndex = 11
        Me.btnHitung.TabStop = False
        Me.btnHitung.Text = "Hitung Teorama Bayes"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(502, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(431, 207)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Variabel"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtWK)
        Me.GroupBox4.Controls.Add(Me.txtWT)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(220, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(205, 182)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dengan Memperhatikan Penyakit"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtWOT)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtWOK)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(205, 182)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tanpa Memperhatikan Penyakit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cedera Pada Telinga :"
        '
        'txtWOT
        '
        Me.txtWOT.Location = New System.Drawing.Point(6, 102)
        Me.txtWOT.Name = "txtWOT"
        Me.txtWOT.Size = New System.Drawing.Size(193, 20)
        Me.txtWOT.TabIndex = 2
        Me.txtWOT.Text = "0.6"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kerusakan Pada Kartilago :"
        '
        'txtWOK
        '
        Me.txtWOK.Location = New System.Drawing.Point(6, 47)
        Me.txtWOK.Name = "txtWOK"
        Me.txtWOK.Size = New System.Drawing.Size(193, 20)
        Me.txtWOK.TabIndex = 0
        Me.txtWOK.Text = "0.7"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 481)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contoh Soal 2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TeoramaBayes.My.Resources.Resources.Screenshot_2023_01_10_084412
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(445, 578)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cedera Pada Telinga :"
        '
        'txtWT
        '
        Me.txtWT.Location = New System.Drawing.Point(6, 102)
        Me.txtWT.Name = "txtWT"
        Me.txtWT.Size = New System.Drawing.Size(193, 20)
        Me.txtWT.TabIndex = 6
        Me.txtWT.Text = "0.5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Kerusakan Pada Kartilago :"
        '
        'txtWK
        '
        Me.txtWK.Location = New System.Drawing.Point(6, 47)
        Me.txtWK.Name = "txtWK"
        Me.txtWK.Size = New System.Drawing.Size(193, 20)
        Me.txtWK.TabIndex = 4
        Me.txtWK.Text = "0.5"
        '
        'Soal2
        '
        Me.AcceptButton = Me.btnHitung
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 505)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHasilW)
        Me.Controls.Add(Me.lblHasil)
        Me.Controls.Add(Me.txtHasilWO)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Soal2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Soal 2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtHasilW As TextBox
    Friend WithEvents lblHasil As Label
    Friend WithEvents txtHasilWO As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtWOT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWOK As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWK As TextBox
    Friend WithEvents txtWT As TextBox
    Friend WithEvents Label5 As Label
End Class
