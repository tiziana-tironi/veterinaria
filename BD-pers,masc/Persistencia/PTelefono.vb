Public Class PTelefono

    Dim listaTelefono As New List(Of Integer)
    Dim conection = New Npgsql.NpgsqlConnection

    Public Sub AgregarTelefono(ci As Integer, telefono As Integer)
        Try

            Dim clasCnn = New Conexion
            Dim resultado As Integer
            conection = clasCnn.AbrirConexion()
            Dim cadenaDeComandos As String
            Dim cmd As New Npgsql.NpgsqlCommand()
            cadenaDeComandos = "insert into telefono(cip,telefono) values (@cip ,@telefono);"
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = conection
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@cip", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = telefono

            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Sub
    Public Function TraerTelefonos(ci As Integer) As List(Of Integer)
        Try

            Dim clasCnn As New Conexion
            Dim cadenaDeComandos As String

            Dim reader As Npgsql.NpgsqlDataReader
            conection = clasCnn.AbrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand()

            cmd.Connection = conection

            cadenaDeComandos = "select * from telefono where ci=@ci;"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            reader = cmd.ExecuteReader
            While reader.Read
                listaTelefono.Add(CInt(reader(2).ToString))

            End While
            Return listaTelefono
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Function

    Public Sub borrarTelefonos(ci As Integer)

        Dim clasCnn = New Conexion
        Dim resultado As Integer
        conection = clasCnn.AbrirConexion()
        Dim cadenaDeComandos As String
        Dim cmd As New Npgsql.NpgsqlCommand()
        resultado = cmd.ExecuteNonQuery()
        cadenaDeComandos = "delete from telefono where cip = @ci"
        cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
        cmd.CommandText = cadenaDeComandos
        resultado = cmd.ExecuteNonQuery()
    End Sub
End Class