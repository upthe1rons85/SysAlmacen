Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsEntradas
Public Class frmEntradas
    Friend cTabla As String
    Public wFolio As String
    Dim TiposMovs As String
    Dim xTipoMov As Integer
    Dim sumaunidades As Double
    Dim sumaprecio As Double
    Dim item As ListViewItem
    Dim buscar As Boolean
    Private Sub frmEntradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblReferencia.Text = "Factura Prov. :"  'se especifica el texto del label ya que es variable dependiendo el tipo de movimiento 
        Dtpfecha.Value = Today
        CargaCbxTipMov()
        ValidaTipoCambio()
        TiposMovimientosEntradas()
        buscar = False
    End Sub
    Private Sub TiposMovimientosEntradas()
        'variable TiposMovs hace referencia a todos los tipos de movimientos de entrada para el sistema almacen
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select tipmoventradas from [Almacen].[dbo].[parametros](nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text
        TiposMovs = cmd.ExecuteScalar()

        Dim datos2 As String
        Dim consulta2 As String = "Select Descripcion from acotipomovpoliza(nolock) where tipomovimiento in (" & TiposMovs & ") "
        Dim cmd2 As New SqlCommand(consulta2, cnnConexion)
        cmd2.CommandType = CommandType.Text
        datos2 = cmd2.ExecuteScalar()

        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub limpiar()
        Dtpfecha.Value = Today
        LstProducto.Items.Clear()
        TxtProveedor.Clear()
        LblNomProv.Text = ""
        TxtReferencia.Clear()
        TxtReferencia.Clear()
        TxtProducto.Clear()
        TxtDescripcion.Clear()
        TxtFolio.Clear()
        TxtFolio.Enabled = False
        Dtpfecha.Enabled = False
        TxtProveedor.Enabled = False
        TxtReferencia.Enabled = False
        CbxTipoMov.Enabled = True
        Dtpfecha.Enabled = False
        TxtProducto.Enabled = False
        TxtPrecio.Enabled = False
        TxtUnidades.Enabled = False
        GbxAreas.Enabled = False
        BtnGrabar.Enabled = False
        BtnEliminar.Enabled = False
        sumaunidades = 0
        sumaprecio = 0
        Me.lblTotal1.Text = 0
        Me.LblTotal.Text = 0
        CbxTipoMov.Focus()
        ValidaTipoCambio()
        LblReferencia.Text = "Referencia :"  'se especifica el texto del label ya que es variable dependiendo el tipo de movimiento 
        Me.CbxClasificacion.Text = ""
    End Sub
    Private Sub RegresaMovimientos()
        'esta variable se utiliza para regresar el valor correcto del tipo de movimiento de la entrada
        xTipoMov = Me.CbxTipoMov.SelectedValue
        Select Case xTipoMov
            Case 52
                xTipoMov = 5
        End Select

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()
        Dim oclsCliente = New clsEntradas()
        Dim dr As SqlDataReader

        dr = oclsCliente.SeleccionaFolio(Me.TxtFolio.Text, xTipoMov)

        If dr.Read() Then
            Me.Dtpfecha.Text = dr("Fecha").ToString()
            Me.TxtProveedor.Text = dr("Proveedor").ToString()
            Me.TxtReferencia.Text = dr("RefDocumento").ToString()
            'valida el estatus del movimiento para saber si no esta cancelado
            Dim ValidaEstatus As Integer
            ValidaEstatus = RTrim(dr("Estatus").ToString())
            If ValidaEstatus = 2 Then
                RegresaDatosLista()
                totales()
                TxtFolio.Focus()
                MsgBox("Folio de Movimiento Cancelado...", MessageBoxIcon.Error)
                Me.TxtFolio.SelectAll()
            Else
                RegresaDatosLista()
                totales()
                TxtFolio.Focus()
                BtnEliminar.Enabled = True
            End If
        Else
            MsgBox("Folio de Movimiento no encontrado...", MessageBoxIcon.Error)
            Me.BtnGrabar.Enabled = False
            Me.BtnNuevo.Enabled = True
            Me.BtnEliminar.Enabled = False
            Me.TxtFolio.Focus()
        End If
    End Sub
    Sub CargaCbxTipMov()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        'Dim consulta As String = "Select TipoMovimiento,Descripcion from [Almacen].[dbo].[acotipomovpoliza](nolock) where TipoMovimiento in('3','5','6','51','52','53')"
        Dim consulta As String = "Select TipoMovimiento,Descripcion from [Almacen].[dbo].[acotipomovpoliza](nolock) where TipoMovimiento in('3','5','6','51','52','53')"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxTipoMov.ValueMember = "TipoMovimiento"
        CbxTipoMov.DisplayMember = "Descripcion"
        CbxTipoMov.DataSource = dt
        CbxTipoMov.Text = "Seleccione Tipo Mov."
        clsDB.CierraConexion(cnnConexion)
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
        'CbxClasificacion.Text = "Seleccione Clasificacion"
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub CbxClasificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxClasificacion.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.CbxArea.Focus()
        End If
    End Sub
    Private Sub CbxClasificacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxClasificacion.SelectedIndexChanged
        If Me.CbxClasificacion.Text = "Seleccione Clasificacion" Then
            Me.CbxClasificacion.ValueMember = ""
            Me.CbxArea.Text = "Seleccione Area"

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

            Me.CbxArea.ValueMember = "Area"
            Me.CbxArea.DisplayMember = "Des_Area"
            Me.CbxArea.DataSource = dt
            Me.CbxArea.Text = "Seleccione Area"
            clsDB.CierraConexion(cnnConexion)
        End If
    End Sub
    Private Sub CbxArea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxArea.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.CbxDepto.Focus()
        End If
    End Sub
    Private Sub CbxArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxArea.SelectedIndexChanged
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
    Private Sub CbxTipEnt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxTipoMov.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            xTipoMov = Me.CbxTipoMov.SelectedValue
            If CbxTipoMov.Text = "Seleccione Tipo Mov." Then
                MsgBox("Seleccione un Tipo de Movimiento...", MessageBoxIcon.Error)
            Else
                Select Case xTipoMov
                    Case 3, 5
                        BtnNuevo.Enabled = True
                        BtnGrabar.Enabled = False
                        Dtpfecha.Enabled = True
                        TxtProveedor.Enabled = True
                        TxtReferencia.Enabled = True
                        CbxTipoMov.Enabled = False
                        Dtpfecha.Focus()
                    Case 6
                        BtnNuevo.Enabled = True
                        BtnGrabar.Enabled = False
                        Dtpfecha.Enabled = True
                        TxtProveedor.Enabled = False
                        TxtProveedor.Text = "0"
                        TxtReferencia.Enabled = True
                        GbxAreas.Enabled = True
                        CargaCbxClasificacion()
                        LblReferencia.Text = "Lote Produccion :"
                        CbxTipoMov.Enabled = False
                        Dtpfecha.Focus()
                    Case 52
                        TxtFolio.Enabled = True
                        CbxTipoMov.Enabled = False
                        TxtFolio.Focus()
                    Case 51, 53
                        BtnNuevo.Enabled = True
                        BtnGrabar.Enabled = False
                        Dtpfecha.Enabled = True
                        TxtProveedor.Enabled = True
                        TxtReferencia.Enabled = True
                        CbxTipoMov.Enabled = False
                        Dtpfecha.Focus()
                    Case Else
                        MsgBox("Tipo de Entrada no Esta Dentro de los Parametros...", MessageBoxIcon.Error)
                        CbxTipoMov.Focus()
                End Select
                If xTipoMov = 51 Then
                    TxtProveedor.Enabled = False
                    TxtProveedor.Text = "0"
                    GbxAreas.Enabled = True
                    CargaCbxClasificacion()
                End If
                '-----Validacion para cambiar el texto del LblReferencia, dependiendo el tipo de movimiento
                If xTipoMov = 5 Then
                    LblReferencia.Text = "Factura Proveedor :"
                ElseIf xTipoMov = 51 Then
                    LblReferencia.Text = "Lote Produccion :"
                End If
            End If
        End If
    End Sub
    Private Sub Dtpfecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Dtpfecha.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            'puede cambiar el focus de proveedor a referencia dependiendo el tipo de movimiento, ya que el tipo de mov 53 no usa campo proveedor
            If TxtProveedor.Enabled = False Then
                TxtReferencia.Focus()
            Else
                TxtProveedor.Focus()
            End If
        End If
    End Sub
    Private Sub TxtProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProveedor.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            MuestraProveedor()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtReferencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReferencia.KeyPress
        'If InStr(1, "0123456789A" & Chr(8), e.KeyChar) = 0 Then
        'e.KeyChar = ""
        'End If
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.CbxClasificacion.Focus()
        End If
        If Not Char.IsLetterOrDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtReferencia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReferencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtReferencia.Text = "" Or TxtProveedor.Text = "" Then
                MsgBox("Faltan datos por capturar...", MessageBoxIcon.Error)
                TxtReferencia.Focus()
            Else
                If Me.CbxTipoMov.SelectedValue = 5 Then
                    '------Valida que la factura de proveedor no halla sido capturada anteriormente
                    Dim FacturaProveedor = New clsEntradas()
                    Dim dr As SqlDataReader

                    dr = FacturaProveedor.ValidaFacturaProv(Me.CbxTipoMov.SelectedValue, Me.TxtProveedor.Text, Me.TxtReferencia.Text)

                    If dr.Read() Then
                        MsgBox("Esta Factura de Proveedor ya se Encuentra Capturada, Favor de Revisar...", MessageBoxIcon.Error)
                        Me.TxtReferencia.SelectAll()
                        Me.TxtReferencia.Focus()
                    Else
                        TxtProducto.Enabled = True
                        TxtUnidades.Enabled = True
                        TxtPrecio.Enabled = True
                        CbxTipoMov.Enabled = False
                        Dtpfecha.Enabled = False
                        TxtProveedor.Enabled = False
                        TxtReferencia.Enabled = False
                        TxtProducto.Focus()
                    End If
                Else
                    TxtProducto.Enabled = True
                    TxtUnidades.Enabled = True
                    TxtPrecio.Enabled = True
                    CbxTipoMov.Enabled = False
                    Dtpfecha.Enabled = False
                    TxtProveedor.Enabled = False
                    TxtReferencia.Enabled = False
                    TxtProducto.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub TxtProducto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProducto.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            cargadatos()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtUnidades_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUnidades.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            If Me.CbxTipoMov.SelectedValue = 51 Or Me.CbxTipoMov.SelectedValue = 6 Or Me.CbxTipoMov.SelectedValue = 53 Then
                If Me.TxtProducto.Text = "" Or Me.TxtUnidades.Text = "" Then
                    MsgBox("No deben quedar datos vacios...", MessageBoxIcon.Error)
                    Me.TxtUnidades.Focus()
                Else
                    '----asigna precio a producto-----
                    Dim CostoProducto = New clsEntradas()
                    Dim dr As SqlDataReader

                    dr = CostoProducto.AsignaPrecioProducto(TxtProducto.Text, Me.TxtUnidades.Text)

                    If dr.Read() Then
                        Me.TxtPrecio.Text = dr("Costo").ToString()
                    End If
                    '---------------------------------
                    cargaLista()
                    totales()
                    BtnGrabar.Enabled = True
                    TxtProducto.Focus()
                End If
            Else
                Me.TxtPrecio.Focus()
            End If
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
            End If
        End If
    End Sub
    Private Sub TxtPrecio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPrecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtPrecio.Text = "" Or TxtProducto.Text = "" Or TxtUnidades.Text = "" Then
                MsgBox("No deben quedar datos vacios...", MessageBoxIcon.Error)
                TxtPrecio.Focus()
            Else
                cargaLista()
                totales()
                BtnGrabar.Enabled = True
                TxtProducto.Focus()
            End If
        End If
    End Sub
    Private Sub TxtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecio.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cargadatos()
        Dim oclsProducto = New clsEntradas()
        Dim dr As SqlDataReader

        dr = oclsProducto.SeleccionaProductos(Me.TxtProducto.Text)

        If dr.Read() Then

            Me.TxtDescripcion.Text = RTrim(dr("Descripcion").ToString())
            Me.TxtSaldo.Text = RTrim(dr("ExistenciaUnidades").ToString())
            TxtUnidades.Focus()
        Else
            MsgBox("Codigo de Producto no encontrado...", MessageBoxIcon.Error)
            BtnGrabar.Enabled = False
            BtnEliminar.Enabled = False
            Me.TxtProducto.Clear()
            Me.TxtDescripcion.Clear()
            Me.TxtProducto.Focus()
        End If
    End Sub
    Private Sub MuestraProveedor()
        Dim xClsProveedor = New clsEntradas()
        Dim dr As SqlDataReader

        dr = xClsProveedor.SeleccionaProveedor(Me.TxtProveedor.Text)

        If dr.Read() Then

            Me.LblNomProv.Text = RTrim(dr("Proveedor").ToString())
            TxtReferencia.Focus()
        Else
            MsgBox("Codigo de Proveedor no Encontrado...", MessageBoxIcon.Error)
            BtnGrabar.Enabled = False
            BtnEliminar.Enabled = False
            Me.TxtProveedor.Focus()
            Me.TxtProveedor.SelectAll()
            Me.LblNomProv.Text = ""
        End If
    End Sub
    Private Sub cargaLista()
        item = New ListViewItem(Me.TxtProducto.Text)
        item.SubItems.Add(Me.TxtDescripcion.Text)
        item.SubItems.Add(Me.TxtUnidades.Text)
        item.SubItems.Add(Me.TxtPrecio.Text)
        LstProducto.Items.Add(item)
        Me.TxtProducto.Clear()
        Me.TxtDescripcion.Clear()
        Me.TxtUnidades.Clear()
        Me.TxtPrecio.Clear()
    End Sub
    Sub totales()
        For i = 0 To LstProducto.Items.Count - 1
            sumaunidades = sumaunidades + Val(LstProducto.Items(i).SubItems(2).Text)
            sumaprecio = sumaprecio + Val(LstProducto.Items(i).SubItems(3).Text)
        Next

        Me.lblTotal1.Text = sumaunidades
        Me.LblTotal.Text = sumaprecio
        sumaunidades = 0
        sumaprecio = 0
    End Sub
    Private Sub LstProducto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstProducto.Leave
        TxtProducto.Focus()
    End Sub
    Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If Me.CbxDepto.Text = "Seleccione Depto." And xTipoMov = 6 Then
            MsgBox("Debe Seleccionar Un Centro de Costo", vbInformation, "Sistema Contable")
            Me.CbxDepto.Focus()
        Else
            'se define el valor para el centro de costos ya que no todos los mov. llevan centro de costos
            Dim cecos As String
            If xTipoMov <> 6 And xTipoMov <> 51 Then
                cecos = ""
            Else
                cecos = CbxDepto.SelectedValue
            End If
            '---------------------------------------------------------------------------------------------
            Try
                'se determina el nombre de la tabla temporal
                Dim Random As New Random()
                ' generar un random entre 1 y 100   
                Dim numero As Integer = Random.Next(1, 1000)
                cTabla = "TMP_" & CInt(numero)
                '----------------------------------------------
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()

                Dim sSql As String = ""
                Dim LocalCmd As SqlCommand
                sSql = "CREATE TABLE " + cTabla + "([CodigoProducto] int, [Descripcion] nvarchar(60), [Piezas] decimal(18, 4), [Costo] decimal(18, 4), [Renglon] int)"

                LocalCmd = New Data.SqlClient.SqlCommand(sSql, cnnConexion)
                LocalCmd.CommandType = Data.CommandType.Text
                LocalCmd.ExecuteNonQuery()

                'inserta a tabla temporal los registros del listview
                Dim sSql2 As String
                sSql2 = "INSERT  INTO " + cTabla + " values (@nProducto,@nDescripcion,@nPiezas,@nCosto,@nRenglon)"
                Dim CmdIns As New SqlCommand(sSql2, cnnConexion)

                CmdIns.CommandType = Data.CommandType.Text
                Dim renglon As Integer

                For Each item As ListViewItem In LstProducto.Items
                    renglon = renglon + 1
                    CmdIns.Parameters.Clear()
                    CmdIns.Parameters.AddWithValue("@nProducto", item.SubItems(0).Text)
                    CmdIns.Parameters.AddWithValue("@nDescripcion", item.SubItems(1).Text)
                    CmdIns.Parameters.AddWithValue("@nPiezas", item.SubItems(2).Text)
                    CmdIns.Parameters.AddWithValue("@nCosto", item.SubItems(3).Text)
                    CmdIns.Parameters.AddWithValue("@nRenglon", renglon)

                    CmdIns.ExecuteNonQuery()
                Next

                '--------Se Valida que el saldo del producto no se haga negativo en alguna salida---------
                Dim Parametrovalidar As String 'si trae valor 1 es que algun producto esta con problemas de integridad y no dejara realizar la salida
                Parametrovalidar = 0
                If CbxTipoMov.SelectedValue = 51 Or CbxTipoMov.SelectedValue = 53 Then
                    Dim ValidaSaldo = New clsEntradas()
                    Dim dr As SqlDataReader

                    dr = ValidaSaldo.ValidaSaldoproductoSalidas(cTabla)

                    Dim productosproblema As String

                    If dr.Read() Then
                        productosproblema = dr("Productos").ToString()
                        MsgBox("Existen Productos que haran el saldo negativo, Favor de Revisar el Saldo de los Productos, " + productosproblema, vbInformation, "Sistema Contable")
                        Me.TxtProducto.Focus()
                        Parametrovalidar = 1
                    End If
                End If
                If Parametrovalidar = 0 Then
                    Dim xQuery As String = ""
                    Dim LocalCommand As SqlCommand
                    'Dim wFolio As String
                    xTipoMov = CInt(Int(Me.CbxTipoMov.SelectedValue))
                    xQuery = "SELECT MAX(folio)+1 FROM Almacen.dbo.acotipomovpoliza (NOLOCK) where TipoMovimiento = '" & Me.CbxTipoMov.SelectedValue & "' "

                    LocalCommand = New Data.SqlClient.SqlCommand(xQuery, cnnConexion)
                    LocalCommand.CommandType = Data.CommandType.Text
                    wFolio = LocalCommand.ExecuteScalar()

                    LocalCommand.Dispose()
                    'cnnConexion.Close()

                    Dim xfecha As String
                    xfecha = Format(Dtpfecha.Value, "yyyyMMdd")

                    Dim commandIns As New SqlCommand("spGuardaEntrada", cnnConexion)
                    commandIns.CommandType = CommandType.StoredProcedure
                    commandIns.Parameters.AddWithValue("@nTipoMovimiento", CbxTipoMov.SelectedValue)
                    commandIns.Parameters.AddWithValue("@nFecha", xfecha)
                    commandIns.Parameters.AddWithValue("@nProveedor", TxtProveedor.Text)
                    commandIns.Parameters.AddWithValue("@nRefDocumento", TxtReferencia.Text)
                    commandIns.Parameters.AddWithValue("@nCecos", cecos)
                    commandIns.Parameters.AddWithValue("@nTabla", cTabla)
                    commandIns.Parameters.AddWithValue("@nUsuario", LoginUsuario)
                    commandIns.Parameters.AddWithValue("@nfolio", wFolio)

                    commandIns.ExecuteNonQuery()

                    cnnConexion.Close()
                    cnnConexion.Dispose()

                    Dim xfolio = New clsEntradas()
                    xfolio.AdelantaFolioEntrada(wFolio, CbxTipoMov.SelectedValue)

                    MsgBox("Registrado Correctamente, Folio de Movimiento " + wFolio, vbInformation, "Sistema Contable")
                    If Me.CbxTipoMov.SelectedValue = 51 Or Me.CbxTipoMov.SelectedValue = 6 Then
                        btnImprimir.PerformClick()
                    End If
                    limpiar()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            'CargaCbxTipMov()
        End If
        
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        limpiar()
        CargaCbxTipMov()
        CargaCbxClasificacion()
        GbxAreas.Enabled = False
    End Sub
    Private Sub TxtFolio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFolio.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            RegresaMovimientos()
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub RegresaDatosLista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim vfolio As Integer = Me.TxtFolio.Text
        Dim vtipomov As Integer = xTipoMov

        Dim consulta As String = "select acokardexmovimientos.codigoproducto,acoproductos.descripcion,acokardexmovimientos.piezas,acokardexmovimientos.costo from acokardexmovimientos INNER JOIN acoproductos ON acokardexmovimientos.codigoproducto=acoproductos.codigoproducto where folio= '" & Me.TxtFolio.Text & "' and TipoMovimiento= '" & xTipoMov & "'  "
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "AcoKardexMovimientos")

        Dim objListItem As New ListViewItem
        Me.LstProducto.Items.Clear()

        For Each drw As DataRow In ds.Tables("AcoKardexMovimientos").Rows
            objListItem = LstProducto.Items.Add(drw.Item("CodigoProducto").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            objListItem.SubItems.Add(drw.Item("Piezas").ToString)
            objListItem.SubItems.Add(drw.Item("Costo").ToString)
        Next
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If MessageBox.Show("¿Desea CANCELAR el folio?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Try
                'se validara que la poliza no este transferida para poder cancelar el movimiento
                Dim xfecha As String = Me.Dtpfecha.Value
                xfecha = Format(Dtpfecha.Value, "yyyyMMdd")

                Dim Conexion = New SqlConnection()
                Dim xclsDB = New clsBD()
                Conexion = xclsDB.CreaConexion()

                Dim commandbus As New SqlCommand("spValidaPoliza", Conexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@TipoMovimiento", xTipoMov)
                commandbus.Parameters.AddWithValue("@Folio", Me.TxtFolio.Text)
                commandbus.Parameters.AddWithValue("@Fecha", xfecha)

                Dim ValidaPoliza As Integer
                ValidaPoliza = RTrim(commandbus.ExecuteScalar())
                xclsDB.CierraConexion(Conexion)
                '-------------------
                If ValidaPoliza = 1 Then
                    MsgBox("Ya se Encuentra Transferida la Poliza para este Movimiento, No se Puede Cancelar", vbInformation, "Sistema Contable")
                    limpiar()
                Else
                    'Se Inicia el proceso de cancelacion, se validara que no se haga negativo el saldo de algun producto
                    Dim ValidaProducto = New clsEntradas()
                    Dim dr As SqlDataReader

                    dr = ValidaProducto.ValidaSaldoproducto(Me.TxtFolio.Text, xTipoMov)

                    If dr.Read() Then
                        MsgBox("Existe al menos un  Producto  que haran el saldo negativo, Favor de Revisar el Saldo del Producto...!!! ", vbInformation, "Sistema Contable")
                        Me.TxtFolio.Focus()
                    Else
                        Dim cnnConexion = New SqlConnection()
                        Dim clsDB = New clsBD()

                        cnnConexion = clsDB.CreaConexion()

                        Dim Cancela As New SqlCommand

                        Cancela.CommandText = "sp_CancelaEntrada"
                        Cancela.CommandType = CommandType.StoredProcedure
                        Cancela.Connection = cnnConexion
                        Cancela.Parameters.AddWithValue("@TipoMovimiento", xTipoMov)
                        Cancela.Parameters.AddWithValue("@Folio", Me.TxtFolio.Text)

                        Cancela.ExecuteNonQuery()

                        cnnConexion.Close()
                        cnnConexion.Dispose()

                        MsgBox("Folio " & Me.TxtFolio.Text & " Cancelado Correctamente...!!! ", vbInformation, "Sistema Contable")
                        Me.BtnEliminar.Enabled = False
                        Me.CbxTipoMov.Focus()
                        limpiar()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
            End Try
            CargaCbxTipMov()
        End If
    End Sub
    Sub ValidaTipoCambio()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        'Dim xfecha As Date = Dtpfecha.Value
        Dim xFecha As String = Format(Dtpfecha.Value, "yyyyMMdd")
        Dim xQuery As String = ""
        Dim LocalCommand As SqlCommand
        Dim xTipoCambio As String
        xQuery = "Select TipoCambio from [Contabilidad].[dbo].[CatTipoCambio](nolock) Where FECHA= '" & xFecha & "'  "

        LocalCommand = New Data.SqlClient.SqlCommand(xQuery, cnnConexion)
        LocalCommand.CommandType = Data.CommandType.Text
        xTipoCambio = LocalCommand.ExecuteScalar()

        If xTipoCambio Is Nothing Then
            MsgBox("No se tiene capturado el Tipo de cambio para el dia de hoy...", vbInformation, "Sistema Contable")
        End If
        cnnConexion.Close()
        cnnConexion.Dispose()
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmReciboAlmacen
        frm.nTipoMovimiento = CbxTipoMov.SelectedValue
        If buscar = True Then
            wFolio = Me.TxtFolio.Text
            frm.nFolio = wFolio
        Else
            frm.nFolio = wFolio
        End If
        frm.nProveedor = TxtProveedor.Text
        frm.nRefDocumento = TxtReferencia.Text
        frm.Show()
    End Sub
    Private Sub CbxDepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxDepto.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtProducto.Focus()
        End If
    End Sub
    Private Sub BtnEliminaFila_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminaFila.Click
        If MessageBox.Show("¿Desea Eliminar la Fila?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'LstProducto.Items.Remove(LstProducto.SelectedItems.index)
            For i As Integer = LstProducto.SelectedItems.Count - 1 To 0 Step -1
                LstProducto.SelectedItems(i).Remove()
            Next
        Else
            Me.TxtProducto.Focus()
        End If
    End Sub
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        buscar = True
        Me.CbxTipoMov.Enabled = True
        Me.TxtFolio.Enabled = True
        Me.CbxTipoMov.Focus()
    End Sub
End Class