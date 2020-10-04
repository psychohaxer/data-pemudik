Imports Data_Pemudik.koneksi
Imports MySql.Data.MySqlClient

Public Class formPemudik
    Dim conn As New MySqlConnection("server=localhost; user id=root; database=pemudik;Convert Zero Datetime=True")
    'Dim conn As New MySqlConnection("server=localhost; user id=root; database=pemudik;")
    Dim perintah As New MySqlCommand
    Dim data As New MySqlDataAdapter
    Dim ds As New DataSet

    Private Sub formPemudik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showData()
        dtpKedatangan.Format = DateTimePickerFormat.Custom
        dtpKedatangan.CustomFormat = "yyyy/MM/dd"
        disableForm()
    End Sub

    Private Sub clearForm()
        txtNIK.Text = ""
        txtNama.Text = ""
        cmbJenkel.Text = ""
        txtPekerjaan.Text = ""
        txtKota.Text = ""
        dtpKedatangan.Text = ""

        txtNIK.Focus()
    End Sub

    Private Sub disableForm()
        txtNIK.Enabled = False
        txtNama.Enabled = False
        cmbJenkel.Enabled = False
        txtPekerjaan.Enabled = False
        txtKota.Enabled = False
        dtpKedatangan.Enabled = False

        btnSaveNew.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False

        SimpanDataToolStripMenuItem.Enabled = False
        SimpanPerubahanToolStripMenuItem.Enabled = False
        HapusDataToolStripMenuItem.Enabled = False

        clearForm()
    End Sub

    Private Sub enableFormInput()
        txtNIK.Enabled = True
        txtNama.Enabled = True
        cmbJenkel.Enabled = True
        txtPekerjaan.Enabled = True
        txtKota.Enabled = True
        dtpKedatangan.Enabled = True

        btnSaveNew.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False

        SimpanDataToolStripMenuItem.Enabled = True
        SimpanPerubahanToolStripMenuItem.Enabled = False
        HapusDataToolStripMenuItem.Enabled = False
    End Sub

    Private Sub enableFormEdit()
        txtNIK.Enabled = True
        txtNama.Enabled = True
        cmbJenkel.Enabled = True
        txtPekerjaan.Enabled = True
        txtKota.Enabled = True
        dtpKedatangan.Enabled = True

        btnSaveNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = True

        SimpanDataToolStripMenuItem.Enabled = False
        SimpanPerubahanToolStripMenuItem.Enabled = True
        HapusDataToolStripMenuItem.Enabled = True
    End Sub

    'Private Sub showData(Optional ByVal blnSearch As Boolean = False)
    Private Sub showData()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim sqlstr As String
        Dim data As Integer

        sqlstr = "SELECT nik,nama,jenis_kelamin,pekerjaan,kota_rantauan,tanggal_kedatangan FROM warga"
        adapter = New MySqlDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        'If blnSearch Then
        '    sqlstr = sqlstr & _
        '        " WHERE " & _
        '        " [nik] " & " Like '%" & txtCari.Text & "%'" & " OR " & _
        '        " [nama] " & " Like '%" & txtCari.Text & "%'" & " OR " & _
        '        " [jenis_kelamin] " & " Like '%" & txtCari.Text & "%'" & " OR " & _
        '        " [pekerjaan] " & " Like '%" & txtCari.Text & "%'" & " OR " & _
        '        " [kota_rantauan] " & " Like '%" & txtCari.Text & "%'" & " OR " & _
        '        " [tanggal_kedatangan] " & " Like '%" & txtCari.Text & "%'" & " OR " & _
        '        " ORDER BY tanggal_kedatangan "
        'Else
        '    sqlstr = sqlstr & " ORDER BY tanggal_kedatangan"
        'End If

        If data > 0 Then
            With warga
                .DataSource = dt
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(0).HeaderText = "NIK"
                .Columns(1).HeaderText = "Nama Lengkap"
                .Columns(2).HeaderText = "Jenis Kelamin"
                .Columns(3).HeaderText = "Pekerjaan"
                .Columns(4).HeaderText = "Kota Rantauan"
                .Columns(5).HeaderText = "Tanggal Kedatangan"

                .RowHeadersVisible = False
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToResizeRows = False
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .ReadOnly = True

                .Sort(.Columns(5), System.ComponentModel.ListSortDirection.Ascending)

                .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                With .ColumnHeadersDefaultCellStyle
                    .BackColor = Color.Navy
                    .ForeColor = Color.Black
                    .Font = New Font("Tahoma", 9, FontStyle.Bold)
                End With
            End With
        Else
            warga.DataSource = Nothing
        End If
        clearForm()
    End Sub

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        clearForm()
        enableFormInput()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearForm()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        disableForm()
    End Sub

    Private Sub btnSaveNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveNew.Click
        conn.Open()
        Try
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "INSERT INTO warga (nik,nama,jenis_kelamin,pekerjaan,kota_rantauan,tanggal_kedatangan) values('" & txtNIK.Text & "','" & txtNama.Text & "','" & cmbJenkel.Text & "','" & txtPekerjaan.Text & "','" & txtKota.Text & "','" & dtpKedatangan.Text & "')"
            perintah.Connection = conn
            perintah.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan sebagai data baru.", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox("Data gagal disimpan" + ex.Message, MsgBoxStyle.Critical)
        End Try
        conn.Close()

        showData()
        enableFormInput()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        conn.Open()
        Try
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "UPDATE warga SET nik='" & txtNIK.Text & "',nama='" & txtNama.Text & "',jenis_kelamin='" & cmbJenkel.Text & "',pekerjaan='" & txtPekerjaan.Text & "',kota_rantauan='" & txtKota.Text & "',tanggal_kedatangan='" & dtpKedatangan.Text & "' WHERE nik='" & txtNIK.Text & "';"
            perintah.Connection = conn
            perintah.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan.", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox("Data gagal disimpan" + ex.Message, MsgBoxStyle.Critical)
        End Try
        conn.Close()

        showData()
        disableForm()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        conn.Open()
        Try
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "DELETE FROM warga WHERE nik='" & txtNIK.Text & "';"
            perintah.Connection = conn
            perintah.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus.", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox("Data gagal dihapus" + ex.Message, MsgBoxStyle.Critical)
        End Try
        conn.Close()
        showData()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        showData()
    End Sub

    Private Sub warga_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles warga.DoubleClick
        Dim baris As Integer

        baris = warga.CurrentRow.Index

        txtNIK.Text = "" & warga.Item(0, baris).Value
        txtNama.Text = "" & warga.Item(1, baris).Value
        cmbJenkel.Text = "" & warga.Item(2, baris).Value
        txtPekerjaan.Text = "" & warga.Item(3, baris).Value
        txtKota.Text = "" & warga.Item(4, baris).Value
        dtpKedatangan.Text = "" & warga.Item(5, baris).Value

        enableFormEdit()
    End Sub

    Private Sub DataBaruToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBaruToolStripMenuItem.Click
        clearForm()
        enableFormInput()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanDataToolStripMenuItem.Click
        conn.Open()
        Try
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "INSERT INTO warga (nik,nama,jenis_kelamin,pekerjaan,kota_rantauan,tanggal_kedatangan) values('" & txtNIK.Text & "','" & txtNama.Text & "','" & cmbJenkel.Text & "','" & txtPekerjaan.Text & "','" & txtKota.Text & "','" & dtpKedatangan.Text & "')"
            perintah.Connection = conn
            perintah.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan sebagai data baru.", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox("Data gagal disimpan" + ex.Message, MsgBoxStyle.Critical)
        End Try
        conn.Close()

        showData()
        enableFormInput()
    End Sub

    Private Sub SimpanPerubahanMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanPerubahanToolStripMenuItem.Click
        conn.Open()
        Try
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "UPDATE warga SET nik='" & txtNIK.Text & "',nama='" & txtNama.Text & "',jenis_kelamin='" & cmbJenkel.Text & "',pekerjaan='" & txtPekerjaan.Text & "',kota_rantauan='" & txtKota.Text & "',tanggal_kedatangan='" & dtpKedatangan.Text & "' WHERE nik='" & txtNIK.Text & "';"
            perintah.Connection = conn
            perintah.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan.", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox("Data gagal disimpan" + ex.Message, MsgBoxStyle.Critical)
        End Try
        conn.Close()

        showData()
        disableForm()
    End Sub

    Private Sub CariDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariDataToolStripMenuItem.Click
        txtCari.Focus()
    End Sub

    Private Sub HapusDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusDataToolStripMenuItem.Click
        conn.Open()
        Try
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "DELETE FROM warga WHERE nik='" & txtNIK.Text & "';"
            perintah.Connection = conn
            perintah.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus.", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox("Data gagal dihapus" + ex.Message, MsgBoxStyle.Critical)
        End Try
        conn.Close()
        showData()
    End Sub

    Private Sub RefreshTabelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshTabelToolStripMenuItem.Click
        showData()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TentangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TentangToolStripMenuItem.Click
        MsgBox("Aplikasi ini dibuat oleh:" & vbCrLf & "201951050 – M. Izzul Haq" & vbCrLf & "201951056 – M. Syar’I Effendi" & vbCrLf & "201951071 – Firman Adi Nur Fatin" & vbCrLf & "201951080 – Rakha Adi Putra Suyitno", 0 + 64 + 0, "Tentang")
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim sqlstr As String
        Dim data As Integer

        If rbNIK.Checked Then
            sqlstr = "SELECT * FROM warga WHERE nik LIKE '%" & txtCari.Text & "%'"
        ElseIf rbNama.Checked Then
            sqlstr = "SELECT * FROM warga WHERE nama LIKE '%" & txtCari.Text & "%'"
        ElseIf rbPekerjaan.Checked Then
            sqlstr = "SELECT * FROM warga WHERE pekerjaan LIKE '%" & txtCari.Text & "%'"
        ElseIf rbKota.Checked Then
            sqlstr = "SELECT * FROM warga WHERE kota_rantauan LIKE '%" & txtCari.Text & "%'"
        End If

        adapter = New MySqlDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        if data > 0 Then
        With warga
            .DataSource = dt
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(0).HeaderText = "NIK"
            .Columns(1).HeaderText = "Nama Lengkap"
            .Columns(2).HeaderText = "Jenis Kelamin"
            .Columns(3).HeaderText = "Pekerjaan"
            .Columns(4).HeaderText = "Kota Rantauan"
            .Columns(5).HeaderText = "Tanggal Kedatangan"

            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True

            .Sort(.Columns(5), System.ComponentModel.ListSortDirection.Ascending)

            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.Black
                .Font = New Font("Tahoma", 9, FontStyle.Bold)
            End With
        End With
        Else
            warga.DataSource = Nothing
        End If
    End Sub

End Class