Imports Npgsql

Public Class PPersona
    Dim connection = New Npgsql.NpgsqlConnection

    Public Sub modificarPersona(personota As Person)
        Try
            Dim classcnn = New Conexion
            connection = classcnn.AbrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = connection
            Dim cadenaComandos As String

            cadenaComandos = "DELETE * FROM telefono WHERE ci = @ci;"
            cmd.CommandText = cadenaComandos
            '
            cadenaComandos = "UPDATE persona SET nombre=@nombre, direccion=@direccion WHERE ci = @ci;"
            cmd.CommandText = cadenaComandos

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personota.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = personota.Name
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = personota.Address


            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()

            If resultado = 1 Then
                Dim i = 0
                While i < personota.PhoneList.Count

                    cmd = New Npgsql.NpgsqlCommand
                    cmd.Connection = connection

                    cadenaComandos = "insert into telefono (ci, tel) values (@ci, @tel);"
                    cmd.CommandText = cadenaComandos

                    cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personota.Ci
                    cmd.Parameters.Add("@tel", NpgsqlTypes.NpgsqlDbType.Integer).Value = personota.PhoneList.Item(i)

                    resultado = cmd.ExecuteNonQuery()
                    i = i + 1

                End While
            End If

        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try

    End Sub


    Public Sub AltaPersona(personota As Person)
        Try
            Dim classCon = New Conexion
            connection = classCon.AbrirConexion
            Dim cmd As New Npgsql.NpgsqlCommand
            Dim cadenaComando As String
            cadenaComando = "insert into persona(nombre, direccion, ci) values(@nombre, @direccion, @ci)"
            cmd.CommandText = cadenaComando
            cmd.Connection = connection
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personota.Name
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personota.Address
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personota.Ci

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()

            If resultado = 1 Then
                Dim i = 0
                While i < personota.PhoneList.Count
                    cmd = New Npgsql.NpgsqlCommand()
                    cmd.Connection = connection
                    cadenaComando = "insert into telefono(ci, telefono) values(@ci, @telefono)"
                    cmd.CommandText = cadenaComando

                    cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personota.Ci
                    cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = personota.PhoneList.Item(i)

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


    Public Function personSearch(cedula As Integer) As Person
        Dim newPerson As New Person()
        Try
            Dim classcnn = New Conexion
            connection = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = connection
            Dim cadenaComandos As String
            cadenaComandos = "SELECT * FROM persona WHERE ci = @ci;"
            cmd.CommandText = cadenaComandos

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = cedula

            Dim lector As NpgsqlDataReader
            lector = cmd.ExecuteReader()

            If lector.HasRows Then
                lector.Read()
                newPerson.Ci = Convert.ToInt32(lector(0).ToString)
                newPerson.Name = lector(1).ToString
                newPerson.Address = lector(2).ToString
            End If
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()

        End Try
        Return newPerson
    End Function
End Class
