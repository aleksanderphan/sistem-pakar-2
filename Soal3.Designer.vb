<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Soal3
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
        Me.txtHasilB = New System.Windows.Forms.TextBox()
        Me.lblHasil = New System.Windows.Forms.Label()
        Me.txtHasilA = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtab3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtab2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtab1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtB3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtB2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtB1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(739, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Hasil B :"
        '
        'txtHasilB
        '
        Me.txtHasilB.Location = New System.Drawing.Point(742, 301)
        Me.txtHasilB.Name = "txtHasilB"
        Me.txtHasilB.ReadOnly = True
        Me.txtHasilB.Size = New System.Drawing.Size(185, 20)
        Me.txtHasilB.TabIndex = 21
        Me.txtHasilB.TabStop = False
        '
        'lblHasil
        '
        Me.lblHasil.AutoSize = True
        Me.lblHasil.Location = New System.Drawing.Point(508, 285)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(46, 13)
        Me.lblHasil.TabIndex = 20
        Me.lblHasil.Text = "Hasil A :"
        '
        'txtHasilA
        '
        Me.txtHasilA.Location = New System.Drawing.Point(511, 302)
        Me.txtHasilA.Name = "txtHasilA"
        Me.txtHasilA.ReadOnly = True
        Me.txtHasilA.Size = New System.Drawing.Size(185, 20)
        Me.txtHasilA.TabIndex = 19
        Me.txtHasilA.TabStop = False
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(502, 237)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(431, 23)
        Me.btnHitung.TabIndex = 18
        Me.btnHitung.TabStop = False
        Me.btnHitung.Text = "Hitung Teorama Bayes"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtab3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtab2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtab1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtB3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtB2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtB1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(502, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(431, 207)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Variabel"
        '
        'txtab3
        '
        Me.txtab3.Location = New System.Drawing.Point(221, 149)
        Me.txtab3.Name = "txtab3"
        Me.txtab3.Size = New System.Drawing.Size(137, 20)
        Me.txtab3.TabIndex = 11
        Me.txtab3.Text = "0.08"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Kerusakan Kamar Mandi di Hotel S (AjB3) :"
        '
        'txtab2
        '
        Me.txtab2.Location = New System.Drawing.Point(221, 97)
        Me.txtab2.Name = "txtab2"
        Me.txtab2.Size = New System.Drawing.Size(137, 20)
        Me.txtab2.TabIndex = 9
        Me.txtab2.Text = "0.04"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(218, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Kerusakan Kamar Mandi Hotel B (AjB2) :"
        '
        'txtab1
        '
        Me.txtab1.Location = New System.Drawing.Point(221, 47)
        Me.txtab1.Name = "txtab1"
        Me.txtab1.Size = New System.Drawing.Size(137, 20)
        Me.txtab1.TabIndex = 7
        Me.txtab1.Text = "0.05"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(218, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(207, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kerusakan Kamar Mandi Di Hotel I (AjB1) :"
        '
        'txtB3
        '
        Me.txtB3.Location = New System.Drawing.Point(9, 149)
        Me.txtB3.Name = "txtB3"
        Me.txtB3.Size = New System.Drawing.Size(137, 20)
        Me.txtB3.TabIndex = 5
        Me.txtB3.Text = "0.3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Penempatan di Hotel S (B3) :"
        '
        'txtB2
        '
        Me.txtB2.Location = New System.Drawing.Point(9, 97)
        Me.txtB2.Name = "txtB2"
        Me.txtB2.Size = New System.Drawing.Size(137, 20)
        Me.txtB2.TabIndex = 3
        Me.txtB2.Text = "0.5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Penempatan di Hotel B (B2) :"
        '
        'txtB1
        '
        Me.txtB1.Location = New System.Drawing.Point(9, 47)
        Me.txtB1.Name = "txtB1"
        Me.txtB1.Size = New System.Drawing.Size(137, 20)
        Me.txtB1.TabIndex = 1
        Me.txtB1.Text = "0.2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Penempatan di Hotel I (B1) :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 481)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contoh Soal 3"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TeoramaBayes.My.Resources.Resources.Screenshot_2023_01_10_090326
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(461, 591)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Soal3
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
        Me.Name = "Soal3"
        Me.Text = "Soal3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHasilB As TextBox
    Friend WithEvents lblHasil As Label
    Friend WithEvents txtHasilA As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtB3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtB2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtB1 As TextBox
    Friend WithEvents txtab3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtab2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtab1 As TextBox
    Friend WithEvents Label7 As Label
End Class
