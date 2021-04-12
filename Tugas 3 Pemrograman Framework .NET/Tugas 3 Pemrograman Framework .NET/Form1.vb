Public Class Form1
    Dim dataNamaBarang As ArrayList = New ArrayList()
    Dim dataStok As ArrayList = New ArrayList()
    Dim dataDeskripsi As ArrayList = New ArrayList()

    Private Sub isiDataTabel()
        tabelDataBarang.Rows.Clear()
        For i As Integer = 0 To dataNamaBarang.Count - 1
            tabelDataBarang.Rows.Add({dataNamaBarang.Item(i), dataStok.Item(i),
                                     dataDeskripsi.Item(i)})
        Next
    End Sub

    Private Sub buttonBeli_Click(sender As Object, e As EventArgs) Handles buttonBeli.Click
        Dim namaBarang, deskripsi, pesan As String
        Dim stok As Integer

        Try
            namaBarang = textNamaBarang.Text
            stok = Convert.ToInt32(textJumlahBarangDibeli.Text)
            deskripsi = textDeskripsi.Text
            dataNamaBarang.Add(namaBarang)
            dataStok.Add(stok)
            dataDeskripsi.Add(deskripsi)
            isiDataTabel()
            pesan = "Pembelian barang berhasil"
        Catch ex As Exception
            MsgBox(ex.Message)
            pesan = "Pembelian barang gagal"
        Finally
            MsgBox(pesan)
        End Try
    End Sub

    Private Sub buttonTambahStok_Click(sender As Object,
                                       e As EventArgs) Handles buttonTambahStok.Click
        On Error Resume Next
        Dim namaBarang As String
        Dim jumlahBarangDibeli As Integer

        namaBarang = textNamaBarang.Text
        jumlahBarangDibeli = Convert.ToInt32(textJumlahBarangDibeli.Text)
        dataStok.Item(dataNamaBarang.IndexOf(namaBarang)) += jumlahBarangDibeli
        isiDataTabel()
    End Sub

    Private Sub buttonJual_Click(sender As Object, e As EventArgs) Handles buttonJual.Click
        On Error GoTo pesan
        Dim namaBarang As String
        Dim jumlahBarangDijual As Integer

        namaBarang = textNamaBarang2.Text
        jumlahBarangDijual = Convert.ToInt32(textJumlahBarangDijual.Text)
        dataStok.Item(dataNamaBarang.IndexOf(namaBarang)) -= jumlahBarangDijual
        isiDataTabel()
        Exit Sub

pesan:
        MsgBox("Text box Nama Barang dan Jumlah Barang Dijual tidak boleh kosong. " &
               "Untuk memunculkan nama barang yang akan dijual, klik nama barang yang " &
               "diinginkan pada tabel. Text box Jumlah Barang Dijual harus diisi angka.")
    End Sub

    Private Sub tabelDataBarang_CellContentClick(sender As Object,
                                                 e As DataGridViewCellEventArgs
                                                 ) Handles tabelDataBarang.CellContentClick
        If e.RowIndex >= 0 Then
            textNamaBarang2.Text = tabelDataBarang.Item(0, e.RowIndex).Value.ToString
        End If
    End Sub
End Class
