Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports WindowsApplication1.mdVariables
Imports System.Data.SqlClient
Public Class frmSaldoProducto
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTSaldoProducto()
        frm.fecha = Format(DtpFecha.Value, "yyyyMMdd")
        frm.ShowDialog()
    End Sub
End Class