Imports System.Linq.Expressions
Imports System.Security.Policy
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Form1
    Dim Capacidad
    Dim minimo As Integer = 1000
    Dim maximo As Integer = 5000
    Dim camionPulsado As Integer
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Timer1.Enabled = True
        'Por defecto se seleccionara el camion uno
        imgCamion.Image = imagenesCamiones.Images(0)
        lbPeso.Text = 18000 & "kg"
        Capacidad = 18000
        lbMarca.Text = "Ford"
    End Sub
    'HORA
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbHora.Text = DateTime.Now.ToString("HH:mm:ss")
        lbFecha.Text = DateTime.Now.ToShortDateString()
    End Sub
    'PESO SACAS
    Private Sub barraMinimo_Scroll(sender As Object, e As ScrollEventArgs) Handles barraMinimo.Scroll
        lbMinimo.Text = barraMinimo.Value
        minimo = barraMinimo.Value
    End Sub
    Private Sub barraMaximo_Scroll(sender As Object, e As ScrollEventArgs) Handles barraMaximo.Scroll
        lbMaximo.Text = barraMaximo.Value
        maximo = barraMaximo.Value
    End Sub
    'CAMION SELECCIONADO
    Private Sub listboxCamiones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxCamiones.SelectedIndexChanged
        Dim opcion As Integer = listboxCamiones.SelectedIndex
        Select Case opcion
            Case 0
                imgCamion.Image = imagenesCamiones.Images(0)
                camionPulsado = 0
                lbPeso.Text = 18000 & "kg"
                lbMarca.Text = "Ford"
                Capacidad = 18000
            Case 1
                imgCamion.Image = imagenesCamiones.Images(1)
                camionPulsado = 1
                lbPeso.Text = 24000 & "kg"
                lbMarca.Text = "Hyundai"
                Capacidad = 24000
            Case 2
                camionPulsado = 2
                imgCamion.Image = imagenesCamiones.Images(2)
                lbPeso.Text = 30000 & "kg"
                lbMarca.Text = "Mercedes"
                Capacidad = 30000
        End Select
    End Sub
    'ABRIR GOOGLE
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("C:\Archivos de Programa\Google\Chrome\Application\chrome.exe --New-window : " & "https://pidemesa.es/blog/mejores-arroces-valencia/")
    End Sub
    'EMPEZAR A INTRODUCIR SACAS
    Private Sub btEmpezar_Click(sender As Object, e As EventArgs) Handles btEmpezar.Click
        Dim j As Integer
        Dim Pesosaca, Cargado As Integer
        Me.Text = "Distribución de cal"

        Do While (Cargado + Pesosaca) <= Capacidad
            If Pesosaca > 0 Then
                Application.DoEvents()
                Cargado = Cargado + Pesosaca
            End If
            j = j + 1
            Pesosaca = 0
            Do While Pesosaca < minimo Or Pesosaca > maximo
                Pesosaca = InputBox("Introduzca el peso de la saca nº " & j & " en kgs", "Dato saca")
                If (Pesosaca < minimo Or Pesosaca > maximo) Then
                    MsgBox("Peso Incorrecto")
                End If
            Loop
            FormCargarSaca.Show()
        Loop
        Cargado = 0
        Thread.Sleep(1100)
        Application.DoEvents()
        Dim formCargarCamion As New FormCargarCamion
        formCargarCamion.index = camionPulsado
        formCargarCamion.Show()
    End Sub
End Class
