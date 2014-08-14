<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInformeProductoPuntoReorden
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInformeProductoPuntoReorden))
        Me.spProdDiasdeConsumoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSProdReorden = New WindowsApplication1.DSProdReorden()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spProdDiasdeConsumoTableAdapter = New WindowsApplication1.DSProdReordenTableAdapters.spProdDiasdeConsumoTableAdapter()
        CType(Me.spProdDiasdeConsumoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSProdReorden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spProdDiasdeConsumoBindingSource
        '
        Me.spProdDiasdeConsumoBindingSource.DataMember = "spProdDiasdeConsumo"
        Me.spProdDiasdeConsumoBindingSource.DataSource = Me.DSProdReorden
        '
        'DSProdReorden
        '
        Me.DSProdReorden.DataSetName = "DSProdReorden"
        Me.DSProdReorden.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSInfProdPtoReorden"
        ReportDataSource1.Value = Me.spProdDiasdeConsumoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTInformeProducto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(647, 416)
        Me.ReportViewer1.TabIndex = 0
        '
        'spProdDiasdeConsumoTableAdapter
        '
        Me.spProdDiasdeConsumoTableAdapter.ClearBeforeFill = True
        '
        'frmRPTInformeProductoPuntoReorden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 416)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTInformeProductoPuntoReorden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de Producto en Punto de Reorden"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spProdDiasdeConsumoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSProdReorden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spProdDiasdeConsumoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSProdReorden As WindowsApplication1.DSProdReorden
    Friend WithEvents spProdDiasdeConsumoTableAdapter As WindowsApplication1.DSProdReordenTableAdapters.spProdDiasdeConsumoTableAdapter
End Class
