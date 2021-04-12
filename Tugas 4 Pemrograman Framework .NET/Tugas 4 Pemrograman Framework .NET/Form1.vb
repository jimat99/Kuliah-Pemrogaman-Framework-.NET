Public Class Form1
    Private Sub buttonCariFaktor_Click(sender As Object, e As EventArgs) Handles buttonCariFaktor.Click
        If buttonCariFaktor.Text = "Cari Faktor" Then
            buttonCariFaktor.Text = "Batalkan"
            listBoxFaktor.Items.Clear()
            bgWorkerFaktor.RunWorkerAsync()
        ElseIf buttonCariFaktor.Text = "Batalkan" Then
            bgWorkerFaktor.CancelAsync()
        End If
    End Sub

    Private Sub bgWorkerFaktor_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorkerFaktor.DoWork
        Dim angka As Integer = Convert.ToInt32(textAngkaFaktor.Text)

        For i As Integer = 1 To angka
            If bgWorkerFaktor.CancellationPending = True Then
                e.Cancel = True
                Exit For
            Else
                If angka Mod i = 0 Then
                    bgWorkerFaktor.ReportProgress((i / angka) * 100, i)
                Else
                    bgWorkerFaktor.ReportProgress((i / angka) * 100)
                End If
                Threading.Thread.Sleep(10)
            End If
        Next
    End Sub

    Private Sub bgWorkerFaktor_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgWorkerFaktor.ProgressChanged
        progressBarFaktor.Value = e.ProgressPercentage
        If e.UserState IsNot Nothing Then
            listBoxFaktor.Items.Add(e.UserState)
        End If
    End Sub

    Private Sub bgWorkerFaktor_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorkerFaktor.RunWorkerCompleted
        If e.Cancelled = True Then
            MsgBox("Pencarian faktor telah dibatalkan!")
            buttonCariFaktor.Text = "Cari Faktor"
            listBoxFaktor.Items.Add("Pencarian faktor telah dibatalkan!")
            progressBarFaktor.Value = progressBarFaktor.Minimum
        Else
            MsgBox("Pencarian faktor selesai!")
            buttonCariFaktor.Text = "Cari Faktor"
            listBoxFaktor.Items.Add("Pencarian faktor selesai!")
            progressBarFaktor.Value = progressBarFaktor.Minimum
        End If
    End Sub

    Private Sub buttonCariKelipatan_Click(sender As Object, e As EventArgs) Handles buttonCariKelipatan.Click
        If buttonCariKelipatan.Text = "Cari Kelipatan" Then
            buttonCariKelipatan.Text = "Batalkan"
            listBoxKelipatan.Items.Clear()
            bgWorkerKelipatan.RunWorkerAsync()
        ElseIf buttonCariKelipatan.Text = "Batalkan" Then
            bgWorkerKelipatan.CancelAsync()
        End If
    End Sub

    Private Sub bgWorkerKelipatan_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorkerKelipatan.DoWork
        Dim angka As Integer = Convert.ToInt32(textAngkaKelipatan.Text)
        Dim batasAwalKelipatan As Integer = Convert.ToInt32(textBatasAwalKelipatan.Text)
        Dim batasAkhirKelipatan As Integer = Convert.ToInt32(textBatasAkhirKelipatan.Text)

        For i As Integer = batasAwalKelipatan To batasAkhirKelipatan
            If bgWorkerKelipatan.CancellationPending = True Then
                e.Cancel = True
                Exit For
            Else
                If i Mod angka = 0 Then
                    bgWorkerKelipatan.ReportProgress((i / batasAkhirKelipatan) * 100, i)
                Else
                    bgWorkerKelipatan.ReportProgress((i / batasAkhirKelipatan) * 100)
                End If
                Threading.Thread.Sleep(10)
            End If
        Next
    End Sub

    Private Sub bgWorkerKelipatan_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgWorkerKelipatan.ProgressChanged
        progressBarKelipatan.Value = e.ProgressPercentage
        If e.UserState IsNot Nothing Then
            listBoxKelipatan.Items.Add(e.UserState)
        End If
    End Sub

    Private Sub bgWorkerKelipatan_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorkerKelipatan.RunWorkerCompleted
        If e.Cancelled = True Then
            MsgBox("Pencarian kelipatan telah dibatalkan!")
            buttonCariKelipatan.Text = "Cari Kelipatan"
            listBoxKelipatan.Items.Add("Pencarian kelipatan telah dibatalkan!")
            progressBarKelipatan.Value = progressBarKelipatan.Minimum
        Else
            MsgBox("Pencarian kelipatan selesai!")
            buttonCariKelipatan.Text = "Cari Kelipatan"
            listBoxKelipatan.Items.Add("Pencarian kelipatan selesai!")
            progressBarKelipatan.Value = progressBarKelipatan.Minimum
        End If
    End Sub
End Class
