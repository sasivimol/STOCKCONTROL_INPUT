Imports Microsoft
Imports System.Windows.Forms

Public Class NMTHFunction
    Public Shared Function CheckConnString(ByVal strCon As String) As String
        If strCon = "IPS" Then
            strCon = "Dsn=IPS;Data Source=//10.152.20.244:5432/StockNMTH;User ID=ball;Password=football;"
        End If
        'If strCon = "IPS" Then
        '    strCon = "Dsn=IPS;Data Source=//localhost/storeNMTH;User ID=postgres;Password=Sonami123;"
        'End If
        Return strCon
    End Function

    Public Shared Function CreateDataSet(ByVal strSQL As String, Optional ByVal ConnNo As String = "IPS") As DataSet
        Dim Conn As New Odbc.OdbcConnection(CheckConnString(ConnNo))
        Dim DA As New Odbc.OdbcDataAdapter(strSQL, Conn)
        Dim DS As New DataSet
        DA.Fill(DS)
        Return DS
    End Function

    Public Shared Function SaveDataToSQL(ByVal strSQL As String, Optional ByVal ConnNo As String = "IPS") As Boolean
        Dim SQLConn As New Odbc.OdbcConnection(CheckConnString(ConnNo))
        Dim SQLCmd As New Odbc.OdbcCommand()

        Try
            SQLConn.Open()
        Catch ex As Exception
            Return False
        End Try

        SQLCmd.Connection = SQLConn
        SQLCmd.CommandText = strSQL
        Try
            SQLCmd.ExecuteNonQuery()
            SQLConn.Close()
            Return True
        Catch ex As Exception
            SQLConn.Close()
            Return False
        End Try
    End Function

End Class
