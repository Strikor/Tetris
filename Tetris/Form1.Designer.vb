<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tmrpiece = New System.Windows.Forms.Timer(Me.components)
        Me.tmrfastdown = New System.Windows.Forms.Timer(Me.components)
        Me.btnreplay = New System.Windows.Forms.Button()
        Me.lblnext = New System.Windows.Forms.Label()
        Me.lblcredit = New System.Windows.Forms.Label()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.pcttitle = New System.Windows.Forms.PictureBox()
        Me.pctnext = New System.Windows.Forms.PictureBox()
        Me.lblscore = New System.Windows.Forms.Label()
        CType(Me.pcttitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctnext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrpiece
        '
        Me.tmrpiece.Interval = 500
        '
        'tmrfastdown
        '
        Me.tmrfastdown.Interval = 50
        '
        'btnreplay
        '
        Me.btnreplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreplay.Location = New System.Drawing.Point(266, 83)
        Me.btnreplay.Name = "btnreplay"
        Me.btnreplay.Size = New System.Drawing.Size(203, 56)
        Me.btnreplay.TabIndex = 0
        Me.btnreplay.Text = "Replay"
        Me.btnreplay.UseVisualStyleBackColor = True
        Me.btnreplay.Visible = False
        '
        'lblnext
        '
        Me.lblnext.AutoSize = True
        Me.lblnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnext.ForeColor = System.Drawing.Color.White
        Me.lblnext.Location = New System.Drawing.Point(561, 34)
        Me.lblnext.Name = "lblnext"
        Me.lblnext.Size = New System.Drawing.Size(126, 25)
        Me.lblnext.TabIndex = 2
        Me.lblnext.Text = "Next Piece"
        Me.lblnext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcredit
        '
        Me.lblcredit.AutoSize = True
        Me.lblcredit.BackColor = System.Drawing.Color.Black
        Me.lblcredit.ForeColor = System.Drawing.Color.White
        Me.lblcredit.Location = New System.Drawing.Point(269, 357)
        Me.lblcredit.Name = "lblcredit"
        Me.lblcredit.Size = New System.Drawing.Size(197, 13)
        Me.lblcredit.TabIndex = 4
        Me.lblcredit.Text = "A simple game of tetris by Jason Graham"
        Me.lblcredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnstart
        '
        Me.btnstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.Location = New System.Drawing.Point(202, 488)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(330, 172)
        Me.btnstart.TabIndex = 5
        Me.btnstart.Text = "START GAME"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'pcttitle
        '
        Me.pcttitle.Image = Global.Tetris.My.Resources.Resources.tetris_logo_1027x780
        Me.pcttitle.InitialImage = Global.Tetris.My.Resources.Resources.tetris_logo_1027x780
        Me.pcttitle.Location = New System.Drawing.Point(43, 20)
        Me.pcttitle.Name = "pcttitle"
        Me.pcttitle.Size = New System.Drawing.Size(679, 309)
        Me.pcttitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcttitle.TabIndex = 3
        Me.pcttitle.TabStop = False
        '
        'pctnext
        '
        Me.pctnext.Location = New System.Drawing.Point(545, 62)
        Me.pctnext.Name = "pctnext"
        Me.pctnext.Size = New System.Drawing.Size(158, 120)
        Me.pctnext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctnext.TabIndex = 1
        Me.pctnext.TabStop = False
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.ForeColor = System.Drawing.Color.White
        Me.lblscore.Location = New System.Drawing.Point(555, 217)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(139, 25)
        Me.lblscore.TabIndex = 6
        Me.lblscore.Text = "Score: 0000"
        Me.lblscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(734, 981)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.lblcredit)
        Me.Controls.Add(Me.pcttitle)
        Me.Controls.Add(Me.lblnext)
        Me.Controls.Add(Me.pctnext)
        Me.Controls.Add(Me.btnreplay)
        Me.Controls.Add(Me.lblscore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Tetris"
        CType(Me.pcttitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctnext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrpiece As System.Windows.Forms.Timer
    Friend WithEvents tmrfastdown As System.Windows.Forms.Timer
    Friend WithEvents btnreplay As System.Windows.Forms.Button
    Friend WithEvents pctnext As System.Windows.Forms.PictureBox
    Friend WithEvents lblnext As System.Windows.Forms.Label
    Friend WithEvents pcttitle As System.Windows.Forms.PictureBox
    Friend WithEvents lblcredit As System.Windows.Forms.Label
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents lblscore As System.Windows.Forms.Label

End Class
