Public Class dispositivosAlmacenamiento1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Declaramos las variables a utilizar en el formulario
        Dim dvd As String
        Dim usb As String
        Dim tsd As String
        Dim aciertos As Integer
        aciertos = 0
        ' Asignamos a las variables el valor leido desde teclado
        dvd = TextBox1.Text
        usb = TextBox2.Text
        tsd = TextBox3.Text

        ' Comprobamos si el usuario introdujo correctamente los nombres a los dispositivos
        If (dvd = "dvd") Then
            aciertos = aciertos + 1
        End If
        If (usb = "memoria usb") Then
            aciertos = aciertos + 1
        End If
        If (tsd = "tarjeta sd") Then
            aciertos = aciertos + 1
        End If

        ' Mostramos en un cuadro de dialogo la puntuacion
        MsgBox("Total de aciertos: " + aciertos.ToString)

        ' Desactivamos el boton aceptar y habilitamos el boton siguiente
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub

    Private Sub dispositivosAlmacenamiento1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' El boton siguiente permanece desactivado
        Button2.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Visualizar formulario 2 y cerrar formulario actual
        dispositivosAlmacenamiento2.Visible = True
        Me.Close()
    End Sub
End Class