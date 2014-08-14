Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Public Class frmMttoProrrateo
    Dim wcodigo As String
    Private Sub cargadatos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim oclsProrrateo = New clsMttoProrrateo()
        Dim dr As SqlDataReader
        dr = oclsProrrateo.SeleccionaProrrateo(Me.txtCodigo.Text)
        If dr.Read() Then
            Me.txtCodigo.Text = dr("CodigoProrrateo").ToString()
            Me.txtDescripcion.Text = dr("Descripcion").ToString()
            txtCodigo.Enabled = False
            txtDescripcion.Enabled = False
            txtDescripcion.Focus()
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            btnModificar.Enabled = True
            BtnEliminar.Enabled = True
            btnVer.Enabled = True
        Else
            MsgBox("Crear Registro Nuevo", vbInformation, "Sistema Almacen")
            txtCodigo.Enabled = False
            txtDescripcion.Enabled = True
            txtCodigo.Focus()
            BtnGrabar.Enabled = True
            BtnNuevo.Enabled = True
            btnModificar.Enabled = False
            BtnEliminar.Enabled = False
            txtDescripcion.Focus()
            txtDescripcion.Clear()
            llenalista2()
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
                llenalista2()
            End If
        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim commandbus As New SqlCommand("sp_ValidaUsuarioProrrateo", cnnConexion)
        commandbus.CommandType = CommandType.StoredProcedure
        commandbus.Parameters.AddWithValue("@CodigoProrrateo", txtCodigo.Text)
        commandbus.Parameters.AddWithValue("@UsuarioRegistro", LoginUsuario)
        Dim n As Integer
        n = RTrim(commandbus.ExecuteScalar())
        If n > "0" Then
            Me.txtCodigo.Enabled = False
            Me.txtDescripcion.Enabled = True
            BtnGrabar.Enabled = True
            BtnNuevo.Enabled = True
            btnModificar.Enabled = False
            BtnEliminar.Enabled = False
            btnVer.Enabled = True
            Me.txtDescripcion.Focus()
            llenalista2()
        Else
            MsgBox("No Tiene Permiso Para Modificar  " + LoginUsuario, vbCritical, "Sistema Almacen")
            Me.txtCodigo.Enabled = True
            Me.txtDescripcion.Enabled = True
            BtnGrabar.Enabled = True
            BtnNuevo.Enabled = True
            btnModificar.Enabled = False
            BtnEliminar.Enabled = False
            btnVer.Enabled = False
            txtCodigo.Clear()
            txtDescripcion.Clear()
            llenalista2()
            txtCodigo.Focus()
        End If
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If txtCodigo.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Almacen")
            txtCodigo.Focus()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()
                Dim commandbus As New SqlCommand("spValidaProrrateo", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@CodigoProrrateo", txtCodigo.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > "0" Then
                    Dim pclsProrrateo = New clsMttoProrrateo()
                    pclsProrrateo.ActualizaProrrateo(Me.txtCodigo.Text, Me.txtDescripcion.Text)
                    MsgBox("Actualizado Correctamente  " + wcodigo, vbInformation, "Sistema Almacen")
                    Dim limpiar As New clsTools
                    limpiar.LimpiarControles(Me)
                    llenalista2()
                    frmLlenaProrrateo.txtCodigo.Text = txtCodigo.Text
                Else
                    Dim sXML = "<xProrrateo>"
                    sXML += "<CodigoProrrateo>" + Me.txtCodigo.Text + "</CodigoProrrateo>"
                    sXML += "<Descripcion>" + Me.txtDescripcion.Text + "</Descripcion>"
                    sXML += "<UsuarioRegistro>" + LoginUsuario + "</UsuarioRegistro>"
                    sXML += "</xProrrateo>"
                    Dim xclsProrrateo = New clsMttoProrrateo()
                    xclsProrrateo.InsertaProrrateo(sXML)
                    MsgBox("Registrado Correctamente " + wcodigo, vbInformation, "Sistema Almacen")
                    Dim limpiar As New clsTools
                    limpiar.LimpiarControles(Me)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Almacen")
            End Try
            frmLlenaProrrateo.Show()
            Me.Hide()
            frmLlenaProrrateo.txtCodigo.Text = txtCodigo.Text
            txtCodigo.Enabled = True
            txtDescripcion.Enabled = True
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            BtnEliminar.Enabled = False
            btnModificar.Enabled = False
            btnVer.Enabled = False
            txtCodigo.Clear()
            txtDescripcion.Clear()
            llenalista2()
            txtCodigo.Focus()
        End If
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If Me.txtCodigo.Text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Almacen")
            txtCodigo.Focus()
        Else
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()
            Dim commandbus As New SqlCommand("sp_ValidaUsuarioProrrateo", cnnConexion)
            commandbus.CommandType = CommandType.StoredProcedure
            commandbus.Parameters.AddWithValue("@CodigoProrrateo", txtCodigo.Text)
            commandbus.Parameters.AddWithValue("@UsuarioRegistro", LoginUsuario)
            Dim n As Integer
            n = RTrim(commandbus.ExecuteScalar())
            If n > "0" Then
                Dim oclsProrrateo = New clsMttoProrrateo()
                oclsProrrateo.EliminaProrrateo(Me.txtCodigo.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Almacen")
                Dim limpiar As New clsTools
                limpiar.LimpiarControles(Me)
                Me.txtCodigo.Enabled = True
                Me.txtDescripcion.Enabled = True
                BtnGrabar.Enabled = True
                BtnNuevo.Enabled = True
                btnModificar.Enabled = False
                BtnEliminar.Enabled = False
                btnVer.Enabled = True
                txtCodigo.Clear()
                txtDescripcion.Clear()
                llenalista2()
                txtCodigo.Focus()
            Else
                MsgBox("No Tiene Permiso Para Eliminar  " + LoginUsuario, vbCritical, "Sistema Almacen")
                Me.txtCodigo.Enabled = True
                Me.txtDescripcion.Enabled = True
                BtnGrabar.Enabled = True
                BtnNuevo.Enabled = True
                btnModificar.Enabled = False
                BtnEliminar.Enabled = False
                btnVer.Enabled = False
                txtCodigo.Clear()
                txtDescripcion.Clear()
                llenalista2()
                txtCodigo.Focus()
            End If
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim limpiar As New clsTools
        limpiar.LimpiarControles(Me)
        txtProrrateo.Text = "Buscar Descripción"
        txtProrrateo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        Me.txtCodigo.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.BtnGrabar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnModificar.Enabled = False
        Me.BtnEliminar.Enabled = False
        txtCodigo.Clear()
        txtDescripcion.Clear()
        llenalista2()
        txtCodigo.Focus()
    End Sub
    Private Sub txtProrrateo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProrrateo.GotFocus
        txtProrrateo.Text = ""
        txtProrrateo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtProrrateo.ForeColor = Color.Black
        llenalista2()
    End Sub
    Private Sub txtProrrateo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProrrateo.KeyUp
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim yclsProrrateo = New clsMttoProrrateo()
        dr = yclsProrrateo.BuscarProrrateo(Me.txtProrrateo.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            listProrrateo.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CodigoProrrateo").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                listProrrateo.Items.Add(lstLista)
            Next
        End If
    End Sub
    Private Sub listProrrateo_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listProrrateo.MouseDoubleClick
        txtCodigo.Text = listProrrateo.SelectedItems(0).SubItems(0).Text
        txtDescripcion.Text = listProrrateo.SelectedItems(0).SubItems(1).Text
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
        btnModificar.Enabled = True
        BtnGrabar.Enabled = False
        BtnEliminar.Enabled = True
        btnVer.Enabled = True
    End Sub
    Private Sub frmMttoProrrateo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenalista2()
        Me.Text = "Mantenimiento Prorrateo " + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.MaximizeBox = False
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        btnVer.Enabled = False
        txtCodigo.Enabled = True
        txtDescripcion.Enabled = True
        txtCodigo.Focus()
    End Sub
    Private Sub llenalista2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "Select * from Compras.Dbo.ProrrateoCat(nolock) order by CodigoProrrateo"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "ProrrateoCat")
        Dim objListItem As New ListViewItem
        Me.listProrrateo.Items.Clear()
        For Each drw As DataRow In ds.Tables("ProrrateoCat").Rows
            objListItem = listProrrateo.Items.Add(drw.Item("CodigoProrrateo").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        frmLlenaProrrateo.txtCodigo.Text = txtCodigo.Text
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim commandbus As New SqlCommand("sp_ValidaUsuarioProrrateo", cnnConexion)
        commandbus.CommandType = CommandType.StoredProcedure
        commandbus.Parameters.AddWithValue("@CodigoProrrateo", frmLlenaProrrateo.txtCodigo.Text)
        commandbus.Parameters.AddWithValue("@UsuarioRegistro", LoginUsuario)
        Dim n As Integer
        n = RTrim(commandbus.ExecuteScalar())
        If n > "0" Then
            'MsgBox("Ver Prorrateo", vbInformation, "Sistema Almacen")
            frmLlenaProrrateo.Show()
            Me.Hide()
        Else
            MsgBox("No Tiene Permiso Para Acceder  " + LoginUsuario, vbCritical, "Sistema Almacen")
            Me.Show()
            Me.txtCodigo.Enabled = True
            Me.txtDescripcion.Enabled = True
            BtnGrabar.Enabled = True
            BtnNuevo.Enabled = True
            btnModificar.Enabled = False
            BtnEliminar.Enabled = False
            btnVer.Enabled = False
            txtCodigo.Clear()
            txtDescripcion.Clear()
            llenalista2()
            txtCodigo.Focus()
        End If
    End Sub
    Private Sub txtDescripcion_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnGrabar.PerformClick()
        End If
    End Sub
End Class
