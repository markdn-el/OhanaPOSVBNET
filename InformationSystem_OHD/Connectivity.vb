Module Connectivity
    Public dbConnection As ADODB.Connection
    Public rsProduct As ADODB.Recordset

    Public Sub dbconnect()
        dbConnection = New ADODB.Connection
        With dbConnection
            .ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = IS_OHD.accdb"
            .Open()

        End With
    End Sub
End Module
