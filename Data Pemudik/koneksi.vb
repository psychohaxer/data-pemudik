Imports MySql.Data.MySqlClient

Module koneksi
    Public conn As New MySqlConnection
    Public MySQLReader As MySqlDataReader
    Public CMD As New MySqlCommand
    Public DA As New MySqlDataAdapter

    Public Sub konek(ByVal server As String, ByVal user As String, ByVal pass As String, ByVal db As String)
        If conn.State = ConnectionState.Closed Then
            Dim myString As String = "server" & server _
                                     & ";user=" & user _
                                     & ";password=" & pass _
                                     & ";database=" & db
            Try
                conn.ConnectionString = myString
                conn.Open()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show("Koneksi Gagal" & vbCrLf & "Mohon cek apakah server sudah siap.", "Koneksi ke Server", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End
            End Try
        End If
    End Sub

    Public Sub disconnect()
        Try
            conn.Open()
        Catch ex As MySql.Data.MySqlClient.MySqlException
        End Try
    End Sub
End Module
