Imports Data_Pemudik.koneksi
Imports MySql.Data.MySqlClient

Public Class formUtama
    Dim conn As New MySqlConnection("server=localhost; user id=root; database=pemudik")
    Dim perintah As New MySqlCommand
    Dim data As New MySqlDataAdapter
    Dim ds As New DataSet

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

        clear()
    End Sub

    Private Sub enableFormInput()
        txtNIK.Enabled = True
        txtNama.Enabled = True
        cmbJenkel.Enabled = True
        txtPekerjaan.Enabled = True
        txtKota.Enabled = True
        dtpKedatangan.Enabled = True

        btnSaveNew.Enabled = True
        btnSave.Enabled = True
        btnDelete.Enabled = True
    End Sub

    'Private Sub enableFormEdit()
    '    txtNIK.Enabled = False
    '    txtNama.Enabled = True
    '    cmbJenkel.Enabled = True
    '    txtPekerjaan.Enabled = True
    '    txtKota.Enabled = True
    '    dtpKedatangan.Enabled = True

    '    btnSaveNew.Enabled = True
    '    btnSave.Enabled = True
    '    btnDelete.Enabled = True
    'End Sub

    Private Sub clear()
        txtNIK.Text = ""
        txtNama.Text = ""
        cmbJenkel.Text = ""
        txtPekerjaan.Text = ""
        txtKota.Text = ""
        dtpKedatangan.Text = ""

        txtNIK.Focus()
    End Sub

    Private Sub tampildata()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim sqlstr As String
        Dim data As Integer

        sqlstr = "SELECT * FROM warga"
        adapter = New MySqlDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

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
        clear()
    End Sub

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        clear()
        enableFormInput()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
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
        tampildata()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        tampildata()
    End Sub

    Private Sub formUtama_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'konek("localhost", "root", "", "pemudik")
        tampildata()
        dtpKedatangan.Format = DateTimePickerFormat.Custom
        dtpKedatangan.CustomFormat = "yyyy/MM/dd"

        disableForm()
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
        tampildata()
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
        tampildata()
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

        enableFormInput()
    End Sub
End Class
