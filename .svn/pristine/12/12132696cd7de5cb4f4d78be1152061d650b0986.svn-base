Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient

Public Class clsInformeProductoPtoReorden
    Function ProdPtoReorden(ByVal Fam As Integer, ByVal CodProd As String, ByVal FechaFinal As Date)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim cont = 7
        Dim FechaInicial As Date

        cmd.CommandText = "spProductoPtoReorden"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Familia", SqlDbType.Int).Value = Fam
        cmd.Parameters.Add("@CodigoProducto", SqlDbType.NChar).Value = CodProd
        cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar).Value = FechaInicial
        cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar).Value = FechaFinal

        For i As Integer = 1 To CInt(cont)
            Do
                FechaFinal = FechaFinal.AddDays(-1)
            Loop While (FechaFinal.DayOfWeek = DayOfWeek.Saturday) Or (FechaFinal.DayOfWeek = DayOfWeek.Sunday)
        Next
        FechaFinal = FechaInicial
        dr = cmd.ExecuteReader()
        ProdPtoReorden = dr
    End Function
End Class
