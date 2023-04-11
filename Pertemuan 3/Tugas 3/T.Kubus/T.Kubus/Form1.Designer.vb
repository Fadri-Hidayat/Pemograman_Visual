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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtLuasP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVolum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSisi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(91, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(222, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Fadri Hidayat_200511060"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(51, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(374, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "VOLUME DAN LUAS PERMUKAAN KUBUS"
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(248, 158)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(91, 29)
        Me.btnHitung.TabIndex = 15
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'txtLuasP
        '
        Me.txtLuasP.Location = New System.Drawing.Point(248, 243)
        Me.txtLuasP.Name = "txtLuasP"
        Me.txtLuasP.Size = New System.Drawing.Size(100, 22)
        Me.txtLuasP.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(92, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Luas Permukaan"
        '
        'txtVolum
        '
        Me.txtVolum.Location = New System.Drawing.Point(248, 206)
        Me.txtVolum.Name = "txtVolum"
        Me.txtVolum.Size = New System.Drawing.Size(100, 22)
        Me.txtVolum.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Volume"
        '
        'txtSisi
        '
        Me.txtSisi.Location = New System.Drawing.Point(248, 104)
        Me.txtSisi.Name = "txtSisi"
        Me.txtSisi.Size = New System.Drawing.Size(100, 22)
        Me.txtSisi.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sisi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(476, 362)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtLuasP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtVolum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSisi)
        Me.Controls.Add(Me.Label6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuasP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVolum As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSisi As TextBox
    Friend WithEvents Label6 As Label
End Class
