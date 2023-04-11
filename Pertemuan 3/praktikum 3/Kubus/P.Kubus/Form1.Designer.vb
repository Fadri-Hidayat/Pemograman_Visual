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
        Me.txtSisi = New System.Windows.Forms.TextBox()
        Me.txtVolum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLuasP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sisi"
        '
        'txtSisi
        '
        Me.txtSisi.Location = New System.Drawing.Point(238, 81)
        Me.txtSisi.Name = "txtSisi"
        Me.txtSisi.Size = New System.Drawing.Size(100, 22)
        Me.txtSisi.TabIndex = 1
        '
        'txtVolum
        '
        Me.txtVolum.Location = New System.Drawing.Point(238, 183)
        Me.txtVolum.Name = "txtVolum"
        Me.txtVolum.Size = New System.Drawing.Size(100, 22)
        Me.txtVolum.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Volume"
        '
        'txtLuasP
        '
        Me.txtLuasP.Location = New System.Drawing.Point(238, 220)
        Me.txtLuasP.Name = "txtLuasP"
        Me.txtLuasP.Size = New System.Drawing.Size(100, 22)
        Me.txtLuasP.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Luas Permukaan"
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(238, 135)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(91, 29)
        Me.btnHitung.TabIndex = 6
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(374, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "VOLUME DAN LUAS PERMUKAAN KUBUS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(81, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fadri Hidayat_200511060"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(495, 314)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtLuasP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVolum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSisi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSisi As TextBox
    Friend WithEvents txtVolum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLuasP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
