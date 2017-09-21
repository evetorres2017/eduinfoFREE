Module funcionesdb
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbsoft.accdb;Persist Security Info=False")
    ' Comand
    Public cmd As New OleDb.OleDbCommand
    ' Data reader
    Public dr As OleDb.OleDbDataReader
    Public Sub conectarse()
        Try
            conn.Open()
            'MsgBox("Conexion exitosa!")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    ' Funcion para consultar la DB
    Public Sub consultar(ByRef identificacion As String)
        ' Inicializar valores de cmd
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        ' Se evalua si la variable identificacion lo tiene una persona en la DB
        If identificacion <> "" Then
            cmd.CommandText = "SELECT NOMBRES, APELLIDOS, CONTRASENA, SEMESTRE, ACIERTOS FROM USUARIO WHERE IDUSUARIO=" + identificacion
        Else
            cmd.CommandText = "SELECT NOMBRES, APELLIDOS, CONTRASENA, SEMESTRE, ACIERTOS FROM USUARIO "
        End If

        Try
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read()
                    MsgBox(dr(0).ToString + " " + dr(1).ToString + " " + dr(2).ToString + " " + dr(3).ToString + " " + dr(4).ToString)
                End While
            Else
                MsgBox("No existen registros para la consulta.")
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
