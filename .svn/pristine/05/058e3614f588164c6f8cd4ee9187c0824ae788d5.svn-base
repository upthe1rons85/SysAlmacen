Public Class frmListadoProveedores

    Private Sub LineShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineShape2.Click

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTListadoProveedores()
        frm.CodProv = Val(txtCodigo.Text)
        frm.Show()
    End Sub

    Private Sub frmListadoProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Listado de Proveedores" + Space(10) + CStr(clsTools.VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        rbTodos.Checked = True
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnImprimir.PerformClick()
        End If
    End Sub

    Private Sub rbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTodos.CheckedChanged
        If rbTodos.Checked Then
            txtCodigo.Clear()
        End If
    End Sub

    Private Sub rbCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodigo.CheckedChanged
        If rbCodigo.Checked Then
            txtCodigo.Enabled = True
            txtCodigo.Focus()
        Else
            txtCodigo.Enabled = False
        End If
    End Sub
End Class