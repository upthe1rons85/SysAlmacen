Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Public Class FrmAyudaCodigo
    Friend DatosLista As String
    Private Sub llenalista2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "select A.CodigoProducto,A.Descripcion,B.UnidadMedida,(B.Descripcion) as UnidadMedida1 from almacen.dbo.AcoProductos A inner join almacen.dbo.AcoUnidadesMedida B on A.UnidadMedida=B.UnidadMedida where CodigoProducto=A.CodigoProducto "
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "AcoProductos,AcoUnidadesMedida")
        Dim objListItem As New ListViewItem
        Me.ListCodigo.Items.Clear()
        For Each drw As DataRow In ds.Tables("AcoProductos,AcoUnidadesMedida").Rows
            objListItem = ListCodigo.Items.Add(drw.Item("CodigoProducto").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            objListItem.SubItems.Add(drw.Item("UnidadMedida1").ToString)
        Next
        'clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub txtDescipcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescipcion.GotFocus
        txtDescipcion.Text = ""
        txtDescipcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtDescipcion.ForeColor = Color.Gray
    End Sub
    Private Sub txtDescipcion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescipcion.KeyUp
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsCodigo = New clsInventarioTeorico()
        dr = oclsCodigo.BuscaCodigo(Me.txtDescipcion.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            ListCodigo.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CodigoProducto").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstLista.SubItems.Add(rRow("UnidadMedida1").ToString)
                ListCodigo.Items.Add(lstLista)
            Next
        End If
    End Sub
    Private Sub FrmAyudaCodigo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenalista2()
    End Sub
End Class