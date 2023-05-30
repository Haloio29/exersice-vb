Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Form1
    Dim query As String
    Dim conn As New SqlConnection
    Public Sub connect()
        conn.ConnectionString = "Data Source = DESKTOP-OG4H5R3 ; Initial Catalog = JualBeli ; Encrypt=False ; Integrated Security = True"
    End Sub
    Sub Clear()
        txtNama.Text = ""
        txtJenis.Text = ""
        txtJual.Text = 0
        txtBeli.Text = 0
        txtSisa.Text = 0
        txtLokasi.Text = ""
        PictureBox1.Image = Nothing
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        txtKode.Text = ""
        Clear()
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtLokasi.Text = OpenFileDialog1.FileName
        PictureBox1.Load(txtLokasi.Text)
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim cmdOpen As New SqlCommand
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn
        query = "SELECT * FROM stok WHERE kode_stok ='" & Trim(txtKode.Text) & "'"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
        If drOpen.HasRows Then
            query = "update stock set" &
                    "nama = '" & Trim(txtNama.Text) & "'," &
                    "jenis = '" & Trim(txtJenis.Text) & "'," &
                    "harga_jual = " & CDec(Trim(txtJual.Text)) & "," &
                    "harga_beli = " & CDec(Trim(txtBeli.Text)) & "," &
                    "lokasi_file = '" & Trim(txtLokasi.Text) & "'," &
                    "sisa_toko = " & CInt(Trim(txtSisa.Text)) &
                    "WHERE kode_stok = '" & Trim(txtKode.Text) & "'"
        Else
            query = "INSERT INTO stok VALUES ('" & Trim(txtKode.Text) & "',
                    '" & Trim(txtNama.Text) & "', 
                    '" & Trim(txtJenis.Text) & "', 
                    '" & CDec(Trim(txtJual.Text)) & "',
                    '" & CDec(Trim(txtBeli.Text)) & "',
                    '" & CDec(Trim(txtSisa.Text)) & "',
                    '" & Trim(txtLokasi.Text) & "')"
        End If
        drOpen.Close()
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        conn.Close()

        MessageBox.Show("Data telah di simpan!!!")
        Clear()
        txtKode.Select()
    End Sub
End Class
