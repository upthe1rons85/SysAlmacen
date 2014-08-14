Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools

Public Class frmInformeEntradas
    
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTInformeMov

        'If Me.dtpFechaFinal.Value < Me.DtpFechaInicial.Value Then
        '    MsgBox("La Fecha Final no debe ser Menor a la Fecha Inicial..!!!", MessageBoxIcon.Error)
        'Else
        '    If rbFolio.Checked Then
        '        If txtFolio.Text = "" Then
        '            MsgBox("No se capturo un dato, revisa bien", MessageBoxIcon.Error)
        '        Else
        '            frm.TipoMov = lblTipoMov.Text
        '            frm.CodProd = Val(txtCodigo.Text)
        '            frm.Folio = Val(txtFolio.Text)
        '            frm.FechaInicial = Format(DtpFechaInicial.Value, "yyyyMMdd")
        '            frm.FechaFinal = Format(dtpFechaFinal.Value, "yyyyMMdd")
        '            frm.ShowDialog()
        '        End If
        '    End If

        '    If rbLote.Checked Then
        '        If txtLote.Text = "" Then
        '            MsgBox("No se capturo un dato, revisa bien", MessageBoxIcon.Error)
        '        Else
        '            frm.TipoMov = lblTipoMov.Text
        '            frm.CodProd = Val(txtCodigo.Text)
        '            frm.Lote = Val(txtLote.Text)
        '            frm.FechaInicial = Format(DtpFechaInicial.Value, "yyyyMMdd")
        '            frm.FechaFinal = Format(dtpFechaFinal.Value, "yyyyMMdd")
        '            frm.ShowDialog()
        '        End If
        '    End If

        '    If rbCeco.Checked Then
        '        If txtCeco.Text = "" Then
        '            MsgBox("No se capturo un dato, revisa bien", MessageBoxIcon.Error)
        '        Else
        '            frm.TipoMov = lblTipoMov.Text
        '            frm.CodProd = Val(txtCodigo.Text)
        '            frm.Ceco = Val(txtCeco.Text)
        '            frm.FechaInicial = Format(DtpFechaInicial.Value, "yyyyMMdd")
        '            frm.FechaFinal = Format(dtpFechaFinal.Value, "yyyyMMdd")
        '            frm.ShowDialog()
        '        End If
        '    End If

        '    If rbProd.Checked Then
        '        If txtCodigo.Text = "" Then
        '            MsgBox("No se Capturo el Codigo de Producto", MessageBoxIcon.Error)
        '        Else
        '            frm.TipoMov = lblTipoMov.Text
        '            frm.CodProd = Val(txtCodigo.Text)
        '            frm.FechaInicial = Format(DtpFechaInicial.Value, "yyyyMMdd")
        '            frm.FechaFinal = Format(dtpFechaFinal.Value, "yyyyMMdd")
        '            frm.ShowDialog()
        '        End If
        '    End If

        'If rbTodos.Checked Then
        Dim Folio As Integer
        Dim CECO As Integer

        If txtFolio.Text = "" Then
            Folio = 0
        Else
            Folio = txtFolio.Text
        End If
        If txtCeco.Text = "" Then
            CECO = 0
        Else
            CECO = txtCeco.Text
        End If

        frm.TipoMov = cbxMovimiento.SelectedValue
        frm.CodProd = Val(cbxDesCodigo.SelectedValue)
        frm.Folio = Val(Folio)
        frm.Lote = txtLote.Text
        frm.Ceco = Val(CECO)
        frm.FechaInicial = Format(DtpFechaInicial.Value, "yyyyMMdd")
        frm.FechaFinal = Format(dtpFechaFinal.Value, "yyyyMMdd")
        frm.ShowDialog()
        'End If
        'End If
    End Sub

    Private Sub frmInformeEntradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Informe de Movimientos" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
        CargaTipoMovimiento()
        CargaProducto()
        CargaCbxClasificacion()
        txtCeco.Text = ""
        cbxMovimiento.Focus()
    End Sub
    Private Sub CargaTipoMovimiento()
        Dim dr As SqlDataReader
        Dim oclsProveedor As New clsInformeMovimientos
        Dim dt As New DataTable
        dr = oclsProveedor.SeleccionaTipoMovimiento(1)

        dt.Load(dr)

        cbxMovimiento.ValueMember = Trim("idMov")
        cbxMovimiento.DisplayMember = Trim("descripcion")
        cbxMovimiento.DataSource = dt
        cbxMovimiento.SelectedValue = 0
    End Sub
    'Sub CargaTipoMov()
    '    Dim cnnConexion = New SqlConnection()
    '    Dim clsDB = New clsBD()
    '    cnnConexion = clsDB.CreaConexion()
    '    Dim consulta As String = "select Descripcion from acoTipoMovPoliza"
    '    Dim cmd As New SqlCommand(consulta, cnnConexion)
    '    cmd.CommandType = CommandType.Text
    '    Dim da As New SqlDataAdapter(cmd)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    cbxMovimiento.DisplayMember = "Descripcion"
    '    cbxMovimiento.DataSource = dt
    'End Sub
    Private Sub CargaProducto()
        Dim dr As SqlDataReader
        Dim oclsProveedor As New clsInformeMovimientos
        Dim dt As New DataTable
        dr = oclsProveedor.SeleccionaProduto(1)

        dt.Load(dr)

        cbxDesCodigo.ValueMember = Trim("idPro")
        cbxDesCodigo.DisplayMember = Trim("descripcion")
        cbxDesCodigo.DataSource = dt
        cbxDesCodigo.SelectedValue = 0
    End Sub

    'Sub CargaDescProd()
    '    Dim cnnConexion = New SqlConnection()
    '    Dim clsDB = New clsBD()
    '    cnnConexion = clsDB.CreaConexion()
    '    Dim consulta As String = "select Descripcion from acoProductos"
    '    Dim cmd As New SqlCommand(consulta, cnnConexion)
    '    cmd.CommandType = CommandType.Text
    '    Dim da As New SqlDataAdapter(cmd)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    cbxDesCodigo.DisplayMember = "Descripcion"
    '    cbxDesCodigo.DataSource = dt
    'End Sub

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

        cbxClasif.ValueMember = "Cve_Clas"
        cbxClasif.DisplayMember = "Des_Clas"
        cbxClasif.DataSource = dt
        cbxClasif.Text = "Seleccione Clasificacion"
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Private Sub cbxMovimiento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMovimiento.SelectedIndexChanged
        'Dim TipoMov = New clsInformeMovimientos()
        'Dim dr As SqlDataReader
        'dr = TipoMov.SeleccionaTipoMov(Me.cbxMovimiento.Text)
        'If dr.Read() Then
        '    Me.lblTipoMov.Text = RTrim(dr("TipoMovimiento").ToString())
        'Else
        '    MsgBox("Movimiento no Encontrado...", MessageBoxIcon.Error)
        'End If
    End Sub

    'Private Sub rbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTodos.CheckedChanged
    '    If rbTodos.Checked Then
    '        txtCodigo.Clear()
    '        txtFolio.Clear()
    '        txtLote.Clear()
    '        txtCeco.Clear()
    '        txtCodigo.Enabled = False
    '        txtFolio.Enabled = False
    '        txtLote.Enabled = False
    '        txtCeco.Enabled = False
    '        cbxDesCodigo.Enabled = False
    '        cbxArea.Enabled = False
    '        cbxCeco.Enabled = False
    '        cbxClasif.Enabled = False
    '    End If
    'End Sub

    'Private Sub rbFolio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFolio.CheckedChanged
    '    If rbFolio.Checked Then
    '        txtCodigo.Enabled = True
    '        txtFolio.Enabled = True
    '        txtLote.Enabled = False
    '        txtCeco.Enabled = False
    '        cbxDesCodigo.Enabled = True
    '        cbxArea.Enabled = False
    '        cbxCeco.Enabled = False
    '        cbxClasif.Enabled = False
    '        txtFolio.Focus()
    '        txtLote.Clear()
    '        txtCeco.Clear()
    '    End If
    'End Sub

    'Private Sub rbLote_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLote.CheckedChanged
    '    If rbLote.Checked Then
    '        txtCodigo.Enabled = True
    '        txtFolio.Enabled = False
    '        txtLote.Enabled = True
    '        txtCeco.Enabled = False
    '        cbxDesCodigo.Enabled = True
    '        cbxArea.Enabled = False
    '        cbxCeco.Enabled = False
    '        cbxClasif.Enabled = False
    '        txtLote.Focus()
    '        txtFolio.Clear()
    '        txtCeco.Clear()
    '    End If
    'End Sub

    'Private Sub rbCeco_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCeco.CheckedChanged
    '    If rbCeco.Checked Then
    '        txtCodigo.Enabled = True
    '        txtFolio.Enabled = False
    '        txtLote.Enabled = False
    '        txtCeco.Enabled = True
    '        cbxDesCodigo.Enabled = True
    '        cbxArea.Enabled = True
    '        cbxCeco.Enabled = True
    '        cbxClasif.Enabled = True
    '        txtCeco.Focus()
    '        txtFolio.Clear()
    '        txtLote.Clear()
    '    End If
    'End Sub

    'Private Sub rbProd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbProd.CheckedChanged
    '    If rbProd.Checked Then
    '        txtCodigo.Enabled = True
    '        txtFolio.Enabled = False
    '        txtLote.Enabled = False
    '        txtCeco.Enabled = False
    '        cbxDesCodigo.Enabled = True
    '        cbxArea.Enabled = False
    '        cbxCeco.Enabled = False
    '        cbxClasif.Enabled = False
    '        txtCodigo.Focus()
    '        txtFolio.Clear()
    '        txtLote.Clear()
    '        txtCeco.Clear()
    '    End If
    'End Sub

    Private Sub cbxDesCodigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDesCodigo.SelectedIndexChanged
        'Dim DesCod = New clsInformeMovimientos()
        'Dim dr As SqlDataReader
        'dr = DesCod.SeleccionaCodProd(cbxDesCodigo.Text)
        'If dr.Read() Then
        '    txtCodigo.Text = RTrim(dr("CodigoProducto").ToString())
        'Else
        '    MsgBox("Producto no Encontrado...", MessageBoxIcon.Error)
        'End If
    End Sub

    Private Sub txtFolio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolio.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtLote_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLote.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCeco_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCeco.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If

    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        e.Handled = True
    '        If txtCodigo.Text = "" Then
    '            MsgBox("No se Capturo el Codigo de Producto", MsgBoxStyle.Critical)
    '        Else
    '            Dim dr As SqlDataReader
    '            Dim oClsInf As New clsInformeMovimientos

    '            dr = oClsInf.SeleccionaProductos(txtCodigo.Text)

    '            If dr.Read() Then

    '                cbxDesCodigo.Text = Trim(dr("Descripcion").ToString())
    '                cbxDesCodigo.Focus()
    '            Else
    '                MsgBox("Producto no Encontrado...", MsgBoxStyle.Critical)
    '                txtCodigo.SelectAll()
    '                cbxDesCodigo.Text = ""
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Dim frm As New frmRPTInformeDetalleMov

        'If rbFolio.Checked Then
        '    If txtFolio.Text = "" Then
        '        MsgBox("No se capturo un dato, revisa bien", MessageBoxIcon.Error)
        '    Else
        '        frm.TipoMov = lblTipoMov.Text
        '        frm.CodProd = Val(txtCodigo.Text)
        '        frm.Folio = Val(txtFolio.Text)
        '        frm.FechaInicial = Format(DtpFechaInicial.Value, "yyyyMMdd")
        '        frm.FechaFinal = Format(dtpFechaFinal.Value, "yyyyMMdd")
        '        frm.ShowDialog()
        '    End If
        'End If

        'If rbLote.Checked Then
        '    If txtLote.Text = "" Then
        '        MsgBox("No se capturo un dato, revisa bien", MessageBoxIcon.Error)
        '    Else
        '        frm.TipoMov = lblTipoMov.Text
        '        frm.CodProd = Val(txtCodigo.Text)
        '        frm.Lote = Val(txtLote.Text)
        '        frm.FechaInicial = Format(DtpFechaInicial.Value, "yyyyMMdd")
        '        frm.FechaFinal = Format(dtpFechaFinal.Value, "yyyyMMdd")
        '        frm.ShowDialog()
        '    End If
        'End If

        'If rbCeco.Checked Then
        '    If txtCeco.Text = "" Then
        '        MsgBox("No se capturo un dato, revisa bien", MessageBoxIcon.Error)
        '    Else
        '        frm.TipoMov = lblTipoMov.Text
        '        frm.CodProd = Val(txtCodigo.Text)
        '        frm.Ceco = Val(txtCeco.Text)
        '        frm.FechaInicial = Format(DtpFechaInicial.Value, "yyyyMMdd")
        '        frm.FechaFinal = Format(dtpFechaFinal.Value, "yyyyMMdd")
        '        frm.ShowDialog()
        '    End If
        'End If

        'If rbProd.Checked Then
        '    If txtCodigo.Text = "" Then
        '        MsgBox("No se Capturo el Codigo de Producto", MessageBoxIcon.Error)
        '    Else
        '        frm.TipoMov = lblTipoMov.Text
        '        frm.CodProd = Val(txtCodigo.Text)
        '        frm.FechaInicial = Format(DtpFechaInicial.Value, "yyyyMMdd")
        '        frm.FechaFinal = Format(dtpFechaFinal.Value, "yyyyMMdd")
        '        frm.ShowDialog()
        '    End If
        'End If

        'If rbTodos.Checked Then
        '    frm.TipoMov = lblTipoMov.Text
        '    frm.CodProd = Val(txtCodigo.Text)
        '    frm.Folio = Val(txtFolio.Text)
        '    frm.Lote = Val(txtLote.Text)
        '    frm.Ceco = Val(txtCeco.Text)
        '    frm.FechaInicial = Format(DtpFechaInicial.Value, "yyyyMMdd")
        '    frm.FechaFinal = Format(dtpFechaFinal.Value, "yyyyMMdd")
        '    frm.ShowDialog()
        'End If
        Dim Folio As Integer
        Dim CECO As Integer

        If txtFolio.Text = "" Then
            Folio = 0
        Else
            Folio = txtFolio.Text
        End If
        If txtCeco.Text = "" Then
            CECO = 0
        Else
            CECO = txtCeco.Text
        End If

        frm.TipoMov = cbxMovimiento.SelectedValue
        frm.CodProd = Val(cbxDesCodigo.SelectedValue)
        frm.Folio = Val(Folio)
        frm.Lote = txtLote.Text
        frm.Ceco = Val(CECO)
        frm.FechaInicial = DtpFechaInicial.Value.Date
        frm.FechaFinal = dtpFechaFinal.Value.Date
        frm.ShowDialog()
    End Sub

    Private Sub cbxArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxArea.SelectedIndexChanged
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim consulta As String = "Select area_depto,Des_depto From [Compras].[dbo].[Deptos] (nolock) where area_depto like '" & cbxArea.SelectedValue & "%' "
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        cbxCeco.ValueMember = "Area_Depto"
        cbxCeco.DisplayMember = "Des_Depto"
        cbxCeco.DataSource = dt
        cbxCeco.Text = "Seleccione Depto."
        clsDB.CierraConexion(cnnConexion)
        cbxCeco.Focus()
    End Sub

    Private Sub cbxCeco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCeco.SelectedIndexChanged
        Dim Cecos = New clsInformeMovimientos()
        Dim dr As SqlDataReader
        dr = Cecos.SeleccionaCecos(cbxCeco.Text)
        If dr.Read() Then
            txtCeco.Text = RTrim(dr("area_depto").ToString())
        Else
            MsgBox("Cecos no encontrado...", MessageBoxIcon.Error)
        End If
        txtCeco.Focus()
    End Sub

    Private Sub cbxClasif_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxClasif.SelectedIndexChanged
        If Me.cbxClasif.Text = "Seleccione Clasificacion" Then
            Me.cbxClasif.ValueMember = ""
            Me.cbxArea.Text = "Seleccione Area"
        Else
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()

            Dim consulta As String = "Select Cve_Clas,Area,Des_Area From [Compras].[dbo].[Area] (nolock) Where Cve_Clas= '" & cbxClasif.SelectedValue & "' "
            Dim cmd As New SqlCommand(consulta, cnnConexion)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            Me.cbxArea.ValueMember = "Area"
            Me.cbxArea.DisplayMember = "Des_Area"
            Me.cbxArea.DataSource = dt
            Me.cbxArea.Text = "Seleccione Area"
            clsDB.CierraConexion(cnnConexion)
        End If
        'cbxArea.Focus()
    End Sub

    Private Sub txtCeco_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCeco.LostFocus
        If txtCeco.Text = "" Then
            cbxClasif.Text = "Seleccione Clasificacion"
            cbxCeco.Text = "Seleccione Depto."
            cbxArea.Text = "Seleccione Area."
        End If
    End Sub
End Class