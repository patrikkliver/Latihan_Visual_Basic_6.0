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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Nim = New System.Windows.Forms.TextBox()
        Me.TB_Alamat = New System.Windows.Forms.TextBox()
        Me.TB_Nama = New System.Windows.Forms.TextBox()
        Me.TB_Telepon = New System.Windows.Forms.TextBox()
        Me.CB_JenisKelamin = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 368)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(634, 212)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NIM :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jenis Kelamin :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Mahasiswa :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Alamat :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Telepon :"
        '
        'TB_Nim
        '
        Me.TB_Nim.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Nim.Location = New System.Drawing.Point(214, 47)
        Me.TB_Nim.Name = "TB_Nim"
        Me.TB_Nim.Size = New System.Drawing.Size(177, 29)
        Me.TB_Nim.TabIndex = 6
        '
        'TB_Alamat
        '
        Me.TB_Alamat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Alamat.Location = New System.Drawing.Point(214, 152)
        Me.TB_Alamat.Multiline = True
        Me.TB_Alamat.Name = "TB_Alamat"
        Me.TB_Alamat.Size = New System.Drawing.Size(177, 84)
        Me.TB_Alamat.TabIndex = 7
        '
        'TB_Nama
        '
        Me.TB_Nama.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Nama.Location = New System.Drawing.Point(214, 82)
        Me.TB_Nama.Name = "TB_Nama"
        Me.TB_Nama.Size = New System.Drawing.Size(177, 29)
        Me.TB_Nama.TabIndex = 9
        '
        'TB_Telepon
        '
        Me.TB_Telepon.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Telepon.Location = New System.Drawing.Point(214, 242)
        Me.TB_Telepon.Name = "TB_Telepon"
        Me.TB_Telepon.Size = New System.Drawing.Size(177, 29)
        Me.TB_Telepon.TabIndex = 10
        '
        'CB_JenisKelamin
        '
        Me.CB_JenisKelamin.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_JenisKelamin.FormattingEnabled = True
        Me.CB_JenisKelamin.Location = New System.Drawing.Point(214, 117)
        Me.CB_JenisKelamin.Name = "CB_JenisKelamin"
        Me.CB_JenisKelamin.Size = New System.Drawing.Size(177, 29)
        Me.CB_JenisKelamin.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(86, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 32)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Input"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(214, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 32)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(342, 315)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 32)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(470, 315)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 32)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 592)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CB_JenisKelamin)
        Me.Controls.Add(Me.TB_Telepon)
        Me.Controls.Add(Me.TB_Nama)
        Me.Controls.Add(Me.TB_Alamat)
        Me.Controls.Add(Me.TB_Nim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRUD1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_Nim As TextBox
    Friend WithEvents TB_Alamat As TextBox
    Friend WithEvents TB_Nama As TextBox
    Friend WithEvents TB_Telepon As TextBox
    Friend WithEvents CB_JenisKelamin As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
