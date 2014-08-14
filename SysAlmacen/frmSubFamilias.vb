Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Public Class frmSubFamilias
    Dim wcodigo As String
    Dim Modifica As Boolean = False
    Private Sub frmSubFamilias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento SubFamilias" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.MaximizeBox = False
        BtnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        txtFamilia.Enabled = True
        GbxFamilia.Enabled = True
        txtFamilia.Focus()
        LlenaLista()
    End Sub
    Private Sub cargadatos()
        Dim oclsSubFamilias = New clsSubFamilias()
        Dim dr As SqlDataReader
        dr = oclsSubFamilias.SeleccionaSubFamilias(Me.txtFamilia.Text, Me.txtCodigo.Text)
        If dr.Read() Then
            Me.txtCodigo.Text = dr("CodSubFami").ToString()
            Me.txtFamilia.Text = dr("CodFamilia").ToString()
            Me.txtDescripcion.Text = dr("Descripcion").ToString()
            Me.txtCuentaInventario.Text = dr("CuentaInventario").ToString()
            Me.txtCuentaGasto.Text = dr("CuentaGasto").ToString()
            Me.txtCuentaCompra.Text = dr("CuentaCompra").ToString()
            txtCodigo.Enabled = False
            txtFamilia.Enabled = False
            txtDescripcion.Enabled = False
            txtCuentaInventario.Enabled = False
            txtCuentaGasto.Enabled = False
            txtCuentaCompra.Enabled = False
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            btnModificar.Enabled = True
            BtnEliminar.Enabled = True
            btnConsultar.Enabled = False
            Me.txtDescripcion.Focus()
        Else
            Me.txtDescripcion.Focus()
            MsgBox("Codigo no encontrado, Se generara uno nuevo", vbInformation, "Sistema Almacen")
            Me.txtFamilia.Enabled = False
            Me.txtCodigo.Enabled = True
            Me.BtnGrabar.Enabled = True
            Me.BtnNuevo.Enabled = True
            Me.btnModificar.Enabled = False
            Me.BtnEliminar.Enabled = False
            Me.btnConsultar.Enabled = True
            Me.txtDescripcion.Enabled = True
            Me.txtCuentaInventario.Enabled = True
            Me.txtCuentaGasto.Enabled = True
            Me.txtCuentaCompra.Enabled = True
            Me.txtDescripcion.Focus()
        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Me.txtFamilia.Enabled = False
        Me.txtCodigo.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtCuentaInventario.Enabled = True
        Me.txtCuentaGasto.Enabled = True
        Me.txtCuentaCompra.Enabled = True
        Me.txtCodigo.Focus()
        Me.BtnGrabar.Enabled = True
        Me.btnConsultar.Enabled = True
        Me.BtnNuevo.Enabled = False
        Me.btnModificar.Enabled = False
        Me.BtnEliminar.Enabled = False
        Modifica = True
        LlenaLista()
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If Me.txtCodigo.Text = "" Or Me.txtFamilia.Text = "" Or Me.txtDescripcion.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Almacen")
            Me.txtCodigo.Focus()
        Else
            Try
                Me.txtDescripcion.Text = UCase(Me.txtDescripcion.Text)
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()
                Dim commandbus As New SqlCommand("spValidaSubFamilia", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@CodSubFami", txtCodigo.Text)
                commandbus.Parameters.AddWithValue("@CodFamilia", txtFamilia.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > "0" Then
                    Dim pclsSubFamilias = New clsSubFamilias()
                    pclsSubFamilias.ActualizaSubFamilias(Me.txtCodigo.Text, Me.txtFamilia.Text, Me.txtDescripcion.Text, Me.txtCuentaInventario.Text, Me.txtCuentaGasto.Text, Me.txtCuentaCompra.Text)
                    MsgBox("Actualizado Correctamente  ", vbInformation, "Sistema Almacen")
                Else
                    Dim sXML = "<xSubFamilias>"
                    sXML += "<CodSubFami>" + Me.txtCodigo.Text + "</CodSubFami>"
                    sXML += "<CodFamilia>" + Me.txtFamilia.Text + "</CodFamilia>"
                    sXML += "<Descripcion>" + Me.txtDescripcion.Text + "</Descripcion>"
                    sXML += "<CuentaInventario>" + Me.txtCuentaInventario.Text + "</CuentaInventario>"
                    sXML += "<CuentaGasto>" + Me.txtCuentaGasto.Text + "</CuentaGasto>"
                    sXML += "<CuentaCompra>" + Me.txtCuentaCompra.Text + "</CuentaCompra>"
                    sXML += "</xSubFamilias>"
                    Dim xclsSubFamilias = New clsSubFamilias()
                    xclsSubFamilias.InsertaSubFamilias(sXML)
                    MsgBox("Registrado Correctamente", vbInformation, "Sistema Almacen")
                    LlenaLista()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Almacen")
            End Try
            
            Me.txtCodigo.Enabled = False
            Me.txtDescripcion.Enabled = False
            Me.txtCuentaInventario.Enabled = False
            Me.txtCuentaGasto.Enabled = False
            Me.txtCuentaCompra.Enabled = False
            Me.BtnGrabar.Enabled = False
            Me.BtnNuevo.Enabled = True
            Me.BtnEliminar.Enabled = False
            Me.btnModificar.Enabled = False
            Me.txtCodigo.Clear()
            Me.txtFamilia.Clear()
            Me.txtDescripcion.Clear()
            Me.txtCuentaInventario.Clear()
            Me.txtCuentaGasto.Clear()
            Me.txtCuentaCompra.Clear()
            LlenaLista()
            Modifica = False
            Me.txtFamilia.Enabled = True
            Me.txtFamilia.Focus()
        End If
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If Me.txtCodigo.Text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Almacen")
            txtCodigo.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsFamilia = New clsSubFamilias()
                oclsFamilia.EliminaSubFamilia(Me.txtCodigo.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Almacen")
                BtnNuevo.Enabled = True
                btnModificar.Enabled = False
                BtnEliminar.Enabled = False
                Me.txtFamilia.Focus()
                Me.txtFamilia.Enabled = True
                Me.txtCodigo.Enabled = False
                Me.txtDescripcion.Enabled = False
                Me.txtCuentaInventario.Enabled = False
                Me.txtCuentaGasto.Enabled = False
                Me.txtCuentaCompra.Enabled = False
                Me.txtCodigo.Clear()
                Me.txtFamilia.Clear()
                Me.txtDescripcion.Clear()
                Me.txtCuentaInventario.Clear()
                Me.txtCuentaGasto.Clear()
                Me.txtCuentaCompra.Clear()
                LlenaLista()
            End If
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Me.txtFamilia.Enabled = True
        Me.txtCodigo.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.txtCuentaInventario.Enabled = False
        Me.txtCuentaGasto.Enabled = False
        Me.txtCuentaCompra.Enabled = False
        Me.BtnGrabar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnModificar.Enabled = False
        Me.BtnEliminar.Enabled = False
        Me.btnConsultar.Enabled = True
        txtCodigo.Clear()
        txtFamilia.Clear()
        txtDescripcion.Clear()
        Me.txtCuentaInventario.Clear()
        Me.txtCuentaGasto.Clear()
        Me.txtCuentaCompra.Clear()
        Me.txtFamilia.Focus()
        LlenaLista()
    End Sub
    Private Sub LlenaLista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim consulta As String = "Select CodSubFami,CodFamilia,Descripcion,CuentaInventario,CuentaGasto,CuentaCompra From CatSubFamilias(nolock) Order By CodFamilia,CodSubFami"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "CatSubFamilias")


        Dim objListItem As New ListViewItem
        Me.lstBuscar.Items.Clear()

        For Each drw As DataRow In ds.Tables("CatSubFamilias").Rows
            objListItem = lstBuscar.Items.Add(drw.Item("CodSubFami").ToString, 0)
            objListItem.SubItems.Add(drw.Item("CodFamilia").ToString)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            objListItem.SubItems.Add(drw.Item("CuentaInventario").ToString)
            objListItem.SubItems.Add(drw.Item("CuentaGasto").ToString)
            objListItem.SubItems.Add(drw.Item("CuentaCompra").ToString)
        Next
    End Sub
    Sub LlenaLista2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim consulta2 As String = "Select CodSubFami,CodFamilia,Descripcion,CuentaInventario,CuentaGasto,CuentaCompra From CatSubFamilias(nolock) where codFamilia=   '" & Me.txtFamilia.Text & "'order by CodFamilia,CodSubFami"
        Dim cmd As New SqlCommand(consulta2, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "CatSubFamilias")

        Dim objListItem As New ListViewItem
        Me.lstBuscar.Items.Clear()

        For Each drw As DataRow In ds.Tables("CatSubFamilias").Rows
            objListItem = lstBuscar.Items.Add(drw.Item("CodSubFami").ToString, 0)
            objListItem.SubItems.Add(drw.Item("CodFamilia").ToString)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            objListItem.SubItems.Add(drw.Item("CuentaInventario").ToString)
            objListItem.SubItems.Add(drw.Item("CuentaGasto").ToString)
            objListItem.SubItems.Add(drw.Item("CuentaCompra").ToString)
        Next
    End Sub
    Private Sub lstBuscar_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstBuscar.MouseDoubleClick
        txtCodigo.Text = lstBuscar.SelectedItems(0).SubItems(0).Text
        txtFamilia.Text = lstBuscar.SelectedItems(0).SubItems(1).Text
        txtDescripcion.Text = lstBuscar.SelectedItems(0).SubItems(2).Text
        txtCuentaInventario.Text = lstBuscar.SelectedItems(0).SubItems(3).Text
        txtCuentaGasto.Text = lstBuscar.SelectedItems(0).SubItems(4).Text
        txtCuentaCompra.Text = lstBuscar.SelectedItems(0).SubItems(5).Text
        txtCodigo.Enabled = False
        txtFamilia.Enabled = False
        txtDescripcion.Enabled = False
        Me.txtCuentaInventario.Enabled = False
        Me.txtCuentaGasto.Enabled = False
        Me.txtCuentaCompra.Enabled = False
        btnModificar.Enabled = True
        BtnGrabar.Enabled = False
        BtnEliminar.Enabled = True
    End Sub
    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If Modifica = True Then
                Me.txtDescripcion.Focus()
            Else
                If Me.txtCodigo.Text <> "" Then
                    cargadatos()
                    'LlenaLista2()
                End If
            End If
            Me.txtDescripcion.Focus()
        End If
       
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtFamilia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFamilia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtFamilia.Text = "" Then
                MsgBox("Debe Capturar un Codigo de Familia.", vbInformation, "Sistema Almacen")
                Me.txtFamilia.Focus()
            Else
                If Me.txtFamilia.Text > 0 Then
                    Dim oclsFamilias = New clsFamilias()
                    Dim dr As SqlDataReader

                    dr = oclsFamilias.SeleccionaFamilias(Me.txtFamilia.Text)

                    If dr.Read() Then
                        LlenaLista2()
                        Me.txtCodigo.Enabled = True
                        Me.txtDescripcion.Enabled = True
                        Me.txtCuentaInventario.Enabled = True
                        Me.txtCuentaGasto.Enabled = True
                        Me.txtCuentaCompra.Enabled = True
                        Me.txtCodigo.Focus()
                    Else
                        MsgBox("Codigo de Familia no Esta Dado de Alta, Favor de Revisar.", vbInformation, "Sistema Almacen")
                        Me.txtFamilia.Focus()
                        Me.txtFamilia.SelectAll()
                    End If
                End If
            End If
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.Text = ""
        txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtBuscar.ForeColor = Color.Black
    End Sub
    Private Sub txtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsSubFamilias = New clsSubFamilias()
        dr = oclsSubFamilias.BuscarSubFamilias(Me.txtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstBuscar.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CodSubFami").ToString)
                lstLista.SubItems.Add(rRow("CodFamilia").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstLista.SubItems.Add(rRow("CuentaInventario").ToString)
                lstLista.SubItems.Add(rRow("CuentaGasto").ToString)
                lstLista.SubItems.Add(rRow("CuentaCompra").ToString)
                lstBuscar.Items.Add(lstLista)
                Refresh()
                'txtFamilia.Focus()
            Next
            'txtFamilia.Focus()
        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        frmListSubfamilias.ShowDialog()
        Me.Refresh()
        txtFamilia.Text = frmListSubfamilias.DatosLista
        LlenaLista2()
        Me.txtCodigo.Focus()
        LlenaLista()
    End Sub
    Private Function IsNothi() As SqlDataAdapter
        Throw New NotImplementedException
    End Function

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtCuentaInventario.Focus()
        End If
        
    End Sub

    Private Sub txtCuentaInventario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaInventario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtCuentaGasto.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtCuentaGasto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaGasto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtCuentaCompra.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtCuentaCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaCompra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnGrabar.PerformClick()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
End Class