<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamilia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFamilia))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GbxDatos = New System.Windows.Forms.GroupBox()
        Me.TxtPrefijoCtaCompra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPrefijoCtaGasto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPrefijoCtaInv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lstBuscar = New System.Windows.Forms.ListView()
        Me.xCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CtaInventario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CtaGasto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CtaCompra = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GbxDatos.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(33, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mtto. Familias"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Familia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(708, 307)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 20
        Me.LineShape2.X2 = 682
        Me.LineShape2.Y1 = 58
        Me.LineShape2.Y2 = 59
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 23
        Me.LineShape1.X2 = 679
        Me.LineShape1.Y1 = 59
        Me.LineShape1.Y2 = 60
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(52, 13)
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(59, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(82, 19)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(123, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 42)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GbxDatos
        '
        Me.GbxDatos.Controls.Add(Me.TxtPrefijoCtaCompra)
        Me.GbxDatos.Controls.Add(Me.Label6)
        Me.GbxDatos.Controls.Add(Me.TxtPrefijoCtaGasto)
        Me.GbxDatos.Controls.Add(Me.Label5)
        Me.GbxDatos.Controls.Add(Me.TxtPrefijoCtaInv)
        Me.GbxDatos.Controls.Add(Me.Label4)
        Me.GbxDatos.Controls.Add(Me.txtDescripcion)
        Me.GbxDatos.Controls.Add(Me.Label3)
        Me.GbxDatos.Enabled = False
        Me.GbxDatos.Location = New System.Drawing.Point(12, 139)
        Me.GbxDatos.Name = "GbxDatos"
        Me.GbxDatos.Size = New System.Drawing.Size(222, 137)
        Me.GbxDatos.TabIndex = 3
        Me.GbxDatos.TabStop = False
        '
        'TxtPrefijoCtaCompra
        '
        Me.TxtPrefijoCtaCompra.Location = New System.Drawing.Point(132, 105)
        Me.TxtPrefijoCtaCompra.MaxLength = 7
        Me.TxtPrefijoCtaCompra.Name = "TxtPrefijoCtaCompra"
        Me.TxtPrefijoCtaCompra.Size = New System.Drawing.Size(73, 20)
        Me.TxtPrefijoCtaCompra.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Prefijo Cta. Compra :"
        '
        'TxtPrefijoCtaGasto
        '
        Me.TxtPrefijoCtaGasto.Location = New System.Drawing.Point(132, 75)
        Me.TxtPrefijoCtaGasto.MaxLength = 7
        Me.TxtPrefijoCtaGasto.Name = "TxtPrefijoCtaGasto"
        Me.TxtPrefijoCtaGasto.Size = New System.Drawing.Size(73, 20)
        Me.TxtPrefijoCtaGasto.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Prefijo Cta. Gasto :"
        '
        'TxtPrefijoCtaInv
        '
        Me.TxtPrefijoCtaInv.Location = New System.Drawing.Point(132, 47)
        Me.TxtPrefijoCtaInv.MaxLength = 10
        Me.TxtPrefijoCtaInv.Name = "TxtPrefijoCtaInv"
        Me.TxtPrefijoCtaInv.Size = New System.Drawing.Size(75, 20)
        Me.TxtPrefijoCtaInv.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Prefijo Cta.Inventario :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 285)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(708, 22)
        Me.StatusStrip1.TabIndex = 11
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
        'lstBuscar
        '
        Me.lstBuscar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.xCodigo, Me.xDescripcion, Me.CtaInventario, Me.CtaGasto, Me.CtaCompra})
        Me.lstBuscar.FullRowSelect = True
        Me.lstBuscar.GridLines = True
        Me.lstBuscar.Location = New System.Drawing.Point(240, 100)
        Me.lstBuscar.Name = "lstBuscar"
        Me.lstBuscar.Size = New System.Drawing.Size(465, 176)
        Me.lstBuscar.TabIndex = 9
        Me.lstBuscar.UseCompatibleStateImageBehavior = False
        Me.lstBuscar.View = System.Windows.Forms.View.Details
        '
        'xCodigo
        '
        Me.xCodigo.Text = "Familia"
        Me.xCodigo.Width = 46
        '
        'xDescripcion
        '
        Me.xDescripcion.Text = "Descripcion"
        Me.xDescripcion.Width = 131
        '
        'CtaInventario
        '
        Me.CtaInventario.Text = "Prefijo Cta.Inv."
        Me.CtaInventario.Width = 82
        '
        'CtaGasto
        '
        Me.CtaGasto.Text = "Prefijo Cta. Gasto"
        Me.CtaGasto.Width = 97
        '
        'CtaCompra
        '
        Me.CtaCompra.Text = "Prefijo Cta. Compra"
        Me.CtaCompra.Width = 105
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtBuscar.Location = New System.Drawing.Point(283, 72)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(229, 22)
        Me.txtBuscar.TabIndex = 8
        Me.txtBuscar.Text = "BUSCAR DESCRIPCION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.ico_buscar
        Me.PictureBox1.Location = New System.Drawing.Point(240, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(560, 13)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(37, 38)
        Me.BtnNuevo.TabIndex = 5
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(603, 13)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(37, 38)
        Me.btnModificar.TabIndex = 6
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(646, 13)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(37, 38)
        Me.BtnEliminar.TabIndex = 7
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Image = Global.WindowsApplication1.My.Resources.Resources.save_C_mayseg
        Me.BtnGrabar.Location = New System.Drawing.Point(517, 13)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(37, 38)
        Me.BtnGrabar.TabIndex = 4
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'frmFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 307)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lstBuscar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.GbxDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmFamilia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mtto. Familias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbxDatos.ResumeLayout(False)
        Me.GbxDatos.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lstBuscar As System.Windows.Forms.ListView
    Friend WithEvents xCodigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents xDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrefijoCtaGasto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPrefijoCtaInv As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CtaInventario As System.Windows.Forms.ColumnHeader
    Friend WithEvents CtaGasto As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtPrefijoCtaCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CtaCompra As System.Windows.Forms.ColumnHeader
End Class
