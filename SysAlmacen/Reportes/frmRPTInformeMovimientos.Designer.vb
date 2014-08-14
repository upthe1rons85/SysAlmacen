<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInformeMovimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInformeMovimientos))
        Me.spSelKardexMovBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.DSInformeMov = New WindowsApplication1.DSInformeMov()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()

        Me.DSInformeMovs = New WindowsApplication1.DSInformeMovs()
        Me.spSelKardexMovBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.spSelKardexMovTableAdapter = New WindowsApplication1.DSInformeMovsTableAdapters.spSelKardexMovTableAdapter()
        CType(Me.DSInformeMovs, System.ComponentModel.ISupportInitialize).BeginInit()

        ' Me.spSelKardexMovTableAdapter = New WindowsApplication1.DSInformeMovTableAdapters.spSelKardexMovTableAdapter()
        CType(Me.spSelKardexMovBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.DSInformeMov, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.SuspendLayout()
        '
        'spSelKardexMovBindingSource
        '
        Me.spSelKardexMovBindingSource.DataMember = "spSelKardexMov"
        ' Me.spSelKardexMovBindingSource.DataSource = Me.DSInformeMov
        '
        'DSInformeMov
        '
        ' Me.DSInformeMov.DataSetName = "DSInformeMov"
        ' Me.DSInformeMov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSInformeMov"
        ReportDataSource1.Value = Me.spSelKardexMovBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTInformeMovimientos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(658, 391)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSInformeMovs
        '
        Me.DSInformeMovs.DataSetName = "DSInformeMovs"
        Me.DSInformeMovs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spSelKardexMovBindingSource
        '
        Me.spSelKardexMovBindingSource.DataMember = "spSelKardexMov"
        Me.spSelKardexMovBindingSource.DataSource = Me.DSInformeMovs
        '

        'spSelKardexMovTableAdapter
        '
        Me.spSelKardexMovTableAdapter.ClearBeforeFill = True
        '
        'frmRPTInformeMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 391)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTInformeMovimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de Movimientos"

        CType(Me.DSInformeMovs, System.ComponentModel.ISupportInitialize).EndInit()

        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spSelKardexMovBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.DSInformeMov, System.ComponentModel.ISupportInitialize).EndInit()

        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spSelKardexMovBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSInformeMovs As WindowsApplication1.DSInformeMovs
    Friend WithEvents spSelKardexMovTableAdapter As WindowsApplication1.DSInformeMovsTableAdapters.spSelKardexMovTableAdapter
    'Friend WithEvents DSInformeMov As WindowsApplication1.DSInformeMov
    'Friend WithEvents spSelKardexMovTableAdapter As WindowsApplication1.DSInformeMovTableAdapters.spSelKardexMovTableAdapter
    'Friend WithEvents spSelKardexMovTableAdapter As WindowsApplication1.DSMovimientosTableAdapters.spSelKardexMovTableAdapter
End Class
