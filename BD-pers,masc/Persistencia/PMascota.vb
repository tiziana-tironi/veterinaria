Public Class PMascota

    Public Sub modificarMascota(mascotita As ClassPet)
        Dim connection = New Npgsql.NpgsqlConnection
        Try
            Dim classcnn = New Conexion
            connection = classcnn.AbrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = connection
            Dim cadenaComandos As String
            '
            cadenaComandos = "UPDATE mascota SET nombre=@nombre, anionacimiento=@anionacimiento WHERE id = @id;"
            cmd.CommandText = cadenaComandos

            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascotita.IdPet
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 15).Value = mascotita.NamePet
            cmd.Parameters.Add("@anionacimiento", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascotita.DateOfBirthdayPet


            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try

    End Sub


    Public Sub AltaMascota(mascotita As ClassPet)
        Dim connection = New Npgsql.NpgsqlConnection
        Try
            Dim classCon = New Conexion
            connection = classCon.AbrirConexion
            Dim cmd As New Npgsql.NpgsqlCommand
            Dim cadenaComando As String
            cadenaComando = "insert into mascota(id, nombre, anionacimiento, ci) values(@id, @nombre, @anionacimiento, @ci)"
            cmd.CommandText = cadenaComando
            cmd.Connection = connection
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = mascotita.NamePet
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascotita.IdPet
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascotita.CiPet
            cmd.Parameters.Add("@anionacimiento", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascotita.DateOfBirthdayPet

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            connection.Close
        End Try
    End Sub

End Class
