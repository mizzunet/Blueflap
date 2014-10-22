<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class messageboxe
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Titre = New System.Windows.Forms.Label()
        Me.Text = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Smiley = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Calibri Light", 17.0!)
        Me.Titre.ForeColor = System.Drawing.Color.White
        Me.Titre.Location = New System.Drawing.Point(103, 22)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(121, 28)
        Me.Titre.TabIndex = 3
        Me.Titre.Text = "Information"
        '
        'Text
        '
        Me.Text.AutoSize = True
        Me.Text.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text.ForeColor = System.Drawing.Color.White
        Me.Text.Location = New System.Drawing.Point(104, 50)
        Me.Text.Name = "Text"
        Me.Text.Size = New System.Drawing.Size(259, 19)
        Me.Text.TabIndex = 4
        Me.Text.Text = "Les statistiques ont été remises à zero"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Blueflap.My.Resources.Resources.white
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(326, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Blueflap.My.Resources.Resources.white
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 125)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(541, 44)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Smiley
        '
        Me.Smiley.AutoSize = True
        Me.Smiley.Font = New System.Drawing.Font("Calibri", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Smiley.ForeColor = System.Drawing.Color.White
        Me.Smiley.Location = New System.Drawing.Point(21, 32)
        Me.Smiley.Name = "Smiley"
        Me.Smiley.Size = New System.Drawing.Size(61, 68)
        Me.Smiley.TabIndex = 5
        Me.Smiley.Text = ":)"
        '
        'messageboxe
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(541, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.Smiley)
        Me.Controls.Add(Me.Text)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(557, 185)
        Me.MinimumSize = New System.Drawing.Size(557, 185)
        Me.Name = "messageboxe"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Titre As System.Windows.Forms.Label
    Friend WithEvents Text As System.Windows.Forms.Label
    Friend WithEvents Smiley As System.Windows.Forms.Label
End Class
