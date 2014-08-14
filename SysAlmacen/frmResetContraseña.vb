Public Class frmResetContraseña

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Dim cont = 0
        If txtNueva.Text = "" Or txtConfirmar.Text = "" Then
            MsgBox("Todos los campos tienen que estar llenos")
            txtNueva.Text = ""
            txtConfirmar.Text = ""
            txtNueva.Focus()
        Else
            If txtNueva.Text <> txtConfirmar.Text Then
                MsgBox("No Coinciden los Datos")
                txtNueva.Text = ""
                txtConfirmar.Text = ""
                txtNueva.Focus()
                frmPrincipal.Show()
                Me.Hide()
            Else
                cont = 1
            End If
            Do While cont = 1
                Dim oclsUsuarios = New clsUsuarios()
                oclsUsuarios.CambiaContraseñaUsuario(LoginUsuario, txtNueva.Text)
                cont = 2
                MsgBox("Cambio Exitoso", vbInformation, "Sistema Almacen")
                Me.Close()
            Loop
        End If
    End Sub
    Private Sub txtNueva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNueva.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtNueva.Focus()
        End If
    End Sub

    Private Sub btnReset_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnReset.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnReset.PerformClick()
        End If

    End Sub
    Private Sub txtConfirmar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirmar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnReset.PerformClick()
        End If
    End Sub
End Class