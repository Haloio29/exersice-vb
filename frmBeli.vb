Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class frmBeli
    Private sAda As Boolean
    Dim query As String
    Private conn As New SqlConnection
    Public Sub connect()
        conn.ConnectionString = "Data Source = DESKTOP-OG4H5R3 ; Initial Catalog = JualBeli ; Encrypt = False ; Integrated Security = True"
    End Sub
    Sub clear()
        txtKode.Text = AutoCode("Beli", Now.Date)
        txtKode_C.Text = ""
        txtNama_C.Text = ""
        dtpTanggal.Value = Now.Date
        txtKeterangan.Text = ""
        txtKode_S.Text = ""
        txtNama_S.Text = ""
        txtQty.Text = ""
        txtHarga.Text = ""
        txtSubTotal.Text = ""
        dgvDetail.Rows.Clear()
        txtTotal.Text = ""
        dgvDetail.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetail.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetail.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetail.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetail.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetail.Columns(2).DefaultCellStyle.Format = "##,##0"
        dgvDetail.Columns(3).DefaultCellStyle.Format = "##,##0.00"
        dgvDetail.Columns(4).DefaultCellStyle.Format = "##,##0.00"
        gbStok.Visible = False
        picStok.Image = Nothing
        txtKode_C.Select()
    End Sub
    Private Sub frmBeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        txtKode.Text = ""
        clear()
        gbStok.Visible = False
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not IsNumeric(Trim(txtTotal.Text)) Then txtTotal.Text = 0

        Dim cmdOpen As New SqlCommand

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn
        query = "SELECT * FROM beli WHERE no_beli = '" & Trim(txtKode.Text) & "'"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        If drOpen.HasRows Then
            sAda = True
            query = "UPDATE beli SET" &
                    "kode_supplier = '" & Trim(txtKode_C.Text) & "'," &
                    "tanggal = '" & Format(dtpTanggal.Value, "yyyy-MM-dd") & "'," &
                    "keterangan = '" & Trim(txtKeterangan.Text) & "'," &
                    "total = '" & CDec(Trim(txtTotal.Text)) &
                    "WHERE no_beli = '" & Trim(txtKode.Text) & "'"
        Else
            sAda = False
            query = "INSERT INTO beli VALUES('" & Trim(txtKode.Text) & "','" &
                    Trim(txtKode_C.Text) & "','" &
                    Format(dtpTanggal.Value, "yyyy-MM-dd") & "','" &
                    Trim(txtKeterangan.Text) & "'," &
                    CDec(Trim(txtTotal.Text)) & ")"
        End If
        drOpen.Close()
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()
    End Sub
End Class