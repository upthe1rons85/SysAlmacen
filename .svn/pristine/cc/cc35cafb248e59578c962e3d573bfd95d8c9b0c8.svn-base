Public Class frmInventarios

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If rbTodos.Checked Then
            Dim frm As New frmRPTInvTeorico
            frm.ShowDialog()
        Else
            If rbSobrantes.Checked Then
                Dim frm As New frmRPTInvTeorico2
                frm.ShowDialog()
            Else
                If rbFaltantes.Checked Then
                    Dim frm As New frmRPTInvTeorico3
                    frm.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub frmInventarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Inventario Teorico" + Space(5) + CStr(clsTools.VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
    End Sub
End Class