Public Class componentesPC

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Declaramos las variables a utilizar en el formulario
        Dim gabinete As String
        Dim mouse As String
        Dim teclado As String
        Dim aciertos As Integer
        aciertos = 0
        ' Asignamos a las variables el valor leido desde teclado
        gabinete = TextBox1.Text
        mouse = TextBox2.Text
        teclado = TextBox3.Text

        ' Comprobamos si el usuario introdujo correctamente los nombres a los dispositivos
        If (gabinete = "gabinete") Then
            aciertos = aciertos + 1
        ElseIf (gabinete = "cpu") Then
            aciertos = aciertos + 1
        End If
        If (mouse = "mouse") Then
            aciertos = aciertos + 1
        ElseIf (mouse = "raton") Then
            aciertos = aciertos + 1
        End If
        If (teclado = "teclado") Then
            aciertos = aciertos + 1
        End If

        ' Mostramos en un cuadro de dialogo la puntuacion
        MsgBox("Total de aciertos: " + aciertos.ToString)

        ' Desactivamos el boton aceptar y habilitamos el boton siguiente
        Button1.Enabled = False
        Button2.Enabled = True

    End Sub

    Private Sub componentesPC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' El boton siguiente permanece desactivado
        Button2.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Abrimos el formulario 2 y cerramos el formulario 1
        componentesPC2.Visible = True
        Me.Close()
    End Sub
End Class