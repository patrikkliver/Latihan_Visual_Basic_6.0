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
        Me.TB_Angka1 = New System.Windows.Forms.TextBox()
        Me.TB_Angka2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Hasil = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_Tambah = New System.Windows.Forms.Button()
        Me.BTN_Kurang = New System.Windows.Forms.Button()
        Me.BTN_Kali = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_Bagi = New System.Windows.Forms.Button()
        Me.BTN_Kosongkan = New System.Windows.Forms.Button()
        Me.BTN_Keluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angka 1"
        '
        'TB_Angka1
        '
        Me.TB_Angka1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Angka1.Location = New System.Drawing.Point(12, 54)
        Me.TB_Angka1.Name = "TB_Angka1"
        Me.TB_Angka1.Size = New System.Drawing.Size(254, 29)
        Me.TB_Angka1.TabIndex = 1
        Me.TB_Angka1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_Angka2
        '
        Me.TB_Angka2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Angka2.Location = New System.Drawing.Point(12, 121)
        Me.TB_Angka2.Name = "TB_Angka2"
        Me.TB_Angka2.Size = New System.Drawing.Size(254, 29)
        Me.TB_Angka2.TabIndex = 3
        Me.TB_Angka2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Angka 2"
        '
        'TB_Hasil
        '
        Me.TB_Hasil.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Hasil.Location = New System.Drawing.Point(12, 187)
        Me.TB_Hasil.Multiline = True
        Me.TB_Hasil.Name = "TB_Hasil"
        Me.TB_Hasil.Size = New System.Drawing.Size(254, 64)
        Me.TB_Hasil.TabIndex = 5
        Me.TB_Hasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hasil"
        '
        'BTN_Tambah
        '
        Me.BTN_Tambah.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Tambah.Location = New System.Drawing.Point(12, 278)
        Me.BTN_Tambah.Name = "BTN_Tambah"
        Me.BTN_Tambah.Size = New System.Drawing.Size(59, 43)
        Me.BTN_Tambah.TabIndex = 6
        Me.BTN_Tambah.Text = "+"
        Me.BTN_Tambah.UseVisualStyleBackColor = True
        '
        'BTN_Kurang
        '
        Me.BTN_Kurang.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Kurang.Location = New System.Drawing.Point(77, 278)
        Me.BTN_Kurang.Name = "BTN_Kurang"
        Me.BTN_Kurang.Size = New System.Drawing.Size(59, 43)
        Me.BTN_Kurang.TabIndex = 7
        Me.BTN_Kurang.Text = "-"
        Me.BTN_Kurang.UseVisualStyleBackColor = True
        '
        'BTN_Kali
        '
        Me.BTN_Kali.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Kali.Location = New System.Drawing.Point(142, 278)
        Me.BTN_Kali.Name = "BTN_Kali"
        Me.BTN_Kali.Size = New System.Drawing.Size(59, 43)
        Me.BTN_Kali.TabIndex = 8
        Me.BTN_Kali.Text = "*"
        Me.BTN_Kali.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hasil"
        '
        'BTN_Bagi
        '
        Me.BTN_Bagi.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Bagi.Location = New System.Drawing.Point(207, 278)
        Me.BTN_Bagi.Name = "BTN_Bagi"
        Me.BTN_Bagi.Size = New System.Drawing.Size(59, 43)
        Me.BTN_Bagi.TabIndex = 9
        Me.BTN_Bagi.Text = "/"
        Me.BTN_Bagi.UseVisualStyleBackColor = True
        '
        'BTN_Kosongkan
        '
        Me.BTN_Kosongkan.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Kosongkan.Location = New System.Drawing.Point(12, 339)
        Me.BTN_Kosongkan.Name = "BTN_Kosongkan"
        Me.BTN_Kosongkan.Size = New System.Drawing.Size(254, 48)
        Me.BTN_Kosongkan.TabIndex = 10
        Me.BTN_Kosongkan.Text = "Kosongkan"
        Me.BTN_Kosongkan.UseVisualStyleBackColor = True
        '
        'BTN_Keluar
        '
        Me.BTN_Keluar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Keluar.Location = New System.Drawing.Point(12, 404)
        Me.BTN_Keluar.Name = "BTN_Keluar"
        Me.BTN_Keluar.Size = New System.Drawing.Size(254, 48)
        Me.BTN_Keluar.TabIndex = 11
        Me.BTN_Keluar.Text = "Keluar"
        Me.BTN_Keluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 484)
        Me.Controls.Add(Me.BTN_Keluar)
        Me.Controls.Add(Me.BTN_Kosongkan)
        Me.Controls.Add(Me.BTN_Bagi)
        Me.Controls.Add(Me.BTN_Kali)
        Me.Controls.Add(Me.BTN_Kurang)
        Me.Controls.Add(Me.BTN_Tambah)
        Me.Controls.Add(Me.TB_Hasil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_Angka2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_Angka1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Angka1 As TextBox
    Friend WithEvents TB_Angka2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Hasil As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_Tambah As Button
    Friend WithEvents BTN_Kurang As Button
    Friend WithEvents BTN_Kali As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_Bagi As Button
    Friend WithEvents BTN_Kosongkan As Button
    Friend WithEvents BTN_Keluar As Button
End Class
