﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.Serialization.Json
Imports Microsoft.Data.SqlClient

Public Class frmListStok
    Dim query As String
    Dim conn As New SqlConnection
    Dim jenis As String
    Public Sub connect()
        conn.ConnectionString = "Data Source = DESKTOP-OG4H5R3 ; Initial Catalog = JualBeli ; Encrypt = False ; Integrated Security = True"
    End Sub
    Private Sub frmListStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        cboCari.Items.Clear()
        cboCari.Items.Add("Kode")
        cboCari.Items.Add("Nama Stok")
        cboCari.Items.Add("Jenis")

        cboCari.SelectedIndex = 1
        connect()
        Dim cmdOpen As New SqlCommand
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Close()
        cmdOpen.Connection = conn

        query = "SELECT * FROM stok ORDER BY kode_stok"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
        i = 1

        If drOpen.HasRows Then
            While drOpen.Read()
                dgv.Rows.Add(i, drOpen("kode_stok").ToString,
                             drOpen("nama"),
                             drOpen("jenis"),
                             drOpen("sisa_toko"))
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
                    Case "Kode" : jenis = "kode_stok"
                    Case "Nama Stok" : jenis = "nama"
                    Case "Jenis" : jenis = "jenis"
                End Select

                dgv.Rows.Clear()
                query = "SELECT * FROM stok WHERE " & jenis & "LIKE : '%" & Trim(txtCari.Text) & "%'"
                query = query & "ORDER BY kode_stok"
                cmdOpen.CommandText = query
                cmdOpen.ExecuteNonQuery()

                Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
                Dim i As Integer
                i = 1

                If drOpen.HasRows Then
                    While drOpen.Read()
                        dgv.Rows.Add(i, drOpen("kode_stok").ToString,
                                     drOpen("nama"),
                                     drOpen("jenis"),
                                     drOpen("sisa_toko"))
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
                query = "SELECT * FROM stok"
                query = query & "ORDER BY kode_stok"
                cmdOpen.CommandText = query
                cmdOpen.ExecuteNonQuery()

                Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
                Dim i As Integer
                i = 1

                If drOpen.HasRows Then
                    While drOpen.Read()
                        dgv.Rows.Add(i, drOpen("kode_stok").ToString,
                                     drOpen("nama"),
                                     drOpen("jenis"),
                                     drOpen("sisa_toko"))
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
            Select Case vStok
                Case "stok"
                    frmStok.txtKode.Text = dgv.CurrentRow.Cells(1).Value
                    Call frmStok.txtKode_LostFocus(sender, e)
            End Select
            Me.Close()
        End If
    End Sub
    Private Sub dgv_keydown(sender As Object, e As KeyEventArgs) Handles dgv.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgv.CurrentRow.Cells(1).Value <> "" Then
                Select Case vStok
                    Case "stok"
                        frmStok.txtKode.Text = dgv.CurrentRow.Cells(1).Value
                        Call frmStok.txtKode_LostFocus(sender, e)
                End Select
                Me.Close()
            End If
        End If
    End Sub
    Private Sub frmListStok_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If conn.State = ConnectionState.Open Then conn.Close()
        conn = Nothing
    End Sub
End Class