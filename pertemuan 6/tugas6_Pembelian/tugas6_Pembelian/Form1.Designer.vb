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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHargaB = New System.Windows.Forms.TextBox()
        Me.txtJumlahB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.ckMember = New System.Windows.Forms.CheckBox()
        Me.txtTotalB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Toko Peci Al-Hidayah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fadri Hidayat(200511060)TIF20C"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Barang"
        '
        'txtHargaB
        '
        Me.txtHargaB.Location = New System.Drawing.Point(209, 105)
        Me.txtHargaB.Name = "txtHargaB"
        Me.txtHargaB.Size = New System.Drawing.Size(120, 22)
        Me.txtHargaB.TabIndex = 3
        '
        'txtJumlahB
        '
        Me.txtJumlahB.Location = New System.Drawing.Point(209, 149)
        Me.txtJumlahB.Name = "txtJumlahB"
        Me.txtJumlahB.Size = New System.Drawing.Size(120, 22)
        Me.txtJumlahB.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jumlah Barang"
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.Yellow
        Me.btnHitung.Location = New System.Drawing.Point(224, 209)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(85, 29)
        Me.btnHitung.TabIndex = 6
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'ckMember
        '
        Me.ckMember.AutoSize = True
        Me.ckMember.Location = New System.Drawing.Point(212, 175)
        Me.ckMember.Name = "ckMember"
        Me.ckMember.Size = New System.Drawing.Size(81, 21)
        Me.ckMember.TabIndex = 7
        Me.ckMember.Text = "member"
        Me.ckMember.UseVisualStyleBackColor = True
        '
        'txtTotalB
        '
        Me.txtTotalB.Location = New System.Drawing.Point(209, 256)
        Me.txtTotalB.Name = "txtTotalB"
        Me.txtTotalB.Size = New System.Drawing.Size(120, 22)
        Me.txtTotalB.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Barang"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(551, 361)
        Me.Controls.Add(Me.txtTotalB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ckMember)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtJumlahB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHargaB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Aplikas Total Pembelian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHargaB As TextBox
    Friend WithEvents txtJumlahB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents ckMember As CheckBox
    Friend WithEvents txtTotalB As TextBox
    Friend WithEvents Label5 As Label
End Class
