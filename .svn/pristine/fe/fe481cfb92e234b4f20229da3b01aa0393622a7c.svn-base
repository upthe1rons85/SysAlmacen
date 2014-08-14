
Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsProductos
    Sub EliminaProducto(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spEliProducto"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@CodigoProducto", SqlDbType.VarChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub InsertaProducto(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsProducto"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)

    End Sub
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
    Function Regresafamilia(ByVal pcodigo As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr1 As SqlDataReader

        cmd.CommandText = "spRegresaFamilia"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodFamilia", SqlDbType.VarChar).Value = pcodigo

        dr1 = cmd.ExecuteReader()
        Regresafamilia = dr1
    End Function
    Function RegresaSubfamilia(ByVal pcodigo As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr2 As SqlDataReader

        cmd.CommandText = "spRegresaSubFamilia"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodSubFamilia", SqlDbType.VarChar).Value = pcodigo

        dr2 = cmd.ExecuteReader()
        RegresaSubfamilia = dr2
    End Function
    Function RegresaSubfamiNiv1(ByVal pcodigo As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr2a As SqlDataReader

        cmd.CommandText = "spRegresaSubFamiNiv1"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodSubFamiNiv1", SqlDbType.VarChar).Value = pcodigo

        dr2a = cmd.ExecuteReader()
        RegresaSubfamiNiv1 = dr2a
    End Function
    Function RegresaSubfamiNiv2(ByVal pcodigo As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr2b As SqlDataReader

        cmd.CommandText = "spRegresaSubFamiNiv2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodSubFamiNiv2", SqlDbType.VarChar).Value = pcodigo

        dr2b = cmd.ExecuteReader()
        RegresaSubfamiNiv2 = dr2b
    End Function
    Function RegresaEstatusProd(ByVal pEstatus As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr3 As SqlDataReader

        cmd.CommandText = "spRegresaEstatusProd"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pEstatus", SqlDbType.NVarChar).Value = pEstatus

        dr3 = cmd.ExecuteReader()
        RegresaEstatusProd = dr3
    End Function
    Function RegresaCuentaConta(ByVal nCuentaConta As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr4 As SqlDataReader

        cmd.CommandText = "spRegresaCuentaConta"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCuentaConta", SqlDbType.NVarChar).Value = nCuentaConta

        dr4 = cmd.ExecuteReader()
        RegresaCuentaConta = dr4
    End Function
    Function RegresaUnidadMedida(ByVal nUniMedida As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr5 As SqlDataReader

        cmd.CommandText = "spRegresaUnidadMedida"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pUnidadMedida", SqlDbType.NVarChar).Value = nUniMedida

        dr5 = cmd.ExecuteReader()
        RegresaUnidadMedida = dr5
    End Function
    Sub ActualizaProducto(ByVal pCodigoProducto As String, ByVal pDescripcion As String, ByVal pnUniMedida As Integer, ByVal pnFamilia As Integer, ByVal pnSubFamilia As Integer,
                          ByVal pCodigoBarras As String, ByVal pnestatus As String, ByVal pusuario As String, ByVal pPtoReorden As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spActProducto"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@CodigoProducto  ", SqlDbType.Int).Value = pCodigoProducto
        cmd.Parameters.Add("@Descripcion  ", SqlDbType.NVarChar, 60).Value = pDescripcion
        cmd.Parameters.Add("@UnidadMedida  ", SqlDbType.Int).Value = pnUniMedida
        cmd.Parameters.Add("@Familia ", SqlDbType.Int).Value = pnFamilia
        cmd.Parameters.Add("@SubFamilia ", SqlDbType.Int).Value = pnSubFamilia
        'cmd.Parameters.Add("@SubFamiNiv1 ", SqlDbType.Int).Value = pnSubFamiNiv1
        'cmd.Parameters.Add("@SubFamiNiv2 ", SqlDbType.Int).Value = pnSubFamiNiv2
        cmd.Parameters.Add("@CodigoBarras ", SqlDbType.NVarChar, 50).Value = pCodigoBarras
        cmd.Parameters.Add("@Estatus ", SqlDbType.NVarChar, 20).Value = pnestatus
        cmd.Parameters.Add("@UsuarioUltimoCambio ", SqlDbType.NVarChar, 15).Value = pusuario
        cmd.Parameters.Add("@PuntoReorden ", SqlDbType.Decimal, 14, 8).Value = pPtoReorden

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function SeleccionaCuenta(ByVal pcuenta As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusDescripcionCta"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = pcuenta

        dr = cmd.ExecuteReader()
        SeleccionaCuenta = dr
        'clsDB.CierraConexion(cnnConexion)
    End Function
    Function BuscaDescProducto(ByVal Descripcion As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusDescripcionProducto"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Descripcion

        dr = cmd.ExecuteReader()
        BuscaDescProducto = dr

    End Function
    Function ValidaEliProducto(ByVal pcodigo As String)
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
        ValidaEliProducto = dr
    End Function
End Class
