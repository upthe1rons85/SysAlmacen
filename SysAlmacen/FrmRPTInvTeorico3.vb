Public Class frmRPTInvTeorico3

    Private Sub frmRPTInvTeorico3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInvTeorico3.spInformeInvTeorico3' Puede moverla o quitarla según sea necesario.
        Me.spInformeInvTeorico3TableAdapter.Fill(Me.DSInvTeorico3.spInformeInvTeorico3)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class