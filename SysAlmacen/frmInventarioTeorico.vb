Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Public Class frmInventarioTeorico
    Dim wcodigo As String
    Dim item As ListViewItem
    Dim nfecha As String
    Private Sub frmInventarioTeorico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Inventario Teorico" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "|| Usuario Actual : " + LoginUsuario
        Me.MaximizeBox = False
        BtnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        btnImprimir.Enabled = True
        BtnEliminar.Enabled = False
        llenalista2()
        txtCodigo.Focus()
    End Sub
    Private Sub cargadatos()
        Dim oclsInventario = New clsInventarioTeorico()
        Dim dr As SqlDataReader
        dr = oclsInventario.CargaInventario(txtCodigo.Text)
        If dr.Read() Then
            txtCodigo.Text = dr("CodigoProducto").ToString()
            txtCantidadFisico.Text = dr("CantidadFisico").ToString()
            txtCodigo.Enabled = False
            txtCantidadFisico.Enabled = False
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            BtnEliminar.Enabled = True
            btnAgregar.Enabled = False
            txtCodigo.Focus()
        Else
            'MsgBox("Crear Registro", vbInformation, "Sistema Almacen")
            txtCodigo.Enabled = True
            txtCantidadFisico.Enabled = True
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            BtnEliminar.Enabled = False
            txtCantidadFisico.Focus()
        End If
    End Sub
    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtCantidadFisico.Focus()
            cargadatos()
        End If
        If txtCodigo.Text <> "" Then
            'txtCodigo.Focus()
            'cargadatos()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click

        If MessageBox.Show("Esta seguro de cruzar el inventario?...Ya nose podra MODIFICAR este inventario...", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                'For Each item As ListViewItem In listInventario.Items
                '    Dim cmd As New SqlCommand
                '    Dim cnnConexion = New SqlConnection()
                '    Dim clsDB = New clsBD()
                '    cnnConexion = clsDB.CreaConexion()
                '    cmd.Connection = cnnConexion
                '    'cmd.Parameters.Clear()
                '    cmd.CommandText = "spInsInvFisico"
                '    cmd.CommandType = CommandType.StoredProcedure

                '    cmd.Parameters.Add("@pCodPro", SqlDbType.VarChar).Value = item.SubItems(1).Text
                '    cmd.Parameters.Add("@pCantidad", SqlDbType.VarChar).Value = item.SubItems(2).Text
                '    cmd.ExecuteNonQuery()
                'Next
                Dim cmd2 As New SqlCommand
                Dim cnnConexion2 = New SqlConnection()
                Dim clsDB2 = New clsBD()
                cnnConexion2 = clsDB2.CreaConexion()
                cmd2.Connection = cnnConexion2
                cmd2.Parameters.Clear()
                cmd2.CommandText = "spCruceInventarioDiferencia"
                cmd2.CommandType = CommandType.StoredProcedure

                cmd2.ExecuteNonQuery()
                MsgBox("Cruze de Inventario Exitoso", vbInformation, "Sistema Almacen")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Almacen")
            End Try
            llenalista2()
            listInventario.Items.Clear()
            txtCodigo.Enabled = True
            txtCantidadFisico.Enabled = True
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            BtnEliminar.Enabled = False
            btnAgregar.Enabled = True
            txtCodigo.Clear()
            txtCodigo.Clear()
            txtCantidadFisico.Clear()
        End If
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If Me.txtCodigo.Text = "" Or txtCantidadFisico.Text = "" Then
            MsgBox("Debe Captrar un Codigo", vbInformation, "Sistema Almacen")
            txtCodigo.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsInventario = New clsInventarioTeorico()
                oclsInventario.EliminaInventario(Me.txtCodigo.Text)
                MsgBox("Eliminado Correctamente", vbInformation, "Sistema Almacen")
                Dim limpiar As New clsTools
                limpiar.LimpiarControles(Me)
                BtnGrabar.Enabled = False
                BtnNuevo.Enabled = True
                BtnEliminar.Enabled = False
                btnAgregar.Enabled = True
                Me.txtCodigo.Enabled = True
                Me.txtCantidadFisico.Enabled = True
                txtCodigo.Clear()
                txtCantidadFisico.Clear()
                txtCodigo.Focus()
                llenalista2()
            End If
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim limpiar As New clsTools
        limpiar.LimpiarControles(Me)
        Me.txtCodigo.Enabled = True
        Me.txtCantidadFisico.Enabled = True
        BtnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        BtnEliminar.Enabled = False
        btnAgregar.Enabled = True
        txtCodigo.Clear()
        txtCantidadFisico.Clear()
        txtCodigo.Focus()
        llenalista2()
    End Sub
    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Or e.KeyChar = ChrW(Keys.Enter) Then
            e.KeyChar = ""
            e.Handled = True
            txtCodigo.Focus()
            btnAgregar.PerformClick()
        End If
        BtnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        BtnEliminar.Enabled = False
        btnAgregar.Enabled = True
    End Sub
    Private Sub llenalista2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "Select * from AcoInventarioHistorico(nolock) where folioInventario is null order by CodigoProducto"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "AcoInventarioHistorico")
        Dim objListItem As New ListViewItem
        Me.listInventario.Items.Clear()
        For Each drw As DataRow In ds.Tables("AcoInventarioHistorico").Rows
            objListItem = listInventario.Items.Add(drw.Item("FolioInventario").ToString, 0)
            objListItem.SubItems.Add(drw.Item("CodigoProducto").ToString)
            objListItem.SubItems.Add(drw.Item("CantidadFisico").ToString)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub listInventario_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listInventario.MouseDoubleClick
        'lblFolio.Text = listInventario.SelectedItems(0).SubItems(0).Text
        txtCodigo.Text = listInventario.SelectedItems(0).SubItems(1).Text
        txtCantidadFisico.Text = listInventario.SelectedItems(0).SubItems(2).Text
        Dim i As Integer
        listInventario.Items.RemoveAt(i)
        txtCodigo.Enabled = False
        txtCantidadFisico.Enabled = False
        BtnGrabar.Enabled = False
        BtnEliminar.Enabled = True
        btnAgregar.Enabled = False
        llenalista2()
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New FrmInventarios
        frm.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New FrmAyudaCodigo
        frm.ShowDialog()
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtCodigo.Text = "" Or txtCantidadFisico.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Almacen")
            txtCodigo.Focus()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()
                Dim commandbus As New SqlCommand("spValidaInventarioTeorico", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@CodigoProducto", txtCodigo.Text)
                Dim n As String
                n = RTrim(commandbus.ExecuteScalar())
                'If n > "0" Then
                '    Dim pclsInvTeorico = New clsInventarioTeorico()
                '    pclsInvTeorico.ActualizaInventario(Me.txtCodigo.Text, Me.txtCantidadFisico.Text)
                '    MsgBox("Actualizado Correctamente  " + wcodigo, vbInformation, "Sistema Almacen")
                '    Dim limpiar As New clsTools
                '    limpiar.LimpiarControles(Me)
                'Else
                Dim sXML = "<xInventario>"
                sXML += "<CodigoProducto>" + Me.txtCodigo.Text + "</CodigoProducto>"
                sXML += "<cantidadFisico>" + Me.txtCantidadFisico.Text + "</cantidadFisico>"
                sXML += "<fecha>" + Me.lblFecha.Text + "</fecha>"
                sXML += "</xInventario>"
                Dim xclsInventario = New clsInventarioTeorico()
                xclsInventario.InsertaInventario(sXML)
                MsgBox("Registrado Correctamente" + wcodigo, vbInformation, "Sistema Almacen")
                'End If
                'End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Almacen")
            End Try
            item = New ListViewItem()
            item.SubItems.Add(Me.txtCodigo.Text)
            item.SubItems.Add(Me.txtCantidadFisico.Text)
            listInventario.Items.Add(item)
            txtCodigo.Clear()
            txtCantidadFisico.Clear()
            txtCodigo.Enabled = False
            txtCantidadFisico.Enabled = True
            BtnGrabar.Enabled = True
            BtnEliminar.Enabled = False
            btnAgregar.Enabled = True
            txtCodigo.Enabled = True
            txtCodigo.Focus()
            llenalista2()
        End If
    End Sub
    Private Sub txtCantidadFisico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadFisico.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnAgregar.PerformClick()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblFecha.Text = DateString
    End Sub
End Class