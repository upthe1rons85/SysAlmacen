Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Public Class frmLlenaProrrateo
    Dim nclasificacion As String
    Dim narea As String
    Dim ndepto As String
    Dim suma As Double
    Dim item As ListViewItem
    Friend cTabla As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        frmMttoProrrateo.Show()
        Close()
    End Sub
    Sub CargaCbxClasificacion()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim consulta As String = "Select Cve_clas,Des_clas From [Compras].[dbo].[AcvClasi] (nolock) Order By Cve_Clas desc "
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        CbxClasificacion.ValueMember = "Cve_Clas"
        CbxClasificacion.DisplayMember = "Des_Clas"
        CbxClasificacion.DataSource = dt
        CbxClasificacion.Text = "Seleccione Clasificacion"
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub CbxClasificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxClasificacion.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            CbxArea.Enabled = True
            Me.CbxArea.Focus()
        End If
        If InStr(1, "" & CDec(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub CbxClasificacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxClasificacion.SelectedIndexChanged
        If CbxClasificacion.Text = "Seleccione Clasificacion" Then
            CbxClasificacion.ValueMember = ""
            CbxArea.Text = "Seleccione Area"
        Else
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()
            Dim consulta As String = "Select Cve_Clas,Area,Des_Area From [Compras].[dbo].[Area] (nolock) Where Cve_Clas= '" & CbxClasificacion.SelectedValue & "' "
            Dim cmd As New SqlCommand(consulta, cnnConexion)
            cmd.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            CbxArea.ValueMember = "Area"
            CbxArea.DisplayMember = "Des_Area"
            CbxArea.DataSource = dt
            CbxArea.Text = "Seleccione Area"
            clsDB.CierraConexion(cnnConexion)
        End If
    End Sub
    Private Sub CbxArea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxArea.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            CbxDepto.Enabled = True
            Me.CbxDepto.Focus()
        End If
        If InStr(1, "" & CDec(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub CbxArea_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxArea.SelectedIndexChanged
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim consulta As String = "Select area_depto,Des_depto From [Compras].[dbo].[Deptos] (nolock) where area_depto like '" & CbxArea.SelectedValue & "%' "
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        CbxDepto.ValueMember = "Area_Depto"
        CbxDepto.DisplayMember = "Des_Depto"
        CbxDepto.DataSource = dt
        CbxDepto.Text = "Seleccione Depto."
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub CbxDepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxDepto.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            txtParticipacion.Enabled = True
            Me.txtParticipacion.Focus()
        End If
        If InStr(1, "" & CDec(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub frmLlenaProrrateo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Agrega Prorrateo " + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.MaximizeBox = False
        CargaCbxClasificacion()
        llenalista2()
        variable = txtCodigo.Text
        totales()
        BtnGrabar.Enabled = True
        btnModificar.Enabled = True
        BtnEliminar.Enabled = True
        btnAgregar.Enabled = False
        'Button1.Enabled = False
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If txtCodigo.Text = "" Or lblTotal1.Text <> 100 Then
            MsgBox("El Porcentaje de Participacion debe ser 100%, Verifique..!!!", vbInformation, "Sistema Almacen")
            Dim cecos As String
            If CbxArea.SelectedValue = Nothing Then
                cecos = ""
            Else
                cecos = CbxArea.SelectedValue
            End If
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()

                Dim oclsProrrateo2 = New clsMttoProrrateo()
                oclsProrrateo2.EliminaProrrateo2(Me.txtCodigo.Text)
                txtParticipacion.Clear()
                BtnGrabar.Enabled = True
                BtnEliminar.Enabled = True
                btnAgregar.Enabled = False
                btnModificar.Enabled = True
                Me.txtCodigo.Focus()
                Me.txtCodigo.Enabled = False
                CbxClasificacion.Enabled = True
                CbxDepto.Enabled = True
                CbxArea.Enabled = True
                txtParticipacion.Enabled = True
                CargaCbxClasificacion()
                Dim sSql2 As String
                sSql2 = " INSERT INTO [Compras].[dbo].[ProrrateoDet] ([CodigoProrrateo],[area_depto],[Participacion])  values (@CodigoProrrateo,@area_depto,@Participacion) "
                Dim CmdIns As New SqlCommand(sSql2, cnnConexion)
                For Each item As ListViewItem In listProrrateo.Items
                    'Me.listProrrateo.Items.Clear()
                    CmdIns.Parameters.Clear()
                    CmdIns.Parameters.AddWithValue("@CodigoProrrateo", item.SubItems(0).Text)
                    CmdIns.Parameters.AddWithValue("@area_depto", item.SubItems(1).Text)
                    CmdIns.Parameters.AddWithValue("@Participacion", item.SubItems(2).Text)
                    'CmdIns.Parameters.AddWithValue("@area_depto")
                    'CmdIns.Parameters.AddWithValue("@Participacion")
                    CmdIns.ExecuteNonQuery()
                Next
                MsgBox("Registrado Correctamente", vbInformation, "Sistema Almacen")
                txtParticipacion.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Almacen")
            End Try
        End If
        'llenalista2()
        totales()
        CargaCbxClasificacion()
    End Sub
    Private Sub llenalista2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        'Dim consulta As String = "Select * from Compras.Dbo.ProrrateoDet(nolock) where codigoprorrateo='" & frmMttoProrrateo.txtCodigo.Text & "'"
        Dim consulta As String = "Select * from Compras.Dbo.ProrrateoDet(nolock) where codigoprorrateo='" & txtCodigo.Text & "'"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "ProrrateoDet")
        Dim objListItem As New ListViewItem
        Me.listProrrateo.Items.Clear()
        For Each drw As DataRow In ds.Tables("ProrrateoDet").Rows
            objListItem = listProrrateo.Items.Add(drw.Item("CodigoProrrateo").ToString, 0)
            objListItem.SubItems.Add(drw.Item("area_depto").ToString)
            objListItem.SubItems.Add(drw.Item("participacion").ToString)
            Refresh()
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub totales()
        Dim importe As Decimal
        Dim total As Decimal = 0
        txtParticipacion.Text = "0"
        For i = 0 To listProrrateo.Items.Count - 1
            importe = CDec(listProrrateo.Items(i).SubItems(2).Text) 'Leemos el valor de la primera columna
            total = total + importe
            Me.lblTotal1.Text = total
            'Leemos el valor de las siguientes columnas
        Next
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If Me.txtCodigo.Text = "" Then
            'MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Almacen")
            txtCodigo.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Todos los Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsProrrateo2 = New clsMttoProrrateo()
                oclsProrrateo2.EliminaProrrateo2(Me.txtCodigo.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Almacen")
                txtParticipacion.Clear()
                BtnGrabar.Enabled = True
                BtnEliminar.Enabled = False
                btnAgregar.Enabled = False
                Me.txtCodigo.Focus()
                Me.txtCodigo.Enabled = False
                CbxClasificacion.Enabled = True
                CbxDepto.Enabled = True
                CbxArea.Enabled = True
                txtParticipacion.Enabled = True
                llenalista2()
                totales()
                CargaCbxClasificacion()
            End If
        End If
    End Sub
    Private Sub txtParticipacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParticipacion.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                txtParticipacion.Focus()
            Else
                btnAgregar.Enabled = True
                ' btnAgregar.PerformClick()
                If e.KeyChar = ChrW(Keys.Enter) Then
                    e.Handled = True
                    btnAgregar.PerformClick()
                End If
            End If
        End If
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtCodigo.Text = "" Or CbxClasificacion.SelectedValue = "" Or txtParticipacion.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Almacen")
        End If
        'Me.listProrrateo.Items.Clear()
        Item = New ListViewItem(Me.txtCodigo.Text)
        Item.SubItems.Add(Me.CbxDepto.SelectedValue)
        Item.SubItems.Add(Me.txtParticipacion.Text)
        listProrrateo.Items.Add(item)
        txtParticipacion.Clear()
        totales()
        BtnGrabar.Enabled = True
        btnModificar.Enabled = True
        BtnEliminar.Enabled = True
        btnAgregar.Enabled = False
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If txtCodigo.Text = "" Or lblTotal1.Text <> 100 Then
            MsgBox("El Porcentaje de Participacion debe ser 100%, Verifique..!!!", vbInformation, "Sistema Almacen")

            Dim cecos As String
            If CbxArea.SelectedValue = Nothing Then
                cecos = ""
            Else
                cecos = CbxArea.SelectedValue
            End If
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()

                Dim oclsProrrateo2 = New clsMttoProrrateo()
                oclsProrrateo2.EliminaProrrateo2(Me.txtCodigo.Text)
                MsgBox("Registro Modificado", vbInformation, "Sistema Almacen")
                txtParticipacion.Clear()
                BtnGrabar.Enabled = True
                BtnEliminar.Enabled = True
                btnAgregar.Enabled = False
                btnModificar.Enabled = True
                Me.txtCodigo.Focus()
                Me.txtCodigo.Enabled = False
                CbxClasificacion.Enabled = True
                CbxDepto.Enabled = False
                CbxArea.Enabled = False
                txtParticipacion.Enabled = False
                'llenalista2()
                'totales()
                CargaCbxClasificacion()
                Dim sSql2 As String
                sSql2 = " INSERT INTO [Compras].[dbo].[ProrrateoDet] ([CodigoProrrateo],[area_depto],[Participacion])  values (@CodigoProrrateo,@area_depto,@Participacion) "
                Dim CmdIns As New SqlCommand(sSql2, cnnConexion)
                For Each item As ListViewItem In listProrrateo.Items
                    'Me.listProrrateo.Items.Clear()
                    CmdIns.Parameters.Clear()
                    CmdIns.Parameters.AddWithValue("@CodigoProrrateo", item.SubItems(0).Text)
                    CmdIns.Parameters.AddWithValue("@area_depto", item.SubItems(1).Text)
                    CmdIns.Parameters.AddWithValue("@Participacion", item.SubItems(2).Text)
                    'CmdIns.Parameters.AddWithValue("@area_depto")
                    'CmdIns.Parameters.AddWithValue("@Participacion")
                    CmdIns.ExecuteNonQuery()
                Next
                'MsgBox("Registrado Correctamente", vbInformation, "Sistema Almacen")
                txtParticipacion.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Almacen")
            End Try
        End If
        'llenalista2()
        totales()
        CargaCbxClasificacion()
    End Sub
    Private Sub btnRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistro.Click
        Dim c As Integer
        c = listProrrateo.SelectedIndices(c)
        listProrrateo.Items.RemoveAt(c)
        totales()
        'listProrrateo.Items(c).Selected = True
        btnRegistro.Enabled = False
    End Sub
    Private Sub listProrrateo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listProrrateo.MouseClick
        btnRegistro.Enabled = True
    End Sub
End Class