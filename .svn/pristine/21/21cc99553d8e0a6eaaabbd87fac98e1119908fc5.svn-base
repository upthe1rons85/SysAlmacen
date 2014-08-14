<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTListadoProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTListadoProveedores))
        Me.sp_BusProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSListadoProveedores = New WindowsApplication1.DSListadoProveedores()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sp_BusProveedorTableAdapter = New WindowsApplication1.DSListadoProveedoresTableAdapters.sp_BusProveedorTableAdapter()
        CType(Me.sp_BusProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSListadoProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sp_BusProveedorBindingSource
        '
        Me.sp_BusProveedorBindingSource.DataMember = "sp_BusProveedor"
        Me.sp_BusProveedorBindingSource.DataSource = Me.DSListadoProveedores
        '
        'DSListadoProveedores
        '
        Me.DSListadoProveedores.DataSetName = "DSListadoProveedores"
        Me.DSListadoProveedores.EnforceConstraints = False
        Me.DSListadoProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.sp_BusProveedorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTListadoProveedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(752, 357)
        Me.ReportViewer1.TabIndex = 0
        '
        'sp_BusProveedorTableAdapter
        '
        Me.sp_BusProveedorTableAdapter.ClearBeforeFill = True
        '
        'frmRPTListadoProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 357)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTListadoProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Proveedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.sp_BusProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSListadoProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sp_BusProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSListadoProveedores As WindowsApplication1.DSListadoProveedores
    Friend WithEvents sp_BusProveedorTableAdapter As WindowsApplication1.DSListadoProveedoresTableAdapters.sp_BusProveedorTableAdapter
End Class
