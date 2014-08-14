<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAyudaCodigo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAyudaCodigo))
        Me.ListCodigo = New System.Windows.Forms.ListView()
        Me.xCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xUnidadMed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtDescipcion = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListCodigo
        '
        Me.ListCodigo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.xCodigo, Me.xDescripcion, Me.xUnidadMed})
        Me.ListCodigo.FullRowSelect = True
        Me.ListCodigo.GridLines = True
        Me.ListCodigo.Location = New System.Drawing.Point(2, 51)
        Me.ListCodigo.Name = "ListCodigo"
        Me.ListCodigo.Size = New System.Drawing.Size(387, 377)
        Me.ListCodigo.TabIndex = 0
        Me.ListCodigo.UseCompatibleStateImageBehavior = False
        Me.ListCodigo.View = System.Windows.Forms.View.Details
        '
        'xCodigo
        '
        Me.xCodigo.Text = "Codigo Producto"
        Me.xCodigo.Width = 93
        '
        'xDescripcion
        '
        Me.xDescripcion.Text = "Descripcion"
        Me.xDescripcion.Width = 177
        '
        'xUnidadMed
        '
        Me.xUnidadMed.Text = "Unidad Medida"
        Me.xUnidadMed.Width = 112
        '
        'txtDescipcion
        '
        Me.txtDescipcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescipcion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtDescipcion.Location = New System.Drawing.Point(55, 12)
        Me.txtDescipcion.Name = "txtDescipcion"
        Me.txtDescipcion.Size = New System.Drawing.Size(188, 20)
        Me.txtDescipcion.TabIndex = 1
        Me.txtDescipcion.Text = "BUSCAR DESCRIPCION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.ico_buscar
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 429)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(392, 22)
        Me.StatusStrip1.TabIndex = 2
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
        'FrmAyudaCodigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 451)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtDescipcion)
        Me.Controls.Add(Me.ListCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "FrmAyudaCodigo"
        Me.Text = "Ayuda Codigo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescipcion As System.Windows.Forms.TextBox
    Friend WithEvents xCodigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents xDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents xUnidadMed As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ListCodigo As System.Windows.Forms.ListView
End Class
