<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnidadesMedida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnidadesMedida))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAbreviacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.lstUnidades = New System.Windows.Forms.ListView()
        Me.xCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xAbreviacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.salir = New System.Windows.Forms.Button()
        Me.picBuscar = New System.Windows.Forms.PictureBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.picBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAbreviacion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtAbreviacion
        '
        Me.txtAbreviacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviacion.Enabled = False
        Me.txtAbreviacion.Location = New System.Drawing.Point(87, 58)
        Me.txtAbreviacion.MaxLength = 6
        Me.txtAbreviacion.Name = "txtAbreviacion"
        Me.txtAbreviacion.Size = New System.Drawing.Size(118, 20)
        Me.txtAbreviacion.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(87, 21)
        Me.txtDescripcion.MaxLength = 30
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(118, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Abreviacion"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(63, 17)
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(89, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(27, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mtto. Unidades de Medida"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(564, 300)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -6
        Me.LineShape2.X2 = 571
        Me.LineShape2.Y1 = 58
        Me.LineShape2.Y2 = 58
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -5
        Me.LineShape1.X2 = 572
        Me.LineShape1.Y1 = 57
        Me.LineShape1.Y2 = 57
        '
        'txtUnidades
        '
        Me.txtUnidades.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidades.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtUnidades.Location = New System.Drawing.Point(299, 71)
        Me.txtUnidades.MaxLength = 30
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(224, 22)
        Me.txtUnidades.TabIndex = 3
        Me.txtUnidades.Text = "BUSCAR DESCRIPCION"
        '
        'lstUnidades
        '
        Me.lstUnidades.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.xCodigo, Me.xDescripcion, Me.xAbreviacion})
        Me.lstUnidades.FullRowSelect = True
        Me.lstUnidades.GridLines = True
        Me.lstUnidades.Location = New System.Drawing.Point(242, 100)
        Me.lstUnidades.Name = "lstUnidades"
        Me.lstUnidades.Size = New System.Drawing.Size(310, 146)
        Me.lstUnidades.TabIndex = 8
        Me.lstUnidades.UseCompatibleStateImageBehavior = False
        Me.lstUnidades.View = System.Windows.Forms.View.Details
        '
        'xCodigo
        '
        Me.xCodigo.Text = "Codigo"
        Me.xCodigo.Width = 52
        '
        'xDescripcion
        '
        Me.xDescripcion.Text = "Descripcion"
        Me.xDescripcion.Width = 160
        '
        'xAbreviacion
        '
        Me.xAbreviacion.Text = "Abreviacion"
        Me.xAbreviacion.Width = 87
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 43)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 278)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(564, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(256, 17)
        Me.ToolStripStatusLabel1.Text = "Desarrollo de Engordas Estabuladas S.A. de C.V."
        '
        'STBlblUsuario
        '
        Me.STBlblUsuario.Name = "STBlblUsuario"
        Me.STBlblUsuario.Size = New System.Drawing.Size(80, 17)
        Me.STBlblUsuario.Text = "STBlblUsuario"
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(514, 252)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(38, 21)
        Me.salir.TabIndex = 17
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'picBuscar
        '
        Me.picBuscar.Image = Global.WindowsApplication1.My.Resources.Resources.ico_buscar
        Me.picBuscar.Location = New System.Drawing.Point(256, 69)
        Me.picBuscar.Name = "picBuscar"
        Me.picBuscar.Size = New System.Drawing.Size(37, 30)
        Me.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBuscar.TabIndex = 16
        Me.picBuscar.TabStop = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(414, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(37, 38)
        Me.BtnNuevo.TabIndex = 5
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(457, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(37, 38)
        Me.btnModificar.TabIndex = 6
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(500, 12)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(37, 38)
        Me.BtnEliminar.TabIndex = 7
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Image = Global.WindowsApplication1.My.Resources.Resources.save_C_mayseg
        Me.BtnGrabar.Location = New System.Drawing.Point(371, 12)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(37, 38)
        Me.BtnGrabar.TabIndex = 4
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'frmUnidadesMedida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 300)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.picBuscar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.lstUnidades)
        Me.Controls.Add(Me.txtUnidades)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUnidadesMedida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mtto. Unidades de Medida"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.picBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lstUnidades As System.Windows.Forms.ListView
    Friend WithEvents xCodigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents xDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents xAbreviacion As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtUnidades As System.Windows.Forms.TextBox
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents picBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents txtAbreviacion As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents salir As System.Windows.Forms.Button
End Class
