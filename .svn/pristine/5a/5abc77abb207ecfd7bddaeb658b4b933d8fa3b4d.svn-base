Public Class frmRPTSaldoProducto
    Public fecha As String

    Private Sub frmRPTSaldoProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSSaldoProducto.spMovimientosProductos' Puede moverla o quitarla según sea necesario.
        Me.spMovimientosProductosTableAdapter.Fill(Me.DSSaldoProducto.spMovimientosProductos, fecha)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class