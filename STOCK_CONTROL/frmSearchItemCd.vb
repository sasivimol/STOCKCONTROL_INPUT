Imports STOCK_CONTROL.NMTHFunction
Imports STOCK_CONTROL.IPSFunction
Imports System.Windows.Forms.DataGridView
Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class frmSearchItemCd
    Dim txtSearch As String

    Private Sub frmSearchItemCd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtSearchItemCdPopup.Text = UCase(frmMain.txtSearchItemCd.Text)
    End Sub

    Private Sub txtSearchItemCdPopup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchItemCdPopup.KeyPress
        If e.KeyChar = Chr(13) Then
            SearchData()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData()
    End Sub

    Private Sub GridView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridView1.MouseDoubleClick
        frmMain.txtSearchItemCd.Text = RTrim(GridView1.Item(0, GridView1.CurrentRow.Index).Value)
        frmMain.txtSearchItemCd.Text = RTrim(GridView1.Item(0, GridView1.CurrentRow.Index).Value)
        Me.Close()
    End Sub

    Public Sub SearchData()
        If UCase(frmMain.txtSearchItemCd.Text) <> "" Then
            txtSearch = UCase(frmMain.txtSearchItemCd.Text)
        Else
            txtSearch = txtSearchItemCdPopup.Text
        End If
        Dim SQLSearch As String = "SELECT DISTINCT I_ITEM_CD" & _
                                    " FROM item_master" & _
                                    " WHERE I_ITEM_CD LIKE '%" & txtSearch & "%'" & _
                                    " ORDER BY I_ITEM_CD"
        Dim DSSearch As DataSet = CreateDataSet(SQLSearch, "IPS")
        If DSSearch.Tables(0).Rows.Count > 0 Then
            GridView1.DataSource = DSSearch.Tables(0)
        Else
            MessageBox.Show("ไม่มีข้อมูลในระบบ กรุณาระบุใหม่ค่ะ", "Don't have data in system", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class