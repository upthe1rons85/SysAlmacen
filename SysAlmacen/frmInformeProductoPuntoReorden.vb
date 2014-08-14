Imports System.Data.SqlClient

Public Class Informe_de_Producto_en_Punto_de_Reorden
    Private Sub Informe_de_Producto_en_Punto_de_Reorden_Load (ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
        Me.Text = "Informe de Producto en Punto de Reorden" + Space (10) + CStr (clsTools.VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        dtpFF.Value = Today
        cargadatos()
    End Sub

    Private Sub btnImprimir_Click (ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTInformeProductoPuntoReorden()
        Dim cont = 7
        Dim FechaInicial As Date

        '-- Obtener fecha inicial ----

        Dim fi As Date = Date.Today
        For i As Integer = 1 To CInt(cont)
            Do
                fi = fi.AddDays(-1)
            Loop While (fi.DayOfWeek = DayOfWeek.Saturday) Or (fi.DayOfWeek = DayOfWeek.Sunday)
        Next
        FechaInicial = fi

        Dim fechaIni As String
        Dim FechaFin As String
        fechaIni = Format(FechaInicial, "yyyyMMdd")
        FechaFin = Format(Date.Today, "yyyyMMdd")


        frm.CodProd = txtCodigo.Text
        frm.FechaInicial = fechaIni
        frm.FechaFinal = FechaFin

        frm.Show()
    End Sub

    Private Sub cargadatos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "select * from acoProductos"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "acoProductos")
        Dim objListItem As New ListViewItem
        Me.lstProducto.Items.Clear()
        For Each drw As DataRow In ds.Tables("acoProductos").Rows
            objListItem = lstProducto.Items.Add(drw.Item("CodigoProducto").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
        Next
    End Sub

    Private Sub txtCodigo_KeyPress (ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = ChrW (Keys.Enter) Then
            btnImprimir.PerformClick()
        End If
    End Sub

    Private Sub lstProducto_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstProducto.MouseDoubleClick
        txtCodigo.Text = lstProducto.SelectedItems(0).SubItems(0).Text
        TxtBuscar.Text = "Buscar Producto"
    End Sub

    Private Sub TxtBuscar_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuscar.KeyUp
        Dim clsBD As New clsBD
        Dim dr As SqlDataReader
        Dim oclsProd = New clsProductos
        dr = oclsProd.BuscaDescProducto(Me.TxtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        lstProducto.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CodigoProducto").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstProducto.Items.Add(lstLista)
        Next
    End Sub

    Private Sub TxtBuscar_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtBuscar.MouseClick
        TxtBuscar.Clear()
    End Sub
End Class