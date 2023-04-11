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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHsl = New System.Windows.Forms.TextBox()
        Me.txtB2 = New System.Windows.Forms.TextBox()
        Me.txtB1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Fadri Hidayat_200511060"
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(255, 186)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(88, 29)
        Me.btnHitung.TabIndex = 16
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Hasil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Bilangan Kedua"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Bilangan Pertama"
        '
        'txtHsl
        '
        Me.txtHsl.Location = New System.Drawing.Point(249, 237)
        Me.txtHsl.Name = "txtHsl"
        Me.txtHsl.Size = New System.Drawing.Size(100, 22)
        Me.txtHsl.TabIndex = 12
        '
        'txtB2
        '
        Me.txtB2.Location = New System.Drawing.Point(249, 139)
        Me.txtB2.Name = "txtB2"
        Me.txtB2.Size = New System.Drawing.Size(100, 22)
        Me.txtB2.TabIndex = 11
        '
        'txtB1
        '
        Me.txtB1.Location = New System.Drawing.Point(249, 94)
        Me.txtB1.Name = "txtB1"
        Me.txtB1.Size = New System.Drawing.Size(100, 22)
        Me.txtB1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "APLIKASI PENJUMLAHAN DUA BILANGAN"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(512, 340)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHsl)
        Me.Controls.Add(Me.txtB2)
        Me.Controls.Add(Me.txtB1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHsl As TextBox
    Friend WithEvents txtB2 As TextBox
    Friend WithEvents txtB1 As TextBox
    Friend WithEvents Label1 As Label
End Class
