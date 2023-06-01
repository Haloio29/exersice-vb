Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class frmSupplier
    Dim query As String
    Dim conn As New SqlConnection
    Public Sub connect()
        conn.ConnectionString = "Data Source = DESKTOP-OG4H5R3 ; Initial Catalog = JualBeli ; Encrypt = False ; Integrated Security = True"
    End Sub
    Sub Clear()
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtKota.Text = ""
        txtTelepon.Text = ""
        txtHP.Text = ""
        txtKeterangan.Text = ""
    End Sub
    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        txtKode.Text = ""
        Clear()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim cmdOpen As New SqlCommand
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn
        query = "SELECT * FROM supplier WHERE kode_supplier ='" & Trim(txtKode.Text) & "'"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        If drOpen.HasRows Then
            query = "update supplier set" &
                    "nama = '" & Trim(txtNama.Text) & "'," &
                    "alamat = '" & Trim(txtAlamat.Text) & "'," &
                    "kota = " & CDec(Trim(txtKota.Text)) & "," &
                    "telepon = " & CDec(Trim(txtTelepon.Text)) & "," &
                    "hp = '" & Trim(txtHP.Text) & "'," &
                    "keterangan = " & CInt(Trim(txtKeterangan.Text)) &
                    "WHERE kode_supplier = '" & Trim(txtKode.Text) & "'"
        Else
            query = "INSERT INTO supplier VALUES ('" & Trim(txtKode.Text) & "',
                    '" & Trim(txtNama.Text) & "', 
                    '" & Trim(txtAlamat.Text) & "', 
                    '" & CDec(Trim(txtKota.Text)) & "',
                    '" & CDec(Trim(txtTelepon.Text)) & "',
                    '" & CDec(Trim(txtHP.Text)) & "',
                    '" & Trim(txtKeterangan.Text) & "')"
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
            query = "SELECT * FROM supplier WHERE kode_supplier = '" & Trim(txtKode.Text) & "'"
            cmdOpen.CommandText = query

            Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
            If drOpen.HasRows Then
                While drOpen.Read()
                    txtKode.Text = drOpen("kode_supplier").ToString
                    txtNama.Text = drOpen("nama").ToString
                    txtAlamat.Text = drOpen("alamat").ToString
                    txtKota.Text = drOpen("kota").ToString
                    txtTelepon.Text = drOpen("telepon").ToString
                    txtHP.Text = drOpen("hp").ToString
                    txtKeterangan.Text = drOpen("keterangan").ToString
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
            query = "DELETE FROM supplier WHERE kode_supplier = '" & Trim(txtKode.Text) & "'"
            cmdOpen.CommandText = query
            cmdOpen.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data telah di hapus!")
            Clear()
            txtKode.Select()
            txtKode.Text = ""
        End If
    End Sub
    Private Sub frmSupplier_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        txtNama.Select()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn = Nothing
    End Sub
    Private Sub frmSupplier_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        txtNama.Select()
    End Sub
End Class
