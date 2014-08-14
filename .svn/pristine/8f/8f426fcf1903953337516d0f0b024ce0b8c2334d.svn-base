
Public Class frmRPTListadoProveedores
    Public CodProv As Integer

    Private Sub frmRPTListadoProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSListadoProveedores.sp_BusProveedor' Puede moverla o quitarla según sea necesario.
        Me.sp_BusProveedorTableAdapter.Fill(Me.DSListadoProveedores.sp_BusProveedor, CodProv)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class