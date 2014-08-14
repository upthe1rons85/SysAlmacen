<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informe_de_Producto_en_Punto_de_Reorden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informe_de_Producto_en_Punto_de_Reorden))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFF = New System.Windows.Forms.DateTimePicker()
        Me.dtpFI = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstProducto = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Producto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 264)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(543, 22)
        Me.StatusStrip1.TabIndex = 13
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Informe de Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(21, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 29)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "en Punto de Reorden"
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 25
        Me.LineShape2.X2 = 573
        Me.LineShape2.Y1 = 68
        Me.LineShape2.Y2 = 68
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(543, 286)
        Me.ShapeContainer1.TabIndex = 16
        Me.ShapeContainer1.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.WindowsApplication1.My.Resources.Resources.print
        Me.btnImprimir.Location = New System.Drawing.Point(476, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(37, 38)
        Me.btnImprimir.TabIndex = 17
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(23, 34)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(83, 20)
        Me.txtCodigo.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFF)
        Me.GroupBox1.Controls.Add(Me.dtpFI)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 70)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Codigo Producto"
        '
        'dtpFF
        '
        Me.dtpFF.Location = New System.Drawing.Point(10, 119)
        Me.dtpFF.Name = "dtpFF"
        Me.dtpFF.Size = New System.Drawing.Size(200, 20)
        Me.dtpFF.TabIndex = 27
        Me.dtpFF.Visible = False
        '
        'dtpFI
        '
        Me.dtpFI.Location = New System.Drawing.Point(10, 119)
        Me.dtpFI.Name = "dtpFI"
        Me.dtpFI.Size = New System.Drawing.Size(200, 20)
        Me.dtpFI.TabIndex = 28
        Me.dtpFI.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.ico_buscar
        Me.PictureBox1.Location = New System.Drawing.Point(246, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 30)
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'lstProducto
        '
        Me.lstProducto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Producto})
        Me.lstProducto.FullRowSelect = True
        Me.lstProducto.GridLines = True
        Me.lstProducto.Location = New System.Drawing.Point(246, 114)
        Me.lstProducto.Name = "lstProducto"
        Me.lstProducto.Size = New System.Drawing.Size(282, 127)
        Me.lstProducto.TabIndex = 90
        Me.lstProducto.UseCompatibleStateImageBehavior = False
        Me.lstProducto.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Tag = ""
        Me.Codigo.Text = "Codigo"
        Me.Codigo.Width = 48
        '
        'Producto
        '
        Me.Producto.Text = "Producto"
        Me.Producto.Width = 230
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtBuscar.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TxtBuscar.Location = New System.Drawing.Point(285, 86)
        Me.TxtBuscar.MaxLength = 90
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(243, 22)
        Me.TxtBuscar.TabIndex = 89
        Me.TxtBuscar.Text = "Buscar Producto"
        '
        'Informe_de_Producto_en_Punto_de_Reorden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 286)
        Me.Controls.Add(Me.lstProducto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Informe_de_Producto_en_Punto_de_Reorden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de Producto en Punto de Reorden"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFI As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstProducto As System.Windows.Forms.ListView
    Friend WithEvents Codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Producto As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
End Class
