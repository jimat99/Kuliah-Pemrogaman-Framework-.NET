Public Class Form1
    Function diskon(ByVal hargaSatuan As Integer) As Integer
        Dim hargaPromo, hargaDiskon As Integer
        hargaDiskon = hargaSatuan * (10 / 100)
        hargaPromo = hargaSatuan - hargaDiskon
        Return hargaPromo
    End Function

    Function total_harga(ByVal hargaPromo As Integer,
                         ByVal jumlah As Integer) As Integer
        Dim totalHarga As Integer
        totalHarga = hargaPromo * jumlah
        Return totalHarga
    End Function

    Function kembalian(ByVal uangPembayaran As Integer,
                       ByVal totalBayar As Integer) As Integer
        Dim uangKembalian As Integer
        uangKembalian = uangPembayaran - totalBayar
        Return uangKembalian
    End Function

    Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim kodeBarang, hargaSatuan, hargaPromo, jumlah, totalHarga As Integer
        Dim namaBarang As String
        kodeBarang = txtKodeBarang.Text
        namaBarang = txtNamaBarang.Text
        hargaSatuan = txtHargaSatuan.Text
        hargaPromo = diskon(hargaSatuan)
        jumlah = txtJumlah.Text
        totalHarga = total_harga(hargaPromo, jumlah)
        txtPromo.Text = hargaPromo
        txtTotalBayar.Text = totalHarga
    End Sub

    Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        Dim uangPembayaran, totalBayar, uangKembalian As Integer
        uangPembayaran = txtUangPembayaran.Text
        totalBayar = txtTotalBayar.Text
        uangKembalian = kembalian(uangPembayaran, totalBayar)
        txtUangKembalian.Text = uangKembalian
    End Sub
End Class