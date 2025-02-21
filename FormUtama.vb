Imports MySql.Data.MySqlClient

Public Class FormUtama
    Private Sub loadData()
        bukaKoneksi()
        da = New MySqlDataAdapter("SELECT * FROM pasien", conn)
        ds = New DataSet
        da.Fill(ds, "pasien")
        DataGridView1.DataSource = ds.Tables("pasien")

        If DataGridView1.Rows.Count > 0 AndAlso DataGridView1.CurrentRow IsNot Nothing Then
            If DataGridView1.CurrentRow.Cells("foto").Value IsNot Nothing AndAlso Not IsDBNull(DataGridView1.CurrentRow.Cells("foto").Value) Then
                Dim fotoBytes As Byte() = CType(DataGridView1.CurrentRow.Cells("foto").Value, Byte())
            End If
        End If

        conn.Close()
    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggalLahir.MaxDate = DateTime.Today.AddDays(-1)
        loadData()
    End Sub
    Private Function validasiInput() As Boolean
        If String.IsNullOrEmpty(txtNama.Text) OrElse
           String.IsNullOrEmpty(txtTempatLahir.Text) OrElse
           String.IsNullOrEmpty(txtNomorKTP.Text) OrElse
           String.IsNullOrEmpty(txtNomorBPJS.Text) Then
            MessageBox.Show("Semua isian wajib diisi!")
            Return False
        End If

        If dtpTanggalLahir.Value.Date = DateTime.Today Then
            MessageBox.Show("Tanggal lahir tidak boleh hari ini!")
            Return False
        End If

        If Not IsNumeric(txtNomorKTP.Text) OrElse txtNomorKTP.Text.Length <> 16 Then
            MessageBox.Show("Nomor KTP harus 16 digit angka!")
            Return False
        End If

        If Not IsNumeric(txtNomorBPJS.Text) OrElse txtNomorBPJS.Text.Length <> 13 Then
            MessageBox.Show("Nomor BPJS harus 13 digit angka!")
            Return False
        End If

        Return True
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not validasiInput() Then Return


        Dim fotoBytes As Byte() = Nothing
        If picFoto.Image IsNot Nothing Then
            Using ms As New IO.MemoryStream()
                picFoto.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                fotoBytes = ms.ToArray()
            End Using
        End If

        bukaKoneksi()
        cmd = New MySqlCommand("INSERT INTO pasien (nama, tempat_lahir, tanggal_lahir, nomor_ktp, nomor_bpjs, foto) VALUES (@nama, @tempat_lahir, @tanggal_lahir, @nomor_ktp, @nomor_bpjs, @foto)", conn)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@tempat_lahir", txtTempatLahir.Text)
        cmd.Parameters.AddWithValue("@tanggal_lahir", dtpTanggalLahir.Value)
        cmd.Parameters.AddWithValue("@nomor_ktp", txtNomorKTP.Text)
        cmd.Parameters.AddWithValue("@nomor_bpjs", txtNomorBPJS.Text)
        cmd.Parameters.AddWithValue("@foto", fotoBytes)
        cmd.ExecuteNonQuery()
        conn.Close()
        loadData()
    End Sub
    Private Sub txtNomorKTP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomorKTP.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If txtNomorKTP.Text.Length >= 16 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNomorBPJS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomorBPJS.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If txtNomorBPJS.Text.Length >= 13 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If Not validasiInput() Then Return

        bukaKoneksi()
        cmd = New MySqlCommand("UPDATE pasien SET nama=@nama, tempat_lahir=@tempat_lahir, tanggal_lahir=@tanggal_lahir, nomor_ktp=@nomor_ktp, nomor_bpjs=@nomor_bpjs WHERE id=@id", conn)
        cmd.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@tempat_lahir", txtTempatLahir.Text)
        cmd.Parameters.AddWithValue("@tanggal_lahir", dtpTanggalLahir.Value)
        cmd.Parameters.AddWithValue("@nomor_ktp", txtNomorKTP.Text)
        cmd.Parameters.AddWithValue("@nomor_bpjs", txtNomorBPJS.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        loadData()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        bukaKoneksi()
        cmd = New MySqlCommand("DELETE FROM pasien WHERE id=@id", conn)
        cmd.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
        cmd.ExecuteNonQuery()
        conn.Close()
        loadData()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub PrintDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintDataToolStripMenuItem.Click
        Dim printDialog As New PrintDialog()
        If printDialog.ShowDialog() = DialogResult.OK Then
            Dim printDocument As New Printing.PrintDocument()
            AddHandler printDocument.PrintPage, AddressOf Me.printDocument_PrintPage
            printDocument.Print()
        End If
    End Sub

    Private Sub printDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim font As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)
        Dim y As Integer = 100
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value IsNot Nothing Then
                e.Graphics.DrawString(row.Cells(0).Value.ToString(), font, brush, 100, y)
            End If
            y += 20
        Next
    End Sub

    Private Sub KeluarAplikasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarAplikasiToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnPilihFoto_Click(sender As Object, e As EventArgs) Handles btnPilihFoto.Click
        If ofdPilihFoto.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(ofdPilihFoto.FileName)
        End If
    End Sub
End Class