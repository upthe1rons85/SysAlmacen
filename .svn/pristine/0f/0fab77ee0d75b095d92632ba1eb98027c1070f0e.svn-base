Imports Microsoft.Reporting.WinForms

Public Class frmRPTInformeDetalleMov
    Public TipoMov As Integer
    Public CodProd As Integer
    Public Folio As Integer
    Public Lote As String
    Public Ceco As Integer
    Public FechaInicial As Date
    Public FechaFinal As Date
    Private Sub frmRPTInformeDetalleMov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DSDetalleMov.EnforceConstraints = False
        'TODO: esta línea de código carga datos en la tabla 'DSDetalleMov.spDetalleTipoMov' Puede moverla o quitarla según sea necesario.
        Me.spDetalleTipoMovTableAdapter.Fill(Me.DSDetalleMov.spDetalleTipoMov, TipoMov, CodProd, Folio, Lote, Ceco, FechaInicial, FechaFinal)
        ReportViewer1.ZoomPercent = 150
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class