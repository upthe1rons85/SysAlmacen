<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInformeDetalleMov
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInformeDetalleMov))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSDetalleMov = New WindowsApplication1.DSDetalleMov()
        Me.spDetalleTipoMovBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spDetalleTipoMovTableAdapter = New WindowsApplication1.DSDetalleMovTableAdapters.spDetalleTipoMovTableAdapter()
        CType(Me.DSDetalleMov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spDetalleTipoMovBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSDetalleMov"
        ReportDataSource1.Value = Me.spDetalleTipoMovBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTInformeDetalleMov.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(832, 372)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSDetalleMov
        '
        Me.DSDetalleMov.DataSetName = "DSDetalleMov"
        Me.DSDetalleMov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spDetalleTipoMovBindingSource
        '
        Me.spDetalleTipoMovBindingSource.DataMember = "spDetalleTipoMov"
        Me.spDetalleTipoMovBindingSource.DataSource = Me.DSDetalleMov
        '
        'spDetalleTipoMovTableAdapter
        '
        Me.spDetalleTipoMovTableAdapter.ClearBeforeFill = True
        '
        'frmRPTInformeDetalleMov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 372)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTInformeDetalleMov"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Detalle de Movimientos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DSDetalleMov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spDetalleTipoMovBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spDetalleTipoMovBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSDetalleMov As WindowsApplication1.DSDetalleMov
    Friend WithEvents spDetalleTipoMovTableAdapter As WindowsApplication1.DSDetalleMovTableAdapters.spDetalleTipoMovTableAdapter
End Class
