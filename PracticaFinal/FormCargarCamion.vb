Imports System.Threading
Imports System.Windows.Forms.Design.AxImporter

Public Class FormCargarCamion
    Public index As Integer
    Private Sub Form4_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        imgCamion.Image = ImageList1.Images(index)
        Dim xFotoSaca = imgSaca.Location.X
        Dim xFotoCamion = imgCamion.Location.X
        'Bucle para que la foto del camion llegue a la foto de la saca
        Do While xFotoCamion > xFotoSaca + imgSaca.Width
            Application.DoEvents()
            xFotoCamion = xFotoCamion - 20
            imgCamion.Location = New Point(xFotoCamion, imgCamion.Location.Y)
            Thread.Sleep(600)
        Loop
        'Borramos la foto de la saca, puesto que se lo llevo el camion
        Application.DoEvents()
        imgSaca.Image = Nothing
        'Bucle para que la foto del camion llegue al borde derecho
        Do While xFotoCamion < Me.Width
            Application.DoEvents()
            xFotoCamion = xFotoCamion + 20
            imgCamion.Location = New Point(xFotoCamion, imgCamion.Location.Y)
            Thread.Sleep(600)
        Loop
        MsgBox("camión cargado")
        Me.Close()
    End Sub
End Class