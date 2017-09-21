Public Class Form1

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub MenúToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenúToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'conectarse()
        
    End Sub

    Private Sub Actividad1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actividad1ToolStripMenuItem.Click
        ' Con esta instruccion se visualiza el formulario de componentes de una PC.
        componentesPC.Show()
    End Sub

    Private Sub AlmacenamientoSecundarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlmacenamientoSecundarioToolStripMenuItem.Click
        ' Con esta instruccion se visualiza el formulario de almacenamiento secundario.
        dispositivosAlmacenamiento1.Show()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    ' Codigo del boton Consultar
    'Dim id As String
    'id = txtId.Text
    'consultar(id)
    'End Sub


    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        acercade.Visible = True
    End Sub
End Class
