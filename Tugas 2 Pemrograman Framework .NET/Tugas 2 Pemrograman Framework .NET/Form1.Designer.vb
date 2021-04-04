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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUangKembalian = New System.Windows.Forms.TextBox()
        Me.txtUangPembayaran = New System.Windows.Forms.TextBox()
        Me.txtTotalBayar = New System.Windows.Forms.TextBox()
        Me.txtPromo = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtHargaSatuan = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama : Bima Kurnia Adam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NPM   : 06.2018.1.07053"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Satuan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Promo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Bayar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Uang Pembayaran"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 326)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Uang Kembalian"
        '
        'txtUangKembalian
        '
        Me.txtUangKembalian.Location = New System.Drawing.Point(124, 323)
        Me.txtUangKembalian.Name = "txtUangKembalian"
        Me.txtUangKembalian.ReadOnly = True
        Me.txtUangKembalian.Size = New System.Drawing.Size(100, 20)
        Me.txtUangKembalian.TabIndex = 17
        '
        'txtUangPembayaran
        '
        Me.txtUangPembayaran.Location = New System.Drawing.Point(124, 268)
        Me.txtUangPembayaran.Name = "txtUangPembayaran"
        Me.txtUangPembayaran.Size = New System.Drawing.Size(100, 20)
        Me.txtUangPembayaran.TabIndex = 16
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.Location = New System.Drawing.Point(124, 235)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.ReadOnly = True
        Me.txtTotalBayar.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalBayar.TabIndex = 15
        '
        'txtPromo
        '
        Me.txtPromo.Location = New System.Drawing.Point(124, 202)
        Me.txtPromo.Name = "txtPromo"
        Me.txtPromo.ReadOnly = True
        Me.txtPromo.Size = New System.Drawing.Size(100, 20)
        Me.txtPromo.TabIndex = 14
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(124, 146)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(100, 20)
        Me.txtJumlah.TabIndex = 13
        '
        'txtHargaSatuan
        '
        Me.txtHargaSatuan.Location = New System.Drawing.Point(124, 120)
        Me.txtHargaSatuan.Name = "txtHargaSatuan"
        Me.txtHargaSatuan.Size = New System.Drawing.Size(100, 20)
        Me.txtHargaSatuan.TabIndex = 12
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(124, 91)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(100, 20)
        Me.txtNamaBarang.TabIndex = 11
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(124, 63)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeBarang.TabIndex = 10
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(124, 173)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(86, 23)
        Me.btnHitung.TabIndex = 18
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnBayar
        '
        Me.btnBayar.Location = New System.Drawing.Point(124, 294)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(73, 23)
        Me.btnBayar.TabIndex = 19
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 381)
        Me.Controls.Add(Me.btnBayar)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtUangKembalian)
        Me.Controls.Add(Me.txtUangPembayaran)
        Me.Controls.Add(Me.txtTotalBayar)
        Me.Controls.Add(Me.txtPromo)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtHargaSatuan)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtUangKembalian As TextBox
    Friend WithEvents txtUangPembayaran As TextBox
    Friend WithEvents txtTotalBayar As TextBox
    Friend WithEvents txtPromo As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtHargaSatuan As TextBox
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtKodeBarang As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnBayar As Button
End Class
