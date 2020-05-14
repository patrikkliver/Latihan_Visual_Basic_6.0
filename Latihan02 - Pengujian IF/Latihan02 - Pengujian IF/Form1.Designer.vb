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
        Me.TB_Nim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_Alamat = New System.Windows.Forms.TextBox()
        Me.TB_Nama = New System.Windows.Forms.TextBox()
        Me.TB_Nohp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTN_Kosongkan = New System.Windows.Forms.Button()
        Me.BTN_Keluar = New System.Windows.Forms.Button()
        Me.BTN_Cari = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TB_Nim
        '
        Me.TB_Nim.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Nim.Location = New System.Drawing.Point(107, 112)
        Me.TB_Nim.Name = "TB_Nim"
        Me.TB_Nim.Size = New System.Drawing.Size(225, 29)
        Me.TB_Nim.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NIM :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Alamat :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "No HP :"
        '
        'TB_Alamat
        '
        Me.TB_Alamat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Alamat.Location = New System.Drawing.Point(107, 194)
        Me.TB_Alamat.Multiline = True
        Me.TB_Alamat.Name = "TB_Alamat"
        Me.TB_Alamat.Size = New System.Drawing.Size(225, 74)
        Me.TB_Alamat.TabIndex = 5
        '
        'TB_Nama
        '
        Me.TB_Nama.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Nama.Location = New System.Drawing.Point(107, 151)
        Me.TB_Nama.Name = "TB_Nama"
        Me.TB_Nama.Size = New System.Drawing.Size(225, 29)
        Me.TB_Nama.TabIndex = 6
        '
        'TB_Nohp
        '
        Me.TB_Nohp.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Nohp.Location = New System.Drawing.Point(107, 283)
        Me.TB_Nohp.Name = "TB_Nohp"
        Me.TB_Nohp.Size = New System.Drawing.Size(225, 29)
        Me.TB_Nohp.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(271, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "BIODATA MAHASISWA"
        '
        'BTN_Kosongkan
        '
        Me.BTN_Kosongkan.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Kosongkan.Location = New System.Drawing.Point(120, 350)
        Me.BTN_Kosongkan.Name = "BTN_Kosongkan"
        Me.BTN_Kosongkan.Size = New System.Drawing.Size(103, 30)
        Me.BTN_Kosongkan.TabIndex = 9
        Me.BTN_Kosongkan.Text = "Kosongkan"
        Me.BTN_Kosongkan.UseVisualStyleBackColor = True
        '
        'BTN_Keluar
        '
        Me.BTN_Keluar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Keluar.Location = New System.Drawing.Point(229, 350)
        Me.BTN_Keluar.Name = "BTN_Keluar"
        Me.BTN_Keluar.Size = New System.Drawing.Size(103, 30)
        Me.BTN_Keluar.TabIndex = 10
        Me.BTN_Keluar.Text = "Keluar"
        Me.BTN_Keluar.UseVisualStyleBackColor = True
        '
        'BTN_Cari
        '
        Me.BTN_Cari.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Cari.Location = New System.Drawing.Point(26, 350)
        Me.BTN_Cari.Name = "BTN_Cari"
        Me.BTN_Cari.Size = New System.Drawing.Size(88, 30)
        Me.BTN_Cari.TabIndex = 11
        Me.BTN_Cari.Text = "Cari"
        Me.BTN_Cari.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 401)
        Me.Controls.Add(Me.BTN_Cari)
        Me.Controls.Add(Me.BTN_Keluar)
        Me.Controls.Add(Me.BTN_Kosongkan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_Nohp)
        Me.Controls.Add(Me.TB_Nama)
        Me.Controls.Add(Me.TB_Alamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_Nim)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_Nim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_Alamat As TextBox
    Friend WithEvents TB_Nama As TextBox
    Friend WithEvents TB_Nohp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BTN_Kosongkan As Button
    Friend WithEvents BTN_Keluar As Button
    Friend WithEvents BTN_Cari As Button
End Class
