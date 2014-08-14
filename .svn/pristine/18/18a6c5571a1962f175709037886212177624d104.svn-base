Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Public Class frmPerfilesUsuario

    Private Sub txtPerfil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPerfil.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtPerfil_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPerfil.KeyUp
        'Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsUsuarios = New clsUsuarios()
        dr = oclsUsuarios.BuscaPerfil(Me.txtPerfil.Text)
        Dim dt = New DataTable()
        txtPerfil.Focus()
        dt.Load(dr)
        lstPerfil.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("Perfil").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstLista.SubItems.Add(rRow("Usuario").ToString)
            lstPerfil.Items.Add(lstLista)
        Next
    End Sub
    Private Sub llenalista2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "select US.usuario,US.perfil,PER.Descripcion from contabilidad.dbo.usuarioperfil US inner join Contabilidad.dbo.perfiles PER on Per.perfil=US.Perfil where usuario=US.usuario union select US.usuario,US.perfil,PER.Descripcion from almacen.dbo.usuarioperfil US inner join almacen.dbo.perfiles PER on Per.perfil=US.Perfil where usuario=US.usuario union select US.usuario,US.perfil,PER.Descripcion from Compras.dbo.usuarioperfil US inner join Compras.dbo.perfiles PER on Per.perfil=US.Perfil where usuario=US.usuario union select US.usuario,US.perfil,PER.Descripcion from Comercial.dbo.usuarioperfil US inner join Comercial.dbo.perfiles PER on Per.perfil=US.Perfil where usuario=US.usuario order by Perfil asc "

        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "usuarioperfil,Perfiles")
        Dim objListItem As New ListViewItem
        Me.lstPerfil.Items.Clear()
        For Each drw As DataRow In ds.Tables("usuarioperfil,Perfiles").Rows
            objListItem = lstPerfil.Items.Add(drw.Item("Perfil").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            objListItem.SubItems.Add(drw.Item("Usuario").ToString)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub frmPerfilesUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenalista2()
    End Sub
    Private Sub txtPerfil_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPerfil.GotFocus
        txtPerfil.Text = ""
        txtPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtPerfil.ForeColor = Color.Gray
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        llenalista2()
        txtPerfil.Text = "Buscar Perfil"
        txtPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75F, FontStyle.Italic)
    End Sub
End Class