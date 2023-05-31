<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        txtHP = New TextBox()
        label6 = New Label()
        btnCari = New Button()
        btnBatal = New Button()
        btnHapus = New Button()
        btnSimpan = New Button()
        txtKeterangan = New TextBox()
        txtTelepon = New TextBox()
        txtKota = New TextBox()
        txtAlamat = New TextBox()
        txtNama = New TextBox()
        txtKode = New TextBox()
        label5 = New Label()
        label4 = New Label()
        label3 = New Label()
        label2 = New Label()
        label1 = New Label()
        label = New Label()
        SuspendLayout()
        ' 
        ' txtHP
        ' 
        txtHP.Location = New Point(331, 328)
        txtHP.Name = "txtHP"
        txtHP.Size = New Size(291, 23)
        txtHP.TabIndex = 37
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Location = New Point(223, 393)
        label6.Name = "label6"
        label6.Size = New Size(67, 15)
        label6.TabIndex = 36
        label6.Text = "Keterangan"
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(508, 469)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(76, 24)
        btnCari.TabIndex = 35
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(426, 469)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(76, 24)
        btnBatal.TabIndex = 34
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(344, 469)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(76, 24)
        btnHapus.TabIndex = 33
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(262, 469)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(76, 24)
        btnSimpan.TabIndex = 32
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Location = New Point(331, 393)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(291, 23)
        txtKeterangan.TabIndex = 30
        ' 
        ' txtTelepon
        ' 
        txtTelepon.Location = New Point(331, 271)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(291, 23)
        txtTelepon.TabIndex = 29
        ' 
        ' txtKota
        ' 
        txtKota.Location = New Point(331, 218)
        txtKota.Name = "txtKota"
        txtKota.Size = New Size(291, 23)
        txtKota.TabIndex = 28
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(331, 169)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(291, 23)
        txtAlamat.TabIndex = 27
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(331, 117)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(291, 23)
        txtNama.TabIndex = 26
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(331, 68)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(291, 23)
        txtKode.TabIndex = 25
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Point(223, 328)
        label5.Name = "label5"
        label5.Size = New Size(45, 15)
        label5.TabIndex = 24
        label5.Text = "No. HP"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(223, 271)
        label4.Name = "label4"
        label4.Size = New Size(70, 15)
        label4.TabIndex = 23
        label4.Text = "No. Telepon"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(223, 218)
        label3.Name = "label3"
        label3.Size = New Size(31, 15)
        label3.TabIndex = 22
        label3.Text = "Kota"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(223, 169)
        label2.Name = "label2"
        label2.Size = New Size(45, 15)
        label2.TabIndex = 21
        label2.Text = "Alamat"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(223, 117)
        label1.Name = "label1"
        label1.Size = New Size(39, 15)
        label1.TabIndex = 20
        label1.Text = "Nama"
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Location = New Point(223, 68)
        label.Name = "label"
        label.Size = New Size(89, 15)
        label.TabIndex = 19
        label.Text = "Kode Customer"
        ' 
        ' frmCustomer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        ClientSize = New Size(887, 646)
        Controls.Add(txtHP)
        Controls.Add(label6)
        Controls.Add(btnCari)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnSimpan)
        Controls.Add(txtKeterangan)
        Controls.Add(txtTelepon)
        Controls.Add(txtKota)
        Controls.Add(txtAlamat)
        Controls.Add(txtNama)
        Controls.Add(txtKode)
        Controls.Add(label5)
        Controls.Add(label4)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(label1)
        Controls.Add(label)
        Name = "frmCustomer"
        Text = "Data Customer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtHP As TextBox
    Friend WithEvents label6 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtKota As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents label5 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents label As Label
End Class
