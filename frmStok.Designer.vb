<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStok
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
        txtSisa = New TextBox()
        label6 = New Label()
        btnCari = New Button()
        btnBatal = New Button()
        btnHapus = New Button()
        btnSimpan = New Button()
        txtLokasi = New TextBox()
        txtBeli = New TextBox()
        txtJual = New TextBox()
        txtJenis = New TextBox()
        txtNama = New TextBox()
        txtKode = New TextBox()
        label5 = New Label()
        label4 = New Label()
        label3 = New Label()
        label2 = New Label()
        label1 = New Label()
        label = New Label()
        PictureBox1 = New PictureBox()
        btnBrowse = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSisa
        ' 
        txtSisa.BackColor = SystemColors.ActiveCaption
        txtSisa.Location = New Point(315, 347)
        txtSisa.Name = "txtSisa"
        txtSisa.Size = New Size(291, 23)
        txtSisa.TabIndex = 73
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.BackColor = SystemColors.ActiveCaption
        label6.Location = New Point(207, 412)
        label6.Name = "label6"
        label6.Size = New Size(72, 15)
        label6.TabIndex = 72
        label6.Text = "Upload Foto"
        ' 
        ' btnCari
        ' 
        btnCari.BackColor = SystemColors.ActiveCaption
        btnCari.Location = New Point(492, 488)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(76, 24)
        btnCari.TabIndex = 71
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = SystemColors.ActiveCaption
        btnBatal.Location = New Point(410, 488)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(76, 24)
        btnBatal.TabIndex = 70
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = SystemColors.ActiveCaption
        btnHapus.Location = New Point(328, 488)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(76, 24)
        btnHapus.TabIndex = 69
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = SystemColors.ActiveCaption
        btnSimpan.Location = New Point(246, 488)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(76, 24)
        btnSimpan.TabIndex = 68
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' txtLokasi
        ' 
        txtLokasi.BackColor = SystemColors.ActiveCaption
        txtLokasi.Location = New Point(315, 412)
        txtLokasi.Name = "txtLokasi"
        txtLokasi.Size = New Size(196, 23)
        txtLokasi.TabIndex = 67
        ' 
        ' txtBeli
        ' 
        txtBeli.BackColor = SystemColors.ActiveCaption
        txtBeli.Location = New Point(315, 290)
        txtBeli.Name = "txtBeli"
        txtBeli.Size = New Size(291, 23)
        txtBeli.TabIndex = 66
        ' 
        ' txtJual
        ' 
        txtJual.BackColor = SystemColors.ActiveCaption
        txtJual.Location = New Point(315, 237)
        txtJual.Name = "txtJual"
        txtJual.Size = New Size(291, 23)
        txtJual.TabIndex = 65
        ' 
        ' txtJenis
        ' 
        txtJenis.BackColor = SystemColors.ActiveCaption
        txtJenis.Location = New Point(315, 188)
        txtJenis.Name = "txtJenis"
        txtJenis.Size = New Size(291, 23)
        txtJenis.TabIndex = 64
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = SystemColors.ActiveCaption
        txtNama.Location = New Point(315, 136)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(291, 23)
        txtNama.TabIndex = 63
        ' 
        ' txtKode
        ' 
        txtKode.BackColor = SystemColors.ActiveCaption
        txtKode.Location = New Point(315, 87)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(291, 23)
        txtKode.TabIndex = 62
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.BackColor = SystemColors.ActiveCaption
        label5.Location = New Point(207, 347)
        label5.Name = "label5"
        label5.Size = New Size(58, 15)
        label5.TabIndex = 61
        label5.Text = "Stok Toko"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.BackColor = SystemColors.ActiveCaption
        label4.Location = New Point(207, 290)
        label4.Name = "label4"
        label4.Size = New Size(61, 15)
        label4.TabIndex = 60
        label4.Text = "Harga Beli"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.BackColor = SystemColors.ActiveCaption
        label3.Location = New Point(207, 237)
        label3.Name = "label3"
        label3.Size = New Size(62, 15)
        label3.TabIndex = 59
        label3.Text = "Harga Jual"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.BackColor = SystemColors.ActiveCaption
        label2.Location = New Point(207, 188)
        label2.Name = "label2"
        label2.Size = New Size(32, 15)
        label2.TabIndex = 58
        label2.Text = "Jenis"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.BackColor = SystemColors.ActiveCaption
        label1.Location = New Point(207, 136)
        label1.Name = "label1"
        label1.Size = New Size(65, 15)
        label1.TabIndex = 57
        label1.Text = "Nama Stok"
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.BackColor = SystemColors.ActiveCaption
        label.Location = New Point(207, 87)
        label.Name = "label"
        label.Size = New Size(60, 15)
        label.TabIndex = 56
        label.Text = "Kode Stok"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ActiveCaption
        PictureBox1.Location = New Point(667, 87)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(291, 348)
        PictureBox1.TabIndex = 74
        PictureBox1.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = SystemColors.ActiveCaption
        btnBrowse.Location = New Point(530, 412)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(76, 24)
        btnBrowse.TabIndex = 75
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' frmStok
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        ClientSize = New Size(1039, 682)
        Controls.Add(btnBrowse)
        Controls.Add(PictureBox1)
        Controls.Add(txtSisa)
        Controls.Add(label6)
        Controls.Add(btnCari)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnSimpan)
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
        Name = "frmStok"
        Text = "frmStok"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSisa As TextBox
    Friend WithEvents label6 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents txtBeli As TextBox
    Friend WithEvents txtJual As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents label5 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents label As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
