<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.barraMinimo = New System.Windows.Forms.HScrollBar()
        Me.valorBarra = New System.Windows.Forms.Label()
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.listboxCamiones = New System.Windows.Forms.ListBox()
        Me.imgCamion = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btEmpezar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbPeso = New System.Windows.Forms.Label()
        Me.imagenesCamiones = New System.Windows.Forms.ImageList(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbMinimo = New System.Windows.Forms.Label()
        Me.lbMaximo = New System.Windows.Forms.Label()
        Me.barraMaximo = New System.Windows.Forms.HScrollBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbMarca = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.imgCamion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escoja rango peso sacas"
        '
        'barraMinimo
        '
        Me.barraMinimo.Location = New System.Drawing.Point(52, 121)
        Me.barraMinimo.Maximum = 5000
        Me.barraMinimo.Minimum = 1000
        Me.barraMinimo.Name = "barraMinimo"
        Me.barraMinimo.Size = New System.Drawing.Size(206, 26)
        Me.barraMinimo.TabIndex = 1
        Me.barraMinimo.Value = 1000
        '
        'valorBarra
        '
        Me.valorBarra.AutoSize = True
        Me.valorBarra.Location = New System.Drawing.Point(55, 74)
        Me.valorBarra.Name = "valorBarra"
        Me.valorBarra.Size = New System.Drawing.Size(63, 40)
        Me.valorBarra.TabIndex = 2
        Me.valorBarra.Text = "Mínimo:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbInfo
        '
        Me.lbInfo.AutoSize = True
        Me.lbInfo.Location = New System.Drawing.Point(94, 293)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(336, 20)
        Me.lbInfo.TabIndex = 3
        Me.lbInfo.Text = "Informacion Camiones, escoja uno para continuar"
        '
        'listboxCamiones
        '
        Me.listboxCamiones.FormattingEnabled = True
        Me.listboxCamiones.ItemHeight = 20
        Me.listboxCamiones.Items.AddRange(New Object() {"Camion Ford", "Camion Hyundai", "Camion Mercedes"})
        Me.listboxCamiones.Location = New System.Drawing.Point(94, 366)
        Me.listboxCamiones.Name = "listboxCamiones"
        Me.listboxCamiones.Size = New System.Drawing.Size(150, 104)
        Me.listboxCamiones.TabIndex = 4
        '
        'imgCamion
        '
        Me.imgCamion.Location = New System.Drawing.Point(344, 342)
        Me.imgCamion.Name = "imgCamion"
        Me.imgCamion.Size = New System.Drawing.Size(150, 150)
        Me.imgCamion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCamion.TabIndex = 5
        Me.imgCamion.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(52, 606)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(295, 20)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Arroz Paco, los mejores arroces de Valencia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 569)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Visite nuestra página!"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Segoe UI Historic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbFecha.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbFecha.Location = New System.Drawing.Point(662, 13)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(94, 38)
        Me.lbFecha.TabIndex = 8
        Me.lbFecha.Text = "Fecha"
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbHora.Location = New System.Drawing.Point(687, 74)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(58, 28)
        Me.lbHora.TabIndex = 9
        Me.lbHora.Text = "Hora"
        '
        'Timer1
        '
        '
        'btEmpezar
        '
        Me.btEmpezar.Location = New System.Drawing.Point(739, 620)
        Me.btEmpezar.Name = "btEmpezar"
        Me.btEmpezar.Size = New System.Drawing.Size(94, 29)
        Me.btEmpezar.TabIndex = 10
        Me.btEmpezar.Text = "Empezar"
        Me.btEmpezar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(560, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Peso:"
        '
        'lbPeso
        '
        Me.lbPeso.AutoSize = True
        Me.lbPeso.Location = New System.Drawing.Point(624, 355)
        Me.lbPeso.Name = "lbPeso"
        Me.lbPeso.Size = New System.Drawing.Size(17, 20)
        Me.lbPeso.TabIndex = 15
        Me.lbPeso.Text = "0"
        '
        'imagenesCamiones
        '
        Me.imagenesCamiones.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imagenesCamiones.ImageStream = CType(resources.GetObject("imagenesCamiones.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenesCamiones.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenesCamiones.Images.SetKeyName(0, "camionFord.jpg")
        Me.imagenesCamiones.Images.SetKeyName(1, "camionHyundai.jpg")
        Me.imagenesCamiones.Images.SetKeyName(2, "camionMercedes.jpg")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Máximo:"
        '
        'lbMinimo
        '
        Me.lbMinimo.AutoSize = True
        Me.lbMinimo.Location = New System.Drawing.Point(133, 74)
        Me.lbMinimo.Name = "lbMinimo"
        Me.lbMinimo.Size = New System.Drawing.Size(41, 20)
        Me.lbMinimo.TabIndex = 17
        Me.lbMinimo.Text = "1000"
        '
        'lbMaximo
        '
        Me.lbMaximo.AutoSize = True
        Me.lbMaximo.Location = New System.Drawing.Point(133, 170)
        Me.lbMaximo.Name = "lbMaximo"
        Me.lbMaximo.Size = New System.Drawing.Size(41, 20)
        Me.lbMaximo.TabIndex = 18
        Me.lbMaximo.Text = "5000"
        '
        'barraMaximo
        '
        Me.barraMaximo.Location = New System.Drawing.Point(52, 211)
        Me.barraMaximo.Maximum = 9000
        Me.barraMaximo.Minimum = 5000
        Me.barraMaximo.Name = "barraMaximo"
        Me.barraMaximo.Size = New System.Drawing.Size(206, 26)
        Me.barraMaximo.TabIndex = 19
        Me.barraMaximo.Value = 5000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(560, 393)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Marca:"
        '
        'lbMarca
        '
        Me.lbMarca.AutoSize = True
        Me.lbMarca.Location = New System.Drawing.Point(624, 393)
        Me.lbMarca.Name = "lbMarca"
        Me.lbMarca.Size = New System.Drawing.Size(0, 20)
        Me.lbMarca.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 639)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(225, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Hay que tener chrome instalado!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 678)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbMarca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.barraMaximo)
        Me.Controls.Add(Me.lbMaximo)
        Me.Controls.Add(Me.lbMinimo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbPeso)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btEmpezar)
        Me.Controls.Add(Me.lbHora)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.imgCamion)
        Me.Controls.Add(Me.listboxCamiones)
        Me.Controls.Add(Me.lbInfo)
        Me.Controls.Add(Me.valorBarra)
        Me.Controls.Add(Me.barraMinimo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.imgCamion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents barraMinimo As HScrollBar
    Friend WithEvents valorBarra As Label
    Friend WithEvents lbInfo As Label
    Friend WithEvents listboxCamiones As ListBox
    Friend WithEvents imgCamion As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents lbFecha As Label
    Friend WithEvents lbHora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btEmpezar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbPeso As Label
    Friend WithEvents imagenesCamiones As ImageList
    Friend WithEvents Label5 As Label
    Friend WithEvents lbMinimo As Label
    Friend WithEvents lbMaximo As Label
    Friend WithEvents barraMaximo As HScrollBar
    Friend WithEvents Label3 As Label
    Friend WithEvents lbMarca As Label
    Friend WithEvents Label6 As Label
End Class
