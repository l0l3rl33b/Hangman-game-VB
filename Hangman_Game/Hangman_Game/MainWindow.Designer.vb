<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
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

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lettertxt = New System.Windows.Forms.TextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.wordtoguesslb = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.ctlb = New System.Windows.Forms.Label()
		Me.falb = New System.Windows.Forms.Label()
		Me.attlb = New System.Windows.Forms.Label()
		Me.trybtn = New System.Windows.Forms.Button()
		Me.finishbtn = New System.Windows.Forms.Button()
		Me.Restartbtn = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(67, 40)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(544, 48)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Welcome to Hangman Game"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(406, 225)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(205, 31)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Insert your letter"
		'
		'lettertxt
		'
		Me.lettertxt.Location = New System.Drawing.Point(472, 259)
		Me.lettertxt.MaxLength = 1
		Me.lettertxt.Name = "lettertxt"
		Me.lettertxt.Size = New System.Drawing.Size(55, 22)
		Me.lettertxt.TabIndex = 2
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(61, 129)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(213, 190)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 3
		Me.PictureBox1.TabStop = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(461, 129)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(95, 31)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "WORD"
		'
		'wordtoguesslb
		'
		Me.wordtoguesslb.AutoSize = True
		Me.wordtoguesslb.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.wordtoguesslb.ForeColor = System.Drawing.Color.Red
		Me.wordtoguesslb.Location = New System.Drawing.Point(472, 169)
		Me.wordtoguesslb.Name = "wordtoguesslb"
		Me.wordtoguesslb.Size = New System.Drawing.Size(0, 31)
		Me.wordtoguesslb.TabIndex = 5
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(55, 378)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(207, 31)
		Me.Label5.TabIndex = 6
		Me.Label5.Text = "correct attempts"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(55, 438)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(195, 31)
		Me.Label6.TabIndex = 7
		Me.Label6.Text = "failed attempts"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(128, 500)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(122, 31)
		Me.Label7.TabIndex = 8
		Me.Label7.Text = "attempts"
		'
		'ctlb
		'
		Me.ctlb.AutoSize = True
		Me.ctlb.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ctlb.Location = New System.Drawing.Point(290, 378)
		Me.ctlb.Name = "ctlb"
		Me.ctlb.Size = New System.Drawing.Size(0, 31)
		Me.ctlb.TabIndex = 9
		'
		'falb
		'
		Me.falb.AutoSize = True
		Me.falb.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.falb.Location = New System.Drawing.Point(290, 438)
		Me.falb.Name = "falb"
		Me.falb.Size = New System.Drawing.Size(0, 31)
		Me.falb.TabIndex = 10
		'
		'attlb
		'
		Me.attlb.AutoSize = True
		Me.attlb.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.attlb.Location = New System.Drawing.Point(290, 500)
		Me.attlb.Name = "attlb"
		Me.attlb.Size = New System.Drawing.Size(0, 31)
		Me.attlb.TabIndex = 11
		'
		'trybtn
		'
		Me.trybtn.Location = New System.Drawing.Point(455, 296)
		Me.trybtn.Name = "trybtn"
		Me.trybtn.Size = New System.Drawing.Size(101, 35)
		Me.trybtn.TabIndex = 12
		Me.trybtn.Text = "Try"
		Me.trybtn.UseVisualStyleBackColor = True
		'
		'finishbtn
		'
		Me.finishbtn.Location = New System.Drawing.Point(600, 528)
		Me.finishbtn.Name = "finishbtn"
		Me.finishbtn.Size = New System.Drawing.Size(101, 35)
		Me.finishbtn.TabIndex = 13
		Me.finishbtn.Text = "Finish game"
		Me.finishbtn.UseVisualStyleBackColor = True
		'
		'Restartbtn
		'
		Me.Restartbtn.Location = New System.Drawing.Point(467, 528)
		Me.Restartbtn.Name = "Restartbtn"
		Me.Restartbtn.Size = New System.Drawing.Size(101, 35)
		Me.Restartbtn.TabIndex = 14
		Me.Restartbtn.Text = "Restart"
		Me.Restartbtn.UseVisualStyleBackColor = True
		'
		'MainWindow
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(713, 575)
		Me.Controls.Add(Me.Restartbtn)
		Me.Controls.Add(Me.finishbtn)
		Me.Controls.Add(Me.trybtn)
		Me.Controls.Add(Me.attlb)
		Me.Controls.Add(Me.falb)
		Me.Controls.Add(Me.ctlb)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.wordtoguesslb)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.lettertxt)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "MainWindow"
		Me.Text = "Hangman Game"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents lettertxt As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents wordtoguesslb As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents ctlb As Label
	Friend WithEvents falb As Label
	Friend WithEvents attlb As Label
	Friend WithEvents trybtn As Button
	Friend WithEvents finishbtn As Button
	Friend WithEvents Restartbtn As Button
End Class
