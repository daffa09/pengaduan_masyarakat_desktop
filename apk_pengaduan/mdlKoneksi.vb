Imports MySql.Data.MySqlClient

Module mdlKoneksi
    Public conn As mysqlConnection
    Public da As mysqlDataAdapter
    Public ds As DataSet
    Public cmd As mysqlCommand
    Public dr As mysqlDataReader

    Public Sub koneksi()
        conn = New MySqlConnection("server=localhost; database=tugas_pengaduan; uid=root; password=")
        conn.Open()
    End Sub
End Module
