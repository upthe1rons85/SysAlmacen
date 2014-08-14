<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTMovSalidasDevo
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSMovSalidasDevo = New WindowsApplication1.DSMovSalidasDevo()
        Me.spMuestraMovSalidasDevoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spMuestraMovSalidasDevoTableAdapter = New WindowsApplication1.DSMovSalidasDevoTableAdapters.spMuestraMovSalidasDevoTableAdapter()
        CType(Me.DSMovSalidasDevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spMuestraMovSalidasDevoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSMovSalidasDevo"
        ReportDataSource1.Value = Me.spMuestraMovSalidasDevoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTInformeMovSalidasDevo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(706, 316)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSMovSalidasDevo
        '
        Me.DSMovSalidasDevo.DataSetName = "DSMovSalidasDevo"
        Me.DSMovSalidasDevo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spMuestraMovSalidasDevoBindingSource
        '
        Me.spMuestraMovSalidasDevoBindingSource.DataMember = "spMuestraMovSalidasDevo"
        Me.spMuestraMovSalidasDevoBindingSource.DataSource = Me.DSMovSalidasDevo
        '
        'spMuestraMovSalidasDevoTableAdapter
        '
        Me.spMuestraMovSalidasDevoTableAdapter.ClearBeforeFill = True
        '
        'frmRPTMovSalidasDevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 316)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRPTMovSalidasDevo"
        Me.Text = "frmRPTMovSalidasDevo"
        CType(Me.DSMovSalidasDevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spMuestraMovSalidasDevoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spMuestraMovSalidasDevoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSMovSalidasDevo As WindowsApplication1.DSMovSalidasDevo
    Friend WithEvents spMuestraMovSalidasDevoTableAdapter As WindowsApplication1.DSMovSalidasDevoTableAdapters.spMuestraMovSalidasDevoTableAdapter
End Class
