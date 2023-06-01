<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListStok
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
        cboCari = New ComboBox()
        txtCari = New TextBox()
        dgv = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cboCari
        ' 
        cboCari.FormattingEnabled = True
        cboCari.Location = New Point(22, 12)
        cboCari.Name = "cboCari"
        cboCari.Size = New Size(121, 23)
        cboCari.TabIndex = 0
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(167, 12)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(396, 23)
        txtCari.TabIndex = 1
        ' 
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgv.Location = New Point(22, 50)
        dgv.Name = "dgv"
        dgv.RowTemplate.Height = 25
        dgv.Size = New Size(541, 343)
        dgv.TabIndex = 2
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "No"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Kode"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Nama Stok"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Jenis"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Sisa Toko"
        Column5.Name = "Column5"
        ' 
        ' frmListStok
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(589, 411)
        Controls.Add(dgv)
        Controls.Add(txtCari)
        Controls.Add(cboCari)
        Name = "frmListStok"
        Text = "frmListStok"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboCari As ComboBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
