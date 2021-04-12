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
        Me.textNamaBarang = New System.Windows.Forms.TextBox()
        Me.textJumlahBarangDibeli = New System.Windows.Forms.TextBox()
        Me.textDeskripsi = New System.Windows.Forms.TextBox()
        Me.textNamaBarang2 = New System.Windows.Forms.TextBox()
        Me.textJumlahBarangDijual = New System.Windows.Forms.TextBox()
        Me.buttonBeli = New System.Windows.Forms.Button()
        Me.buttonTambahStok = New System.Windows.Forms.Button()
        Me.buttonJual = New System.Windows.Forms.Button()
        Me.tabelDataBarang = New System.Windows.Forms.DataGridView()
        Me.kolomNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolomStok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolomDeskripsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program Manajemen Stok Sederhana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah Barang Dibeli"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Deskripsi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(291, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah Barang Dijual"
        '
        'textNamaBarang
        '
        Me.textNamaBarang.Location = New System.Drawing.Point(140, 59)
        Me.textNamaBarang.Name = "textNamaBarang"
        Me.textNamaBarang.Size = New System.Drawing.Size(130, 20)
        Me.textNamaBarang.TabIndex = 6
        '
        'textJumlahBarangDibeli
        '
        Me.textJumlahBarangDibeli.Location = New System.Drawing.Point(140, 98)
        Me.textJumlahBarangDibeli.Name = "textJumlahBarangDibeli"
        Me.textJumlahBarangDibeli.Size = New System.Drawing.Size(130, 20)
        Me.textJumlahBarangDibeli.TabIndex = 7
        '
        'textDeskripsi
        '
        Me.textDeskripsi.Location = New System.Drawing.Point(140, 136)
        Me.textDeskripsi.Name = "textDeskripsi"
        Me.textDeskripsi.Size = New System.Drawing.Size(130, 20)
        Me.textDeskripsi.TabIndex = 8
        '
        'textNamaBarang2
        '
        Me.textNamaBarang2.Location = New System.Drawing.Point(403, 59)
        Me.textNamaBarang2.Name = "textNamaBarang2"
        Me.textNamaBarang2.ReadOnly = True
        Me.textNamaBarang2.Size = New System.Drawing.Size(130, 20)
        Me.textNamaBarang2.TabIndex = 9
        '
        'textJumlahBarangDijual
        '
        Me.textJumlahBarangDijual.Location = New System.Drawing.Point(403, 98)
        Me.textJumlahBarangDijual.Name = "textJumlahBarangDijual"
        Me.textJumlahBarangDijual.Size = New System.Drawing.Size(130, 20)
        Me.textJumlahBarangDijual.TabIndex = 10
        '
        'buttonBeli
        '
        Me.buttonBeli.Location = New System.Drawing.Point(195, 173)
        Me.buttonBeli.Name = "buttonBeli"
        Me.buttonBeli.Size = New System.Drawing.Size(75, 23)
        Me.buttonBeli.TabIndex = 11
        Me.buttonBeli.Text = "Beli"
        Me.buttonBeli.UseVisualStyleBackColor = True
        '
        'buttonTambahStok
        '
        Me.buttonTambahStok.Location = New System.Drawing.Point(87, 173)
        Me.buttonTambahStok.Name = "buttonTambahStok"
        Me.buttonTambahStok.Size = New System.Drawing.Size(102, 23)
        Me.buttonTambahStok.TabIndex = 12
        Me.buttonTambahStok.Text = "Tambah Stok"
        Me.buttonTambahStok.UseVisualStyleBackColor = True
        '
        'buttonJual
        '
        Me.buttonJual.Location = New System.Drawing.Point(403, 134)
        Me.buttonJual.Name = "buttonJual"
        Me.buttonJual.Size = New System.Drawing.Size(75, 23)
        Me.buttonJual.TabIndex = 13
        Me.buttonJual.Text = "Jual"
        Me.buttonJual.UseVisualStyleBackColor = True
        '
        'tabelDataBarang
        '
        Me.tabelDataBarang.AllowUserToAddRows = False
        Me.tabelDataBarang.AllowUserToDeleteRows = False
        Me.tabelDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kolomNamaBarang, Me.kolomStok, Me.kolomDeskripsi})
        Me.tabelDataBarang.Location = New System.Drawing.Point(106, 233)
        Me.tabelDataBarang.Name = "tabelDataBarang"
        Me.tabelDataBarang.Size = New System.Drawing.Size(345, 150)
        Me.tabelDataBarang.TabIndex = 14
        '
        'kolomNamaBarang
        '
        Me.kolomNamaBarang.HeaderText = "Nama Barang"
        Me.kolomNamaBarang.Name = "kolomNamaBarang"
        '
        'kolomStok
        '
        Me.kolomStok.HeaderText = "Stok"
        Me.kolomStok.Name = "kolomStok"
        '
        'kolomDeskripsi
        '
        Me.kolomDeskripsi.HeaderText = "Deskripsi"
        Me.kolomDeskripsi.Name = "kolomDeskripsi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 450)
        Me.Controls.Add(Me.tabelDataBarang)
        Me.Controls.Add(Me.buttonJual)
        Me.Controls.Add(Me.buttonTambahStok)
        Me.Controls.Add(Me.buttonBeli)
        Me.Controls.Add(Me.textJumlahBarangDijual)
        Me.Controls.Add(Me.textNamaBarang2)
        Me.Controls.Add(Me.textDeskripsi)
        Me.Controls.Add(Me.textJumlahBarangDibeli)
        Me.Controls.Add(Me.textNamaBarang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents textNamaBarang As TextBox
    Friend WithEvents textJumlahBarangDibeli As TextBox
    Friend WithEvents textDeskripsi As TextBox
    Friend WithEvents textNamaBarang2 As TextBox
    Friend WithEvents textJumlahBarangDijual As TextBox
    Friend WithEvents buttonBeli As Button
    Friend WithEvents buttonTambahStok As Button
    Friend WithEvents buttonJual As Button
    Friend WithEvents tabelDataBarang As DataGridView
    Friend WithEvents kolomNamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents kolomStok As DataGridViewTextBoxColumn
    Friend WithEvents kolomDeskripsi As DataGridViewTextBoxColumn
End Class
