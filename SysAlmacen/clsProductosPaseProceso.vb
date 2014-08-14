Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsProductosPaseProceso
    Function SeleccionaProcesoOrigen(ByVal pCodigoProducto As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spSelProdOrigen"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = pCodigoProducto
        'cmd.Parameters.Add("@CodigoDestino", SqlDbType.Int).Value = pCodigoDestino
        dr = cmd.ExecuteReader()
        SeleccionaProcesoOrigen = dr
    End Function
    Function SeleccionaProcesoDestino(ByVal pCodigoProducto As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spSelProdDestino"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodDestino", SqlDbType.Int).Value = pCodigoProducto

        'cmd.Parameters.Add("@DescripcionOrigen", SqlDbType.VarChar).Value = pDescripcion
        dr = cmd.ExecuteReader()
        SeleccionaProcesoDestino = dr
    End Function
    Sub InsertaProcesos(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spInsProductosPaseProceso"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub ActualizaProcesos(ByVal pCodigo As Integer, ByVal pDescripcion As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spActProductoDestino"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodDestino", SqlDbType.Int).Value = pCodigo
        cmd.Parameters.Add("@DescripcionDestino", SqlDbType.VarChar, 50).Value = pDescripcion
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
End Class
