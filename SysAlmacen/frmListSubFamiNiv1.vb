Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.frmSubFamilias
Public Class frmListSubFamiNiv1
    Friend DatosListaSubFamiNiv1 As String
    Private Sub frmListSubFamiNiv1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clsBD As New clsBD()
        'Dim dr As SqlDataReader
        Dim tclsFamilias = New clsSubFamilias()
        'dr = tclsFamilias.SeleccionaSubFamilias(Me.TxtSubFamilia.Text)
        DatosListaSubFamiNiv1 = ""
        Dim dt = New DataTable()
        'dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstMuestraSubFamilia.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CodSubFami").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstMuestraSubFamilia.Items.Add(lstLista)
            Next
        End If
    End Sub
    Private Sub txtDescripcion_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsFamilia = New clsSubFamilias()
        dr = oclsFamilia.BuscarsubFamilias(Me.TxtDescripcion.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        'If dt.Rows.Count > 0 Then
        lstMuestraSubFamilia.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CodSubFamilia").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstMuestraSubFamilia.Items.Add(lstLista)
        Next
    End Sub
    Private Sub TxtSubFamilia_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSubFamilia.KeyUp
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsFamilias = New clsFamilias()
        dr = oclsFamilias.SeleccionaFamilias(Me.TxtSubFamilia.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        'If dt.Rows.Count > 0 Then
        lstMuestraSubFamilia.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CodSubFami").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstMuestraSubFamilia.Items.Add(lstLista)
        Next
    End Sub
    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub lstMuestraSubFamilia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstMuestraSubFamilia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If lstMuestraSubFamilia.Items(0).Selected = False Then
                MsgBox("No se ha Seleccionado Ningun Elemento", MsgBoxStyle.Exclamation)
                Return
            End If
            DatosListaSubFamiNiv1 = lstMuestraSubFamilia.SelectedItems(0).Text
            Me.Close()
        End If
    End Sub
    Private Sub lstMuestraSubFamilia_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstMuestraSubFamilia.MouseClick
        DatosListaSubFamiNiv1 = lstMuestraSubFamilia.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class