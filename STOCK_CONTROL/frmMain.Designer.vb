<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.FRM_Label = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GridView2 = New System.Windows.Forms.DataGridView
        Me.lblDateNow = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClearData = New System.Windows.Forms.Button
        Me.btnSearchItemCd = New System.Windows.Forms.Button
        Me.btnSearchPartNo = New System.Windows.Forms.Button
        Me.btnSearchData = New System.Windows.Forms.Button
        Me.txtSearchCustCd = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSearchPartNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSearchItemCd = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSearchITSNo = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtQRCodeNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridView1 = New System.Windows.Forms.DataGridView
        Me.btnSave = New System.Windows.Forms.Button
        Me.Nitto_Logo = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtInputQty = New System.Windows.Forms.TextBox
        Me.txtLotNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPDLine = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnDelete = New System.Windows.Forms.Button
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nitto_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'FRM_Label
        '
        Me.FRM_Label.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FRM_Label.ForeColor = System.Drawing.Color.Blue
        Me.FRM_Label.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FRM_Label.Location = New System.Drawing.Point(195, 9)
        Me.FRM_Label.Name = "FRM_Label"
        Me.FRM_Label.Size = New System.Drawing.Size(452, 39)
        Me.FRM_Label.TabIndex = 38
        Me.FRM_Label.Text = "STOCK CONTROL SYSTEM : INPUT DATA"
        Me.FRM_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(685, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 14)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Date.:"
        '
        'GridView2
        '
        Me.GridView2.AllowUserToAddRows = False
        Me.GridView2.AllowUserToDeleteRows = False
        Me.GridView2.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.GridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridView2.DefaultCellStyle = DataGridViewCellStyle18
        Me.GridView2.Location = New System.Drawing.Point(8, 420)
        Me.GridView2.Name = "GridView2"
        Me.GridView2.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.GridView2.RowHeadersWidth = 20
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
        Me.GridView2.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.GridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView2.Size = New System.Drawing.Size(784, 232)
        Me.GridView2.TabIndex = 15
        '
        'lblDateNow
        '
        Me.lblDateNow.AutoSize = True
        Me.lblDateNow.BackColor = System.Drawing.SystemColors.Control
        Me.lblDateNow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDateNow.ForeColor = System.Drawing.Color.Green
        Me.lblDateNow.Location = New System.Drawing.Point(734, 17)
        Me.lblDateNow.Name = "lblDateNow"
        Me.lblDateNow.Size = New System.Drawing.Size(0, 14)
        Me.lblDateNow.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClearData)
        Me.GroupBox1.Controls.Add(Me.btnSearchItemCd)
        Me.GroupBox1.Controls.Add(Me.btnSearchPartNo)
        Me.GroupBox1.Controls.Add(Me.btnSearchData)
        Me.GroupBox1.Controls.Add(Me.txtSearchCustCd)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSearchPartNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSearchItemCd)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSearchITSNo)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtQRCodeNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(874, 114)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Data"
        '
        'btnClearData
        '
        Me.btnClearData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClearData.ForeColor = System.Drawing.Color.Green
        Me.btnClearData.Location = New System.Drawing.Point(753, 17)
        Me.btnClearData.Name = "btnClearData"
        Me.btnClearData.Size = New System.Drawing.Size(113, 43)
        Me.btnClearData.TabIndex = 120
        Me.btnClearData.Text = "CLEAR DATA"
        Me.btnClearData.UseVisualStyleBackColor = True
        '
        'btnSearchItemCd
        '
        Me.btnSearchItemCd.ForeColor = System.Drawing.Color.Black
        Me.btnSearchItemCd.Location = New System.Drawing.Point(690, 78)
        Me.btnSearchItemCd.Name = "btnSearchItemCd"
        Me.btnSearchItemCd.Size = New System.Drawing.Size(57, 28)
        Me.btnSearchItemCd.TabIndex = 7
        Me.btnSearchItemCd.Text = "SEARCH"
        Me.btnSearchItemCd.UseVisualStyleBackColor = True
        '
        'btnSearchPartNo
        '
        Me.btnSearchPartNo.ForeColor = System.Drawing.Color.Black
        Me.btnSearchPartNo.Location = New System.Drawing.Point(329, 78)
        Me.btnSearchPartNo.Name = "btnSearchPartNo"
        Me.btnSearchPartNo.Size = New System.Drawing.Size(56, 28)
        Me.btnSearchPartNo.TabIndex = 4
        Me.btnSearchPartNo.Text = "SEARCH"
        Me.btnSearchPartNo.UseVisualStyleBackColor = True
        '
        'btnSearchData
        '
        Me.btnSearchData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearchData.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnSearchData.Location = New System.Drawing.Point(753, 63)
        Me.btnSearchData.Name = "btnSearchData"
        Me.btnSearchData.Size = New System.Drawing.Size(113, 43)
        Me.btnSearchData.TabIndex = 8
        Me.btnSearchData.Text = "SEARCH"
        Me.btnSearchData.UseVisualStyleBackColor = True
        '
        'txtSearchCustCd
        '
        Me.txtSearchCustCd.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearchCustCd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchCustCd.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCustCd.ForeColor = System.Drawing.Color.Purple
        Me.txtSearchCustCd.Location = New System.Drawing.Point(486, 47)
        Me.txtSearchCustCd.Name = "txtSearchCustCd"
        Me.txtSearchCustCd.Size = New System.Drawing.Size(261, 28)
        Me.txtSearchCustCd.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(397, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 16)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "CUST CODE.:"
        '
        'txtSearchPartNo
        '
        Me.txtSearchPartNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearchPartNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchPartNo.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchPartNo.ForeColor = System.Drawing.Color.Purple
        Me.txtSearchPartNo.Location = New System.Drawing.Point(103, 78)
        Me.txtSearchPartNo.Name = "txtSearchPartNo"
        Me.txtSearchPartNo.Size = New System.Drawing.Size(220, 28)
        Me.txtSearchPartNo.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(24, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "PART NO.:"
        '
        'txtSearchItemCd
        '
        Me.txtSearchItemCd.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearchItemCd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchItemCd.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchItemCd.ForeColor = System.Drawing.Color.Purple
        Me.txtSearchItemCd.Location = New System.Drawing.Point(486, 78)
        Me.txtSearchItemCd.Name = "txtSearchItemCd"
        Me.txtSearchItemCd.Size = New System.Drawing.Size(198, 28)
        Me.txtSearchItemCd.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(398, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "ITEM CODE.:"
        '
        'txtSearchITSNo
        '
        Me.txtSearchITSNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearchITSNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchITSNo.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchITSNo.ForeColor = System.Drawing.Color.Purple
        Me.txtSearchITSNo.Location = New System.Drawing.Point(103, 47)
        Me.txtSearchITSNo.Name = "txtSearchITSNo"
        Me.txtSearchITSNo.Size = New System.Drawing.Size(282, 28)
        Me.txtSearchITSNo.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(38, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 16)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "ITS NO.:"
        '
        'txtQRCodeNo
        '
        Me.txtQRCodeNo.BackColor = System.Drawing.SystemColors.Info
        Me.txtQRCodeNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQRCodeNo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtQRCodeNo.ForeColor = System.Drawing.Color.Purple
        Me.txtQRCodeNo.Location = New System.Drawing.Point(103, 17)
        Me.txtQRCodeNo.Name = "txtQRCodeNo"
        Me.txtQRCodeNo.Size = New System.Drawing.Size(644, 27)
        Me.txtQRCodeNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "QRCODE NO.:"
        '
        'GridView1
        '
        Me.GridView1.AllowUserToAddRows = False
        Me.GridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black
        Me.GridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.GridView1.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView1.Location = New System.Drawing.Point(8, 21)
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ReadOnly = True
        Me.GridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.GridView1.RowHeadersWidth = 20
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black
        Me.GridView1.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.GridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView1.Size = New System.Drawing.Size(858, 139)
        Me.GridView1.StandardTab = True
        Me.GridView1.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSave.Location = New System.Drawing.Point(798, 420)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 56)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "บันทึกข้อมูล   SAVE DATA"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Nitto_Logo
        '
        Me.Nitto_Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Nitto_Logo.ErrorImage = CType(resources.GetObject("Nitto_Logo.ErrorImage"), System.Drawing.Image)
        Me.Nitto_Logo.Image = CType(resources.GetObject("Nitto_Logo.Image"), System.Drawing.Image)
        Me.Nitto_Logo.Location = New System.Drawing.Point(8, 7)
        Me.Nitto_Logo.Name = "Nitto_Logo"
        Me.Nitto_Logo.Size = New System.Drawing.Size(140, 34)
        Me.Nitto_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Nitto_Logo.TabIndex = 39
        Me.Nitto_Logo.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label6.Location = New System.Drawing.Point(30, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 14)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "PD Finish Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(754, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 18)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "INPUT QTY "
        '
        'txtInputQty
        '
        Me.txtInputQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtInputQty.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputQty.Location = New System.Drawing.Point(743, 44)
        Me.txtInputQty.Name = "txtInputQty"
        Me.txtInputQty.Size = New System.Drawing.Size(123, 34)
        Me.txtInputQty.TabIndex = 14
        Me.txtInputQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLotNo
        '
        Me.txtLotNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLotNo.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotNo.Location = New System.Drawing.Point(569, 43)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New System.Drawing.Size(169, 34)
        Me.txtLotNo.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(614, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "LOT NO "
        '
        'txtLocation
        '
        Me.txtLocation.BackColor = System.Drawing.Color.White
        Me.txtLocation.Enabled = False
        Me.txtLocation.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(310, 42)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(130, 34)
        Me.txtLocation.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(329, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "LOCATION "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(10, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(132, 29)
        Me.DateTimePicker1.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtPDLine)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtLocation)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtLotNo)
        Me.GroupBox2.Controls.Add(Me.txtInputQty)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(874, 84)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Data"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(467, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 18)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "PD LINE"
        '
        'txtPDLine
        '
        Me.txtPDLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPDLine.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPDLine.Location = New System.Drawing.Point(446, 42)
        Me.txtPDLine.Name = "txtPDLine"
        Me.txtPDLine.Size = New System.Drawing.Size(117, 34)
        Me.txtPDLine.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(9, 161)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(874, 167)
        Me.GroupBox3.TabIndex = 87
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Result For Search Data"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnDelete.Location = New System.Drawing.Point(798, 482)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 56)
        Me.btnDelete.TabIndex = 88
        Me.btnDelete.Text = "ลบข้อมูล   DELETE DATA"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(890, 658)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDateNow)
        Me.Controls.Add(Me.GridView2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Nitto_Logo)
        Me.Controls.Add(Me.FRM_Label)
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCK CONTROL : INPUT DATA"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nitto_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nitto_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents FRM_Label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents lblDateNow As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearchITSNo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtQRCodeNo As System.Windows.Forms.TextBox
    Friend WithEvents GridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtSearchPartNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSearchItemCd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSearchCustCd As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSearchData As System.Windows.Forms.Button
    Friend WithEvents btnSearchPartNo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtInputQty As System.Windows.Forms.TextBox
    Friend WithEvents txtLotNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchItemCd As System.Windows.Forms.Button
    Friend WithEvents txtPDLine As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClearData As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
