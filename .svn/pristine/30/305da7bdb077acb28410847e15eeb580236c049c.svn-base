Imports System.Data.SqlClient
Imports System.Data
Imports WindowsApplication1.clsUsuarios
Imports WindowsApplication1.mdVariables
Imports WindowsApplication1.clsTools
Imports System.Deployment.Application

Public Class frmPrincipal
    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Space(160) + "Desarrollo de Engordas Estabuladas S.A. de C.V." + Space(10) + VersionCont()
        Me.Hide()
        login.Show()
        Me.WindowState = 2
    End Sub
    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        'Dim frm As New frmProductos()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmProductos.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmProductos.Show()
        Else
            My.Forms.frmProductos.Focus()
        End If
    End Sub

    Private Sub ResetDeContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetDeContraseñaToolStripMenuItem.Click
        'Dim frm As New frmResetContraseña()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmResetContraseña.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmResetContraseña.Show()
        Else
            My.Forms.frmResetContraseña.Focus()
        End If
    End Sub
    Private Sub PerfilDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerfilDeUsuarioToolStripMenuItem.Click
        'Dim frm As New frmPerfilesUsuario()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmPerfilesUsuario.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmPerfilesUsuario.Show()
        Else
            My.Forms.frmPerfilesUsuario.Focus()
        End If
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        If MsgBox("Desea Cerrar Sesion ? ", MessageBoxButtons.YesNo, "               SysCont [V 1.0]") = MsgBoxResult.Yes Then
            Me.Hide()
            login.Show()
        End If
    End Sub

    Private Sub SalirDeSysAlamcenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirDeSysAlamcenToolStripMenuItem.Click
        If MsgBox("Desea Salir de SysCont ? ", MessageBoxButtons.YesNo, "               SysCont [V 1.0]") = MsgBoxResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub
    Private Sub ENTRADASINVENTARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ENTRADASINVENTARIOToolStripMenuItem.Click
        'Dim frm As New frmEntradas()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmEntradas.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmEntradas.Show()
        Else
            My.Forms.frmEntradas.Focus()
        End If
    End Sub
    Private Sub FamiliasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FamiliasToolStripMenuItem.Click
        'Dim frm As New frmFamilia()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmFamilia.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmFamilia.Show()
        Else
            My.Forms.frmFamilia.Focus()
        End If
    End Sub
    Private Sub SubfamiliasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubfamiliasToolStripMenuItem.Click
        'Dim frm As New frmSubFamilias()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmSubFamilias.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmSubFamilias.Show()
        Else
            My.Forms.frmSubFamilias.Focus()
        End If
    End Sub
    Private Sub UnidadesDeMedidaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnidadesDeMedidaToolStripMenuItem.Click
        'Dim frm As New frmUnidadesMedida()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmUnidadesMedida.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmUnidadesMedida.Show()
        Else
            My.Forms.frmUnidadesMedida.Focus()
        End If
    End Sub
    Private Sub SubFamiNiv1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmSubFamiNiv1()
        'frm.Show()
    End Sub
    Private Sub SubFamiNiv2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmSubFamiNiv2()
        'frm.Show()
    End Sub

    Private Sub InformeEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeEntradasToolStripMenuItem.Click
        'Dim frm As New frmInformeEntradas()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmInformeEntradas.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmInformeEntradas.Show()
        Else
            My.Forms.frmInformeEntradas.Focus()
        End If
    End Sub

    Private Sub InformeDeProductoEnPuntoDeReordenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeDeProductoEnPuntoDeReordenToolStripMenuItem.Click
        'Dim frm As New Informe_de_Producto_en_Punto_de_Reorden()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = Informe_de_Producto_en_Punto_de_Reorden.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.Informe_de_Producto_en_Punto_de_Reorden.Show()
        Else
            My.Forms.Informe_de_Producto_en_Punto_de_Reorden.Focus()
        End If
    End Sub

    Private Sub ListadoDeProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeProveedoresToolStripMenuItem.Click
        'Dim frm As New frmListadoProveedores()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmListadoProveedores.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmListadoProveedores.Show()
        Else
            My.Forms.frmListadoProveedores.Focus()
        End If
    End Sub

    Private Sub MttoProrrateoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MttoProrrateoToolStripMenuItem1.Click
        Dim frm As New frmMttoProrrateo()
        frm.Show()
        
    End Sub
    Private Sub ExistenciasProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistenciasProductosToolStripMenuItem.Click
        'Dim frm As New frmSaldoProducto()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmSaldoProducto.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmSaldoProducto.Show()
        Else
            My.Forms.frmSaldoProducto.Focus()
        End If
    End Sub

    Private Sub InventarioTeoricoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioTeoricoToolStripMenuItem.Click
        'Dim frm As New frmInventarioTeorico()
        'frm.Show()
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmInventarioTeorico.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmInventarioTeorico.Show()
        Else
            My.Forms.frmInventarioTeorico.Focus()
        End If
    End Sub

    Private Sub IndiceAyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndiceAyudaToolStripMenuItem.Click
        Process.Start("file:///U:/Octavio/Manual%20SysAlmacen/ManualSysAlmacen.html")
        'System.Diagnostics.Process.Start("C:\Program Files\Internet Explorer\IExplore.exe", "")

    End Sub

    Private Sub InformeDeSalidasYDevolucionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeDeSalidasYDevolucionesToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmMovSalidasDevo.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmMovSalidasDevo.Show()
        Else
            My.Forms.frmMovSalidasDevo.Focus()
        End If
    End Sub

    Private Sub AcercaDelSysAlamacenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDelSysAlamacenToolStripMenuItem.Click

    End Sub

    Private Sub ProductosPaseAProcesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosPaseAProcesoToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmProductosPaseProceso.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmProductosPaseProceso.Show()
        Else
            My.Forms.frmProductosPaseProceso.Focus()
        End If
    End Sub
End Class