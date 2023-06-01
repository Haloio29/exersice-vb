<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListSupplier
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
        dgv = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        txtCari = New TextBox()
        cboCari = New ComboBox()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        dgv.Location = New Point(31, 55)
        dgv.Name = "dgv"
        dgv.RowTemplate.Height = 25
        dgv.Size = New Size(643, 343)
        dgv.TabIndex = 8
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
        Column3.HeaderText = "Nama Supplier"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Alamat"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Kota"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Telepon"
        Column6.Name = "Column6"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(278, 17)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(396, 23)
        txtCari.TabIndex = 7
        ' 
        ' cboCari
        ' 
        cboCari.FormattingEnabled = True
        cboCari.Location = New Point(31, 17)
        cboCari.Name = "cboCari"
        cboCari.Size = New Size(220, 23)
        cboCari.TabIndex = 6
        ' 
        ' frmListSupplier
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(694, 423)
        Controls.Add(dgv)
        Controls.Add(txtCari)
        Controls.Add(cboCari)
        Name = "frmListSupplier"
        Text = "frmListSupplier"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents txtCari As TextBox
    Friend WithEvents cboCari As ComboBox
End Class
