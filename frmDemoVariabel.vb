'Created by Rizky Khapidsyah

'CONTOH SOAL:
'Jika sebuah mobil berkecepatan 50 km/jam, 
'berapa jumlah jarak yang dicapainya dalam waktu 14 jam?
'Disamping itu berapa jam kah yang diperlukan untuk menjelajah 410 km?

Public Class frmDemoVariabel
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Text = "Demo Variabel"
            .btHitung.Text = "Hitung"
            .btKeluar.Text = "Keluar"
            .MaximizeBox = False
            .MinimizeBox = False
        End With
    End Sub

    Private Sub BtHitung_Click(sender As Object, e As EventArgs) Handles btHitung.Click
        Dim Kecepatan As Double
        Dim waktuTempuh As Double
        Dim Jarak As Double

        Kecepatan = 50
        waktuTempuh = 14

        lbHasil.Items.Clear()

        Jarak = Kecepatan * waktuTempuh
        lbHasil.Items.Add(Jarak)

        Jarak = 410
        waktuTempuh = Jarak / Kecepatan
        lbHasil.Items.Add(waktuTempuh)
    End Sub

    Private Sub BtKeluar_Click(sender As Object, e As EventArgs) Handles btKeluar.Click
        Dim X As Integer

        X = MsgBox(
            "Anda yakin ingin keluar?",
            MsgBoxStyle.Exclamation + vbYesNo,
            "Keluar")

        If X = vbYes Then
            End
        ElseIf vbNo Then
            If lbHasil.Items.Count = 0 Then
                MsgBox("OK", vbOKOnly, "Lanjut")
            Else
                lbHasil.SelectedIndex = 1
            End If
        End If
    End Sub
End Class
