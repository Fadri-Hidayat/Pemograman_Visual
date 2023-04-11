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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtLuasp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVol = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTinggi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGP = New System.Windows.Forms.TextBox()
        Me.txtJari = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(110, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 18)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Fadri Hidayat_200511060"
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(320, 215)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 26)
        Me.btnHitung.TabIndex = 24
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'txtLuasp
        '
        Me.txtLuasp.Location = New System.Drawing.Point(309, 305)
        Me.txtLuasp.Name = "txtLuasp"
        Me.txtLuasp.Size = New System.Drawing.Size(100, 22)
        Me.txtLuasp.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Luas Permukaan"
        '
        'txtVol
        '
        Me.txtVol.Location = New System.Drawing.Point(309, 261)
        Me.txtVol.Name = "txtVol"
        Me.txtVol.Size = New System.Drawing.Size(100, 22)
        Me.txtVol.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(110, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Volume"
        '
        'txtTinggi
        '
        Me.txtTinggi.Location = New System.Drawing.Point(309, 172)
        Me.txtTinggi.Name = "txtTinggi"
        Me.txtTinggi.Size = New System.Drawing.Size(100, 22)
        Me.txtTinggi.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Tinggi"
        '
        'txtGP
        '
        Me.txtGP.Location = New System.Drawing.Point(309, 128)
        Me.txtGP.Name = "txtGP"
        Me.txtGP.Size = New System.Drawing.Size(100, 22)
        Me.txtGP.TabIndex = 17
        '
        'txtJari
        '
        Me.txtJari.Location = New System.Drawing.Point(309, 87)
        Me.txtJari.Name = "txtJari"
        Me.txtJari.Size = New System.Drawing.Size(100, 22)
        Me.txtJari.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Garis Pelukis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(110, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Jari-Jari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "VOLUME DAN LUAR PERMUKAAN KERUCUT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(548, 417)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtLuasp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVol)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTinggi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGP)
        Me.Controls.Add(Me.txtJari)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuasp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVol As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGP As TextBox
    Friend WithEvents txtJari As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
