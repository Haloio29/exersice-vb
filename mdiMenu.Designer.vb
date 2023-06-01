<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiMenu
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
        MenuStrip1 = New MenuStrip()
        MasterToolStripMenuItem = New ToolStripMenuItem()
        StokToolStripMenuItem = New ToolStripMenuItem()
        CustomerToolStripMenuItem = New ToolStripMenuItem()
        SupplierToolStripMenuItem = New ToolStripMenuItem()
        PaketToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        SettingToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MasterToolStripMenuItem, TransaksiToolStripMenuItem, LaporanToolStripMenuItem, SettingToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MasterToolStripMenuItem
        ' 
        MasterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StokToolStripMenuItem, CustomerToolStripMenuItem, SupplierToolStripMenuItem, PaketToolStripMenuItem, KeluarToolStripMenuItem})
        MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        MasterToolStripMenuItem.Size = New Size(55, 20)
        MasterToolStripMenuItem.Text = "Master"
        ' 
        ' StokToolStripMenuItem
        ' 
        StokToolStripMenuItem.Name = "StokToolStripMenuItem"
        StokToolStripMenuItem.Size = New Size(180, 22)
        StokToolStripMenuItem.Text = "Stok"
        ' 
        ' CustomerToolStripMenuItem
        ' 
        CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        CustomerToolStripMenuItem.Size = New Size(180, 22)
        CustomerToolStripMenuItem.Text = "Customer"
        ' 
        ' SupplierToolStripMenuItem
        ' 
        SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        SupplierToolStripMenuItem.Size = New Size(180, 22)
        SupplierToolStripMenuItem.Text = "Supplier"
        ' 
        ' PaketToolStripMenuItem
        ' 
        PaketToolStripMenuItem.Name = "PaketToolStripMenuItem"
        PaketToolStripMenuItem.Size = New Size(180, 22)
        PaketToolStripMenuItem.Text = "Paket"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(180, 22)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TransaksiToolStripMenuItem
        ' 
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        TransaksiToolStripMenuItem.Size = New Size(66, 20)
        TransaksiToolStripMenuItem.Text = "Transaksi"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(62, 20)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' SettingToolStripMenuItem
        ' 
        SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        SettingToolStripMenuItem.Size = New Size(56, 20)
        SettingToolStripMenuItem.Text = "Setting"
        ' 
        ' mdiMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "mdiMenu"
        Text = "mdiMenu"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
End Class
