Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Public Class frmUnidadesMedida
    Dim usuario As String
    Dim Existencias As String
    Public modifica As Integer
    Dim wcodigo As String
    Private Sub cargadatos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim oclsUnidadesMedida = New clsUnidadesMedida()
        Dim dr As SqlDataReader
        dr = oclsUnidadesMedida.SeleccionaUnidadesMedida(Me.txtCodigo.Text)
        If dr.Read() Then
            Me.txtCodigo.Text = dr("UnidadMedida").ToString()
            Me.txtDescripcion.Text = dr("Descripcion").ToString()
            Me.txtAbreviacion.Text = dr("Abreviacion").ToString()
        Else
            MsgBox("Codigo no encontrado...", MessageBoxIcon.Error)
            txtDescripcion.Enabled = False
            txtAbreviacion.Enabled = False
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            btnModificar.Enabled = False
            BtnEliminar.Enabled = False
            txtCodigo.Clear()
            txtDescripcion.Clear()
            txtAbreviacion.Clear()
            LlenarLista()
        End If
    End Sub
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtAbreviacion.Focus()
        End If
    End Sub
    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                txtDescripcion.Focus()
            End If
            If txtCodigo.Text <> "" Then
                cargadatos()
                BtnGrabar.Enabled = False
                BtnNuevo.Enabled = False
                btnModificar.Enabled = True
                BtnEliminar.Enabled = True
                txtCodigo.Focus()
                LlenarLista()
            Else
                txtCodigo.Text = "0000"
                btnModificar.Enabled = True
                btnModificar.PerformClick()
                Dim limpiar As New clsTools
                limpiar.LimpiarControles(Me)
                BtnGrabar.Enabled = True
                BtnNuevo.Enabled = True
                btnModificar.Enabled = False
                BtnEliminar.Enabled = False
                txtDescripcion.Clear()
                txtAbreviacion.Clear()
            End If
        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Me.txtCodigo.Enabled = False
            Me.txtDescripcion.Enabled = True
            Me.txtAbreviacion.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = False
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
            Me.txtDescripcion.Focus()
            LlenarLista()
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If txtCodigo.Text = "" Or txtDescripcion.Text = "" Or txtAbreviacion.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Almacen")
            txtCodigo.Focus()
            LlenarLista()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()
                Dim commandbus As New SqlCommand("sp_ValidaUnidadesMedida", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@UnidadMedida", txtCodigo.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > "0" Then
                    Dim pclsUnidadesMedida = New clsUnidadesMedida()
                    pclsUnidadesMedida.ActualizaUnidadesMedida(Me.txtCodigo.Text, Me.txtDescripcion.Text, Me.txtAbreviacion.Text)
                    MsgBox("Actualizado Correctamente  " + wcodigo, vbInformation, "Sistema Contable")
                    Dim limpiar As New clsTools
                    limpiar.LimpiarControles(Me)
                Else
                    Dim wQuery As String = ""
                    Dim LocalCommand As SqlCommand
                    Dim wCodigo As String
                    wQuery = "SELECT MAX(FolioUnidadMedida)+1 FROM parametros (NOLOCK)"
                    LocalCommand = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
                    LocalCommand.CommandType = Data.CommandType.Text
                    wCodigo = LocalCommand.ExecuteScalar()
                    If wCodigo IsNot Nothing Then
                        'MsgBox("Se Genero Consecutivo de Folio Proveedor Correctamente", vbInformation, "Sistema Contable")
                    Else
                        MsgBox("No Se Genero Consecutivo de Folio ", vbInformation, "Sistema Almacen")
                    End If
                    LocalCommand.Dispose()
                    Dim xfoliador = New clsUnidadesMedida()
                    xfoliador.AvanzaFolioUnidades(wCodigo)
                    ' Existencias = 0
                    Dim sXML = "<xUnidadesMedida>"
                    sXML += "<UnidadMedida>" + wCodigo + "</UnidadMedida>"
                    sXML += "<Descripcion>" + Me.txtDescripcion.Text + "</Descripcion>"
                    sXML += "<Abreviacion>" + Me.txtAbreviacion.Text + "</Abreviacion>"
                    sXML += "</xUnidadesMedida>"
                    Dim xclsUnidadesMedida = New clsUnidadesMedida()
                    xclsUnidadesMedida.InsertaUnidadesMedida(sXML)
                    MsgBox("Registrado Correctamente, Codigo de Producto " + wCodigo, vbInformation, "Sistema Contable")
                    LlenarLista()
                    Dim limpiar As New clsTools
                    limpiar.LimpiarControles(Me)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Almacen")
            End Try
            txtCodigo.Focus()
            txtCodigo.Enabled = True
            txtDescripcion.Enabled = False
            txtAbreviacion.Enabled = False
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            BtnEliminar.Enabled = False
            btnModificar.Enabled = False
            txtCodigo.Clear()
            txtDescripcion.Clear()
            txtAbreviacion.Clear()
            LlenarLista()
        End If
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If Me.txtCodigo.Text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Almacen")
            txtCodigo.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsUnidadesMedida = New clsUnidadesMedida()
                oclsUnidadesMedida.EliminaUnidadesMedida(Me.txtCodigo.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Almacen")
                Dim limpiar As New clsTools
                limpiar.LimpiarControles(Me)
                BtnGrabar.Enabled = False
                BtnNuevo.Enabled = False
                btnModificar.Enabled = True
                BtnEliminar.Enabled = False
                Me.txtCodigo.Focus()
                Me.txtCodigo.Enabled = True
                txtCodigo.Clear()
                txtDescripcion.Clear()
                txtAbreviacion.Clear()
                LlenarLista()
            End If
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim limpiar As New clsTools
        limpiar.LimpiarControles(Me)
        Me.txtCodigo.Focus()
        Me.txtCodigo.Enabled = True
        Me.txtDescripcion.Enabled = False
        Me.txtAbreviacion.Enabled = False
        Me.BtnGrabar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnModificar.Enabled = False
        Me.BtnEliminar.Enabled = False
        txtCodigo.Clear()
        txtDescripcion.Clear()
        txtAbreviacion.Clear()
        LlenarLista()
    End Sub
    Private Sub LlenarLista()
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsUnidadesMedida = New clsUnidadesMedida()
        dr = oclsUnidadesMedida.BuscarUnidadesMedida(Me.txtUnidades.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstUnidades.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("UnidadMedida").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstLista.SubItems.Add(rRow("Abreviacion").ToString)
                lstUnidades.Items.Add(lstLista)
            Next
        End If
    End Sub
    Private Sub txtUnidades_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidades.KeyUp
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsUnidadesMedida = New clsUnidadesMedida()
        dr = oclsUnidadesMedida.BuscarUnidadesMedida(Me.txtUnidades.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstUnidades.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("UnidadMedida").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstLista.SubItems.Add(rRow("Abreviacion").ToString)
                lstUnidades.Items.Add(lstLista)
                Refresh()
            Next
        End If
    End Sub
    Private Sub lstUnidades_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstUnidades.MouseDoubleClick
        txtCodigo.Text = lstUnidades.SelectedItems(0).SubItems(0).Text
        txtDescripcion.Text = lstUnidades.SelectedItems(0).SubItems(1).Text
        txtAbreviacion.Text = lstUnidades.SelectedItems(0).SubItems(2).Text
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
        txtAbreviacion.Enabled = False
        btnModificar.Enabled = True
        BtnGrabar.Enabled = False
        BtnEliminar.Enabled = True
    End Sub
    Private Sub frmUnidadesMedida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenalista2()
        Me.Text = "Mantenimiento Unidades de Medida " + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.MaximizeBox = False
        LlenarLista()
        BtnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub
    Private Sub txtUnidades_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnidades.GotFocus
        txtUnidades.Text = ""
        txtUnidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtUnidades.ForeColor = Color.Black
        LlenarLista()
    End Sub
    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        Close()
    End Sub
    Private Sub txtDescripcion_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtAbreviacion.Focus()
        End If
    End Sub
    Private Sub txtAbreviacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbreviacion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnGrabar.PerformClick()
        End If
    End Sub
    Private Sub llenalista2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "Select * from Almacen.Dbo.acoUnidadesMedida(nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "acoUnidadesMedida")
        Dim objListItem As New ListViewItem
        Me.lstUnidades.Items.Clear()
        For Each drw As DataRow In ds.Tables("acoUnidadesMedida").Rows
            objListItem = lstUnidades.Items.Add(drw.Item("UnidadMedida").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            objListItem.SubItems.Add(drw.Item("Abreviacion").ToString)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub
End Class