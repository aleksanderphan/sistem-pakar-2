<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Master
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Master))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSoal1 = New System.Windows.Forms.ToolStripButton()
        Me.btnSoal2 = New System.Windows.Forms.ToolStripButton()
        Me.btnSoal3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnSP = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSoal1, Me.btnSoal2, Me.btnSoal3, Me.ToolStripSeparator4, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSoal1
        '
        Me.btnSoal1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSoal1.Image = CType(resources.GetObject("btnSoal1.Image"), System.Drawing.Image)
        Me.btnSoal1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSoal1.Name = "btnSoal1"
        Me.btnSoal1.Size = New System.Drawing.Size(42, 22)
        Me.btnSoal1.Text = "Soal 1"
        '
        'btnSoal2
        '
        Me.btnSoal2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSoal2.Image = CType(resources.GetObject("btnSoal2.Image"), System.Drawing.Image)
        Me.btnSoal2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSoal2.Name = "btnSoal2"
        Me.btnSoal2.Size = New System.Drawing.Size(42, 22)
        Me.btnSoal2.Text = "Soal 2"
        '
        'btnSoal3
        '
        Me.btnSoal3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSoal3.Image = CType(resources.GetObject("btnSoal3.Image"), System.Drawing.Image)
        Me.btnSoal3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSoal3.Name = "btnSoal3"
        Me.btnSoal3.Size = New System.Drawing.Size(42, 22)
        Me.btnSoal3.Text = "Soal 3"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(44, 22)
        Me.btnExit.Text = "Keluar"
        '
        'btnSP
        '
        Me.btnSP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSP.Location = New System.Drawing.Point(683, 0)
        Me.btnSP.Name = "btnSP"
        Me.btnSP.Size = New System.Drawing.Size(117, 25)
        Me.btnSP.TabIndex = 3
        Me.btnSP.Text = "Sistem Pakar"
        Me.btnSP.UseVisualStyleBackColor = True
        Me.btnSP.Visible = False
        '
        'Timer1
        '
        '
        'Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSP)
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teorama Bayes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSoal1 As ToolStripButton
    Friend WithEvents btnSoal2 As ToolStripButton
    Friend WithEvents btnSoal3 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents btnSP As Button
    Friend WithEvents Timer1 As Timer
End Class
