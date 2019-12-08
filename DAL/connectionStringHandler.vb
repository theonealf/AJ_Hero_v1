Public Class connectionStringHandler
    Private _connectionstring As String

    Public Sub New()
        Dim connstr As ConnectionStringSettingsCollection = ConfigurationManager.ConnectionStrings
        '_connectionstring = "Data Source=.\SQLEXPRESS;Initial Catalog=207074-frontdatadb;User ID=207074_il88852;Password=L0rda1fHem"
        '_connectionstring = "Data Source=ms04b.sqlserver.se;Initial Catalog=207074-frontdatadb;User ID=207074_il88852;Password=L0rda1fHem"
        '_connectionstring = "Data Source=frontdatadb-207074.mssql.binero.se;Initial Catalog=207074-frontdatadb;Integrated Security=False;User ID=207074_il88852;Connect Timeout=300;Encrypt=False;Packet Size=4096"
        _connectionstring = connstr.Item("SiteSqlServer").ConnectionString
    End Sub
    Public ReadOnly Property CurrentConnectionString() As String
        Get
            Return _connectionstring
        End Get

    End Property
End Class
