<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Persegi
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
        Me.BTN_Keliling = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Sisi1 = New System.Windows.Forms.TextBox()
        Me.TB_Sisi2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Hasil = New System.Windows.Forms.TextBox()
        Me.BTN_Luas = New System.Windows.Forms.Button()
        Me.BTN_Kosongkan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_Kembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_Keliling
        '
        Me.BTN_Keliling.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Keliling.Location = New System.Drawing.Point(37, 238)
        Me.BTN_Keliling.Name = "BTN_Keliling"
        Me.BTN_Keliling.Size = New System.Drawing.Size(87, 30)
        Me.BTN_Keliling.TabIndex = 0
        Me.BTN_Keliling.Text = "Keliling"
        Me.BTN_Keliling.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sisi 1 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sisi 2 :"
        '
        'TB_Sisi1
        '
        Me.TB_Sisi1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Sisi1.Location = New System.Drawing.Point(107, 103)
        Me.TB_Sisi1.Name = "TB_Sisi1"
        Me.TB_Sisi1.Size = New System.Drawing.Size(225, 29)
        Me.TB_Sisi1.TabIndex = 3
        '
        'TB_Sisi2
        '
        Me.TB_Sisi2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Sisi2.Location = New System.Drawing.Point(107, 144)
        Me.TB_Sisi2.Name = "TB_Sisi2"
        Me.TB_Sisi2.Size = New System.Drawing.Size(225, 29)
        Me.TB_Sisi2.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Hasil :"
        '
        'TB_Hasil
        '
        Me.TB_Hasil.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Hasil.Location = New System.Drawing.Point(107, 189)
        Me.TB_Hasil.Name = "TB_Hasil"
        Me.TB_Hasil.Size = New System.Drawing.Size(225, 29)
        Me.TB_Hasil.TabIndex = 6
        '
        'BTN_Luas
        '
        Me.BTN_Luas.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Luas.Location = New System.Drawing.Point(130, 238)
        Me.BTN_Luas.Name = "BTN_Luas"
        Me.BTN_Luas.Size = New System.Drawing.Size(87, 30)
        Me.BTN_Luas.TabIndex = 7
        Me.BTN_Luas.Text = "Luas"
        Me.BTN_Luas.UseVisualStyleBackColor = True
        '
        'BTN_Kosongkan
        '
        Me.BTN_Kosongkan.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Kosongkan.Location = New System.Drawing.Point(224, 238)
        Me.BTN_Kosongkan.Name = "BTN_Kosongkan"
        Me.BTN_Kosongkan.Size = New System.Drawing.Size(108, 30)
        Me.BTN_Kosongkan.TabIndex = 8
        Me.BTN_Kosongkan.Text = "Kosongkan"
        Me.BTN_Kosongkan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "PERSEGI"
        '
        'BTN_Kembali
        '
        Me.BTN_Kembali.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Kembali.Location = New System.Drawing.Point(37, 290)
        Me.BTN_Kembali.Name = "BTN_Kembali"
        Me.BTN_Kembali.Size = New System.Drawing.Size(295, 30)
        Me.BTN_Kembali.TabIndex = 10
        Me.BTN_Kembali.Text = "Kembali"
        Me.BTN_Kembali.UseVisualStyleBackColor = True
        '
        'F_Persegi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 362)
        Me.Controls.Add(Me.BTN_Kembali)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTN_Kosongkan)
        Me.Controls.Add(Me.BTN_Luas)
        Me.Controls.Add(Me.TB_Hasil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_Sisi2)
        Me.Controls.Add(Me.TB_Sisi1)
        Me.Controls.Add(Me.BTN_Keliling)
        Me.Name = "F_Persegi"
        Me.Text = "Persegi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Keliling As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Sisi1 As TextBox
    Friend WithEvents TB_Sisi2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_Hasil As TextBox
    Friend WithEvents BTN_Luas As Button
    Friend WithEvents BTN_Kosongkan As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_Kembali As Button
End Class
