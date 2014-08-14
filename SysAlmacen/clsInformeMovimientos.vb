Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient

Public Class clsInformeMovimientos
    Function SeleccionaTipoMov(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusTipoMovimiento"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = pcodigo

        dr = cmd.ExecuteReader()
        SeleccionaTipoMov = dr
    End Function
    Function SeleccionaTipoMovimiento(ByVal nOpcion As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spCBXTipoMovimiento"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion

        dr = cmd.ExecuteReader()
        SeleccionaTipoMovimiento = dr
    End Function

    Function SeleccionaProduto(ByVal nOpcion As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spCBXProducto"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion

        dr = cmd.ExecuteReader()
        SeleccionaProduto = dr
    End Function
    Function SeleccionaCodProd(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusDescProducto"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = pcodigo

        dr = cmd.ExecuteReader()
        SeleccionaCodProd = dr
    End Function

    Function SeleccionaCecos(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusCecos"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@des_depto", SqlDbType.VarChar).Value = pcodigo

        dr = cmd.ExecuteReader()
        SeleccionaCecos = dr
    End Function

    Function SeleccionaProductos(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelDescProducto"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodigoProducto", SqlDbType.Int).Value = pcodigo

        dr = cmd.ExecuteReader()
        SeleccionaProductos = dr
    End Function
End Class
