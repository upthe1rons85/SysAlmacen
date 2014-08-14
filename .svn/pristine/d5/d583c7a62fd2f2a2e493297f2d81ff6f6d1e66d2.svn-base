Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.frmEntradas
Public Class clsEntradas
    Function SeleccionaProductos(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusProducto"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodigoProducto", SqlDbType.VarChar).Value = pcodigo

        dr = cmd.ExecuteReader()
        SeleccionaProductos = dr
    End Function
    Function SeleccionaProveedor(ByVal CodProveedor As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusProveedor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = CodProveedor

        dr = cmd.ExecuteReader()
        SeleccionaProveedor = dr
    End Function
    Sub AdelantaFolioEntrada(ByVal pFolio As String, ByVal ptipomov As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "sp_AdeFolioEntrada"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@Folio", SqlDbType.Float).Value = pFolio
        cmd.Parameters.Add("@TipoMov", SqlDbType.Int).Value = ptipomov

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        cnnConexion.Close()
    End Sub
    Function SeleccionaFolio(ByVal pFolio As String, ByVal pTipoMovimiento As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "sp_BusFolioMovimiento"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@nFolio", SqlDbType.VarChar).Value = pFolio
        cmd.Parameters.Add("@nTipoMovimiento", SqlDbType.VarChar).Value = pTipoMovimiento

        dr = cmd.ExecuteReader()
        SeleccionaFolio = dr
    End Function
    Function ValidaFacturaProv(ByVal TipoMovimiento As Integer, ByVal Proveedor As String, ByVal FacturaProv As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spValidaFacturaProv"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@nTipoMovimiento", SqlDbType.Int).Value = TipoMovimiento
        cmd.Parameters.Add("@nProveedor", SqlDbType.VarChar).Value = Proveedor
        cmd.Parameters.Add("@facturaprov", SqlDbType.VarChar).Value = FacturaProv

        dr = cmd.ExecuteReader()
        ValidaFacturaProv = dr
        'cnnConexion.Close()
    End Function
    Sub RegresaDatos(ByVal pfolio As String, ByVal ptipomov As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "sp_AdeFolioEntrada"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@Folio", SqlDbType.Float).Value = pfolio
        cmd.Parameters.Add("@TipoMov", SqlDbType.Int).Value = ptipomov

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        cnnConexion.Close()
    End Sub
    Sub CancelaEntrada(ByVal xFolio As String, ByVal xtipomov As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "sp_CancelaEntrada"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@Folio", SqlDbType.Float).Value = xFolio
        cmd.Parameters.Add("@TipoMov", SqlDbType.Int).Value = xtipomov

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        cnnConexion.Close()
    End Sub
    Function ValidaSaldoproducto(ByVal pfolio As String, ByVal pTipoMovimiento As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spValidaSaldoProducto"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@TipoMovimiento", SqlDbType.VarChar).Value = pTipoMovimiento
        cmd.Parameters.Add("@Folio", SqlDbType.VarChar).Value = pfolio

        dr = cmd.ExecuteReader()
        ValidaSaldoproducto = dr
    End Function
    Function AsignaPrecioProducto(ByVal nProducto As String, ByVal nPiezas As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spMuestraCostoPromedio"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodigoProducto", SqlDbType.VarChar).Value = nProducto
        cmd.Parameters.Add("@Piezas", SqlDbType.NVarChar).Value = nPiezas

        dr = cmd.ExecuteReader()
        AsignaPrecioProducto = dr
    End Function
    Function ValidaSaldoproductoSalidas(ByVal cTabla As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spValidaSaldoProductoSalidas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@ntabla", SqlDbType.VarChar).Value = cTabla

        dr = cmd.ExecuteReader()
        ValidaSaldoproductoSalidas = dr
    End Function
End Class
