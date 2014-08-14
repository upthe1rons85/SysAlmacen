
Public Class frmRPTInformeMovimientos
    Public tipoMov As Integer
    Public fechaInicial As Date
    Public fechaFinal As Date
    Public codigoProd As String

    Private Sub frmRPTInformeMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInformeMovs.spSelKardexMov' Puede moverla o quitarla según sea necesario.
        Me.spSelKardexMovTableAdapter.Fill(Me.DSInformeMovs.spSelKardexMov, tipoMov, fechaInicial, fechaFinal, codigoProd)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class