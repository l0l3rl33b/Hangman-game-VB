<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class starting_screen
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(starting_screen))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.startbtn = New System.Windows.Forms.Button()
		Me.Leavebtn = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Red
		Me.Label1.Location = New System.Drawing.Point(185, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(313, 38)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "The hangman game"
		'
		'startbtn
		'
		Me.startbtn.Location = New System.Drawing.Point(291, 171)
		Me.startbtn.Name = "startbtn"
		Me.startbtn.Size = New System.Drawing.Size(113, 36)
		Me.startbtn.TabIndex = 1
		Me.startbtn.Text = "Start game"
		Me.startbtn.UseVisualStyleBackColor = True
		'
		'Leavebtn
		'
		Me.Leavebtn.Location = New System.Drawing.Point(291, 273)
		Me.Leavebtn.Name = "Leavebtn"
		Me.Leavebtn.Size = New System.Drawing.Size(113, 36)
		Me.Leavebtn.TabIndex = 2
		Me.Leavebtn.Text = "Leave"
		Me.Leavebtn.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Red
		Me.Label2.Location = New System.Drawing.Point(464, 537)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(223, 18)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Made by: Yesid David Padilla C"
		'
		'starting_screen
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(686, 555)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Leavebtn)
		Me.Controls.Add(Me.startbtn)
		Me.Controls.Add(Me.Label1)
		Me.DoubleBuffered = True
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "starting_screen"
		Me.Text = "starting_screen"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents startbtn As Button
	Friend WithEvents Leavebtn As Button
	Friend WithEvents Label2 As Label
End Class
