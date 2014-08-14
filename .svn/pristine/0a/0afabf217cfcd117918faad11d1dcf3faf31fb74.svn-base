<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeInventarioTeorico
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
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformeInventarioTeorico))
        Me.spSelInventarioHistoricoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.spSelInventarioHistoricoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spSelInventarioHistoricoBindingSource
        '
        Me.spSelInventarioHistoricoBindingSource.DataMember = "spSelInventarioHistorico"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource9.Name = "DataSet1"
        ReportDataSource9.Value = Me.spSelInventarioHistoricoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTInventarioTeorico.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(621, 356)
        Me.ReportViewer1.TabIndex = 0
        '
        'InformeInventarioTeorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 356)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InformeInventarioTeorico"
        Me.Text = "Informe Inventario Teorico"
        CType(Me.spSelInventarioHistoricoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spSelInventarioHistoricoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvTeorico As WindowsApplication1.InvTeorico
    Friend WithEvents spSelInventarioHistoricoTableAdapter As WindowsApplication1.InvTeoricoTableAdapters.spSelInventarioHistoricoTableAdapter
End Class
