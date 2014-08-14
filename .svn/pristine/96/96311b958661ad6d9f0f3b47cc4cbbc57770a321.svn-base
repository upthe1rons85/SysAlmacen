Public Class frmInfProductos

    Private Sub frmInfProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInfProductos.spInformeProductos' Puede moverla o quitarla según sea necesario.
        Me.spInformeProductosTableAdapter.Fill(Me.DSInfProductos.spInformeProductos, xcodigo)

        Me.ReportViewer1.RefreshReport()

        Me.Text = "Informe del Producto" + Space(5) + CStr(clsTools.VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
    End Sub
End Class