<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCargarSaca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCargarSaca))
        Me.barraProgreso = New System.Windows.Forms.ProgressBar()
        Me.imgSacaPala = New System.Windows.Forms.PictureBox()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.lbInfo = New System.Windows.Forms.Label()
        CType(Me.imgSacaPala, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barraProgreso
        '
        Me.barraProgreso.Location = New System.Drawing.Point(261, 287)
        Me.barraProgreso.Name = "barraProgreso"
        Me.barraProgreso.Size = New System.Drawing.Size(205, 29)
        Me.barraProgreso.TabIndex = 0
        '
        'imgSacaPala
        '
        Me.imgSacaPala.Location = New System.Drawing.Point(238, 33)
        Me.imgSacaPala.Name = "imgSacaPala"
        Me.imgSacaPala.Size = New System.Drawing.Size(258, 190)
        Me.imgSacaPala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSacaPala.TabIndex = 1
        Me.imgSacaPala.TabStop = False
        '
        'imagenes
        '
        Me.imagenes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "sacallena.jpg")
        Me.imagenes.Images.SetKeyName(1, "pala.jpg")
        '
        'lbInfo
        '
        Me.lbInfo.AutoSize = True
        Me.lbInfo.Location = New System.Drawing.Point(276, 356)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(177, 20)
        Me.lbInfo.TabIndex = 2
        Me.lbInfo.Text = "Atencion cargando saca..."
        '
        'FormCargarSaca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbInfo)
        Me.Controls.Add(Me.imgSacaPala)
        Me.Controls.Add(Me.barraProgreso)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCargarSaca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar saca"
        CType(Me.imgSacaPala, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barraProgreso As ProgressBar
    Friend WithEvents imgSacaPala As PictureBox
    Friend WithEvents imagenes As ImageList
    Friend WithEvents lbInfo As Label
End Class
