Imports System.Data.SqlClient

Class clsInformeProductoPtoReorden
    Function ProdPtoReorden(ByVal CodProd As String, ByVal FechaFinal As Date)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim cont = 7
        Dim FechaInicial As Date

        Dim fi As Date = FechaFinal
        For i As Integer = 1 To CInt(cont)
            Do
                fi = fi.AddDays(-1)
            Loop While (fi.DayOfWeek = DayOfWeek.Saturday) Or (fi.DayOfWeek = DayOfWeek.Sunday)
        Next
        FechaInicial = fi

        Dim fechaIni As String
        Dim FechaFin As String
        fechaIni = Format(FechaInicial, "yyyyMMdd")
        FechaFin = Format(FechaFinal, "yyyyMMdd")

        cmd.CommandText = "spProductoDiasdeConsumo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodigoProducto", SqlDbType.NChar).Value = CodProd
        cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar).Value = fechaIni
        cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar).Value = FechaFin

        dr = cmd.ExecuteReader()
        ProdPtoReorden = dr
    End Function
End Class
