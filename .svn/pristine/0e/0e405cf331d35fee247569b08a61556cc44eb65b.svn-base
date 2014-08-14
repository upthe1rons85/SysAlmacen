Public Class frmInfProductos2

    Private Sub frmInfProductos2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInfProductos2.spInformeProductos2' Puede moverla o quitarla según sea necesario.
        Me.spInformeProductos2TableAdapter.Fill(Me.DSInfProductos2.spInformeProductos2)

        Me.ReportViewer1.RefreshReport()

        Me.Text = "Informe de los Productos" + Space(5) + CStr(clsTools.VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
    End Sub
End Class