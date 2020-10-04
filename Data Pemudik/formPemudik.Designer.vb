<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPemudik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPemudik))
        Me.warga = New System.Windows.Forms.DataGridView()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SimpanDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanPerubahanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CariDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.HapusDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshTabelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpKedatangan = New System.Windows.Forms.DateTimePicker()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.cmbJenkel = New System.Windows.Forms.ComboBox()
        Me.txtPekerjaan = New System.Windows.Forms.TextBox()
        Me.txtNIK = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbNama = New System.Windows.Forms.RadioButton()
        Me.rbNIK = New System.Windows.Forms.RadioButton()
        Me.rbPekerjaan = New System.Windows.Forms.RadioButton()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.rbKota = New System.Windows.Forms.RadioButton()
        CType(Me.warga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'warga
        '
        Me.warga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.warga.Location = New System.Drawing.Point(158, 27)
        Me.warga.Name = "warga"
        Me.warga.Size = New System.Drawing.Size(1100, 374)
        Me.warga.TabIndex = 0
        '
        'menuStrip
        '
        Me.menuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.BantuanToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(1270, 24)
        Me.menuStrip.TabIndex = 2
        Me.menuStrip.Text = "MenuStrip1"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBaruToolStripMenuItem, Me.ToolStripSeparator1, Me.SimpanDataToolStripMenuItem, Me.SimpanPerubahanToolStripMenuItem, Me.ToolStripSeparator2, Me.CariDataToolStripMenuItem, Me.ToolStripSeparator3, Me.HapusDataToolStripMenuItem, Me.ToolStripSeparator5, Me.RefreshTabelToolStripMenuItem, Me.ToolStripSeparator4, Me.KeluarToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'DataBaruToolStripMenuItem
        '
        Me.DataBaruToolStripMenuItem.Name = "DataBaruToolStripMenuItem"
        Me.DataBaruToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DataBaruToolStripMenuItem.Text = "Data Baru"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'SimpanDataToolStripMenuItem
        '
        Me.SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        Me.SimpanDataToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SimpanDataToolStripMenuItem.Text = "Simpan Data"
        '
        'SimpanPerubahanToolStripMenuItem
        '
        Me.SimpanPerubahanToolStripMenuItem.Name = "SimpanPerubahanToolStripMenuItem"
        Me.SimpanPerubahanToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SimpanPerubahanToolStripMenuItem.Text = "Simpan Perubahan"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(171, 6)
        '
        'CariDataToolStripMenuItem
        '
        Me.CariDataToolStripMenuItem.Name = "CariDataToolStripMenuItem"
        Me.CariDataToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CariDataToolStripMenuItem.Text = "Cari Data"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(171, 6)
        '
        'HapusDataToolStripMenuItem
        '
        Me.HapusDataToolStripMenuItem.Name = "HapusDataToolStripMenuItem"
        Me.HapusDataToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.HapusDataToolStripMenuItem.Text = "Hapus Data"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(171, 6)
        '
        'RefreshTabelToolStripMenuItem
        '
        Me.RefreshTabelToolStripMenuItem.Name = "RefreshTabelToolStripMenuItem"
        Me.RefreshTabelToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.RefreshTabelToolStripMenuItem.Text = "Refresh Tabel"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(171, 6)
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TentangToolStripMenuItem})
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.BantuanToolStripMenuItem.Text = "Bantuan"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpKedatangan)
        Me.GroupBox1.Controls.Add(Me.txtKota)
        Me.GroupBox1.Controls.Add(Me.cmbJenkel)
        Me.GroupBox1.Controls.Add(Me.txtPekerjaan)
        Me.GroupBox1.Controls.Add(Me.txtNIK)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSaveNew)
        Me.GroupBox1.Font = New System.Drawing.Font("Balloon Bd BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SeaShell
        Me.GroupBox1.Location = New System.Drawing.Point(158, 407)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 276)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Input Data Pemudik"
        '
        'dtpKedatangan
        '
        Me.dtpKedatangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpKedatangan.Location = New System.Drawing.Point(178, 216)
        Me.dtpKedatangan.Name = "dtpKedatangan"
        Me.dtpKedatangan.Size = New System.Drawing.Size(200, 26)
        Me.dtpKedatangan.TabIndex = 6
        '
        'txtKota
        '
        Me.txtKota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKota.Location = New System.Drawing.Point(178, 176)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(200, 26)
        Me.txtKota.TabIndex = 5
        '
        'cmbJenkel
        '
        Me.cmbJenkel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenkel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJenkel.FormattingEnabled = True
        Me.cmbJenkel.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cmbJenkel.Location = New System.Drawing.Point(178, 102)
        Me.cmbJenkel.Name = "cmbJenkel"
        Me.cmbJenkel.Size = New System.Drawing.Size(200, 28)
        Me.cmbJenkel.TabIndex = 3
        '
        'txtPekerjaan
        '
        Me.txtPekerjaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPekerjaan.Location = New System.Drawing.Point(178, 140)
        Me.txtPekerjaan.Name = "txtPekerjaan"
        Me.txtPekerjaan.Size = New System.Drawing.Size(200, 26)
        Me.txtPekerjaan.TabIndex = 4
        '
        'txtNIK
        '
        Me.txtNIK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIK.Location = New System.Drawing.Point(178, 26)
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.Size = New System.Drawing.Size(200, 26)
        Me.txtNIK.TabIndex = 1
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(178, 64)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(200, 26)
        Me.txtNama.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tanggal Kedatangan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Kota Rantauan"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnDelete.Location = New System.Drawing.Point(384, 188)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(280, 80)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Hapus Data"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pekerjaan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Jenis Kelamin"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.Location = New System.Drawing.Point(384, 105)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(280, 80)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Simpan Perubahan Data"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Lengkap"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NIK"
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNew.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSaveNew.Location = New System.Drawing.Point(384, 22)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(280, 80)
        Me.btnSaveNew.TabIndex = 7
        Me.btnSaveNew.Text = "Simpan Sebagai Data Baru"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!)
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRefresh.Location = New System.Drawing.Point(12, 625)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(140, 50)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh Tabel"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancel.Location = New System.Drawing.Point(12, 351)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(140, 50)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Batal"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.Location = New System.Drawing.Point(12, 295)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(140, 50)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Bersihkan"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnInput.Location = New System.Drawing.Point(12, 239)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(140, 50)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Data_Pemudik.My.Resources.Resources.stick_traveler_icon_1320087275727511390
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Balloon Bd BT", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Tomato
        Me.Label7.Location = New System.Drawing.Point(11, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 29)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Data Pemudik"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Balloon Bd BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SeaShell
        Me.Label8.Location = New System.Drawing.Point(57, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 22)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "v 2.0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbKota)
        Me.GroupBox2.Controls.Add(Me.rbNama)
        Me.GroupBox2.Controls.Add(Me.rbNIK)
        Me.GroupBox2.Controls.Add(Me.rbPekerjaan)
        Me.GroupBox2.Controls.Add(Me.btnCari)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtCari)
        Me.GroupBox2.Font = New System.Drawing.Font("Balloon Bd BT", 14.25!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.SeaShell
        Me.GroupBox2.Location = New System.Drawing.Point(834, 407)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 276)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Form Pencarian Data"
        '
        'rbNama
        '
        Me.rbNama.AutoSize = True
        Me.rbNama.Checked = True
        Me.rbNama.Location = New System.Drawing.Point(6, 93)
        Me.rbNama.Name = "rbNama"
        Me.rbNama.Size = New System.Drawing.Size(130, 26)
        Me.rbNama.TabIndex = 19
        Me.rbNama.TabStop = True
        Me.rbNama.Text = "Nama Lengkap"
        Me.rbNama.UseVisualStyleBackColor = True
        '
        'rbNIK
        '
        Me.rbNIK.AutoSize = True
        Me.rbNIK.Location = New System.Drawing.Point(6, 64)
        Me.rbNIK.Name = "rbNIK"
        Me.rbNIK.Size = New System.Drawing.Size(52, 26)
        Me.rbNIK.TabIndex = 18
        Me.rbNIK.Text = "NIK"
        Me.rbNIK.UseVisualStyleBackColor = True
        '
        'rbPekerjaan
        '
        Me.rbPekerjaan.AutoSize = True
        Me.rbPekerjaan.Location = New System.Drawing.Point(6, 125)
        Me.rbPekerjaan.Name = "rbPekerjaan"
        Me.rbPekerjaan.Size = New System.Drawing.Size(103, 26)
        Me.rbPekerjaan.TabIndex = 17
        Me.rbPekerjaan.Text = "Pekerjaan"
        Me.rbPekerjaan.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCari.Location = New System.Drawing.Point(10, 188)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(408, 80)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "Cari Data"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Kata Kunci"
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Balloon Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(212, 23)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(200, 32)
        Me.txtCari.TabIndex = 1
        '
        'rbKota
        '
        Me.rbKota.AutoSize = True
        Me.rbKota.Location = New System.Drawing.Point(6, 156)
        Me.rbKota.Name = "rbKota"
        Me.rbKota.Size = New System.Drawing.Size(138, 26)
        Me.rbKota.TabIndex = 20
        Me.rbKota.Text = "Kota Rantauan"
        Me.rbKota.UseVisualStyleBackColor = True
        '
        'formPemudik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1270, 687)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.warga)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.Name = "formPemudik"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pemudik v 2.0"
        CType(Me.warga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents warga As System.Windows.Forms.DataGridView
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBaruToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SimpanDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpanPerubahanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CariDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HapusDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSaveNew As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpKedatangan As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents cmbJenkel As System.Windows.Forms.ComboBox
    Friend WithEvents txtPekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents txtNIK As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents BantuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshTabelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents rbNama As System.Windows.Forms.RadioButton
    Friend WithEvents rbNIK As System.Windows.Forms.RadioButton
    Friend WithEvents rbPekerjaan As System.Windows.Forms.RadioButton
    Friend WithEvents rbKota As System.Windows.Forms.RadioButton
End Class
