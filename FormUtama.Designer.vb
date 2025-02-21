<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormPasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtTempatLahir = New System.Windows.Forms.TextBox()
        Me.txtNomorKTP = New System.Windows.Forms.TextBox()
        Me.txtNomorBPJS = New System.Windows.Forms.TextBox()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.btnPilihFoto = New System.Windows.Forms.Button()
        Me.ofdPilihFoto = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.MasterToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(708, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "Profil"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.PrintDataToolStripMenuItem, Me.KeluarAplikasiToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(47, 20)
        Me.ToolStripMenuItem1.Text = "Profil"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'PrintDataToolStripMenuItem
        '
        Me.PrintDataToolStripMenuItem.Name = "PrintDataToolStripMenuItem"
        Me.PrintDataToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintDataToolStripMenuItem.Text = "Print Data"
        '
        'KeluarAplikasiToolStripMenuItem
        '
        Me.KeluarAplikasiToolStripMenuItem.Name = "KeluarAplikasiToolStripMenuItem"
        Me.KeluarAplikasiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KeluarAplikasiToolStripMenuItem.Text = "Keluar Aplikasi"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.BackColor = System.Drawing.Color.YellowGreen
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormPasienToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'FormPasienToolStripMenuItem
        '
        Me.FormPasienToolStripMenuItem.Name = "FormPasienToolStripMenuItem"
        Me.FormPasienToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FormPasienToolStripMenuItem.Text = "Form Pasien"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tempat Lahir :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tanggal Lahir :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(123, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nomor KTP :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nomor BPJS :"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(170, 236)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(100, 32)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(248, 90)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(258, 20)
        Me.txtNama.TabIndex = 7
        '
        'txtTempatLahir
        '
        Me.txtTempatLahir.Location = New System.Drawing.Point(248, 116)
        Me.txtTempatLahir.Name = "txtTempatLahir"
        Me.txtTempatLahir.Size = New System.Drawing.Size(258, 20)
        Me.txtTempatLahir.TabIndex = 8
        '
        'txtNomorKTP
        '
        Me.txtNomorKTP.Location = New System.Drawing.Point(248, 168)
        Me.txtNomorKTP.Name = "txtNomorKTP"
        Me.txtNomorKTP.Size = New System.Drawing.Size(258, 20)
        Me.txtNomorKTP.TabIndex = 10
        '
        'txtNomorBPJS
        '
        Me.txtNomorBPJS.Location = New System.Drawing.Point(248, 194)
        Me.txtNomorBPJS.Name = "txtNomorBPJS"
        Me.txtNomorBPJS.Size = New System.Drawing.Size(258, 20)
        Me.txtNomorBPJS.TabIndex = 11
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(286, 236)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(100, 32)
        Me.btnUbah.TabIndex = 12
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(406, 236)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 32)
        Me.btnHapus.TabIndex = 13
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 288)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(708, 162)
        Me.DataGridView1.TabIndex = 14
        '
        'dtpTanggalLahir
        '
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(249, 142)
        Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(257, 20)
        Me.dtpTanggalLahir.TabIndex = 15
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(533, 86)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(131, 128)
        Me.picFoto.TabIndex = 16
        Me.picFoto.TabStop = False
        '
        'btnPilihFoto
        '
        Me.btnPilihFoto.Location = New System.Drawing.Point(552, 220)
        Me.btnPilihFoto.Name = "btnPilihFoto"
        Me.btnPilihFoto.Size = New System.Drawing.Size(100, 21)
        Me.btnPilihFoto.TabIndex = 17
        Me.btnPilihFoto.Text = "Pilih Foto"
        Me.btnPilihFoto.UseVisualStyleBackColor = True
        '
        'ofdPilihFoto
        '
        Me.ofdPilihFoto.FileName = "OpenFileDialog1"
        Me.ofdPilihFoto.Filter = "Gambar (*.jpg; *.png; *.bmp)|*.jpg;*.png;*.bmp"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(81, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(542, 33)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Aplikasi Pencatatan Data Pasien"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(708, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnPilihFoto)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Me.dtpTanggalLahir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.txtNomorBPJS)
        Me.Controls.Add(Me.txtNomorKTP)
        Me.Controls.Add(Me.txtTempatLahir)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FormUtama"
        Me.Text = "Form Utama"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarAplikasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormPasienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtTempatLahir As TextBox
    Friend WithEvents txtNomorKTP As TextBox
    Friend WithEvents txtNomorBPJS As TextBox
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnPilihFoto As Button
    Friend WithEvents ofdPilihFoto As OpenFileDialog
    Friend WithEvents Label6 As Label
End Class
