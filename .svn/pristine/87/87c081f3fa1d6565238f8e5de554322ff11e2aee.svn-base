<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInvTeorico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInvTeorico))
        Me.spInformeInvTeoricoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSInvTeorico = New WindowsApplication1.DSInvTeorico()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spInformeInvTeoricoTableAdapter = New WindowsApplication1.DSInvTeoricoTableAdapters.spInformeInvTeoricoTableAdapter()
        CType(Me.spInformeInvTeoricoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSInvTeorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spInformeInvTeoricoBindingSource
        '
        Me.spInformeInvTeoricoBindingSource.DataMember = "spInformeInvTeorico"
        Me.spInformeInvTeoricoBindingSource.DataSource = Me.DSInvTeorico
        '
        'DSInvTeorico
        '
        Me.DSInvTeorico.DataSetName = "DSInvTeorico"
        Me.DSInvTeorico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSInvTeorico1"
        ReportDataSource1.Value = Me.spInformeInvTeoricoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTInvTeorico.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(662, 494)
        Me.ReportViewer1.TabIndex = 0
        '
        'spInformeInvTeoricoTableAdapter
        '
        Me.spInformeInvTeoricoTableAdapter.ClearBeforeFill = True
        '
        'frmRPTInvTeorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 494)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTInvTeorico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Inventario Teorico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spInformeInvTeoricoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSInvTeorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spInformeInvTeoricoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSInvTeorico As WindowsApplication1.DSInvTeorico
    Friend WithEvents spInformeInvTeoricoTableAdapter As WindowsApplication1.DSInvTeoricoTableAdapters.spInformeInvTeoricoTableAdapter
End Class
