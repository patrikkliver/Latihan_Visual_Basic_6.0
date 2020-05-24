<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Admin
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_IdUser = New System.Windows.Forms.TextBox()
        Me.TB_Nama = New System.Windows.Forms.TextBox()
        Me.TB_Password = New System.Windows.Forms.TextBox()
        Me.CB_RoleId = New System.Windows.Forms.ComboBox()
        Me.DG_AllUser = New System.Windows.Forms.DataGridView()
        Me.BTN_Simpan = New System.Windows.Forms.Button()
        Me.BTN_Update = New System.Windows.Forms.Button()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        CType(Me.DG_AllUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Role Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama"
        '
        'TB_IdUser
        '
        Me.TB_IdUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_IdUser.Location = New System.Drawing.Point(108, 51)
        Me.TB_IdUser.Name = "TB_IdUser"
        Me.TB_IdUser.Size = New System.Drawing.Size(181, 26)
        Me.TB_IdUser.TabIndex = 4
        '
        'TB_Nama
        '
        Me.TB_Nama.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Nama.Location = New System.Drawing.Point(108, 94)
        Me.TB_Nama.Name = "TB_Nama"
        Me.TB_Nama.Size = New System.Drawing.Size(181, 26)
        Me.TB_Nama.TabIndex = 5
        '
        'TB_Password
        '
        Me.TB_Password.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Password.Location = New System.Drawing.Point(108, 137)
        Me.TB_Password.Name = "TB_Password"
        Me.TB_Password.Size = New System.Drawing.Size(181, 26)
        Me.TB_Password.TabIndex = 6
        '
        'CB_RoleId
        '
        Me.CB_RoleId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_RoleId.FormattingEnabled = True
        Me.CB_RoleId.Location = New System.Drawing.Point(108, 180)
        Me.CB_RoleId.Name = "CB_RoleId"
        Me.CB_RoleId.Size = New System.Drawing.Size(181, 27)
        Me.CB_RoleId.TabIndex = 7
        '
        'DG_AllUser
        '
        Me.DG_AllUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_AllUser.Location = New System.Drawing.Point(25, 304)
        Me.DG_AllUser.Name = "DG_AllUser"
        Me.DG_AllUser.Size = New System.Drawing.Size(747, 238)
        Me.DG_AllUser.TabIndex = 8
        '
        'BTN_Simpan
        '
        Me.BTN_Simpan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Simpan.Location = New System.Drawing.Point(25, 240)
        Me.BTN_Simpan.Name = "BTN_Simpan"
        Me.BTN_Simpan.Size = New System.Drawing.Size(68, 28)
        Me.BTN_Simpan.TabIndex = 9
        Me.BTN_Simpan.Text = "Simpan"
        Me.BTN_Simpan.UseVisualStyleBackColor = True
        '
        'BTN_Update
        '
        Me.BTN_Update.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Update.Location = New System.Drawing.Point(123, 240)
        Me.BTN_Update.Name = "BTN_Update"
        Me.BTN_Update.Size = New System.Drawing.Size(68, 28)
        Me.BTN_Update.TabIndex = 10
        Me.BTN_Update.Text = "Ubah"
        Me.BTN_Update.UseVisualStyleBackColor = True
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Delete.Location = New System.Drawing.Point(221, 240)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(68, 28)
        Me.BTN_Delete.TabIndex = 11
        Me.BTN_Delete.Text = "Hapus"
        Me.BTN_Delete.UseVisualStyleBackColor = True
        '
        'Form_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 569)
        Me.Controls.Add(Me.BTN_Delete)
        Me.Controls.Add(Me.BTN_Update)
        Me.Controls.Add(Me.BTN_Simpan)
        Me.Controls.Add(Me.DG_AllUser)
        Me.Controls.Add(Me.CB_RoleId)
        Me.Controls.Add(Me.TB_Password)
        Me.Controls.Add(Me.TB_Nama)
        Me.Controls.Add(Me.TB_IdUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Admin"
        CType(Me.DG_AllUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_IdUser As TextBox
    Friend WithEvents TB_Nama As TextBox
    Friend WithEvents TB_Password As TextBox
    Friend WithEvents CB_RoleId As ComboBox
    Friend WithEvents DG_AllUser As DataGridView
    Friend WithEvents BTN_Simpan As Button
    Friend WithEvents BTN_Update As Button
    Friend WithEvents BTN_Delete As Button
End Class
