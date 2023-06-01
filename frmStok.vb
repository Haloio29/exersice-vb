Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class frmStok
    Dim query As String
    Dim conn As New SqlConnection
    Public Sub connect()
        conn.ConnectionString = "Data Source = DESKTOP-OG4H5R3 ; Initial Catalog = JualBeli ; Encrypt = False ; Integrated Security = True"
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
    Private Sub frmStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        txtKode.Text = ""
    End Sub
    Public Sub txtKode_LostFocus(sender As Object, e As EventArgs) Handles txtKode.LostFocus
        If Trim(txtKode.Text) <> "" Then
            Dim cmdOpen As New SqlCommand
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn
            query = "SELECT * FROM stok WHERE kode_stok = '" & Trim(txtKode.Text) & "'"
            cmdOpen.CommandText = query

            PictureBox1.Image = Nothing

            Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
            If drOpen.HasRows Then
                While drOpen.Read()
                    txtKode.Text = drOpen("kode_stok").ToString
                    txtNama.Text = drOpen("nama").ToString
                    txtJenis.Text = drOpen("jenis").ToString
                    txtJual.Text = Format(drOpen("harga_jual"), "##,#0.00")
                    txtBeli.Text = Format(drOpen("harga_beli"), "##,#0.00")
                    txtSisa.Text = Format(drOpen("sisa_toko"), "##,##0")
                    txtLokasi.Text = drOpen("lokasi_file").ToString

                    If Trim(txtLokasi.Text) <> "" Then
                        On Error Resume Next
                        PictureBox1.Load(txtLokasi.Text)
                    End If
                End While
            Else
                Clear()
                txtNama.Select()
            End If
            drOpen.Close()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MessageBox.Show("Yakin mau di hapus?", "Ya", MessageBoxButtons.OKCancel) = vbOK Then
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn
            query = "DELETE FROM stok WHERE kode_stok = '" & Trim(txtKode.Text) & "'"
            cmdOpen.CommandText = query
            cmdOpen.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data telah di hapus!")
            Clear()
            txtKode.Select()
            txtKode.Text = ""
        End If
    End Sub

    Private Sub txtJual_LostFocus(sender As Object, e As EventArgs)
        If Not IsNumeric(Trim(txtJual.Text)) Then txtJual.Text = 0
        txtJual.Text = Format(CDec(txtJual.Text), "##,##0.00")
    End Sub
    Private Sub txtBeli_LostFocus(sender As Object, e As EventArgs)
        If Not IsNumeric(Trim(txtBeli.Text)) Then txtBeli.Text = 0
        txtBeli.Text = Format(CDec(txtBeli.Text), "##,##0.00")
    End Sub
    Private Sub txtSisa_LostFocus(sender As Object, e As EventArgs)
        If Not IsNumeric(Trim(txtSisa.Text)) Then txtSisa.Text = 0
        txtSisa.Text = Format(CDec(txtSisa.Text), "##,##0")
    End Sub
    Private Sub frmStok_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        txtNama.Select()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn = Nothing
    End Sub
    Private Sub txtJual_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtBeli_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtSisa_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub frmStok_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        txtNama.Select()
    End Sub
End Class
