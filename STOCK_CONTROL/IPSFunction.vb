Imports STOCK_CONTROL.NMTHFunction
Imports STOCK_CONTROL.frmMain
Imports System.Windows.Forms.DataGridView

Public Class IPSFunction

    Public Function SplitQRCode(ByVal QRCodeNo As String) As Array
        Dim strQRCode As Array = QRCodeNo.Split("$")
        Return strQRCode
    End Function

    Public Shared Function CheckGridviewDBNull(ByVal strGridData As Object) As String
        If IsDBNull(strGridData) Then
            Return ""
        Else
            Return RTrim(strGridData.ToString())
        End If
    End Function

    Public Function GetComputerName() As String
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        Return ComputerName
    End Function

    'Public Function LoadData(ByVal dataQRCodeSearch As String) As DataSet
    '    Dim SQLQRCodeSearch As String
    '    Dim DSQRCodeSearch As DataSet
    '    If SeparateQRCode(dataQRCodeSearch) = "ITS" Then
    '        SQLQRCodeSearch = "SELECT * FROM ITS " & _
    '                            " WHERE its_no='P2014101'"
    '        DSQRCodeSearch = CreateDataSet(SQLQRCodeSearch, SeparateQRCode(dataQRCodeSearch))
    '        Return DSQRCodeSearch
    '    Else 'SeparateQRCode(dataQRCodeSearch) = "SPS" Then
    '        SQLQRCodeSearch = ""
    '        DSQRCodeSearch = CreateDataSet(SQLQRCodeSearch, SeparateQRCode(dataQRCodeSearch))
    '        Return DSQRCodeSearch
    '    End If
    'End Function

    'Public Class MyDataGridView

    '    Inherits DataGridView

    '    Protected Overrides Function ProcessDialogKey(ByVal keydata As Keys) As Boolean

    '        Dim key As Keys = keydata And Keys.KeyCode
    '        If key = Keys.Enter Then
    '            Return Me.ProcessTabKey(keydata)
    '        End If
    '        Return MyBase.ProcessDialogKey(keydata)

    '    End Function

    '    Protected Overrides Function ProcessDataGridViewKey(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean

    '        If e.KeyCode = Keys.Enter Then
    '            Return Me.ProcessTabKey(e.KeyData)
    '        End If
    '        Return MyBase.ProcessDataGridViewKey(e)
    '    End Function

    'End Class
End Class
