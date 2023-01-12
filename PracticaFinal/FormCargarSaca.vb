Imports System.Reflection.Emit
Imports System.Threading

Public Class FormCargarSaca
    Private Sub Form3_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Cargamos la imagen de la saca
        imgSacaPala.Image = imagenes.Images(0)
        'Incrementamos la barra de progreso
        For i = 1 To 100
            Application.DoEvents()
            barraProgreso.Increment(1)
            Thread.Sleep(40)
        Next
        'cargamos la imagen de la pala
        imgSacaPala.Image = imagenes.Images(1)
        Application.DoEvents()
        'Mandamos a dormir para que se muestre la imagen antes del mensaje
        Thread.Sleep(900)
        'Mostramos mensaje de informacion
        MsgBox("Saca cargada")
        Me.Close()
    End Sub
End Class