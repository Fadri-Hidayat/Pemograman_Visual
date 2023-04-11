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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtP = New System.Windows.Forms.TextBox()
        Me.txtL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVolum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLuasP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VOLUME DAN LUAS PERMUKAAN BALOK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Panjang"
        '
        'txtP
        '
        Me.txtP.Location = New System.Drawing.Point(259, 79)
        Me.txtP.Name = "txtP"
        Me.txtP.Size = New System.Drawing.Size(100, 22)
        Me.txtP.TabIndex = 2
        '
        'txtL
        '
        Me.txtL.Location = New System.Drawing.Point(259, 119)
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(100, 22)
        Me.txtL.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Lebar"
        '
        'txtT
        '
        Me.txtT.Location = New System.Drawing.Point(259, 161)
        Me.txtT.Name = "txtT"
        Me.txtT.Size = New System.Drawing.Size(100, 22)
        Me.txtT.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tinggi"
        '
        'txtVolum
        '
        Me.txtVolum.Location = New System.Drawing.Point(259, 249)
        Me.txtVolum.Name = "txtVolum"
        Me.txtVolum.Size = New System.Drawing.Size(100, 22)
        Me.txtVolum.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Volume"
        '
        'txtLuasP
        '
        Me.txtLuasP.Location = New System.Drawing.Point(259, 296)
        Me.txtLuasP.Name = "txtLuasP"
        Me.txtLuasP.Size = New System.Drawing.Size(100, 22)
        Me.txtLuasP.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Luas Permukaan"
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(269, 203)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(77, 26)
        Me.btnHitung.TabIndex = 11
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(73, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(222, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fadri Hidayat_200511060"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(530, 395)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtLuasP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtVolum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtP As TextBox
    Friend WithEvents txtL As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVolum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLuasP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label7 As Label
End Class
