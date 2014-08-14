Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports WindowsApplication1.mdVariables
Imports System.Data.SqlClient
Public Class InformeInventarioTeorico

    Public CodigoProducto As String
   
    Private Sub InformeInventarioTeorico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'InvTeorico.spSelInventarioHistorico' Puede moverla o quitarla según sea necesario.
        Me.spSelInventarioHistoricoTableAdapter.Fill(Me.InvTeorico.spSelInventarioHistorico, CodigoProducto)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class