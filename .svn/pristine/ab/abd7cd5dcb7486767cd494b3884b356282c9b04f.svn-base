

Public Class frmRPTInformeProductoPuntoReorden
    Public CodProd As String
    Public FechaInicial As String
    Public FechaFinal As String

    Private Sub frmRPTInformeProductoPuntoReorden_Load (ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSProdReorden.spProdDiasdeConsumo' Puede moverla o quitarla según sea necesario.
        Me.spProdDiasdeConsumoTableAdapter.Fill(Me.DSProdReorden.spProdDiasdeConsumo, CodProd, FechaInicial, FechaFinal)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class