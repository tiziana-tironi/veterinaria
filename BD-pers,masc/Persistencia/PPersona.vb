Public Class PPersona

    Sub New()

    End Sub
    Dim connection = New Npgsql.NpgsqlConnection
    Public Sub AltaPersona(Persona As Person)
        Try
            Dim classCon = New Conexion
            connection = classCon.AbrirConexion
            Dim cmd As New Npgsql.NpgsqlCommand
            Dim cadenaComando As String
            cadenaComando = "insert into persona(nombre, direccion, ci) values(@nombre, @direccion, @ci)"
            cmd.CommandText = cadenaComando
            cmd.Connection = connection
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = Persona.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = Persona.Direccion
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = Persona.Ci

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()

            If resultado = 1 Then
                Dim i = 0
                While i < Persona.Listatelefono.Count
                    cmd = New Npgsql.NpgsqlCommand()
                    cmd.Connection = connection
                    cadenaComando = "insert into telefono(ci, telefono) values(@ci, @telefono)"
                    cmd.CommandText = cadenaComando

                    cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = Persona.Ci
                    cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = Persona.Listatelefono.Item(i)

                    resultado = cmd.ExecuteNonQuery()
                    i += 1
                End While
            End If

        Catch ex As Exception
            Throw ex
        Finally
            connection.Close
        End Try
    End Sub
End Class
