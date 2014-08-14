<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTInvTeorico2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTInvTeorico2))
        Me.spInformeInvTeorico2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSInvTeorico2 = New WindowsApplication1.DSInvTeorico2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spInformeInvTeorico2TableAdapter = New WindowsApplication1.DSInvTeorico2TableAdapters.spInformeInvTeorico2TableAdapter()
        CType(Me.spInformeInvTeorico2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSInvTeorico2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spInformeInvTeorico2BindingSource
        '
        Me.spInformeInvTeorico2BindingSource.DataMember = "spInformeInvTeorico2"
        Me.spInformeInvTeorico2BindingSource.DataSource = Me.DSInvTeorico2
        '
        'DSInvTeorico2
        '
        Me.DSInvTeorico2.DataSetName = "DSInvTeorico2"
        Me.DSInvTeorico2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSInvTeorico2"
        ReportDataSource1.Value = Me.spInformeInvTeorico2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTInvTeorico2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(614, 544)
        Me.ReportViewer1.TabIndex = 0
        '
        'spInformeInvTeorico2TableAdapter
        '
        Me.spInformeInvTeorico2TableAdapter.ClearBeforeFill = True
        '
        'frmRPTInvTeorico2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 544)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTInvTeorico2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Inventario Teorico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.spInformeInvTeorico2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSInvTeorico2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spInformeInvTeorico2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSInvTeorico2 As WindowsApplication1.DSInvTeorico2
    Friend WithEvents spInformeInvTeorico2TableAdapter As WindowsApplication1.DSInvTeorico2TableAdapters.spInformeInvTeorico2TableAdapter
End Class
