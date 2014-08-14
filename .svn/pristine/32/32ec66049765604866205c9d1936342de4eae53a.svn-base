Public Class clsTools
    ''SE DECLARA EL NUMERO DE VERSION PARA SER INSERTADO EN LOS DEMAS FORMS
    Public Shared Function VersionCont() As String
        Dim ver As String
        ver = "SysAlmacen [V 1.0.0.32]"
        Return ver
    End Function
    Public Sub LimpiarControles(ByVal formulario As Form)
        'Recorremos todos los controles del formulario que enviamos    
        For Each control As Control In formulario.Controls

            'Filtramos solo aquellos de tipo TextBox   
            If TypeOf control Is TextBox Then
                control.Text = "" ' eliminar el texto    
            End If
        Next

    End Sub
End Class
