Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Public Class frmProductosPaseProceso
    Private Sub frmProductosPaseProceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Productos Pase a Proceso" + Space(10) + VersionCont()
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.MaximizeBox = False
        llenalista()
        txtOrigen.Enabled = True
        txtDestino.Enabled = True
        txtDescripcionOrigen.Enabled = False
        txtDescripcionDestino.Enabled = False
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = True
        btnModificar.Enabled = True
    End Sub
    Private Sub cargadatosOrigen()
        Dim oclsProceso = New clsProductosPaseProceso()
        Dim dr As SqlDataReader
        dr = oclsProceso.SeleccionaProcesoOrigen(txtOrigen.Text)
        If dr.Read() Then
            Me.txtOrigen.Text = dr("CodigoProducto").ToString()
            Me.txtDescripcionOrigen.Text = dr("Descripcion").ToString()
            txtOrigen.Enabled = False
            txtDescripcionOrigen.Enabled = False
            'Me.txtDestino.Focus()
        Else
            MsgBox("El Codigo No Existe, Revise de Nuevo", vbInformation, "Sistema Almacen")
            txtOrigen.Clear()
        End If
    End Sub
    Private Sub cargadatosDestino()
        Dim oclsProceso = New clsProductosPaseProceso()
        Dim dr As SqlDataReader
        dr = oclsProceso.SeleccionaProcesoDestino(Me.txtDestino.Text)
        If dr.Read() Then
            Me.txtDestino.Text = dr("CodigoDestino").ToString()
            Me.txtDescripcionDestino.Text = dr("DescripcionDestino").ToString()
            txtDestino.Enabled = False
            txtDescripcionDestino.Enabled = False
            Me.txtDescripcionDestino.Focus()
            BtnGrabar.Enabled = True
            BtnNuevo.Enabled = True
            btnModificar.Enabled = True
        Else
            MsgBox("El Codigo No Existe, Se Generara Nuevo Registro", vbInformation, "Sistema Almacen")
            txtDestino.Enabled = False
            txtDescripcionDestino.Enabled = True
            BtnGrabar.Enabled = True
            BtnNuevo.Enabled = True
            btnModificar.Enabled = False
            txtDescripcionDestino.Focus()
        End If
    End Sub
    Private Sub txtOrigen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrigen.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                txtDestino.Enabled = False
                txtDestino.Focus()
            End If
            If Me.txtOrigen.Text <> "" Then
                cargadatosOrigen()
            End If
        End If
    End Sub
    Private Sub txtDestino_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDestino.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                txtDescripcionDestino.Focus()
            End If
            If Me.txtOrigen.Text <> "" Then
                cargadatosDestino()
            End If
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        txtOrigen.Clear()
        txtDestino.Clear()
        txtDescripcionOrigen.Clear()
        txtDescripcionDestino.Clear()
        txtOrigen.Enabled = True
        txtDestino.Enabled = True
        txtDescripcionOrigen.Enabled = False
        txtDescripcionDestino.Enabled = False
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = True
        btnModificar.Enabled = True
        llenalista()
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        txtOrigen.Enabled = False
        txtDestino.Enabled = False
        txtDescripcionOrigen.Enabled = False
        txtDescripcionDestino.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = True
        btnModificar.Enabled = True
        llenalista()
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If txtOrigen.Text = "" Or txtDescripcionOrigen.Text = "" Or txtDescripcionDestino.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Almacen")
            txtOrigen.Focus()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()
                'Dim commandbus2 As New SqlCommand("spValidaProductoOrigen", cnnConexion)
                'commandbus2.CommandType = CommandType.StoredProcedure
                'commandbus2.Parameters.AddWithValue("@CodOrigen", txtOrigen.Text)
                Dim commandbus As New SqlCommand("spValidaProductoDestino", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@CodDestino", txtDestino.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                'n = RTrim(commandbus2.ExecuteScalar())
                If n > 0 Then
                    Dim pclsProceso = New clsProductosPaseProceso()
                    pclsProceso.ActualizaProcesos(Me.txtDestino.Text, Me.txtDescripcionDestino.Text)
                    MsgBox("Actualizado Correctamente", vbInformation, "Sistema Almacen")
                Else
                    Dim sXML = "<xProcesos>"
                    sXML += "<CodigoOrigen>" + Me.txtOrigen.Text + "</CodigoOrigen>"
                    sXML += "<DescripcionOrigen>" + Me.txtDescripcionOrigen.Text + "</DescripcionOrigen>"
                    sXML += "<CodigoDestino>" + Me.txtDestino.Text + "</CodigoDestino>"
                    sXML += "<DescripcionDestino>" + Me.txtDescripcionDestino.Text + "</DescripcionDestino>"
                    sXML += "</xProcesos>"
                    Dim xclsProceso = New clsProductosPaseProceso()
                    xclsProceso.InsertaProcesos(sXML)
                    MsgBox("Registrado Correctamente", vbInformation, "Sistema Comercial")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Comercial")
            End Try
            txtOrigen.Enabled = True
            txtDestino.Enabled = True
            txtDescripcionOrigen.Enabled = False
            txtDescripcionDestino.Enabled = False
            BtnGrabar.Enabled = True
            BtnNuevo.Enabled = True
            btnModificar.Enabled = True
            txtOrigen.Clear()
            txtDestino.Clear()
            txtDescripcionOrigen.Clear()
            txtDescripcionDestino.Clear()
            llenalista()
            txtOrigen.Focus()
        End If
    End Sub
    Private Sub txtDescripcionDestino_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcionDestino.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnGrabar.PerformClick()
        End If
    End Sub
    Private Sub llenalista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "Select * from catProductoPaseProceso"

        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "catProductoPaseProceso")
        Dim objListItem As New ListViewItem
        Me.lstProceso.Items.Clear()
        For Each drw As DataRow In ds.Tables("catProductoPaseProceso").Rows
            objListItem = lstProceso.Items.Add(drw.Item("CodigoOrigen").ToString, 0)
            objListItem.SubItems.Add(drw.Item("DescripcionOrigen").ToString)
            objListItem.SubItems.Add(drw.Item("CodigoDestino").ToString)
            objListItem.SubItems.Add(drw.Item("DescripcionDestino").ToString)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub lstProceso_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstProceso.MouseDoubleClick
        txtOrigen.Text = lstProceso.SelectedItems(0).SubItems(0).Text
        txtDescripcionOrigen.Text = lstProceso.SelectedItems(0).SubItems(1).Text
        txtDestino.Text = lstProceso.SelectedItems(0).SubItems(2).Text
        txtDescripcionDestino.Text = lstProceso.SelectedItems(0).SubItems(3).Text
        txtOrigen.Enabled = False
        txtDescripcionOrigen.Enabled = False
        txtDestino.Enabled = False
        txtDescripcionDestino.Enabled = False
    End Sub
End Class