Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsSubFamilias
Public Class frmSubFamiNiv1
    Private Sub SubFamiNiv1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento SubFamilias" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.MaximizeBox = False
        LlenaListaFamiNiv1()
    End Sub
    Private Sub CargaDatos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim ClsSubFamiNiv1 = New clsSubFamilias()
        Dim dr As SqlDataReader
        dr = ClsSubFamiNiv1.SeleccionaSubFamiNiv1(Me.txtCodSubFamiNiv1.Text)
        If dr.Read() Then
            Me.txtCodSubFamiNiv1.Text = dr("CodSubFamiNiv1").ToString()
            Me.txtCodSubFamilia.Text = dr("CodSubFamilia").ToString()
            Me.txtDescripcion.Text = dr("Descripcion").ToString()
            Me.txtCodSubFamiNiv1.Enabled = False
            txtCodSubFamilia.Enabled = False
            txtDescripcion.Enabled = False
            BtnGrabar.Enabled = True
            BtnNuevo.Enabled = True
            btnModificar.Enabled = True
            BtnEliminar.Enabled = True
            btnConsultar.Enabled = False
        Else
            MsgBox("Codigo No Encontrado, Se Generara uno Nuevo Con el Codigo Ingresado", vbInformation, "Sistema Almacen")
            txtCodSubFamiNiv1.Enabled = False
            txtCodSubFamilia.Enabled = True
            txtDescripcion.Enabled = True
            BtnGrabar.Enabled = True
            BtnNuevo.Enabled = True
            btnModificar.Enabled = False
            BtnEliminar.Enabled = False
            btnConsultar.Enabled = True
            Me.txtCodSubFamilia.Focus()
        End If

        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub LlenaListaFamiNiv1()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim consulta As String = "Select * from CatSubFamiNiv1(nolock) order by CodSubFamiNiv1,CodSubFamilia"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "CatSubFamiNiv1")

        Dim objListItem As New ListViewItem
        Me.lstBuscar.Items.Clear()

        For Each drw As DataRow In ds.Tables("CatSubFamiNiv1").Rows
            objListItem = lstBuscar.Items.Add(drw.Item("CodSubFamiNiv1").ToString, 0)
            objListItem.SubItems.Add(drw.Item("CodSubFamilia").ToString)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
        Next
        cnnConexion.Close()
    End Sub
    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodSubFamiNiv1.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            If txtCodSubFamiNiv1.Text <> "" Then
                CargaDatos()
            End If
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Me.txtCodSubFamiNiv1.Enabled = True
        Me.txtCodSubFamilia.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.BtnGrabar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnModificar.Enabled = False
        Me.BtnEliminar.Enabled = False
        Me.btnConsultar.Enabled = True
        txtCodSubFamiNiv1.Clear()
        txtCodSubFamilia.Clear()
        txtDescripcion.Clear()
        Me.txtCodSubFamiNiv1.Focus()
    End Sub
    Private Sub lstBuscar_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstBuscar.MouseDoubleClick
        Me.txtCodSubFamiNiv1.Text = lstBuscar.SelectedItems(0).SubItems(0).Text
        Me.txtCodSubFamilia.Text = lstBuscar.SelectedItems(0).SubItems(1).Text
        Me.txtDescripcion.Text = lstBuscar.SelectedItems(0).SubItems(2).Text
        Me.txtCodSubFamiNiv1.Enabled = False
        Me.txtCodSubFamilia.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.btnModificar.Enabled = True
        Me.BtnGrabar.Enabled = False
        Me.BtnEliminar.Enabled = True
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Me.txtCodSubFamiNiv1.Enabled = False
        Me.txtCodSubFamilia.Enabled = True
        Me.txtDescripcion.Enabled = True
        BtnGrabar.Enabled = True
        btnConsultar.Enabled = True
        BtnNuevo.Enabled = False
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        Me.txtCodSubFamilia.Focus()
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If txtCodSubFamiNiv1.Text = "" Or txtCodSubFamilia.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Almacen")
            txtCodSubFamiNiv1.Focus()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()

                cnnConexion = clsDB.CreaConexion()

                Dim commandbus As New SqlCommand("sp_ValidaSubFamiNiv1", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@CodSubFamiNiv1", Me.txtCodSubFamiNiv1.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > 0 Then
                    Dim aclsFamiNiv1 = New clsSubFamilias()
                    aclsFamiNiv1.ActualizaSubFamiNiv1(Me.txtCodSubFamiNiv1.Text, Me.txtCodSubFamilia.Text, Me.txtDescripcion.Text)
                    MsgBox("Actualizado Correctamente  ", vbInformation, "Sistema Almacen")

                Else
                    Dim sXML = "<xSubFamiNiv1>"
                    sXML += "<CodSubFamiNiv1>" + Me.txtCodSubFamiNiv1.Text + "</CodSubFamiNiv1>"
                    sXML += "<CodSubFamilia>" + Me.txtCodSubFamilia.Text + "</CodSubFamilia>"
                    sXML += "<Descripcion>" + Me.txtDescripcion.Text + "</Descripcion>"
                    sXML += "</xSubFamiNiv1>"
                    Dim bclsFamiNiv1 = New clsSubFamilias()
                    bclsFamiNiv1.InsertaSubFamiNiv1(sXML)
                    MsgBox("Registrado Correctamente", vbInformation, "Sistema Almacen")

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Almacen")
            End Try
            txtCodSubFamiNiv1.Enabled = True
            txtCodSubFamilia.Enabled = False
            txtDescripcion.Enabled = False
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            BtnEliminar.Enabled = False
            btnModificar.Enabled = False
            txtCodSubFamiNiv1.Clear()
            txtCodSubFamilia.Clear()
            txtDescripcion.Clear()
            txtCodSubFamiNiv1.Focus()
            LlenaListaFamiNiv1()
        End If
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If Me.txtCodSubFamiNiv1.Text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Almacen")
            txtCodSubFamiNiv1.Focus()
        Else
            Try
                If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim odclsSubFamiNiv1 = New clsSubFamilias()
                    odclsSubFamiNiv1.EliminaSubFamiNiv1(Me.txtCodSubFamiNiv1.Text)
                    MsgBox("Registro Eliminado", vbInformation, "Sistema Almacen")
                    BtnGrabar.Enabled = False
                    BtnNuevo.Enabled = True
                    btnModificar.Enabled = False
                    BtnEliminar.Enabled = False
                    txtCodSubFamiNiv1.Clear()
                    txtCodSubFamilia.Clear()
                    txtDescripcion.Clear()
                    LlenaListaFamiNiv1()
                    Me.txtCodSubFamiNiv1.Enabled = True
                    Me.txtCodSubFamiNiv1.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Almacen")
            End Try
        End If
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub
    Private Sub txtCodSubFamilia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodSubFamilia.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.txtDescripcion.Focus()
        End If
    End Sub
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            BtnGrabar.Focus()
        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        frmListSubFamiNiv1.ShowDialog()
        Me.Refresh()
        txtCodSubFamilia.Text = frmListSubFamiNiv1.DatosListaSubFamiNiv1
        Me.txtDescripcion.Focus()
    End Sub
    Private Sub LlenaLista()
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
                lstBuscar.Items.Add(lstLista)
            Next
        End If
        txtCodSubFamilia.Focus()
    End Sub
End Class