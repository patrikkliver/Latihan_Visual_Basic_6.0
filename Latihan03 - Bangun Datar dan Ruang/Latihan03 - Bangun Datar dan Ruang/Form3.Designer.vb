<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Balok
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
        Me.TB_Panjang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Tinggi = New System.Windows.Forms.TextBox()
        Me.TB_Lebar = New System.Windows.Forms.TextBox()
        Me.TB_Hasil = New System.Windows.Forms.TextBox()
        Me.BTN_Volume = New System.Windows.Forms.Button()
        Me.BTN_Bersihkan = New System.Windows.Forms.Button()
        Me.BTN_Kembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VOLUME BALOK"
        '
        'TB_Panjang
        '
        Me.TB_Panjang.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Panjang.Location = New System.Drawing.Point(117, 75)
        Me.TB_Panjang.Name = "TB_Panjang"
        Me.TB_Panjang.Size = New System.Drawing.Size(174, 29)
        Me.TB_Panjang.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Panjang :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tinggi :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Lebar :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Hasil :"
        '
        'TB_Tinggi
        '
        Me.TB_Tinggi.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Tinggi.Location = New System.Drawing.Point(117, 160)
        Me.TB_Tinggi.Name = "TB_Tinggi"
        Me.TB_Tinggi.Size = New System.Drawing.Size(174, 29)
        Me.TB_Tinggi.TabIndex = 6
        '
        'TB_Lebar
        '
        Me.TB_Lebar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Lebar.Location = New System.Drawing.Point(117, 117)
        Me.TB_Lebar.Name = "TB_Lebar"
        Me.TB_Lebar.Size = New System.Drawing.Size(174, 29)
        Me.TB_Lebar.TabIndex = 7
        '
        'TB_Hasil
        '
        Me.TB_Hasil.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Hasil.Location = New System.Drawing.Point(117, 203)
        Me.TB_Hasil.Name = "TB_Hasil"
        Me.TB_Hasil.Size = New System.Drawing.Size(174, 29)
        Me.TB_Hasil.TabIndex = 8
        '
        'BTN_Volume
        '
        Me.BTN_Volume.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Volume.Location = New System.Drawing.Point(33, 262)
        Me.BTN_Volume.Name = "BTN_Volume"
        Me.BTN_Volume.Size = New System.Drawing.Size(81, 29)
        Me.BTN_Volume.TabIndex = 9
        Me.BTN_Volume.Text = "Volume"
        Me.BTN_Volume.UseVisualStyleBackColor = True
        '
        'BTN_Bersihkan
        '
        Me.BTN_Bersihkan.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Bersihkan.Location = New System.Drawing.Point(120, 262)
        Me.BTN_Bersihkan.Name = "BTN_Bersihkan"
        Me.BTN_Bersihkan.Size = New System.Drawing.Size(168, 29)
        Me.BTN_Bersihkan.TabIndex = 13
        Me.BTN_Bersihkan.Text = "Bersihkan"
        Me.BTN_Bersihkan.UseVisualStyleBackColor = True
        '
        'BTN_Kembali
        '
        Me.BTN_Kembali.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Kembali.Location = New System.Drawing.Point(33, 297)
        Me.BTN_Kembali.Name = "BTN_Kembali"
        Me.BTN_Kembali.Size = New System.Drawing.Size(258, 29)
        Me.BTN_Kembali.TabIndex = 14
        Me.BTN_Kembali.Text = "Kembali"
        Me.BTN_Kembali.UseVisualStyleBackColor = True
        '
        'F_Balok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 343)
        Me.Controls.Add(Me.BTN_Kembali)
        Me.Controls.Add(Me.BTN_Bersihkan)
        Me.Controls.Add(Me.BTN_Volume)
        Me.Controls.Add(Me.TB_Hasil)
        Me.Controls.Add(Me.TB_Lebar)
        Me.Controls.Add(Me.TB_Tinggi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_Panjang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "F_Balok"
        Me.Text = "Balok"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Panjang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_Tinggi As TextBox
    Friend WithEvents TB_Lebar As TextBox
    Friend WithEvents TB_Hasil As TextBox
    Friend WithEvents BTN_Volume As Button
    Friend WithEvents BTN_Bersihkan As Button
    Friend WithEvents BTN_Kembali As Button
End Class
