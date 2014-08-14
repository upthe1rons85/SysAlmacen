Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsUsuarios
    Function SeleccionaUsuarios(ByVal pusuario As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "sp_busUsuario"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = pusuario
        dr = cmd.ExecuteReader()
        SeleccionaUsuarios = dr
    End Function
    Sub InsertaUsuarios(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spInsUsuario"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Shared Sub CerrarConexion()
        Throw New NotImplementedException
    End Sub
    Sub EliminaUsuarios(ByVal pUsuario As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spEliUsuario"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = pUsuario
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub CambiaContraseñaUsuario(ByVal pDatos As String, ByVal pContraseña As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spCambiaContraseña"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = pDatos
        cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = pContraseña
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function BuscaPerfil(ByVal pperfil As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "dbo.spBusPerfil"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = pperfil

        dr = cmd.ExecuteReader()
        BuscaPerfil = dr

    End Function
End Class
