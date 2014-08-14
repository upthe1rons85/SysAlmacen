<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReciboAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciboAlmacen))
        Me.spBusMovimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSReciboAlmacen = New WindowsApplication1.DSReciboAlmacen()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spBusMovimientoTableAdapter = New WindowsApplication1.DSReciboAlmacenTableAdapters.spBusMovimientoTableAdapter()
        CType(Me.spBusMovimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSReciboAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spBusMovimientoBindingSource
        '
        Me.spBusMovimientoBindingSource.DataMember = "spBusMovimiento"
        Me.spBusMovimientoBindingSource.DataSource = Me.DSReciboAlmacen
        '
        'DSReciboAlmacen
        '
        Me.DSReciboAlmacen.DataSetName = "DSReciboAlmacen"
        Me.DSReciboAlmacen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSReciboAlmacen"
        ReportDataSource1.Value = Me.spBusMovimientoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTReciboAlmacen.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(705, 343)
        Me.ReportViewer1.TabIndex = 0
        '
        'spBusMovimientoTableAdapter
        '
        Me.spBusMovimientoTableAdapter.ClearBeforeFill = True
        '
        'frmReciboAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 343)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReciboAlmacen"
        Me.Text = "frmReciboAlmacen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spBusMovimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSReciboAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spBusMovimientoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSReciboAlmacen As WindowsApplication1.DSReciboAlmacen
    Friend WithEvents spBusMovimientoTableAdapter As WindowsApplication1.DSReciboAlmacenTableAdapters.spBusMovimientoTableAdapter
End Class
