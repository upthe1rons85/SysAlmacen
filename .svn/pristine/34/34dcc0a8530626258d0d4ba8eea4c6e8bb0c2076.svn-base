Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsInventarioTeorico
    Function SeleccionaInventario(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spSelInventarioHistorico"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@FolioInventario", SqlDbType.Int).Value = pcodigo
        dr = cmd.ExecuteReader()
        SeleccionaInventario = dr
    End Function
    Function CargaInventario(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spCargaInvTeorico"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        'cmd.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = pcodigo
        cmd.Parameters.Add("@CodigoProducto", SqlDbType.NChar).Value = pcodigo
        dr = cmd.ExecuteReader()
        CargaInventario = dr
    End Function
    Sub ActualizaInventario(ByVal pCodigo As String, ByVal pCantidad As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spActInventarioHistorico"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        'cmd.Parameters.Add("@FolioInventario", SqlDbType.NChar, 10).Value = pFolio
        cmd.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = pCodigo
        cmd.Parameters.Add("@CantidadFisico", SqlDbType.NChar, 30).Value = pCantidad
        'cmd.Parameters.Add("@Diferencia", SqlDbType.NChar, 30).Value = pDiferencia
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub InsertaInventario(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spInsCruzarInventario"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub EliminaInventario(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spEliInventarioHistorico"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodigoProducto", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub AvanzaFolioInventario(ByVal pCodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spAvanzaFolioInventario"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@FolioInventario", SqlDbType.NChar).Value = pCodigo
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function SeleccionaInventarioInforme(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spBusInventario"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodigoProducto", SqlDbType.VarChar).Value = pcodigo
        dr = cmd.ExecuteReader()
        SeleccionaInventarioInforme = dr
    End Function
    Function BuscaCodigo(ByVal pCodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "sp_BusCodigo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = pCodigo
        dr = cmd.ExecuteReader()
        BuscaCodigo = dr
    End Function
    'Sub InsertaInventario(ByVal pCodigoProducto As Integer, ByVal pCantidad As Decimal)
    '    Dim cnnConexion = New SqlConnection()
    '    Dim clsDB = New clsBD()
    '    cnnConexion = clsDB.CreaConexion()
    '    Dim cmd As New SqlCommand
    '    'Dim dr As SqlDataReader
    '    cmd.CommandText = "spInsInvFisico"
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.Connection = cnnConexion
    '    cmd.Parameters.Add("@pCodPro", SqlDbType.VarChar).Value = pCodigoProducto
    '    cmd.Parameters.Add("@pCantidad", SqlDbType.VarChar).Value = pCantidad
    '    cmd.ExecuteNonQuery()
    '    cmd.Dispose()
    '    clsDB.CierraConexion(cnnConexion)
    'End Sub
End Class
