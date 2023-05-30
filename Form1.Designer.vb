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
        label = New Label()
        label1 = New Label()
        label2 = New Label()
        label3 = New Label()
        label4 = New Label()
        label5 = New Label()
        txtKode = New TextBox()
        txtNama = New TextBox()
        txtJenis = New TextBox()
        txtJual = New TextBox()
        txtBeli = New TextBox()
        txtLokasi = New TextBox()
        btnBrowse = New Button()
        btnSimpan = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnCari = New Button()
        label6 = New Label()
        txtSisa = New TextBox()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Location = New Point(167, 39)
        label.Name = "label"
        label.Size = New Size(66, 15)
        label.TabIndex = 0
        label.Text = "Kode Stock"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(167, 88)
        label1.Name = "label1"
        label1.Size = New Size(71, 15)
        label1.TabIndex = 1
        label1.Text = "Nama Stock"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(167, 140)
        label2.Name = "label2"
        label2.Size = New Size(32, 15)
        label2.TabIndex = 2
        label2.Text = "Jenis"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(167, 189)
        label3.Name = "label3"
        label3.Size = New Size(65, 15)
        label3.TabIndex = 3
        label3.Text = "Hargal Jual"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(167, 242)
        label4.Name = "label4"
        label4.Size = New Size(64, 15)
        label4.TabIndex = 4
        label4.Text = "Hargal Beli"
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Point(167, 299)
        label5.Name = "label5"
        label5.Size = New Size(58, 15)
        label5.TabIndex = 5
        label5.Text = "Stok Toko"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(275, 39)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(291, 23)
        txtKode.TabIndex = 6
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(275, 88)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(291, 23)
        txtNama.TabIndex = 7
        ' 
        ' txtJenis
        ' 
        txtJenis.Location = New Point(275, 140)
        txtJenis.Name = "txtJenis"
        txtJenis.Size = New Size(291, 23)
        txtJenis.TabIndex = 8
        ' 
        ' txtJual
        ' 
        txtJual.Location = New Point(275, 189)
        txtJual.Name = "txtJual"
        txtJual.Size = New Size(291, 23)
        txtJual.TabIndex = 9
        ' 
        ' txtBeli
        ' 
        txtBeli.Location = New Point(275, 242)
        txtBeli.Name = "txtBeli"
        txtBeli.Size = New Size(291, 23)
        txtBeli.TabIndex = 10
        ' 
        ' txtLokasi
        ' 
        txtLokasi.Location = New Point(275, 364)
        txtLokasi.Name = "txtLokasi"
        txtLokasi.Size = New Size(203, 23)
        txtLokasi.TabIndex = 11
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(491, 364)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 26)
        btnBrowse.TabIndex = 12
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(206, 440)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(76, 24)
        btnSimpan.TabIndex = 13
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(288, 440)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(76, 24)
        btnHapus.TabIndex = 14
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(370, 440)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(76, 24)
        btnBatal.TabIndex = 15
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(452, 440)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(76, 24)
        btnCari.TabIndex = 16
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Location = New Point(167, 364)
        label6.Name = "label6"
        label6.Size = New Size(72, 15)
        label6.TabIndex = 17
        label6.Text = "Upload Foto"
        ' 
        ' txtSisa
        ' 
        txtSisa.Location = New Point(275, 299)
        txtSisa.Name = "txtSisa"
        txtSisa.Size = New Size(291, 23)
        txtSisa.TabIndex = 18
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(600, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(291, 351)
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(953, 583)
        Controls.Add(PictureBox1)
        Controls.Add(txtSisa)
        Controls.Add(label6)
        Controls.Add(btnCari)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnSimpan)
        Controls.Add(btnBrowse)
        Controls.Add(txtLokasi)
        Controls.Add(txtBeli)
        Controls.Add(txtJual)
        Controls.Add(txtJenis)
        Controls.Add(txtNama)
        Controls.Add(txtKode)
        Controls.Add(label5)
        Controls.Add(label4)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(label1)
        Controls.Add(label)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label As Label
    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents txtJual As TextBox
    Friend WithEvents txtBeli As TextBox
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents label6 As Label
    Friend WithEvents txtSisa As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
