Public Class Conexion
    Public Function AbrirConexion() As Npgsql.NpgsqlConnection
        Dim conexion As Npgsql.NpgsqlConnection

        Try
            conexion = New Npgsql.NpgsqlConnection
            Dim cadenaConexion As String
            cadenaConexion = "Server=127.0.0.1;Port=5432;User Id='postgres';Password='root';Database = veterinaria"

            conexion.ConnectionString = cadenaConexion
            conexion.Open()

        Catch ex As Exception
            Throw ex
        End Try




        Return conexion
    End Function

End Class
