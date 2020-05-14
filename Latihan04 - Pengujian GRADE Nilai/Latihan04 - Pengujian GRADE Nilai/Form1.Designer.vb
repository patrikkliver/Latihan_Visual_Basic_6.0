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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Tugas = New System.Windows.Forms.TextBox()
        Me.TB_Quiz = New System.Windows.Forms.TextBox()
        Me.TB_Uts = New System.Windows.Forms.TextBox()
        Me.TB_Uas = New System.Windows.Forms.TextBox()
        Me.L_Tugas = New System.Windows.Forms.Label()
        Me.L_Uts = New System.Windows.Forms.Label()
        Me.L_Quiz = New System.Windows.Forms.Label()
        Me.L_Uas = New System.Windows.Forms.Label()
        Me.BTN_Proses = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_TotalNilai = New System.Windows.Forms.TextBox()
        Me.TB_GradeNilai = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTN_Bersihkan = New System.Windows.Forms.Button()
        Me.BTN_Keluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PENGUJIAN GRADE NILAI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TUGAS (25%) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "UTS (30%) :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "QUIZ (15%) :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "UAS(30%) :"
        '
        'TB_Tugas
        '
        Me.TB_Tugas.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Tugas.Location = New System.Drawing.Point(168, 32)
        Me.TB_Tugas.Name = "TB_Tugas"
        Me.TB_Tugas.Size = New System.Drawing.Size(122, 29)
        Me.TB_Tugas.TabIndex = 5
        '
        'TB_Quiz
        '
        Me.TB_Quiz.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Quiz.Location = New System.Drawing.Point(168, 72)
        Me.TB_Quiz.Name = "TB_Quiz"
        Me.TB_Quiz.Size = New System.Drawing.Size(122, 29)
        Me.TB_Quiz.TabIndex = 6
        '
        'TB_Uts
        '
        Me.TB_Uts.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Uts.Location = New System.Drawing.Point(168, 110)
        Me.TB_Uts.Name = "TB_Uts"
        Me.TB_Uts.Size = New System.Drawing.Size(122, 29)
        Me.TB_Uts.TabIndex = 7
        '
        'TB_Uas
        '
        Me.TB_Uas.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Uas.Location = New System.Drawing.Point(168, 150)
        Me.TB_Uas.Name = "TB_Uas"
        Me.TB_Uas.Size = New System.Drawing.Size(122, 29)
        Me.TB_Uas.TabIndex = 8
        '
        'L_Tugas
        '
        Me.L_Tugas.AutoSize = True
        Me.L_Tugas.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Tugas.Location = New System.Drawing.Point(304, 35)
        Me.L_Tugas.Name = "L_Tugas"
        Me.L_Tugas.Size = New System.Drawing.Size(16, 21)
        Me.L_Tugas.TabIndex = 9
        Me.L_Tugas.Text = "-"
        '
        'L_Uts
        '
        Me.L_Uts.AutoSize = True
        Me.L_Uts.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Uts.Location = New System.Drawing.Point(304, 113)
        Me.L_Uts.Name = "L_Uts"
        Me.L_Uts.Size = New System.Drawing.Size(16, 21)
        Me.L_Uts.TabIndex = 10
        Me.L_Uts.Text = "-"
        '
        'L_Quiz
        '
        Me.L_Quiz.AutoSize = True
        Me.L_Quiz.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Quiz.Location = New System.Drawing.Point(304, 75)
        Me.L_Quiz.Name = "L_Quiz"
        Me.L_Quiz.Size = New System.Drawing.Size(16, 21)
        Me.L_Quiz.TabIndex = 11
        Me.L_Quiz.Text = "-"
        '
        'L_Uas
        '
        Me.L_Uas.AutoSize = True
        Me.L_Uas.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Uas.Location = New System.Drawing.Point(304, 150)
        Me.L_Uas.Name = "L_Uas"
        Me.L_Uas.Size = New System.Drawing.Size(16, 21)
        Me.L_Uas.TabIndex = 12
        Me.L_Uas.Text = "-"
        '
        'BTN_Proses
        '
        Me.BTN_Proses.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BTN_Proses.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Proses.Location = New System.Drawing.Point(33, 204)
        Me.BTN_Proses.Name = "BTN_Proses"
        Me.BTN_Proses.Size = New System.Drawing.Size(80, 29)
        Me.BTN_Proses.TabIndex = 13
        Me.BTN_Proses.Text = "Proses"
        Me.BTN_Proses.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Total Nilai :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 22)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Grade Nilai :"
        '
        'TB_TotalNilai
        '
        Me.TB_TotalNilai.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TotalNilai.Location = New System.Drawing.Point(168, 259)
        Me.TB_TotalNilai.Name = "TB_TotalNilai"
        Me.TB_TotalNilai.Size = New System.Drawing.Size(122, 29)
        Me.TB_TotalNilai.TabIndex = 16
        '
        'TB_GradeNilai
        '
        Me.TB_GradeNilai.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_GradeNilai.Location = New System.Drawing.Point(168, 298)
        Me.TB_GradeNilai.Name = "TB_GradeNilai"
        Me.TB_GradeNilai.Size = New System.Drawing.Size(122, 29)
        Me.TB_GradeNilai.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_Tugas)
        Me.GroupBox1.Controls.Add(Me.TB_GradeNilai)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TB_TotalNilai)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BTN_Proses)
        Me.GroupBox1.Controls.Add(Me.TB_Quiz)
        Me.GroupBox1.Controls.Add(Me.L_Uas)
        Me.GroupBox1.Controls.Add(Me.TB_Uts)
        Me.GroupBox1.Controls.Add(Me.L_Quiz)
        Me.GroupBox1.Controls.Add(Me.TB_Uas)
        Me.GroupBox1.Controls.Add(Me.L_Uts)
        Me.GroupBox1.Controls.Add(Me.L_Tugas)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(42, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 353)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Nilai"
        '
        'BTN_Bersihkan
        '
        Me.BTN_Bersihkan.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Bersihkan.Location = New System.Drawing.Point(42, 488)
        Me.BTN_Bersihkan.Name = "BTN_Bersihkan"
        Me.BTN_Bersihkan.Size = New System.Drawing.Size(102, 31)
        Me.BTN_Bersihkan.TabIndex = 19
        Me.BTN_Bersihkan.Text = "Bersihkan"
        Me.BTN_Bersihkan.UseVisualStyleBackColor = True
        '
        'BTN_Keluar
        '
        Me.BTN_Keluar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Keluar.Location = New System.Drawing.Point(283, 488)
        Me.BTN_Keluar.Name = "BTN_Keluar"
        Me.BTN_Keluar.Size = New System.Drawing.Size(102, 31)
        Me.BTN_Keluar.TabIndex = 20
        Me.BTN_Keluar.Text = "Keluar"
        Me.BTN_Keluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 574)
        Me.Controls.Add(Me.BTN_Keluar)
        Me.Controls.Add(Me.BTN_Bersihkan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_Tugas As TextBox
    Friend WithEvents TB_Quiz As TextBox
    Friend WithEvents TB_Uts As TextBox
    Friend WithEvents TB_Uas As TextBox
    Friend WithEvents L_Tugas As Label
    Friend WithEvents L_Uts As Label
    Friend WithEvents L_Quiz As Label
    Friend WithEvents L_Uas As Label
    Friend WithEvents BTN_Proses As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_TotalNilai As TextBox
    Friend WithEvents TB_GradeNilai As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTN_Bersihkan As Button
    Friend WithEvents BTN_Keluar As Button
End Class
