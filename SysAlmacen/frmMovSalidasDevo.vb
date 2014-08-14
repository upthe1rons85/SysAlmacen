Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Public Class frmMovSalidasDevo
    Dim TipoMov As Integer = 51
   
    Private Sub frmMovSalidasDevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Informe de Movimientos" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
        RbtSalidas.Checked = True
        Dim toolTipGrabar As New ToolTip()
        toolTipGrabar.SetToolTip(Me.btnImprimir, "Imprimir")
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.DtpFechaFinal.Value < Me.DtpFechaInicial.Value Then
            MsgBox("La Fecha Final No Debe Ser Menor a la Fecha Inicial..", MsgBoxStyle.Information)
            Me.DtpFechaFinal.Focus()
        Else
            Dim frm As New frmRPTMovSalidasDevo
            frm.TipoMov = TipoMov
            frm.FechaInicial = Format(DtpFechaInicial.Value, "yyyyMMdd")
            frm.FechaFinal = Format(DtpFechaFinal.Value, "yyyyMMdd")
            frm.ShowDialog()
        End If

    End Sub
    Private Sub RbtSalidas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtSalidas.CheckedChanged
        TipoMov = 51
    End Sub
    Private Sub RbtDevoluciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtDevoluciones.CheckedChanged
        TipoMov = 6
    End Sub
End Class