Public Class frmRPTInventarioTeorico
    Public ncodigoproducto As Integer
    Private Sub frmRPTInventarioTeorico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'InventarioTeorico.spSelInventarioHistorico' Puede moverla o quitarla según sea necesario.
        Me.spSelInventarioHistoricoTableAdapter.Fill(Me.InventarioTeorico.spSelInventarioHistorico, ncodigoproducto)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class