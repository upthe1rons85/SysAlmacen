<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubFamiNiv2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubFamiNiv2))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtCodSubFamiNiv1 = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCodSubFamiNiv2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstBuscar = New System.Windows.Forms.ListView()
        Me.xCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xFamilia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(514, 247)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(38, 21)
        Me.btnSalir.TabIndex = 34
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.TxtCodSubFamiNiv1)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 88)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(88, 54)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(129, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'TxtCodSubFamiNiv1
        '
        Me.TxtCodSubFamiNiv1.Enabled = False
        Me.TxtCodSubFamiNiv1.Location = New System.Drawing.Point(88, 19)
        Me.TxtCodSubFamiNiv1.MaxLength = 4
        Me.TxtCodSubFamiNiv1.Name = "TxtCodSubFamiNiv1"
        Me.TxtCodSubFamiNiv1.Size = New System.Drawing.Size(57, 20)
        Me.TxtCodSubFamiNiv1.TabIndex = 0
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(163, 19)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(54, 20)
        Me.btnConsultar.TabIndex = 1
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descripcion :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Familia Nivel 1 :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCodSubFamiNiv2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 41)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'txtCodSubFamiNiv2
        '
        Me.txtCodSubFamiNiv2.Location = New System.Drawing.Point(56, 15)
        Me.txtCodSubFamiNiv2.MaxLength = 4
        Me.txtCodSubFamiNiv2.Name = "txtCodSubFamiNiv2"
        Me.txtCodSubFamiNiv2.Size = New System.Drawing.Size(58, 20)
        Me.txtCodSubFamiNiv2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo :"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(415, 3)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(37, 38)
        Me.BtnNuevo.TabIndex = 31
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(458, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(37, 38)
        Me.btnModificar.TabIndex = 32
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(501, 3)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(37, 38)
        Me.BtnEliminar.TabIndex = 33
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Image = Global.WindowsApplication1.My.Resources.Resources.save_C_mayseg
        Me.BtnGrabar.Location = New System.Drawing.Point(372, 3)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(37, 38)
        Me.BtnGrabar.TabIndex = 30
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(29, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 29)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Mtto.SubFamilias Nivel 2"
        '
        'lstBuscar
        '
        Me.lstBuscar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.xCodigo, Me.xFamilia, Me.xDescripcion})
        Me.lstBuscar.FullRowSelect = True
        Me.lstBuscar.GridLines = True
        Me.lstBuscar.Location = New System.Drawing.Point(244, 93)
        Me.lstBuscar.MultiSelect = False
        Me.lstBuscar.Name = "lstBuscar"
        Me.lstBuscar.Size = New System.Drawing.Size(308, 148)
        Me.lstBuscar.TabIndex = 29
        Me.lstBuscar.UseCompatibleStateImageBehavior = False
        Me.lstBuscar.View = System.Windows.Forms.View.Details
        '
        'xCodigo
        '
        Me.xCodigo.Text = "Codigo"
        Me.xCodigo.Width = 46
        '
        'xFamilia
        '
        Me.xFamilia.Text = "Sub Familia Niv.1"
        Me.xFamilia.Width = 97
        '
        'xDescripcion
        '
        Me.xDescripcion.Text = "Descripcion"
        Me.xDescripcion.Width = 192
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtBuscar.Location = New System.Drawing.Point(298, 65)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(225, 22)
        Me.txtBuscar.TabIndex = 28
        Me.txtBuscar.Text = "BUSCAR DESCRIPCION"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 272)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(558, 22)
        Me.StatusStrip1.TabIndex = 35
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.ico_buscar
        Me.PictureBox1.Location = New System.Drawing.Point(255, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'frmSubFamiNiv2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 294)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSubFamiNiv2"
        Me.Text = "frmSubFamiNiv2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodSubFamiNiv1 As System.Windows.Forms.TextBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodSubFamiNiv2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstBuscar As System.Windows.Forms.ListView
    Friend WithEvents xCodigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents xFamilia As System.Windows.Forms.ColumnHeader
    Friend WithEvents xDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
