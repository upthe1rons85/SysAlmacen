Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsSubFamilias
    Sub EliminaSubFamilia(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spEliSubFamilias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodSubFami", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub InsertaSubFamilias(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spInsSubFamilias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function BuscarSubFamilias(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "sp_BusSubFamilias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = pcodigo
        dr = cmd.ExecuteReader()
        BuscarSubFamilias = dr
    End Function
    Sub ActualizaSubFamilias(ByVal psubFamilia As Integer, ByVal pFamilia As Integer, ByVal pDescripcion As String, ByVal pInventario As String, ByVal pGasto As String, ByVal pCompra As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spActSubFamilias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodSubFami", SqlDbType.Int).Value = psubFamilia
        cmd.Parameters.Add("@CodFamilia", SqlDbType.Int).Value = pFamilia
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = pDescripcion
        cmd.Parameters.Add("@CuentaInventario", SqlDbType.NVarChar, 14).Value = pInventario
        cmd.Parameters.Add("@CuentaGasto", SqlDbType.NVarChar, 14).Value = pGasto
        cmd.Parameters.Add("@CuentaCompra", SqlDbType.NVarChar, 24).Value = pCompra
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function SeleccionaSubFamilias(ByVal pfamilia As String, ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spSelSubFamilias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodFamilia", SqlDbType.VarChar).Value = pFamilia
        cmd.Parameters.Add("@CodSubFami", SqlDbType.VarChar).Value = pcodigo
        dr = cmd.ExecuteReader()
        SeleccionaSubFamilias = dr
    End Function
    Function SeleccionaSubFamiNiv1(ByVal pcodigo As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "sp_SelSubFamiNiv1"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodSubFamiNiv1", SqlDbType.Int).Value = pcodigo
        dr = cmd.ExecuteReader()
        SeleccionaSubFamiNiv1 = dr
    End Function
    Sub ActualizaSubFamiNiv1(ByVal pCodigo As String, ByVal pSubFamilia As String, ByVal pDescripcion As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spActSubFamiNiv1"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodSubFamiNiv1", SqlDbType.Int).Value = pCodigo
        cmd.Parameters.Add("@CodSubFamilia", SqlDbType.Int).Value = pSubFamilia
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = pDescripcion
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub InsertaSubFamiNiv1(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spInsSubFamiNiv1"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub EliminaSubFamiNiv1(ByVal pDatos As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spEliSubFamiNiv1"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodSubFamiNiv1", SqlDbType.Int).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function SeleccionaSubFamiNiv2(ByVal pcodigo As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "sp_SelSubFamiNiv2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodSubFamiNiv2", SqlDbType.Int).Value = pcodigo
        dr = cmd.ExecuteReader()
        SeleccionaSubFamiNiv2 = dr
    End Function
    Sub ActualizaSubFamiNiv2(ByVal pCodigo As Integer, ByVal pSubFamilia As Integer, ByVal pDescripcion As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spActSubFamiNiv2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodSubFamiNiv2", SqlDbType.Int).Value = pCodigo
        cmd.Parameters.Add("@CodSubFamiNiv1", SqlDbType.Int).Value = pSubFamilia
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = pDescripcion
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub InsertaSubFamiNiv2(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spInsSubFamiNiv2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub EliminaSubFamiNiv2(ByVal pDatos As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spEliSubFamiNiv2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodSubFamiNiv2", SqlDbType.Int).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

End Class
