Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsUnidadesMedida
    Sub EliminaUnidadesMedida(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spEliUnidadesMedida"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@UnidadMedida", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub InsertaUnidadesMedida(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spInsUnidadesMedida"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function BuscarUnidadesMedida(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "sp_BusUnidadesMedida"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = pcodigo
        dr = cmd.ExecuteReader()
        BuscarUnidadesMedida = dr
    End Function
    Sub AvanzaFolioUnidades(ByVal pCodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spAvanzaFolioUnidades"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@FolioUnidadMedida", SqlDbType.NChar).Value = pCodigo
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub ActualizaUnidadesMedida(ByVal pUnidadMedida As String, ByVal pDescripcion As String, ByVal pAbreviacion As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spActUnidadesMedida"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@UnidadMedida", SqlDbType.Int).Value = pUnidadMedida
        cmd.Parameters.Add("@Descripcion", SqlDbType.NChar, 30).Value = pDescripcion
        cmd.Parameters.Add("@Abreviacion", SqlDbType.NChar, 6).Value = pAbreviacion
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function SeleccionaUnidadesMedida(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "sp_SelUnidadesMedida"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@UnidadMedida", SqlDbType.VarChar).Value = pcodigo
        dr = cmd.ExecuteReader()
        SeleccionaUnidadesMedida = dr
    End Function
End Class
