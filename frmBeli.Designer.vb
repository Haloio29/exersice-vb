<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBeli
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtKode = New TextBox()
        txtKode_C = New TextBox()
        txtNama_C = New TextBox()
        txtKeterangan = New TextBox()
        txtTotal = New TextBox()
        btnCari_C = New Button()
        btnTambah = New Button()
        btnSimpan = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnCari = New Button()
        dtpTanggal = New DateTimePicker()
        dgvDetail = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        gbStok = New GroupBox()
        Label11 = New Label()
        btnSelesai = New Button()
        btnBersihkan = New Button()
        btnTambah_S = New Button()
        txtSubTotal = New TextBox()
        txtHarga = New TextBox()
        txtQty = New TextBox()
        txtNama_S = New TextBox()
        picStok = New PictureBox()
        btnCari_S = New Button()
        txtKode_S = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        CType(dgvDetail, ComponentModel.ISupportInitialize).BeginInit()
        gbStok.SuspendLayout()
        CType(picStok, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 15)
        Label1.TabIndex = 0
        Label1.Text = "No. Beli"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 15)
        Label2.TabIndex = 1
        Label2.Text = "Kode Supplier"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(61, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 2
        Label3.Text = "Nama Supplier"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(61, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 3
        Label4.Text = "Tanggal"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(61, 197)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 4
        Label5.Text = "Keterangan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(61, 561)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 5
        Label6.Text = "Grand Total"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(206, 28)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(399, 23)
        txtKode.TabIndex = 6
        ' 
        ' txtKode_C
        ' 
        txtKode_C.Location = New Point(206, 69)
        txtKode_C.Name = "txtKode_C"
        txtKode_C.Size = New Size(287, 23)
        txtKode_C.TabIndex = 7
        ' 
        ' txtNama_C
        ' 
        txtNama_C.Location = New Point(206, 114)
        txtNama_C.Name = "txtNama_C"
        txtNama_C.Size = New Size(399, 23)
        txtNama_C.TabIndex = 8
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Location = New Point(206, 197)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(399, 23)
        txtKeterangan.TabIndex = 9
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(206, 561)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(399, 23)
        txtTotal.TabIndex = 10
        ' 
        ' btnCari_C
        ' 
        btnCari_C.Location = New Point(508, 69)
        btnCari_C.Name = "btnCari_C"
        btnCari_C.Size = New Size(97, 23)
        btnCari_C.TabIndex = 11
        btnCari_C.Text = "Cari Supplier"
        btnCari_C.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(61, 233)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(85, 23)
        btnTambah.TabIndex = 12
        btnTambah.Text = "Tambah Stok"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(206, 627)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 13
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(315, 627)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 14
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(427, 627)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 15
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(530, 627)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(75, 23)
        btnCari.TabIndex = 16
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(206, 158)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(399, 23)
        dtpTanggal.TabIndex = 17
        ' 
        ' dgvDetail
        ' 
        dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetail.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgvDetail.Location = New Point(61, 275)
        dgvDetail.Name = "dgvDetail"
        dgvDetail.RowTemplate.Height = 25
        dgvDetail.Size = New Size(544, 265)
        dgvDetail.TabIndex = 18
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Kode Stok"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama Stok"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Qty"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "@ / Satuan"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Sub Total"
        Column5.Name = "Column5"
        ' 
        ' gbStok
        ' 
        gbStok.BackColor = SystemColors.ActiveCaption
        gbStok.Controls.Add(Label11)
        gbStok.Controls.Add(btnSelesai)
        gbStok.Controls.Add(btnBersihkan)
        gbStok.Controls.Add(btnTambah_S)
        gbStok.Controls.Add(txtSubTotal)
        gbStok.Controls.Add(txtHarga)
        gbStok.Controls.Add(txtQty)
        gbStok.Controls.Add(txtNama_S)
        gbStok.Controls.Add(picStok)
        gbStok.Controls.Add(btnCari_S)
        gbStok.Controls.Add(txtKode_S)
        gbStok.Controls.Add(Label10)
        gbStok.Controls.Add(Label9)
        gbStok.Controls.Add(Label8)
        gbStok.Controls.Add(Label7)
        gbStok.Location = New Point(206, 226)
        gbStok.Name = "gbStok"
        gbStok.Size = New Size(488, 229)
        gbStok.TabIndex = 19
        gbStok.TabStop = False
        gbStok.Text = "Tambah Data Stok"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.ActiveCaption
        Label11.Location = New Point(21, 35)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 15)
        Label11.TabIndex = 14
        Label11.Text = "Kode Stok"
        ' 
        ' btnSelesai
        ' 
        btnSelesai.Location = New Point(212, 195)
        btnSelesai.Name = "btnSelesai"
        btnSelesai.Size = New Size(75, 23)
        btnSelesai.TabIndex = 13
        btnSelesai.Text = "Selesai"
        btnSelesai.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.Location = New Point(119, 195)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(75, 23)
        btnBersihkan.TabIndex = 12
        btnBersihkan.Text = "Bersih"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' btnTambah_S
        ' 
        btnTambah_S.Location = New Point(21, 195)
        btnTambah_S.Name = "btnTambah_S"
        btnTambah_S.Size = New Size(75, 23)
        btnTambah_S.TabIndex = 11
        btnTambah_S.Text = "Tambah"
        btnTambah_S.UseVisualStyleBackColor = True
        ' 
        ' txtSubTotal
        ' 
        txtSubTotal.Location = New Point(106, 152)
        txtSubTotal.Name = "txtSubTotal"
        txtSubTotal.Size = New Size(181, 23)
        txtSubTotal.TabIndex = 10
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(106, 122)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(181, 23)
        txtHarga.TabIndex = 9
        ' 
        ' txtQty
        ' 
        txtQty.Location = New Point(106, 93)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(181, 23)
        txtQty.TabIndex = 8
        ' 
        ' txtNama_S
        ' 
        txtNama_S.Location = New Point(106, 64)
        txtNama_S.Name = "txtNama_S"
        txtNama_S.Size = New Size(181, 23)
        txtNama_S.TabIndex = 7
        ' 
        ' picStok
        ' 
        picStok.BackColor = SystemColors.Control
        picStok.Location = New Point(293, 64)
        picStok.Name = "picStok"
        picStok.Size = New Size(181, 111)
        picStok.TabIndex = 6
        picStok.TabStop = False
        ' 
        ' btnCari_S
        ' 
        btnCari_S.Location = New Point(212, 35)
        btnCari_S.Name = "btnCari_S"
        btnCari_S.Size = New Size(75, 23)
        btnCari_S.TabIndex = 5
        btnCari_S.Text = "Cari Stok"
        btnCari_S.UseVisualStyleBackColor = True
        ' 
        ' txtKode_S
        ' 
        txtKode_S.Location = New Point(106, 35)
        txtKode_S.Name = "txtKode_S"
        txtKode_S.Size = New Size(100, 23)
        txtKode_S.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(21, 152)
        Label10.Name = "Label10"
        Label10.Size = New Size(55, 15)
        Label10.TabIndex = 3
        Label10.Text = "Sub Total"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(21, 122)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 15)
        Label9.TabIndex = 2
        Label9.Text = "Harga Satuan"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(21, 93)
        Label8.Name = "Label8"
        Label8.Size = New Size(26, 15)
        Label8.TabIndex = 1
        Label8.Text = "Qty"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(21, 64)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 15)
        Label7.TabIndex = 0
        Label7.Text = "Nama Stok"
        ' 
        ' frmBeli
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(888, 686)
        Controls.Add(gbStok)
        Controls.Add(dgvDetail)
        Controls.Add(dtpTanggal)
        Controls.Add(btnCari)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnSimpan)
        Controls.Add(btnTambah)
        Controls.Add(btnCari_C)
        Controls.Add(txtTotal)
        Controls.Add(txtKeterangan)
        Controls.Add(txtNama_C)
        Controls.Add(txtKode_C)
        Controls.Add(txtKode)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmBeli"
        Text = "frmBeli"
        CType(dgvDetail, ComponentModel.ISupportInitialize).EndInit()
        gbStok.ResumeLayout(False)
        gbStok.PerformLayout()
        CType(picStok, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtKode_C As TextBox
    Friend WithEvents txtNama_C As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCari_C As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents gbStok As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSelesai As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnTambah_S As Button
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtNama_S As TextBox
    Friend WithEvents picStok As PictureBox
    Friend WithEvents btnCari_S As Button
    Friend WithEvents txtKode_S As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
