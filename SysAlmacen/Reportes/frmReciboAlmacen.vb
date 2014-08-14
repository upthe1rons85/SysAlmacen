Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports WindowsApplication1.mdVariables
Imports System.Data.SqlClient
Public Class frmReciboAlmacen
    Public nTipoMovimiento As String
    Public nFolio As String
    Public nProveedor As String
    Public nRefDocumento As String

    Private Sub frmReciboAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSReciboAlmacen.spBusMovimiento' Puede moverla o quitarla según sea necesario.
        DSReciboAlmacen.EnforceConstraints = False
        Me.spBusMovimientoTableAdapter.Fill(Me.DSReciboAlmacen.spBusMovimiento, nTipoMovimiento, nFolio, nProveedor, nRefDocumento)
        Me.ReportViewer1.RefreshReport()


    End Sub
End Class