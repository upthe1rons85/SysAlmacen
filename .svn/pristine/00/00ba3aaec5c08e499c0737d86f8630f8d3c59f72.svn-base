Imports Microsoft.Reporting.WinForms
Public Class frmRPTInformeMov
    Public TipoMov As Integer
    Public CodProd As Integer
    Public Folio As Integer
    Public Lote As String
    Public Ceco As Integer
    Public FechaInicial As String
    Public FechaFinal As String

    Private Sub frmRPTInformeMov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInformeMov.spSelKardexMov' Puede moverla o quitarla según sea necesario.
        Me.spSelKardexMovTableAdapter.Fill(Me.DSInformeMov.spSelKardexMov, TipoMov, CodProd, Folio, Lote, Ceco, FechaInicial, FechaFinal)
        Me.WindowState = FormWindowState.Maximized
        Me.Focus()
        ReportViewer1.ZoomPercent = 150
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class