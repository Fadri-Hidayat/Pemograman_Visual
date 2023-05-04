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
        Me.rbnAnak = New System.Windows.Forms.RadioButton()
        Me.rbnDewasa = New System.Windows.Forms.RadioButton()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHargaT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih kategori"
        '
        'rbnAnak
        '
        Me.rbnAnak.AutoSize = True
        Me.rbnAnak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnAnak.Location = New System.Drawing.Point(48, 152)
        Me.rbnAnak.Name = "rbnAnak"
        Me.rbnAnak.Size = New System.Drawing.Size(100, 22)
        Me.rbnAnak.TabIndex = 1
        Me.rbnAnak.TabStop = True
        Me.rbnAnak.Text = "Anak-Anak"
        Me.rbnAnak.UseVisualStyleBackColor = True
        '
        'rbnDewasa
        '
        Me.rbnDewasa.AutoSize = True
        Me.rbnDewasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnDewasa.Location = New System.Drawing.Point(48, 191)
        Me.rbnDewasa.Name = "rbnDewasa"
        Me.rbnDewasa.Size = New System.Drawing.Size(83, 22)
        Me.rbnDewasa.TabIndex = 2
        Me.rbnDewasa.TabStop = True
        Me.rbnDewasa.Text = "Dewasa"
        Me.rbnDewasa.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.Yellow
        Me.btnHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(48, 229)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(107, 32)
        Me.btnHitung.TabIndex = 3
        Me.btnHitung.Text = "Submit"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Harga Tiket"
        '
        'txtHargaT
        '
        Me.txtHargaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaT.Location = New System.Drawing.Point(165, 287)
        Me.txtHargaT.Name = "txtHargaT"
        Me.txtHargaT.Size = New System.Drawing.Size(115, 24)
        Me.txtHargaT.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 346)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fadri Hidayat(200511060)TIF20C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(342, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Pemesanan Tiket Wisata Cirebon Waterbom"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(542, 417)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHargaT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.rbnDewasa)
        Me.Controls.Add(Me.rbnAnak)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pemesanan Tiket Wisata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rbnAnak As RadioButton
    Friend WithEvents rbnDewasa As RadioButton
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHargaT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
