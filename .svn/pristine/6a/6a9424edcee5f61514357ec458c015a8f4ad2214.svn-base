Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.mdVariables
Public Class frmProductos

    Dim xFecha As Date = Now
    Dim fechaAlta As String = Format(xFecha, "M/d/yyyy H:mm")
    Dim fechaBaja As String = Format(xFecha, "M/d/yyyy H:mm")
    Dim fechaAlta2 As Date
    Dim FechaUltimoCambio As String = Format(xFecha, "M/d/yyyy H:mm")
    Dim nUniMedida As String
    Dim nFamilia As String
    Dim nSubFamilia As String
    'Dim nSubFamiNiv1 As String
    'Dim nSubFamiNiv2 As String
    Dim nEstatus As String
    Dim Existencias As String
    Private Sub frmProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Catálogo de Productos" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        CargaCbxUniMedida()
        CargaCbxEstatus()
        CargaCbxFamilia()
        llenalista()
    End Sub
    Private Sub llenalista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "Select * from Almacen.Dbo.AcoProductos(nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "AcoProductos")
        Dim objListItem As New ListViewItem
        lstProducto.Items.Clear()
        For Each drw As DataRow In ds.Tables("AcoProductos").Rows
            objListItem = lstProducto.Items.Add(drw.Item("CodigoProducto").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub TxtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If TxtCodigo.Text <> "" Then
                cargadatos()
                BtnGrabar.Enabled = False
                BtnNuevo.Enabled = True
                btnModificar.Enabled = True
                BtnEliminar.Enabled = True
            Else
                Me.TxtCodigo.Text = "0000"
                Me.TxtCodigo.Enabled = False
                Me.btnModificar.Enabled = True
                Me.btnModificar.PerformClick()
                Me.TxtCodigo.Clear()
                Me.TxtDescripcion.Clear()
                Me.TxtCtoProm.Clear()
                Me.TxtUltimoCto.Clear()
                Me.TxtExiUni.Clear()
                Me.TxtExiFin.Clear()
                Me.TxtCodBarras.Clear()
                Me.TxtPtoReorden.Clear()
                Me.BtnGrabar.Enabled = True
                Me.BtnNuevo.Enabled = True
                Me.btnModificar.Enabled = False
                Me.BtnEliminar.Enabled = False
            End If
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
            End If
        End If
    End Sub
    Private Sub cargadatos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim oclsProducto = New clsProductos()
        Dim dr As SqlDataReader

        dr = oclsProducto.SeleccionaProductos(Me.TxtCodigo.Text)

        If dr.Read() Then
            'Regresara la conversion de los datos numericos a String(Descripcion) de los sig. 3 campos de la tabla AcoProductos

            nUniMedida = dr("UnidadMedida").ToString()
            nFamilia = dr("Familia").ToString()
            nSubFamilia = dr("SubFamilia").ToString()
            'nSubFamiNiv1 = dr("SubFamiNiv1").ToString()
            'nSubFamiNiv2 = dr("SubFamiNiv2").ToString()
            nEstatus = dr("Estatus").ToString()

            Dim dr1 As SqlDataReader
            Dim aclsproducto = New clsProductos()

            dr1 = aclsproducto.Regresafamilia(nFamilia)
            If dr1.Read Then
                nFamilia = dr1("Descripcion").ToString()
            End If

            Dim dr2 As SqlDataReader
            Dim bclsproducto = New clsProductos()

            dr2 = bclsproducto.RegresaSubfamilia(nSubFamilia)
            If dr2.Read Then
                nSubFamilia = dr1("Descripcion").ToString()
            End If

            'Dim dr2a As SqlDataReader
            'Dim baclsproducto = New clsProductos()

            'dr2a = baclsproducto.RegresaSubfamiNiv1(nSubFamiNiv1)
            'If dr2a.Read Then
            'nSubFamiNiv1 = dr1("Descripcion").ToString()
            'End If

            'Dim dr2b As SqlDataReader
            'Dim bbclsproducto = New clsProductos()

            'dr2b = bbclsproducto.RegresaSubfamiNiv2(nSubFamiNiv2)
            'If dr2b.Read Then
            'nSubFamiNiv2 = dr1("Descripcion").ToString()
            'End If

            Dim dr3 As SqlDataReader
            Dim cclsproducto = New clsProductos()

            dr3 = cclsproducto.RegresaEstatusProd(nEstatus)
            If dr3.Read Then
                nEstatus = dr3("Descripcion").ToString()
            End If



            Dim dr5 As SqlDataReader
            Dim eclsproducto = New clsProductos()

            dr5 = eclsproducto.RegresaUnidadMedida(nUniMedida)
            If dr5.Read Then
                nUniMedida = dr5("Descripcion").ToString()
            End If

            Me.TxtCodigo.Text = dr("CodigoProducto").ToString()
            Me.TxtDescripcion.Text = dr("Descripcion").ToString()
            Me.CbxUniMedida.Text = nUniMedida
            Me.CbxFamilia.Text = nFamilia
            Me.CbxSubFami.Text = nSubFamilia
            'Me.CbxSubFamiNiv1.Text = nSubFamiNiv1
            'Me.CbxSubFamiNiv2.Text = nSubFamiNiv2
            Me.TxtCtoProm.Text = dr("CostoPromedio").ToString()
            Me.TxtUltimoCto.Text = dr("Ultimocosto").ToString()
            Me.TxtExiUni.Text = dr("ExistenciaUnidades").ToString()
            Me.TxtExiFin.Text = dr("ExistenciaFinanciera").ToString()
            Me.TxtCodBarras.Text = dr("CodigoBarras").ToString()
            Me.CbxEstatus.Text = nEstatus
            fechaAlta2 = dr("FechaAlta").ToString()
            fechaBaja = dr("FechaBaja").ToString()
            FechaUltimoCambio = dr("FechaAlta").ToString()
            Me.TxtPtoReorden.Text = dr("PuntoReorden").ToString()
            Me.LblCtaInventario.Text = dr("CuentaInventario").ToString()
            Me.LblCtaGasto.Text = dr("CuentaGasto").ToString()
            Me.LblCtaCompra.Text = dr("CuentaCompra").ToString()
        Else

            MsgBox("Codigo de Producto no encontrado...", MessageBoxIcon.Error)
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            btnModificar.Enabled = False
            BtnEliminar.Enabled = False
        End If
    End Sub
    Private Sub CargaCbxEstatus()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select Estatus,Descripcion from [Almacen].[dbo].[CatEstatusAlma](nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxEstatus.ValueMember = "Estatus"
        CbxEstatus.DisplayMember = "Descripcion"
        CbxEstatus.DataSource = dt
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub CargaCbxFamilia()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select CodFamilia,Descripcion from [Almacen].[dbo].[CatFamilias](nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxFamilia.ValueMember = "CodFamilia"
        CbxFamilia.DisplayMember = "Descripcion"
        CbxFamilia.DataSource = dt
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub CargaCbxUniMedida()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select UnidadMedida,Descripcion from [Almacen].[dbo].[AcoUnidadesMedida](nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxUniMedida.ValueMember = "UnidadMedida"
        CbxUniMedida.DisplayMember = "Descripcion"
        CbxUniMedida.DataSource = dt
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Me.TxtCodigo.Enabled = False
        Me.TxtDescripcion.Enabled = True
        Me.CbxUniMedida.Enabled = True
        Me.CbxFamilia.Enabled = True
        Me.CbxSubFami.Enabled = True
        'Me.CbxSubFamiNiv1.Enabled = True
        'If Me.CbxSubFamiNiv1.Text = "" Then
        'Me.CbxSubFamiNiv1.Enabled = False
        'End If
        'Me.CbxSubFamiNiv2.Enabled = True
        'If Me.CbxSubFamiNiv2.Text = "" Then
        'Me.CbxSubFamiNiv2.Enabled = False
        'End If
        Me.TxtCtoProm.Enabled = False
        Me.TxtUltimoCto.Enabled = False
        Me.TxtExiUni.Enabled = False
        Me.TxtExiFin.Enabled = False
        Me.TxtCodBarras.Enabled = True
        Me.CbxEstatus.Enabled = True
        Me.TxtPtoReorden.Enabled = True
        Me.LblCtaInventario.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        Me.TxtDescripcion.Focus()
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If Me.TxtDescripcion.Text = "" Or Me.TxtPtoReorden.Text = "" Or Me.CbxFamilia.Text = "" Or Me.CbxSubFami.Text = "" Then
            MsgBox("Faltan Datos Por Capturar..!!!", vbInformation, "Sistema Almacen")
            TxtDescripcion.Focus()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()

                Dim commandbus As New SqlCommand("sp_ValidaProducto", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure

                commandbus.Parameters.AddWithValue("@CodigoProducto", TxtCodigo.Text)

                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())

                If n > "0" Then

                    nUniMedida = CbxUniMedida.SelectedValue
                    nFamilia = CbxFamilia.SelectedValue
                    nSubFamilia = CbxSubFami.SelectedValue
                    nEstatus = CbxEstatus.SelectedValue
                    '-----------------------------------------
                    'If Me.CbxSubFamiNiv1.Text = "" Then
                    ' nSubFamiNiv1 = " "
                    'Else
                    'nSubFamiNiv1 = CbxSubFamiNiv1.SelectedValue
                    'End If
                    '-----------------------------------------
                    'If Me.CbxSubFamiNiv2.Text = "" Then
                    'nSubFamiNiv2 = " " = " "
                    'Else
                    'nSubFamiNiv2 = CbxSubFamiNiv2.SelectedValue
                    'End If
                    '-----------------------------------------
                    Me.TxtDescripcion.Text = UCase(Me.TxtDescripcion.Text)
                    Dim oclsProducto = New clsProductos()
                    oclsProducto.ActualizaProducto(Me.TxtCodigo.Text, Me.TxtDescripcion.Text, nUniMedida, nFamilia, nSubFamilia, Me.TxtCodBarras.Text, nEstatus, LoginUsuario, Me.TxtPtoReorden.Text)

                    MsgBox("Actualizado Correctamente", vbInformation, "Sistema Almacen")
                    Me.TxtCodigo.Clear()
                    Me.TxtDescripcion.Clear()
                    Me.TxtCtoProm.Clear()
                    Me.TxtUltimoCto.Clear()
                    Me.TxtExiUni.Clear()
                    Me.TxtExiFin.Clear()
                    Me.TxtCodBarras.Clear()
                    Me.TxtPtoReorden.Clear()
                    Me.LblCtaInventario.Text = ""
                    Me.LblCtaGasto.Text = ""
                    llenalista()

                Else
                    Dim wCodigo As String
                    Dim wQuery As String = ""
                    Dim LocalCommand As SqlCommand

                    'Dim xCodigo As Integer = 0
                    wQuery = "SELECT (folioproducto)+1 FROM parametros (NOLOCK)"

                    LocalCommand = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
                    LocalCommand.CommandType = Data.CommandType.Text
                    wCodigo = LocalCommand.ExecuteScalar()
                    LocalCommand.Dispose()
                    If wCodigo IsNot Nothing Then
                        'MsgBox("Se Genero Consecutivo de Folio Producto Correctamente", vbInformation, "Sistema Contable")
                    Else
                        MsgBox("No Se Genero Consecutivo de Folio Producto", vbInformation, "Sistema Almacen")
                    End If

                    nUniMedida = CbxUniMedida.SelectedValue
                    nFamilia = CbxFamilia.SelectedValue
                    nSubFamilia = CbxSubFami.SelectedValue
                    'nSubFamiNiv1 = CbxSubFamiNiv1.SelectedValue
                    'nSubFamiNiv2 = CbxSubFamiNiv2.SelectedValue
                    nEstatus = CbxEstatus.SelectedValue

                    'se agregan valores en ceros para los campos de costopromedio,ultimocosto,exi.unidades,exifinanciera cuando se crea el registro
                    Existencias = 0

                    Me.TxtDescripcion.Text = UCase(Me.TxtDescripcion.Text)

                    Dim sXML = "<xProducto>"
                    sXML += "<CodigoProducto>" + wCodigo + "</CodigoProducto>"
                    sXML += "<Descripcion>" + Me.TxtDescripcion.Text + "</Descripcion>"
                    sXML += "<UnidadMedida>" + nUniMedida + "</UnidadMedida>"
                    sXML += "<Familia>" + nFamilia + "</Familia>"
                    sXML += "<SubFamilia>" + nSubFamilia + "</SubFamilia>"
                    'sXML += "<SubFamiNiv1>" + nSubFamiNiv1 + "</SubFamiNiv1>"
                    'sXML += "<SubFamiNiv2>" + nSubFamiNiv2 + "</SubFamiNiv2>"
                    sXML += "<CostoPromedio>" + Existencias + "</CostoPromedio>"
                    sXML += "<UltimoCosto>" + Existencias + "</UltimoCosto>"
                    sXML += "<ExistenciaUnidades>" + Existencias + "</ExistenciaUnidades>"
                    sXML += "<ExistenciaFinanciera>" + Existencias + "</ExistenciaFinanciera>"
                    sXML += "<CodigoBarras>" + Me.TxtCodBarras.Text + "</CodigoBarras>"
                    sXML += "<Estatus>" + nEstatus + "</Estatus>"
                    sXML += "<FechaAlta>" + fechaAlta + "</FechaAlta>"
                    sXML += "<FechaUltimoCambio>" + fechaAlta + "</FechaUltimoCambio>"
                    sXML += "<UsuarioUltimoCambio>" + LoginUsuario + "</UsuarioUltimoCambio>"
                    sXML += "<PuntoReorden>" + Me.TxtPtoReorden.Text + "</PuntoReorden>"
                    sXML += "</xProducto>"

                    Dim oclsProducto = New clsProductos()
                    oclsProducto.InsertaProducto(sXML)
                    
                    MsgBox("Registrado Correctamente, Codigo de Producto " + wCodigo, vbInformation, "Sistema Almacen")

                    'Dim frm As New frmInfProductos
                    'xcodigo = wCodigo
                    'frm.ShowDialog()

                    Me.TxtCodigo.Clear()
                    Me.TxtDescripcion.Clear()
                    Me.TxtCtoProm.Clear()
                    Me.TxtUltimoCto.Clear()
                    Me.TxtExiUni.Clear()
                    Me.TxtExiFin.Clear()
                    Me.TxtCodBarras.Clear()
                    Me.TxtPtoReorden.Clear()
                    Me.LblCtaInventario.Text = ""
                    Me.LblCtaGasto.Text = ""
                    llenalista()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Almacen")
            End Try

            TxtCodigo.Enabled = True
            TxtDescripcion.Enabled = False
            CbxUniMedida.Enabled = False
            CbxFamilia.Enabled = False
            CbxSubFami.Enabled = False
            'CbxSubFamiNiv1.Enabled = False
            'CbxSubFamiNiv2.Enabled = False
            TxtCtoProm.Enabled = False
            TxtUltimoCto.Enabled = False
            TxtExiUni.Enabled = False
            TxtExiFin.Enabled = False
            TxtCodBarras.Enabled = False
            CbxEstatus.Enabled = False
            TxtPtoReorden.Enabled = False
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = False
            BtnEliminar.Enabled = False
            btnModificar.Enabled = False
            TxtCodigo.Focus()
        End If
    End Sub
    Private Sub CbxFamilia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxFamilia.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            CbxSubFami.Focus()
        End If
    End Sub
    Private Sub CbxFamilia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxFamilia.SelectedIndexChanged
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta2 As String = "Select CodSubFami,Descripcion from CatSubFamilias where CodFamilia = '" & CbxFamilia.SelectedValue & "'"
        Dim cmd2 As New SqlCommand(consulta2, cnnConexion)
        cmd2.CommandType = CommandType.Text

        Dim da2 As New SqlDataAdapter(cmd2)
        Dim dt2 As New DataTable

        da2.Fill(dt2)

        CbxSubFami.ValueMember = "CodSubFami"
        CbxSubFami.DisplayMember = "Descripcion"
        CbxSubFami.DataSource = dt2
    End Sub
    Private Sub CbxSubFami_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxSubFami.SelectedIndexChanged
        'Dim cnnConexion = New SqlConnection()
        'Dim clsDB = New clsBD()
        'cnnConexion = clsDB.CreaConexion()

        'Dim consulta3 As String = "Select CodSubFamiNiv1,Descripcion from CatSubFamiNiv1 where CodSubFamilia = '" & CbxSubFami.SelectedValue & "'"
        'Dim cmd3 As New SqlCommand(consulta3, cnnConexion)
        'cmd3.CommandType = CommandType.Text

        'Dim da3 As New SqlDataAdapter(cmd3)
        'Dim dt3 As New DataTable

        'da3.Fill(dt3)

        'CbxSubFamiNiv1.ValueMember = "CodSubFamiNiv1"
        'CbxSubFamiNiv1.DisplayMember = "Descripcion"
        'CbxSubFamiNiv1.DataSource = dt3
    End Sub
    Private Sub CbxSubFamiNiv1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim cnnConexion = New SqlConnection()
        'Dim clsDB = New clsBD()
        'cnnConexion = clsDB.CreaConexion()

        'Dim consulta4 As String = "Select CodSubFamiNiv2,Descripcion from CatSubFamiNiv2 where CodSubFamiNiv1 = '" & CbxSubFamiNiv1.SelectedValue & "'"
        'Dim cmd4 As New SqlCommand(consulta4, cnnConexion)
        'cmd4.CommandType = CommandType.Text

        'Dim da4 As New SqlDataAdapter(cmd4)
        'Dim dt4 As New DataTable

        'da4.Fill(dt4)

        'CbxSubFamiNiv2.ValueMember = "CodSubFamiNiv2"
        'CbxSubFamiNiv2.DisplayMember = "Descripcion"
        'CbxSubFamiNiv2.DataSource = dt4
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If Me.TxtCodigo.Text = "" Or Me.CbxFamilia.Text = "" Then
            MsgBox("Debe capturar un Codigo de Producto", vbInformation, "Sistema Almacen")
            TxtCodigo.Focus()
        Else

            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()

            Dim commandbus As New SqlCommand("spValEliProducto", cnnConexion)
            commandbus.CommandType = CommandType.StoredProcedure

            commandbus.Parameters.AddWithValue("@CodigoProducto", TxtCodigo.Text)

            Dim n As Integer
            n = RTrim(commandbus.ExecuteScalar())

            If n > "0" Then
                MsgBox("El Codigo de Producto No puede Ser Eliminado ya que Contiene Historial en el Kardex, favor de revisar.", vbInformation, "Sistema Almacen")
                TxtCodigo.Focus()
            Else
                If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim oclsProveedor = New clsProductos()
                    oclsProveedor.EliminaProducto(Me.TxtCodigo.Text)
                    MsgBox("Registro Eliminado", vbInformation, "Sistema Almacen")
                    Me.TxtCodigo.Clear()
                    Me.TxtDescripcion.Clear()
                    Me.TxtCtoProm.Clear()
                    Me.TxtUltimoCto.Clear()
                    Me.TxtExiUni.Clear()
                    Me.TxtExiFin.Clear()
                    Me.TxtCodBarras.Clear()
                    Me.TxtPtoReorden.Clear()
                    Me.LblCtaInventario.Text = ""
                    Me.LblCtaGasto.Text = ""
                    BtnGrabar.Enabled = False
                    BtnNuevo.Enabled = False
                    btnModificar.Enabled = False
                    btnModificar.Enabled = False
                    BtnEliminar.Enabled = False
                    Me.TxtCodigo.Enabled = True
                    Me.TxtCodigo.Focus()
                    llenalista()
                End If
            End If
            clsDB.CierraConexion(cnnConexion)
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Me.TxtCodigo.Clear()
        Me.TxtDescripcion.Clear()
        Me.TxtCtoProm.Clear()
        Me.TxtUltimoCto.Clear()
        Me.TxtExiUni.Clear()
        Me.TxtExiFin.Clear()
        Me.TxtCodBarras.Clear()
        Me.TxtPtoReorden.Clear()
        Me.LblCtaInventario.Text = ""
        Me.LblCtaGasto.Text = ""
        Me.TxtCodigo.Enabled = False
        Me.TxtDescripcion.Enabled = True
        Me.CbxUniMedida.Enabled = True
        Me.CbxFamilia.Enabled = True
        Me.CbxSubFami.Enabled = True
        'Me.CbxSubFamiNiv1.Enabled = True
        'If Me.CbxSubFamiNiv1.Text = "" Then
        'Me.CbxSubFamiNiv1.Enabled = False
        'End If
        'Me.CbxSubFamiNiv2.Enabled = True
        'If Me.CbxSubFamiNiv2.Text = "" Then
        'Me.CbxSubFamiNiv2.Enabled = False
        'End If
        Me.TxtCodBarras.Enabled = True
        Me.CbxEstatus.Enabled = True
        Me.TxtPtoReorden.Enabled = True
        Me.BtnGrabar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnModificar.Enabled = False
        Me.BtnEliminar.Enabled = False
        Me.TxtDescripcion.Focus()
    End Sub
    Private Sub TxtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.CbxUniMedida.Focus()
        End If
    End Sub
    Private Sub CbxUniMedida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxUniMedida.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            CbxFamilia.Focus()
        End If
    End Sub
    Private Sub CbxSubFami_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxSubFami.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtPtoReorden.Focus()
        End If
    End Sub
    Private Sub TxtPtoReorden_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPtoReorden.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.CbxEstatus.Focus()
        End If
    End Sub
    Private Sub CbxEstatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxEstatus.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtCodBarras.Focus()
        End If
    End Sub
    Private Sub TxtCodBarras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodBarras.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.BtnGrabar.Focus()
        End If
    End Sub
    Private Sub TxtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBuscar.GotFocus
        Me.TxtBuscar.Text = ""
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        Me.TxtBuscar.ForeColor = Color.Black
    End Sub
    Private Sub TxtProducto_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuscar.KeyUp
        Dim dr As SqlDataReader
        Dim Productodescripcion = New clsProductos()

        dr = Productodescripcion.BuscaDescProducto(Me.TxtBuscar.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        lstProducto.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CodigoProducto").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstProducto.Items.Add(lstLista)
        Next
    End Sub
    Private Sub lstProducto_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstProducto.MouseDoubleClick
        Me.TxtCodigo.Text = lstProducto.SelectedItems(0).SubItems(0).Text
        cargadatos()
        Me.BtnGrabar.Enabled = False
        Me.BtnEliminar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnModificar.Enabled = True
        Me.TxtCodigo.Focus()
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmInfProductos2
        frm.ShowDialog()
    End Sub
End Class