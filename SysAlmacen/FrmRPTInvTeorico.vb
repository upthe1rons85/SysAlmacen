Public Class frmRPTInvTeorico

    Private Sub frmRPTInvTeorico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInvTeorico.spInformeInvTeorico' Puede moverla o quitarla según sea necesario.
        Me.spInformeInvTeoricoTableAdapter.Fill(Me.DSInvTeorico.spInformeInvTeorico)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class