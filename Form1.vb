Imports System.ComponentModel.DataAnnotations

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nama As String
        Dim Npm As String
        Dim Kehadiran As Double
        Dim NTugas As Double
        Dim NUts As Double
        Dim NUas As Double
        Dim NAkhir As Double
        Dim IPS As Double
        Dim IPK As Double
        Dim Grade As String
        Dim Komen As String

        Nama = TextNama.Text
        Npm = TextNpm.Text
        Kehadiran = Val(TextKehadiran.Text)
        NTugas = Val(TextTugas.Text)
        NUts = Val(TextUts.Text)
        NUas = Val(TextUas.Text)

        NAkhir = ((Kehadiran / 16 * 10) + NTugas * 0.2 + NUts * 0.3 + NUas * 0.4)
        TextNilaiakhir.Text = NAkhir
        IPS = ((NAkhir * 4) / 100)
        TextIps.Text = IPS
        IPK = IPS
        TextIpk.Text = IPS


        If NAkhir >= 80 Then
            Grade = "A"
            Komen = "Selamat Anda Lulus"
        ElseIf NAkhir >= 70 Then
            Grade = "B"
            Komen = "Selamat Anda Lulus"
        ElseIf NAkhir >= 60 Then
            Grade = "C"
            Komen = "Anda Tidak Lulus"
        ElseIf NAkhir >= 50 Then
            Grade = "D"
            Komen = "Anda Tidak Lulus"
        ElseIf NAkhir < 50 Then
            Grade = "E"
            Komen = "Anda Tidak Lulus"
        End If
        LabelGrade.Text = Grade
        LabelKomen.Text = Komen

        Dim arr(5) As String
        arr(0) = TextNpm.Text
        arr(1) = TextNama.Text
        arr(2) = ComboBox1.Text
        arr(3) = TextSemester.Text
        arr(4) = TextNilaiakhir.Text
        arr(5) = TextIps.Text

        Dim list As ListViewItem
        list = New ListViewItem
        list = ListView1.Items.Add(arr(0))
        list.SubItems.Add(arr(1))
        list.SubItems.Add(arr(2))
        list.SubItems.Add(arr(3))
        list.SubItems.Add(arr(4))
        list.SubItems.Add(arr(5))
       


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextNama.Text = ""
        TextNpm.Text = ""
        ComboBox1.Text = ""
        TextKehadiran.Text = ""
        TextTugas.Text = ""
        TextUts.Text = ""
        TextUas.Text = ""
        TextNilaiakhir.Text = ""
        TextIps.Text = ""
        TextIpk.Text = ""
        LabelGrade.Text = ""
        LabelKomen.Text = ""
        TextNama.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr(2, 1) As String
        arr(0, 0) = "Nama"
        arr(0, 1) = "NPM"
        arr(1, 0) = "Jurusan"
        arr(1, 1) = "SEMESTER"
        arr(2, 1) = "NILAI AKHIR"
        arr(2, 1) = "IPS"
        ListView1.GridLines = True
        ListView1.View = View.Details

        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(arr(baris, kolom), 120)
            Next kolom
        Next baris


    End Sub
End Class
