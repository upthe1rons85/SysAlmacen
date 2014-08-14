Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsFamilias
    Sub EliminaFamilia(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spEliFamilias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodFamilia", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub InsertaFamilias(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spInsFamilias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function BuscarFamilias(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spBusFamilias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = pcodigo
        dr = cmd.ExecuteReader()
        BuscarFamilias = dr
        clsDB.CierraConexion(cnnConexion)
    End Function
    Sub AvanzaFolioFamilias(ByVal pCodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spAvanzaFolioFamilias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@FolioCodFamilia", SqlDbType.NChar).Value = pCodigo
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub ActualizaFamilias(ByVal pUnidadMedida As String, ByVal pDescripcion As String, ByVal pCtaInventario As String, ByVal pCtaGasto As String, ByVal pCtaCompra As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spActFamilias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodFamilia", SqlDbType.Int).Value = pUnidadMedida
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = pDescripcion
        cmd.Parameters.Add("@PrefijoCtaInventario", SqlDbType.VarChar, 50).Value = pCtaInventario
        cmd.Parameters.Add("@PrefijoCtaGasto", SqlDbType.VarChar, 50).Value = pCtaGasto
        cmd.Parameters.Add("@PrefijoCtaCompra", SqlDbType.VarChar, 50).Value = pCtaCompra
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function SeleccionaFamilias(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spSelFamilias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodFamilia", SqlDbType.VarChar).Value = pcodigo
        dr = cmd.ExecuteReader()
        SeleccionaFamilias = dr
    End Function
    Function ValidaEliFamilias(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spValidaFamilias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodFamilia", SqlDbType.VarChar).Value = pcodigo
        dr = cmd.ExecuteReader()
        ValidaEliFamilias = dr

    End Function
End Class
