<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCargarCamion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCargarCamion))
        Me.imgSaca = New System.Windows.Forms.PictureBox()
        Me.imgCamion = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.imgSaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCamion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgSaca
        '
        Me.imgSaca.Image = Global.PracticaFinal.My.Resources.Resources.sacallena
        Me.imgSaca.Location = New System.Drawing.Point(218, 68)
        Me.imgSaca.Name = "imgSaca"
        Me.imgSaca.Size = New System.Drawing.Size(150, 150)
        Me.imgSaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSaca.TabIndex = 0
        Me.imgSaca.TabStop = False
        '
        'imgCamion
        '
        Me.imgCamion.Location = New System.Drawing.Point(580, 68)
        Me.imgCamion.Name = "imgCamion"
        Me.imgCamion.Size = New System.Drawing.Size(150, 150)
        Me.imgCamion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCamion.TabIndex = 1
        Me.imgCamion.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "camionFord.jpg")
        Me.ImageList1.Images.SetKeyName(1, "camionHyundai.jpg")
        Me.ImageList1.Images.SetKeyName(2, "camionMercedes.jpg")
        '
        'FormCargarCamion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 469)
        Me.ControlBox = False
        Me.Controls.Add(Me.imgCamion)
        Me.Controls.Add(Me.imgSaca)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCargarCamion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar camion"
        CType(Me.imgSaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCamion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imgSaca As PictureBox
    Friend WithEvents imgCamion As PictureBox
    Friend WithEvents ImageList1 As ImageList
End Class
