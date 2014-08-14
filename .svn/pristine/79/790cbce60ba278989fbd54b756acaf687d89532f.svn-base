Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient

Public Class clsInformeFamilias
    Function Descripcion(ByVal desc As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusFamilias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = desc

        dr = cmd.ExecuteReader()
        Descripcion = dr
    End Function
End Class
