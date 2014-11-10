Imports STOCK_CONTROL.NMTHFunction
Imports STOCK_CONTROL.IPSFunction
Imports System.Windows.Forms.DataGridView
Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class frmMain
    Dim IPSFunc As New IPSFunction
    Dim AutoManual As Boolean

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtQRCodeNo.Focus()
        lblDateNow.Text = DateTime.Now.ToString("dd MMMM yyyy")
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        GridView1HeaderText()
        GridView2HeaderText()
    End Sub

    Public Sub GridView1HeaderText()
        GridView1.Columns.Add("ITEM NO", "ITEM NO")
        GridView1.Columns.Add("PART NO", "PART NO")
        GridView1.Columns.Add("WI NO", "WI NO")
        GridView1.Columns.Add("PACKAGING", "PACKAGING")
        GridView1.Columns.Add("PLANT", "PLANT")
        GridView1.Columns.Add("PCS / BOX", "PCS / BOX")
        GridView1.Columns.Add("PCS / PACK", "PCS / PACK")
        GridView1.Columns.Add("CUST NO", "CUST NO")
        GridView1.Columns.Add("ITS NO", "ITS NO")
        GridView1.Columns(4).Width = "80"
        GridView1.Columns(5).Width = "90"
        GridView1.Columns(6).Width = "90"
        GridView1.Columns(7).Width = "80"
        GridView1.Columns(8).Width = "95"
    End Sub

    Public Sub GridView2HeaderText()
        GridView2.Columns.Add("ITEM NO", "ITEM NO")
        GridView2.Columns.Add("PART NO", "PART NO")
        GridView2.Columns.Add("WI NO", "WI NO")
        GridView2.Columns.Add("PACKAGING", "PACKAGING")
        GridView2.Columns.Add("PLANT", "PLANT")
        GridView2.Columns.Add("PD FINISH DATE", "PD FINISH DATE")
        GridView2.Columns.Add("LOCATION", "LOCATION")
        GridView2.Columns.Add("LOT NO", "LOT NO")
        GridView2.Columns.Add("INPUT QTY", "INPUT QTY")
        GridView2.Columns.Add("PD LINE", "PD LINE")
        GridView2.Columns.Add("PCS / BOX", "PCS / BOX")
        GridView2.Columns.Add("PCS / PACK", "PCS / PACK")
        GridView2.Columns.Add("CUST NO", "CUST NO")
        GridView2.Columns.Add("ITS NO", "ITS NO")
        GridView2.Columns(4).Width = "70"
        GridView2.Columns(5).Width = "120"
    End Sub

    Public Sub ClearDataSearch()
        txtQRCodeNo.Text = ""
        txtSearchITSNo.Text = ""
        txtSearchCustCd.Text = ""
        txtSearchItemCd.Text = ""
        txtSearchPartNo.Text = ""
        GridView1.DataSource = Nothing
        GridView1.Rows.Clear()
        txtQRCodeNo.Focus()
    End Sub

    Public Sub ClearData()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        txtPDLine.Text = ""
        txtLocation.Text = ""
        txtLotNo.Text = ""
        txtInputQty.Text = ""
        txtQRCodeNo.Focus()
    End Sub

    Private Sub txtLotNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLotNo.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim SQLLocation As String = "SELECT * FROM IPS_STOCKCONTROL " & _
                                          " WHERE I_ITEM_CD = '" & CheckGridviewDBNull(GridView1.Item(0, GridView1.CurrentRow.Index).Value) & "'" & _
                                                " AND I_TRADE_ITEM_CD = '" & CheckGridviewDBNull(GridView1.Item(1, GridView1.CurrentRow.Index).Value) & "'" & _
                                                " AND IPS_CUST_CD = '" & CheckGridviewDBNull(GridView1.Item(7, GridView1.CurrentRow.Index).Value) & "'" & _
                                                " AND PACKAGING = '" & CheckGridviewDBNull(GridView1.Item(3, GridView1.CurrentRow.Index).Value) & "'" & _
                                                " AND LOT_NO = '" & txtLotNo.Text & "'" & _
                                                " AND I_FAC_CD = '1NMTH'"
            Dim DSLocation As DataSet = CreateDataSet(SQLLocation, "IPS")
            If DSLocation.Tables(0).Rows.Count > 0 Then
                txtInputQty.Text = Format(DSLocation.Tables(0).Rows(0).Item("INPUT_QTY"), "##")
                txtLocation.Enabled = True
                txtLocation.Focus()
            Else
                txtInputQty.Focus()
            End If
        End If
    End Sub

    Public Sub DataFromSearch()
        Dim SearchCon As String = ""
        Dim SearchITSNo As String = ""
        Dim SearchItemCd As String = ""
        Dim SearchPartNo As String = ""
        Dim SearchCustCd As String = ""
        Dim SQLSEARCH As String
        Dim TBSEARCH As String
        Dim DSSEARCH As DataSet
        If txtQRCodeNo.Text <> "" Then
            Dim QRCodeSearch As Array = IPSFunc.SplitQRCode(Me.txtQRCodeNo.Text)
            SearchITSNo = UCase(QRCodeSearch(0))
            SearchItemCd = UCase(QRCodeSearch(1))
            SearchPartNo = UCase(QRCodeSearch(2))
            SearchCustCd = UCase(QRCodeSearch(3))
        Else
            SearchITSNo = UCase(txtSearchITSNo.Text)
            SearchItemCd = UCase(txtSearchItemCd.Text)
            SearchPartNo = UCase(txtSearchPartNo.Text)
            SearchCustCd = UCase(txtSearchCustCd.Text)
        End If
        If SearchITSNo <> "" Then
            TBSEARCH = "ITS"
        Else
            TBSEARCH = "ITEM_MASTER"
        End If
        If SearchITSNo <> "" Or SearchItemCd <> "" Or SearchPartNo <> "" Or SearchCustCd <> "" Then
            If SearchITSNo <> "" Then
                SearchCon += " AND " & TBSEARCH & ".ITS_NO LIKE '%" & SearchITSNo & "%'"

            End If
            If SearchItemCd <> "" Then
                SearchCon += " AND " & TBSEARCH & ".I_ITEM_CD LIKE '%" & SearchItemCd & "%'"
            End If
            If SearchPartNo <> "" Then
                SearchCon += " AND " & TBSEARCH & ".I_TRADE_ITEM_CD LIKE '%" & SearchPartNo & "%'"
            End If
            If SearchCustCd <> "" Then
                SearchCon += " AND " & TBSEARCH & ".IPS_CUST_CD LIKE '%" & SearchCustCd & "%'"
            End If

            If SearchITSNo <> "" Then
                SQLSEARCH = " SELECT ITS.I_ITEM_CD As ITEMCD, ITS.I_TRADE_ITEM_CD As PARTNO," & _
                                                    " ITS.WI_NO As WINO, WI_MASTER.BOX_CD As PACKAGING," & _
                                                    " WI_MASTER.PLANT As PLANT, WI_MASTER.PCS_BOX As PCSPERBOX," & _
                                                    " WI_MASTER.PCS_PACK As PCSPERPACK ,ITS.IPS_CUST_CD AS IPSCUSTCD," & _
                                                    " ITS.ITS_NO AS ITSNO" & _
                                                " FROM ITS LEFT JOIN WI_MASTER ON ITS.WI_NO = WI_MASTER.WI_NO " & _
                                                    " WHERE ITS.I_ITEM_CD <> ''" & _
                                                    " " + SearchCon + ""
                DSSEARCH = CreateDataSet(SQLSEARCH, "IPS")
            Else
                SQLSEARCH = "SELECT ITEM_MASTER.I_ITEM_CD As ITEMCD, ITEM_MASTER.I_TRADE_ITEM_CD As PARTNO," & _
                                            " ITEM_MASTER.WI_NO As WINO, WI_MASTER.BOX_CD As PACKAGING," & _
                                            " WI_MASTER.PLANT As PLANT, WI_MASTER.PCS_BOX As PCSPERBOX," & _
                                            " WI_MASTER.PCS_PACK As PCSPERPACK, ITEM_MASTER.IPS_CUST_CD AS IPSCUSTCD," & _
                                            " '' AS ITSNO" & _
                                         " FROM ITEM_MASTER LEFT OUTER JOIN WI_MASTER" & _
                                            " ON ITEM_MASTER.WI_NO = WI_MASTER.WI_NO" & _
                                         " WHERE ITEM_MASTER.I_ITEM_CD <> ''" & _
                                         " " + SearchCon + ""
                DSSEARCH = CreateDataSet(SQLSEARCH, "IPS")
            End If
            If DSSEARCH.Tables(0).Rows.Count > 0 Then
                GridView1.Rows.Clear()
                For i = 0 To DSSEARCH.Tables(0).Rows.Count - 1
                    Dim n As Integer = GridView1.Rows.Add()
                    For j = 0 To DSSEARCH.Tables(0).Columns.Count - 1
                        GridView1.Rows.Item(n).Cells(j).Value = DSSEARCH.Tables(0).Rows(i).Item(j)
                    Next
                Next
                GridView1.Focus()
            Else
                MessageBox.Show("ไม่มีข้อมูลในระบบ กรุณาระบุใหม่ค่ะ", "Don't have data in system", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub txtInputQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInputQty.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) And txtInputQty.Text <> "" Then
            GridView2.AutoGenerateColumns = False
            Dim n As Integer = GridView2.Rows.Add()
            GridView2.Rows.Item(n).Cells(0).Value = CheckGridviewDBNull(GridView1.Item(0, GridView1.CurrentRow.Index).Value)
            GridView2.Rows.Item(n).Cells(1).Value = CheckGridviewDBNull(GridView1.Item(1, GridView1.CurrentRow.Index).Value)
            GridView2.Rows.Item(n).Cells(2).Value = CheckGridviewDBNull(GridView1.Item(2, GridView1.CurrentRow.Index).Value)
            GridView2.Rows.Item(n).Cells(3).Value = CheckGridviewDBNull(GridView1.Item(3, GridView1.CurrentRow.Index).Value)
            GridView2.Rows.Item(n).Cells(4).Value = CheckGridviewDBNull(GridView1.Item(4, GridView1.CurrentRow.Index).Value)
            GridView2.Rows.Item(n).Cells(5).Value = RTrim(Me.DateTimePicker1.Text)
            GridView2.Rows.Item(n).Cells(6).Value = RTrim(Me.txtLocation.Text)
            GridView2.Rows.Item(n).Cells(7).Value = RTrim(Me.txtLotNo.Text)
            GridView2.Rows.Item(n).Cells(8).Value = RTrim(Me.txtInputQty.Text)
            GridView2.Rows.Item(n).Cells(9).Value = RTrim(Me.txtPDLine.Text)
            GridView2.Rows.Item(n).Cells(10).Value = CheckGridviewDBNull(GridView1.Item(5, GridView1.CurrentRow.Index).Value)
            GridView2.Rows.Item(n).Cells(11).Value = CheckGridviewDBNull(GridView1.Item(6, GridView1.CurrentRow.Index).Value)
            GridView2.Rows.Item(n).Cells(12).Value = CheckGridviewDBNull(GridView1.Item(7, GridView1.CurrentRow.Index).Value)
            GridView2.Rows.Item(n).Cells(13).Value = CheckGridviewDBNull(GridView1.Item(8, GridView1.CurrentRow.Index).Value)
            ClearDataSearch()
            ClearData()
            txtLocation.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If GridView2.RowCount > 0 Then
            For i = 0 To GridView2.Rows.Count - 1
                If CheckGridviewDBNull(GridView2.Rows.Item(i).Cells(6).Value) <> "" Then 'Check Location
                    Dim SQLSearch As String = "SELECT * FROM IPS_STOCKCONTROL " & _
                                              " WHERE I_ITEM_CD = '" & GridView2.Rows.Item(i).Cells(0).Value & "'" & _
                                                    " AND I_TRADE_ITEM_CD = '" & GridView2.Rows.Item(i).Cells(1).Value & "'" & _
                                                    " AND IPS_CUST_CD = '" & GridView2.Rows.Item(i).Cells(12).Value & "'" & _
                                                    " AND PACKAGING = '" & GridView2.Rows.Item(i).Cells(3).Value & "'" & _
                                                    " AND LOT_NO = '" & GridView2.Rows.Item(i).Cells(7).Value & "'" & _
                                                    " AND I_FAC_CD = '1NMTH'"
                    Dim DSSearch As DataSet = CreateDataSet(SQLSearch, "IPS")
                    If DSSearch.Tables(0).Rows.Count > 0 Then
                        Dim SQLSearchLoc As String = "SELECT * FROM IPS_STOCKCONTROL_WH " & _
                                                        " WHERE STOCKCONTROL_NO = '" & CheckGridviewDBNull(DSSearch.Tables(0).Rows(0).Item("STOCKCONTROL_NO")) & "'" & _
                                                            " AND I_FAC_CD = '1NMTH'" & _
                                                            " AND I_ITEM_CD = '" & GridView2.Rows.Item(i).Cells(0).Value & "'" & _
                                                            " AND I_TRADE_ITEM_CD = '" & GridView2.Rows.Item(i).Cells(1).Value & "'" & _
                                                            " AND IPS_CUST_CD = '" & GridView2.Rows.Item(i).Cells(12).Value & "'" & _
                                                            " AND LOT_NO = '" & GridView2.Rows.Item(i).Cells(7).Value & "'" & _
                                                            " AND STORE_LOCATION = '" & GridView2.Rows.Item(i).Cells(6).Value & "'" & _
                                                            " AND INPUT_RECEIVE_DATE = to_date('" & Today.ToString("dd/MM/yyyy") & "','dd/mm/yyyy')"
                        Dim DSSearchLoc As DataSet = CreateDataSet(SQLSearchLoc, "IPS")
                        If DSSearchLoc.Tables(0).Rows.Count > 0 Then
                            Dim QTY As Integer = DSSearchLoc.Tables(0).Rows(0).Item("INPUT_QTY") + CheckGridviewDBNull(GridView2.Rows.Item(i).Cells(8).Value)
                            Dim sqlUpdLoc As String = " UPDATE IPS_STOCKCONTROL_WH " & _
                                                          " SET INPUT_QTY = '" & QTY & "'," & _
                                                            " UPDATE_DATE = to_date('" & Today.ToString("dd/MM/yyyy") & "','dd/mm/yyyy')" & _
                                                          " WHERE STOCKCONTROL_NO = '" & CheckGridviewDBNull(DSSearch.Tables(0).Rows(0).Item("STOCKCONTROL_N0")) & "'" & _
                                                            " AND I_FAC_CD = '1NMTH'" & _
                                                            " AND I_ITEM_CD = '" & GridView2.Rows.Item(i).Cells(0).Value & "'" & _
                                                            " AND I_TRADE_ITEM_CD = '" & GridView2.Rows.Item(i).Cells(1).Value & "'" & _
                                                            " AND IPS_CUST_CD = '" & GridView2.Rows.Item(i).Cells(12).Value & "'" & _
                                                            " AND LOT_NO = '" & GridView2.Rows.Item(i).Cells(7).Value & "'" & _
                                                            " AND STORE_LOCATION = '" & GridView2.Rows.Item(i).Cells(6).Value & "'" & _
                                                            " AND INPUT_RECEIVE_DATE = to_date('" & Today.ToString("dd/MM/yyyy") & "','dd/mm/yyyy')"
                        Else
                            Dim SQLInsLoc As String = "INSERT INTO IPS_STOCKCONTROL_WH(" & _
                                                        " STOCKCONTROL_NO, I_FAC_CD," & _
                                                        " I_ITEM_CD, I_TRADE_ITEM_CD," & _
                                                        " IPS_CUST_CD, LOT_NO," & _
                                                        " STORE_LOCATION, INPUT_RECEIVE_DATE," & _
                                                        " INPUT_QTY, CREATE_DATE," & _
                                                        " CREATE_BY, COMPUTER_NAME)" & _
                                                    " VALUES(" & _
                                                        " '" & CheckGridviewDBNull(DSSearch.Tables(0).Rows(0).Item("STOCKCONTROL_NO")) & "', '1NMTH'," & _
                                                        " '" & CheckGridviewDBNull(DSSearch.Tables(0).Rows(0).Item("I_ITEM_CD")) & "', '" & CheckGridviewDBNull(DSSearch.Tables(0).Rows(0).Item("I_TRADE_ITEM_CD")) & "'," & _
                                                        " '" & CheckGridviewDBNull(DSSearch.Tables(0).Rows(0).Item("IPS_CUST_CD")) & "', '" & CheckGridviewDBNull(GridView2.Rows.Item(i).Cells(7).Value) & "'," & _
                                                        " '" & CheckGridviewDBNull(GridView2.Rows.Item(i).Cells(6).Value) & "', to_date('" & Today.ToString("dd/MM/yyyy") & "','dd/mm/yyyy')," & _
                                                        " '" & CheckGridviewDBNull(GridView2.Rows.Item(i).Cells(8).Value) & "', to_date('" & Today.ToString("dd/MM/yyyy") & "','dd/mm/yyyy')," & _
                                                        " '', '" & IPSFunc.GetComputerName() & "')"
                            If SaveDataToSQL(SQLInsLoc, "IPS") Then
                                'MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้วค่ะ", "Save Data Completed!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    End If
                Else
                    Dim period_month As String = DateTime.Now.ToString("yyyyMM")
                    Dim SQLIns As String = "INSERT INTO IPS_STOCKCONTROL(" & _
                                                " ITS_NO," & _
                                                " I_FAC_CD, I_ITEM_CD," & _
                                                " I_TRADE_ITEM_CD, IPS_CUST_CD," & _
                                                " PERIOD_MONTH, PACKAGING," & _
                                                " RECEIVE_DATE, PD_FINISH_DATE," & _
                                                " PD_LINE," & _
                                                " LOT_NO, STORE_LOCATION," & _
                                                " BEGIN_QTY, INPUT_QTY," & _
                                                " OUTPUT_QTY, RESERVE_QTY," & _
                                                " ONHAND_BALANCE, STATUS_USE," & _
                                                " CREATE_DATE, UPDATE_DATE, COMPUTER_NAME)" & _
                                            " VALUES('" & GridView2.Rows.Item(i).Cells(13).Value & "'," & _
                                                " '1NMTH','" & GridView2.Rows.Item(i).Cells(0).Value & "'," & _
                                                " '" & GridView2.Rows.Item(i).Cells(1).Value & "','" & GridView2.Rows.Item(i).Cells(12).Value & "'," & _
                                                " '" & period_month & "','" & GridView2.Rows.Item(i).Cells(3).Value & "'," & _
                                                " to_date('" & Today.ToString("dd/MM/yyyy") & "','dd/mm/yyyy'),to_date('" & GridView2.Rows.Item(i).Cells(5).Value & "','dd/mm/yyyy')," & _
                                                " '" & GridView2.Rows.Item(i).Cells(9).Value & "'," & _
                                                " '" & GridView2.Rows.Item(i).Cells(7).Value & "','" & GridView2.Rows.Item(i).Cells(6).Value & "'," & _
                                                " '" & GridView2.Rows.Item(i).Cells(8).Value & "','" & GridView2.Rows.Item(i).Cells(8).Value & "'," & _
                                                " '0.000000','0.000000'," & _
                                                " '" & GridView2.Rows.Item(i).Cells(8).Value & "','Start'," & _
                                                " to_date('" & Today.ToString("dd/MM/yyyy") & "','dd/mm/yyyy'),to_date('" & Today.ToString("dd/MM/yyyy") & "','dd/mm/yyyy'),'" & IPSFunc.GetComputerName() & "')"
                    If SaveDataToSQL(SQLIns, "IPS") Then
                        Dim NMax As String = " SELECT MAX(STOCKCONTROL_NO) FROM IPS_STOCKCONTROL " & _
                                                    " WHERE I_ITEM_CD = '" & GridView2.Rows.Item(i).Cells(0).Value & "'" & _
                                                    " AND I_TRADE_ITEM_CD = '" & GridView2.Rows.Item(i).Cells(1).Value & "'" & _
                                                    " AND IPS_CUST_CD = '" & GridView2.Rows.Item(i).Cells(12).Value & "'" & _
                                                    " AND PACKAGING = '" & GridView2.Rows.Item(i).Cells(3).Value & "'" & _
                                                    " AND LOT_NO = '" & GridView2.Rows.Item(i).Cells(7).Value & "'" & _
                                                    " AND I_FAC_CD = '1NMTH'"
                        Dim SQLInsLoc As String = "INSERT INTO IPS_STOCKCONTROL_WH(" & _
                                                " STOCKCONTROL_NO, I_FAC_CD," & _
                                                " I_ITEM_CD, I_TRADE_ITEM_CD," & _
                                                " IPS_CUST_CD, LOT_NO," & _
                                                " STORE_LOCATION, INPUT_RECEIVE_DATE," & _
                                                " INPUT_QTY, CREATE_DATE," & _
                                                " CREATE_BY, COMPUTER_NAME)" & _
                                            " VALUES(" & _
                                                " '" & NMax & "', '1NMTH'," & _
                                                " '" & GridView2.Rows.Item(i).Cells(0).Value & "', '" & GridView2.Rows.Item(i).Cells(1).Value & "'," & _
                                                " '" & GridView2.Rows.Item(i).Cells(12).Value & "', '" & GridView2.Rows.Item(i).Cells(7).Value & "'," & _
                                                " 'WAIT_STOCKIN', to_date('" & Today.ToString("dd/MM/yyyy") & "','dd/mm/yyyy')," & _
                                                " '" & CheckGridviewDBNull(GridView2.Rows.Item(i).Cells(8).Value) & "', to_date('" & Today.ToString("dd/MM/yyyy") & "','dd/mm/yyyy')," & _
                                                " '', '" & IPSFunc.GetComputerName() & "')"
                        SaveDataToSQL(SQLInsLoc, "IPS")
                    End If
                End If
                txtQRCodeNo.Focus()
            Next
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้วค่ะ", "Save Data Completed!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        GridView2.Rows.Clear()
    End Sub

    Private Sub btnSearchData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchData.Click
        DataFromSearch()
    End Sub

    Private Sub txtSearchITSNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchITSNo.KeyPress
        If e.KeyChar = Chr(13) Then
            DataFromSearch()
        End If
    End Sub

    Private Sub txtSearchCustCd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchCustCd.KeyPress
        If e.KeyChar = Chr(13) Then
            DataFromSearch()
        End If
    End Sub

    Private Sub txtSearchPartNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchPartNo.KeyPress
        If e.KeyChar = Chr(13) Then
            DataFromSearch()
        End If
    End Sub

    Private Sub txtSearchItemCd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchItemCd.KeyPress
        If e.KeyChar = Chr(13) Then
            DataFromSearch()
        End If
    End Sub

    Private Sub btnClearData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearData.Click
        ClearDataSearch()
        GridView2.Rows.Clear()
        ClearData()
    End Sub

    Private Sub btnSearchPartNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchPartNo.Click
        frmSearchPartNo.Show()
    End Sub

    Private Sub btnSearchItemCd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchItemCd.Click
        frmSearchItemCd.Show()
    End Sub

    Private Sub txtLocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocation.KeyPress
        If e.KeyChar = Chr(13) Then
            txtInputQty.Focus()
        End If
    End Sub

    Private Sub txtQRCodeNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQRCodeNo.KeyPress
        If e.KeyChar = Chr(13) Then
            DataFromSearch()
        End If
    End Sub

    Private Sub txtPDLine_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPDLine.KeyPress
        If e.KeyChar = Chr(13) Then
            txtLotNo.Focus()
        End If
    End Sub

    Private Sub GridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridView1.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPDLine.Focus()
        End If
    End Sub

End Class

