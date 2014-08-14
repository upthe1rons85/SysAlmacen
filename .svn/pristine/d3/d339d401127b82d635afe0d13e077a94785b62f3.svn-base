Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Public Class frmFamilia
    Dim wcodigo As String
    Private Sub frmFamilia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Familias " + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.MaximizeBox = False
        llenalista()
        txtCodigo.Enabled = True
        BtnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        ' txtCodigo.Focus()
    End Sub
    Private Sub cargadatos()
        Dim oclsFamilias = New clsFamilias()
        Dim dr As SqlDataReader
        dr = oclsFamilias.SeleccionaFamilias(Me.txtCodigo.Text)
        If dr.Read() Then
            Me.txtCodigo.Text = dr("CodFamilia").ToString()
            Me.txtDescripcion.Text = dr("Descripcion").ToString()
            Me.TxtPrefijoCtaInv.Text = dr("PrefijoCuentaInventario").ToString()
            Me.TxtPrefijoCtaGasto.Text = dr("PrefijoCuentaGasto").ToString()
            Me.TxtPrefijoCtaCompra.Text = dr("PrefijoCuentaCompra").ToString()
            txtCodigo.Enabled = False
            GbxDatos.Enabled = False
            txtDescripcion.Focus()
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            btnModificar.Enabled = True
            BtnEliminar.Enabled = True
        Else
            MsgBox("Codigo de Familia no encontrado, Se Generara uno Nuevo" + wcodigo, vbInformation, "Sistema Almacen")
            txtCodigo.Enabled = False
            GbxDatos.Enabled = True
            txtDescripcion.Focus()
            BtnGrabar.Enabled = True
            BtnNuevo.Enabled = True
            btnModificar.Enabled = False
            BtnEliminar.Enabled = False
        End If
    End Sub
    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                txtDescripcion.Focus()
                txtDescripcion.SelectAll()
            End If
            If txtCodigo.Text <> "" Then
                cargadatos()
                llenalista()
                txtDescripcion.Focus()
            End If
        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        llenalista()
        Me.txtCodigo.Enabled = False
        Me.GbxDatos.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = False
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        'Me.txtDescripcion.Enabled = True
        'Me.TxtPrefijoCtaInv.Enabled = False
        'Me.TxtPrefijoCtaGasto.Enabled = False
        Me.txtDescripcion.Focus()
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If txtCodigo.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Almacen")
            txtCodigo.Focus()
        Else
            If TxtPrefijoCtaInv.TextLength <> 10 Then
                'MsgBox(Len(txtDescripcion.Text) & " Caracteres")
                MsgBox("El Prefijo de la Cta.Inventario debe contener 10 Digitos, Favor de Revisar.")
                Me.TxtPrefijoCtaInv.Focus()
                Me.TxtPrefijoCtaInv.SelectAll()
            Else
                If txtCodigo.TextLength >= 50 Then
                    If TxtPrefijoCtaGasto.TextLength <> 7 And TxtPrefijoCtaCompra.TextLength <> 7 Then
                        MsgBox("El Prefijo de la Cta. Gasto debe contener 7 Digitos, Favor de Revisar.")
                        Me.TxtPrefijoCtaGasto.Focus()
                        Me.TxtPrefijoCtaGasto.SelectAll()
                    End If
                Else

                    Try
                        Me.txtDescripcion.Text = UCase(Me.txtDescripcion.Text)
                        Dim cnnConexion = New SqlConnection()
                        Dim clsDB = New clsBD()
                        cnnConexion = clsDB.CreaConexion()

                        Dim commandbus As New SqlCommand("spValidaFamilia", cnnConexion)
                        commandbus.CommandType = CommandType.StoredProcedure
                        commandbus.Parameters.AddWithValue("@CodFamilia", txtCodigo.Text)

                        Dim n As Integer
                        n = RTrim(commandbus.ExecuteScalar())
                        clsDB.CierraConexion(cnnConexion)
                        If n > 0 Then
                            Dim pclsFamilias = New clsFamilias()
                            pclsFamilias.ActualizaFamilias(Me.txtCodigo.Text, Me.txtDescripcion.Text, Me.TxtPrefijoCtaInv.Text, Me.TxtPrefijoCtaGasto.Text, Me.TxtPrefijoCtaCompra.Text)
                            MsgBox("Actualizado Correctamente  " + wcodigo, vbInformation, "Sistema Almacen")
                            limpiar()
                        Else
                            Dim sXML = "<xFamilias>"
                            sXML += "<CodFamilia>" + Me.txtCodigo.Text + "</CodFamilia>"
                            sXML += "<Descripcion>" + Me.txtDescripcion.Text + "</Descripcion>"
                            sXML += "<PrefijoCuentaInventario>" + Me.TxtPrefijoCtaInv.Text + "</PrefijoCuentaInventario>"
                            sXML += "<PrefijoCuentaGasto>" + Me.TxtPrefijoCtaGasto.Text + "</PrefijoCuentaGasto>"
                            sXML += "<PrefijoCuentaCompra>" + Me.TxtPrefijoCtaCompra.Text + "</PrefijoCuentaCompra>"
                            sXML += "</xFamilias>"
                            Dim xclsFamilias = New clsFamilias()
                            xclsFamilias.InsertaFamilias(sXML)
                            MsgBox("Registrado Correctamente" + wcodigo, vbInformation, "Sistema Almacen")
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        MsgBox("Ocurrio un Error", vbInformation, "Sistema Almacen")
                    End Try

                    txtCodigo.Enabled = True
                    GbxDatos.Enabled = False
                    BtnGrabar.Enabled = False
                    BtnNuevo.Enabled = True
                    BtnEliminar.Enabled = False
                    btnModificar.Enabled = False
                    llenalista()
                    limpiar()
                    txtCodigo.Clear()
                    txtCodigo.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If Me.txtCodigo.Text = "" Then
            MsgBox("Debe Capturar un Codigo", vbInformation, "Sistema Almacen")
            txtCodigo.Focus()
        Else
            Dim oclsFamilias = New clsFamilias()
            Dim dr As SqlDataReader
            dr = oclsFamilias.ValidaEliFamilias(Me.txtCodigo.Text)
            If dr.Read() Then
                MsgBox("Familia no puede ser Eliminada, ya que existen SubFamilias asignadas a esta Familia, Favor de Revisar", vbInformation, "Sistema Almacen")
            Else
                If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim oclsFamilia = New clsFamilias()
                    oclsFamilia.EliminaFamilia(Me.txtCodigo.Text)
                    MsgBox("Registro Eliminado", vbInformation, "Sistema Almacen")
                    limpiar()
                    txtCodigo.Clear()
                    BtnGrabar.Enabled = False
                    BtnNuevo.Enabled = True
                    btnModificar.Enabled = False
                    BtnEliminar.Enabled = False
                    llenalista()
                    Me.txtCodigo.Enabled = True
                    Me.txtCodigo.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Me.txtCodigo.Enabled = True
        Me.BtnGrabar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnModificar.Enabled = False
        Me.BtnEliminar.Enabled = False
        txtCodigo.Clear()
        limpiar()
        llenalista()
        Me.txtCodigo.Focus()
    End Sub
    Private Sub llenalista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim consulta As String = "Select CodFamilia,Descripcion,PrefijoCuentaInventario,PrefijoCuentaGasto,PrefijoCuentaCompra From CatFamilias(nolock) Order By CodFamilia"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "CatFamilias")


        Dim objListItem As New ListViewItem
        Me.lstBuscar.Items.Clear()

        For Each drw As DataRow In ds.Tables("CatFamilias").Rows
            objListItem = lstBuscar.Items.Add(drw.Item("CodFamilia").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            objListItem.SubItems.Add(drw.Item("PrefijoCuentaInventario").ToString)
            objListItem.SubItems.Add(drw.Item("PrefijoCuentaGasto").ToString)
            objListItem.SubItems.Add(drw.Item("PrefijoCuentaCompra").ToString)
        Next
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.Text = ""
        txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtBuscar.ForeColor = Color.Black
    End Sub
    Private Sub txtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsFamilias = New clsFamilias()
        dr = oclsFamilias.BuscarFamilias(Me.txtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstBuscar.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CodFamilia").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstLista.SubItems.Add(rRow("PrefijoCuentaInventario").ToString)
                lstLista.SubItems.Add(rRow("PrefijoCuentaGasto").ToString)
                lstLista.SubItems.Add(rRow("PrefijoCuentaCompra").ToString)
                lstBuscar.Items.Add(lstLista)
                Refresh()
            Next
            'txtDescripcion.Focus()
        End If
    End Sub
    Private Sub lstBuscar_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstBuscar.MouseDoubleClick
        txtCodigo.Text = lstBuscar.SelectedItems(0).SubItems(0).Text
        txtDescripcion.Text = lstBuscar.SelectedItems(0).SubItems(1).Text
        TxtPrefijoCtaInv.Text = lstBuscar.SelectedItems(0).SubItems(2).Text
        TxtPrefijoCtaGasto.Text = lstBuscar.SelectedItems(0).SubItems(3).Text
        TxtPrefijoCtaCompra.Text = lstBuscar.SelectedItems(0).SubItems(4).Text
        txtCodigo.Enabled = False
        'txtDescripcion.Enabled = False
        Me.GbxDatos.Enabled = False
        btnModificar.Enabled = True
        BtnGrabar.Enabled = False
        BtnEliminar.Enabled = True
    End Sub
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            TxtPrefijoCtaInv.Focus()
        End If
    End Sub
    Private Sub TxtPrefijoCtaInv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrefijoCtaInv.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            TxtPrefijoCtaGasto.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtPrefijoCtaGasto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrefijoCtaGasto.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            TxtPrefijoCtaCompra.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub limpiar()
        Me.txtDescripcion.Clear()
        Me.TxtPrefijoCtaInv.Clear()
        Me.TxtPrefijoCtaGasto.Clear()
        Me.TxtPrefijoCtaCompra.Clear()
        Me.GbxDatos.Enabled = False
    End Sub

    Private Sub TxtPrefijoCtaCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrefijoCtaCompra.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            BtnGrabar.PerformClick()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    
End Class