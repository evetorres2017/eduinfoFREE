Public Class componentesPC2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Abrimos el formulario 3 y cerramos el formulario 2
        componentesPC3.Visible = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Declaramos las variables a utilizar en el formulario
        Dim impresora As String
        Dim lapiz As String
        Dim escaner As String
        Dim aciertos As Integer
        aciertos = 0
        ' Asignamos a las variables el valor leido desde teclado
        impresora = TextBox1.Text
        lapiz = TextBox2.Text
        escaner = TextBox3.Text

        ' Comprobamos si el usuario introdujo correctamente los nombres a los dispositivos
        If (impresora = "impresora") Then
            aciertos = aciertos + 1
        End If
        If (lapiz = "lapiz optico") Then
            aciertos = aciertos + 1
        End If
        If (escaner = "escaner") Then
            aciertos = aciertos + 1
        End If

        ' Mostramos en un cuadro de dialogo la puntuacion
        MsgBox("Total de aciertos: " + aciertos.ToString)

        ' Desactivamos el boton aceptar y habilitamos el boton siguiente
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub

    Private Sub componentesPC2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' El boton siguiente permanece desactivado
        Button2.Enabled = False
    End Sub
End Class