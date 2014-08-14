Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.frmFamilia
Imports WindowsApplication1.mdVariables
Public Class frmListSubfamilias
    Friend DatosLista As String
    Private Sub frmListSubfamilias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenalista()
    End Sub
    Private Sub llenarlista2()
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsFamilias = New clsFamilias()
        dr = oclsFamilias.SeleccionaFamilias(txtFamilia.Text)
        DatosLista = ""
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstMuestraFamilia.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CodFamilia").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstMuestraFamilia.Items.Add(lstLista)
            Next
        End If
    End Sub
    Private Sub lstMuestraFamilia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstMuestraFamilia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If lstMuestraFamilia.Items(0).Selected = False Then
                MsgBox("No se ha Seleccionado Ningun Elemento", MsgBoxStyle.Exclamation)
                Return
            End If
            DatosLista = lstMuestraFamilia.SelectedItems(0).Text
            Me.Close()
        End If
    End Sub
    Private Sub lstMuestraFamilia_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstMuestraFamilia.MouseDoubleClick
        'VPCatSubFamilias = lstMuestraFamilia.SelectedItems(0).Text
        DatosLista = lstMuestraFamilia.SelectedItems(0).Text
        Me.Close()
    End Sub
    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFamilia.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtDescripcion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyUp
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsFamilia = New clsFamilias()
        dr = oclsFamilia.BuscarFamilias(Me.txtDescripcion.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        'If dt.Rows.Count > 0 Then
        lstMuestraFamilia.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CodFamilia").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstMuestraFamilia.Items.Add(lstLista)
        Next
    End Sub
    Private Sub txtFamilia_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFamilia.KeyUp
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsFamilias = New clsFamilias()
        dr = oclsFamilias.SeleccionaFamilias(Me.txtFamilia.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        'If dt.Rows.Count > 0 Then
        lstMuestraFamilia.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CodFamilia").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstMuestraFamilia.Items.Add(lstLista)
        Next
    End Sub
    Private Sub llenalista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim consulta As String = "Select CodFamilia,Descripcion From CatFamilias(nolock) Order By CodFamilia"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "CatFamilias")


        Dim objListItem As New ListViewItem
        Me.lstMuestraFamilia.Items.Clear()

        For Each drw As DataRow In ds.Tables("CatFamilias").Rows
            objListItem = lstMuestraFamilia.Items.Add(drw.Item("CodFamilia").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
        Next
    End Sub
End Class