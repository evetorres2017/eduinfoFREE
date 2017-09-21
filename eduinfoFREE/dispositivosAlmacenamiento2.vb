Public Class dispositivosAlmacenamiento2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Declaramos las variables a utilizar en el formulario
        Dim disco As String
        Dim ram As String
        Dim cd As String
        Dim aciertos As Integer
        aciertos = 0
        ' Asignamos a las variables el valor leido desde teclado
        disco = TextBox1.Text
        ram = TextBox2.Text
        cd = TextBox3.Text

        ' Comprobamos si el usuario introdujo correctamente los nombres a los dispositivos
        If (disco = "disco duro") Then
            aciertos = aciertos + 1
        End If
        If (ram = "memoria ram") Then
            aciertos = aciertos + 1
        End If
        If (cd = "cd") Then
            aciertos = aciertos + 1
        End If

        ' Mostramos en un cuadro de dialogo la puntuacion
        MsgBox("Total de aciertos: " + aciertos.ToString)

        ' Desactivamos el boton aceptar y habilitamos el boton siguiente
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub

    Private Sub dispositivosAlmacenamiento2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' El boton salir permanece desactivado
        Button2.Enabled = False
    End Sub
End Class