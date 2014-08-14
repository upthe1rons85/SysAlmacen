Public Class frmRPTMovSalidasDevo
    Public TipoMov As Integer
    Public FechaInicial As String
    Public FechaFinal As String
    Private Sub frmRPTMovSalidasDevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSMovSalidasDevo.spMuestraMovSalidasDevo' Puede moverla o quitarla según sea necesario.
        Me.spMuestraMovSalidasDevoTableAdapter.Fill(Me.DSMovSalidasDevo.spMuestraMovSalidasDevo, FechaInicial, FechaFinal, TipoMov)
        'Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        'Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 80
        Me.WindowState = FormWindowState.Maximized
        Me.Focus()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class