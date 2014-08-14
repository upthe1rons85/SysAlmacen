Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsSubFamilias
Public Class frmSubFamiNiv2
    Private Sub SubFamiNiv2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento SubFamilias Nivel 2" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.MaximizeBox = False
        LlenaListaFamiNiv2()
    End Sub
    Private Sub CargaDatos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim ClsSubFamiNiv2 = New clsSubFamilias()
        Dim dr As SqlDataReader
        dr = ClsSubFamiNiv2.SeleccionaSubFamiNiv2(Me.txtCodSubFamiNiv2.Text)
        If dr.Read() Then
            Me.txtCodSubFamiNiv2.Text = dr("CodSubFamiNiv2").ToString()
            Me.TxtCodSubFamiNiv1.Text = dr("CodSubFamiNiv1").ToString()
            Me.txtDescripcion.Text = dr("Descripcion").ToString()
            Me.txtCodSubFamiNiv2.Enabled = False
            TxtCodSubFamiNiv1.Enabled = False
            txtDescripcion.Enabled = False
            BtnGrabar.Enabled = True
            BtnNuevo.Enabled = True
            btnModificar.Enabled = True
            BtnEliminar.Enabled = True
            btnConsultar.Enabled = False
        Else
            MsgBox("Codigo No Encontrado, Se Generara uno Nuevo Con el Codigo Ingresado", vbInformation, "Sistema Almacen")
            txtCodSubFamiNiv2.Enabled = False
            TxtCodSubFamiNiv1.Enabled = True
            txtDescripcion.Enabled = True
            BtnGrabar.Enabled = True
            BtnNuevo.Enabled = True
            btnModificar.Enabled = False
            BtnEliminar.Enabled = False
            btnConsultar.Enabled = True
            Me.TxtCodSubFamiNiv1.Focus()
        End If

        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub LlenaListaFamiNiv2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim consulta As String = "Select * from CatSubFamiNiv2(nolock) order by CodSubFamiNiv2,CodSubFamiNiv1"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "CatSubFamiNiv2")

        Dim objListItem As New ListViewItem
        Me.lstBuscar.Items.Clear()

        For Each drw As DataRow In ds.Tables("CatSubFamiNiv2").Rows
            objListItem = lstBuscar.Items.Add(drw.Item("CodSubFamiNiv2").ToString, 0)
            objListItem.SubItems.Add(drw.Item("CodSubFamiNiv1").ToString)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
        Next
        cnnConexion.Close()
    End Sub
    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodSubFamiNiv2.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            If txtCodSubFamiNiv2.Text <> "" Then
                CargaDatos()
            End If
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Me.txtCodSubFamiNiv2.Enabled = True
        Me.TxtCodSubFamiNiv1.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.BtnGrabar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnModificar.Enabled = False
        Me.BtnEliminar.Enabled = False
        Me.btnConsultar.Enabled = True
        txtCodSubFamiNiv2.Clear()
        TxtCodSubFamiNiv1.Clear()
        txtDescripcion.Clear()
        Me.txtCodSubFamiNiv2.Focus()
    End Sub
    Private Sub lstBuscar_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstBuscar.MouseDoubleClick
        Me.txtCodSubFamiNiv2.Text = lstBuscar.SelectedItems(0).SubItems(0).Text
        Me.TxtCodSubFamiNiv1.Text = lstBuscar.SelectedItems(0).SubItems(1).Text
        Me.txtDescripcion.Text = lstBuscar.SelectedItems(0).SubItems(2).Text
        Me.txtCodSubFamiNiv2.Enabled = False
        Me.TxtCodSubFamiNiv1.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.btnModificar.Enabled = True
        Me.BtnGrabar.Enabled = False
        Me.BtnEliminar.Enabled = True
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Me.txtCodSubFamiNiv2.Enabled = False
        Me.TxtCodSubFamiNiv1.Enabled = True
        Me.txtDescripcion.Enabled = True
        BtnGrabar.Enabled = True
        btnConsultar.Enabled = True
        BtnNuevo.Enabled = False
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        Me.TxtCodSubFamiNiv1.Focus()
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If txtCodSubFamiNiv2.Text = "" Or TxtCodSubFamiNiv1.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Almacen")
            txtCodSubFamiNiv2.Focus()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()

                cnnConexion = clsDB.CreaConexion()

                Dim commandbus As New SqlCommand("sp_ValidaSubFamiNiv2", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@CodSubFamiNiv2", Me.txtCodSubFamiNiv2.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > 0 Then
                    Dim aclsFamiNiv2 = New clsSubFamilias()
                    aclsFamiNiv2.ActualizaSubFamiNiv2(Me.txtCodSubFamiNiv2.Text, Me.TxtCodSubFamiNiv1.Text, Me.txtDescripcion.Text)
                    MsgBox("Actualizado Correctamente  ", vbInformation, "Sistema Almacen")

                Else
                    Dim sXML = "<xSubFamiNiv2>"
                    sXML += "<CodSubFamiNiv2>" + Me.txtCodSubFamiNiv2.Text + "</CodSubFamiNiv2>"
                    sXML += "<CodSubFamiNiv1>" + Me.TxtCodSubFamiNiv1.Text + "</CodSubFamiNiv1>"
                    sXML += "<Descripcion>" + Me.txtDescripcion.Text + "</Descripcion>"
                    sXML += "</xSubFamiNiv2>"
                    Dim bclsFamiNiv2 = New clsSubFamilias()
                    bclsFamiNiv2.InsertaSubFamiNiv2(sXML)
                    MsgBox("Registrado Correctamente", vbInformation, "Sistema Almacen")

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Almacen")
            End Try
            txtCodSubFamiNiv2.Enabled = True
            TxtCodSubFamiNiv1.Enabled = False
            txtDescripcion.Enabled = False
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            BtnEliminar.Enabled = False
            btnModificar.Enabled = False
            txtCodSubFamiNiv2.Clear()
            TxtCodSubFamiNiv1.Clear()
            txtDescripcion.Clear()
            txtCodSubFamiNiv2.Focus()
            LlenaListaFamiNiv2()
        End If
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If Me.txtCodSubFamiNiv2.Text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Almacen")
            txtCodSubFamiNiv2.Focus()
        Else
            Try
                If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim odclsSubFamiNiv2 = New clsSubFamilias()
                    odclsSubFamiNiv2.EliminaSubFamiNiv2(Me.txtCodSubFamiNiv2.Text)
                    MsgBox("Registro Eliminado", vbInformation, "Sistema Almacen")
                    BtnGrabar.Enabled = False
                    BtnNuevo.Enabled = True
                    btnModificar.Enabled = False
                    BtnEliminar.Enabled = False
                    txtCodSubFamiNiv2.Clear()
                    TxtCodSubFamiNiv1.Clear()
                    txtDescripcion.Clear()
                    LlenaListaFamiNiv2()
                    Me.txtCodSubFamiNiv2.Enabled = True
                    Me.txtCodSubFamiNiv2.Focus()
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
    Private Sub txtCodSubFamilia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodSubFamiNiv1.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.txtDescripcion.Focus()
        End If
    End Sub
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            BtnGrabar.Focus()
        End If
    End Sub
End Class