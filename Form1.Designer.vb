<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextNama = New System.Windows.Forms.TextBox()
        Me.TextNpm = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextTugas = New System.Windows.Forms.TextBox()
        Me.TextUts = New System.Windows.Forms.TextBox()
        Me.TextUas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextIps = New System.Windows.Forms.TextBox()
        Me.TextIpk = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelGrade = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextNilaiakhir = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelKomen = New System.Windows.Forms.Label()
        Me.TextSemester = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextKehadiran = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(195, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(635, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM PROGRAM MENGHITUNG NILAI MAHASISWA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NPM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "JURUSAN"
        '
        'TextNama
        '
        Me.TextNama.Location = New System.Drawing.Point(122, 70)
        Me.TextNama.Name = "TextNama"
        Me.TextNama.Size = New System.Drawing.Size(338, 27)
        Me.TextNama.TabIndex = 4
        Me.TextNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextNpm
        '
        Me.TextNpm.Location = New System.Drawing.Point(122, 108)
        Me.TextNpm.Name = "TextNpm"
        Me.TextNpm.Size = New System.Drawing.Size(338, 27)
        Me.TextNpm.TabIndex = 5
        Me.TextNpm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SISTEM INFORMASI", "SISTEM INFORMASI AKUTANSI", "TEKNIK INFORMATIKA", "REKAYASA PERANGKAT LUNAK", "MANAJEMEN"})
        Me.ComboBox1.Location = New System.Drawing.Point(122, 148)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(338, 28)
        Me.ComboBox1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(12, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "KEHADIRAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(12, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "NILAI TUGAS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(353, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "NILAI UTS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(353, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "NILAI UAS"
        '
        'TextTugas
        '
        Me.TextTugas.Location = New System.Drawing.Point(122, 284)
        Me.TextTugas.MaxLength = 100
        Me.TextTugas.Name = "TextTugas"
        Me.TextTugas.Size = New System.Drawing.Size(197, 27)
        Me.TextTugas.TabIndex = 12
        Me.TextTugas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextUts
        '
        Me.TextUts.Location = New System.Drawing.Point(460, 251)
        Me.TextUts.MaxLength = 100
        Me.TextUts.Name = "TextUts"
        Me.TextUts.Size = New System.Drawing.Size(197, 27)
        Me.TextUts.TabIndex = 13
        Me.TextUts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextUas
        '
        Me.TextUas.Location = New System.Drawing.Point(460, 284)
        Me.TextUas.MaxLength = 100
        Me.TextUas.Name = "TextUas"
        Me.TextUas.Size = New System.Drawing.Size(197, 27)
        Me.TextUas.TabIndex = 14
        Me.TextUas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(694, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "IPS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(693, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "IPK"
        '
        'TextIps
        '
        Me.TextIps.Enabled = False
        Me.TextIps.Location = New System.Drawing.Point(768, 247)
        Me.TextIps.MaxLength = 2
        Me.TextIps.Name = "TextIps"
        Me.TextIps.ReadOnly = True
        Me.TextIps.Size = New System.Drawing.Size(197, 27)
        Me.TextIps.TabIndex = 17
        Me.TextIps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextIpk
        '
        Me.TextIpk.Enabled = False
        Me.TextIpk.Location = New System.Drawing.Point(768, 280)
        Me.TextIpk.MaxLength = 4
        Me.TextIpk.Name = "TextIpk"
        Me.TextIpk.ReadOnly = True
        Me.TextIpk.Size = New System.Drawing.Size(197, 27)
        Me.TextIpk.TabIndex = 18
        Me.TextIpk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(122, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "HITUNG"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(225, 317)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "HAPUS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(871, 476)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "KELUAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(693, 322)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "GRADE"
        '
        'LabelGrade
        '
        Me.LabelGrade.AutoSize = True
        Me.LabelGrade.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelGrade.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelGrade.Location = New System.Drawing.Point(768, 317)
        Me.LabelGrade.Name = "LabelGrade"
        Me.LabelGrade.Size = New System.Drawing.Size(23, 25)
        Me.LabelGrade.TabIndex = 23
        Me.LabelGrade.Text = "-"
        Me.LabelGrade.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(353, 322)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 20)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "NILAI AKHIR"
        '
        'TextNilaiakhir
        '
        Me.TextNilaiakhir.Enabled = False
        Me.TextNilaiakhir.Location = New System.Drawing.Point(460, 319)
        Me.TextNilaiakhir.MaxLength = 100
        Me.TextNilaiakhir.Name = "TextNilaiakhir"
        Me.TextNilaiakhir.ReadOnly = True
        Me.TextNilaiakhir.Size = New System.Drawing.Size(197, 27)
        Me.TextNilaiakhir.TabIndex = 25
        Me.TextNilaiakhir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(460, 367)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 20)
        Me.Label12.TabIndex = 26
        '
        'LabelKomen
        '
        Me.LabelKomen.AutoSize = True
        Me.LabelKomen.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelKomen.Font = New System.Drawing.Font("Comic Sans MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelKomen.Location = New System.Drawing.Point(518, 123)
        Me.LabelKomen.Name = "LabelKomen"
        Me.LabelKomen.Size = New System.Drawing.Size(40, 45)
        Me.LabelKomen.TabIndex = 27
        Me.LabelKomen.Text = "-"
        Me.LabelKomen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextSemester
        '
        Me.TextSemester.Location = New System.Drawing.Point(619, 70)
        Me.TextSemester.MaxLength = 100
        Me.TextSemester.Name = "TextSemester"
        Me.TextSemester.Size = New System.Drawing.Size(197, 27)
        Me.TextSemester.TabIndex = 28
        Me.TextSemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(518, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 20)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "SEMESTER"
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HoverSelection = True
        Me.ListView1.Location = New System.Drawing.Point(12, 356)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(853, 149)
        Me.ListView1.TabIndex = 30
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"LAKI - LAKI", "PEREMPUAN", "RAHASIA"})
        Me.ComboBox2.Location = New System.Drawing.Point(122, 188)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(338, 28)
        Me.ComboBox2.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(12, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 20)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "L/P"
        '
        'TextKehadiran
        '
        Me.TextKehadiran.FormattingEnabled = True
        Me.TextKehadiran.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.TextKehadiran.Location = New System.Drawing.Point(122, 251)
        Me.TextKehadiran.Name = "TextKehadiran"
        Me.TextKehadiran.Size = New System.Drawing.Size(197, 28)
        Me.TextKehadiran.TabIndex = 33
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 517)
        Me.Controls.Add(Me.TextKehadiran)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextSemester)
        Me.Controls.Add(Me.LabelKomen)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextNilaiakhir)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LabelGrade)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextIpk)
        Me.Controls.Add(Me.TextIps)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextUas)
        Me.Controls.Add(Me.TextUts)
        Me.Controls.Add(Me.TextTugas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextNpm)
        Me.Controls.Add(Me.TextNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextNama As TextBox
    Friend WithEvents TextNpm As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextTugas As TextBox
    Friend WithEvents TextUts As TextBox
    Friend WithEvents TextUas As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextIps As TextBox
    Friend WithEvents TextIpk As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents LabelGrade As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextNilaiakhir As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LabelKomen As Label
    Friend WithEvents TextSemester As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextKehadiran As ComboBox
End Class
