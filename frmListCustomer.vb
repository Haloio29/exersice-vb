Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.Serialization.Json
Imports Microsoft.Data.SqlClient

Public Class frmListCustomer
    Dim query As String
    Dim conn As New SqlConnection
    Dim jenis As String
    Public Sub connect()
        conn.ConnectionString = "Data Source = DESKTOP-OG4H5R3 ; Initial Catalog = JualBeli ; Encrypt = False ; Integrated Security = True"
    End Sub
    Private Sub frmListCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        cboCari.Items.Clear()
        cboCari.Items.Add("Kode")
        cboCari.Items.Add("Nama Customer")
        cboCari.Items.Add("Alamat")
        cboCari.Items.Add("Kota")

        cboCari.SelectedIndex = 1
        connect()
        Dim cmdOpen As New SqlCommand
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Close()
        cmdOpen.Connection = conn

        query = "SELECT * FROM customer ORDER BY kode_customer"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
        i = 1

        If drOpen.HasRows Then
            While drOpen.Read()
                dgv.Rows.Add(i, drOpen("kode_customer").ToString,
                             drOpen("nama"),
                             drOpen("alamat"),
                             drOpen("kota"),
                             drOpen("telepon"))
                i = i + 1
            End While
        End If
        drOpen.Close()
        conn.Close()
    End Sub
    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cboCari.Text <> "" Then
                Dim cmdOpen As New SqlCommand
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Close()
                cmdOpen.Connection = conn
                Select Case cboCari.Text
                    Case "Kode" : jenis = "kode_customer"
                    Case "Nama Customer" : jenis = "nama"
                    Case "Alamat" : jenis = "Alamat"
                    Case "Kota" : jenis = "Kota"
                End Select

                dgv.Rows.Clear()
                query = "SELECT * FROM customer WHERE " & jenis & "LIKE : '%" & Trim(txtCari.Text) & "%'"
                query = query & "ORDER BY kode_customer"
                cmdOpen.CommandText = query
                cmdOpen.ExecuteNonQuery()

                Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
                Dim i As Integer
                i = 1

                If drOpen.HasRows Then
                    While drOpen.Read()
                        dgv.Rows.Add(i, drOpen("kode_customer").ToString,
                                    drOpen("nama"),
                                    drOpen("alamat"),
                                    drOpen("kota"),
                                    drOpen("telepon"))
                        i = i + 1
                    End While
                End If
                drOpen.Close()
                conn.Close()
            Else
                Dim cmdOpen As New SqlCommand
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                cmdOpen.Connection = conn

                dgv.Rows.Clear()
                query = "SELECT * FROM customer"
                query = query & "ORDER BY kode_customer"
                cmdOpen.CommandText = query
                cmdOpen.ExecuteNonQuery()

                Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
                Dim i As Integer
                i = 1

                If drOpen.HasRows Then
                    While drOpen.Read()
                        dgv.Rows.Add(i, drOpen("kode_customer").ToString,
                                    drOpen("nama"),
                                    drOpen("alamat"),
                                    drOpen("kota"),
                                    drOpen("telepon"))
                        i = i + 1
                    End While
                End If
                drOpen.Close()
                conn.Close()
            End If
        End If
    End Sub
    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If dgv.CurrentRow.Cells(1).Value <> "" Then
            Select Case vCustomer
                Case "customer"
                    frmCustomer.txtKode.Text = dgv.CurrentRow.Cells(1).Value
                    Call frmCustomer.txtKode_LostFocus(sender, e)
            End Select
            Me.Close()
        End If
    End Sub
    Private Sub dgv_keydown(sender As Object, e As KeyEventArgs) Handles dgv.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgv.CurrentRow.Cells(1).Value <> "" Then
                Select Case vCustomer
                    Case "customer"
                        frmCustomer.txtKode.Text = dgv.CurrentRow.Cells(1).Value
                        Call frmCustomer.txtKode_LostFocus(sender, e)
                End Select
                Me.Close()
            End If
        End If
    End Sub
    Private Sub frmListCustomer_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If conn.State = ConnectionState.Open Then conn.Close()
        conn = Nothing
    End Sub
End Class