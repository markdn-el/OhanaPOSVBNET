<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashiering
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
        Me.TransactionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdVoidAll = New System.Windows.Forms.Button()
        Me.cmdLinevoid = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdAddItem = New System.Windows.Forms.Button()
        Me.txtamountrendered = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpprice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpdescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAddNewCust = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCashTendered = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblChangeDue = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnEndSession = New System.Windows.Forms.Button()
        Me.dgvCashiering = New System.Windows.Forms.DataGridView()
        Me.colPcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblrno = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCashiering, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransactionDate
        '
        Me.TransactionDate.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionDate.Location = New System.Drawing.Point(388, 594)
        Me.TransactionDate.MaximumSize = New System.Drawing.Size(324, 43)
        Me.TransactionDate.Name = "TransactionDate"
        Me.TransactionDate.Size = New System.Drawing.Size(324, 29)
        Me.TransactionDate.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(30, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "CUSTOMER ID:"
        '
        'cmdVoidAll
        '
        Me.cmdVoidAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdVoidAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdVoidAll.Location = New System.Drawing.Point(173, 74)
        Me.cmdVoidAll.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdVoidAll.Name = "cmdVoidAll"
        Me.cmdVoidAll.Size = New System.Drawing.Size(168, 69)
        Me.cmdVoidAll.TabIndex = 113
        Me.cmdVoidAll.Text = "VOID ALL"
        Me.cmdVoidAll.UseVisualStyleBackColor = True
        '
        'cmdLinevoid
        '
        Me.cmdLinevoid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdLinevoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdLinevoid.Location = New System.Drawing.Point(2, 74)
        Me.cmdLinevoid.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdLinevoid.Name = "cmdLinevoid"
        Me.cmdLinevoid.Size = New System.Drawing.Size(167, 69)
        Me.cmdLinevoid.TabIndex = 112
        Me.cmdLinevoid.Text = "LINE VOID"
        Me.cmdLinevoid.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdSave.Location = New System.Drawing.Point(173, 2)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(168, 68)
        Me.cmdSave.TabIndex = 110
        Me.cmdSave.Text = "SAVE / PRINT"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdAddItem
        '
        Me.cmdAddItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddItem.Location = New System.Drawing.Point(2, 2)
        Me.cmdAddItem.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.Size = New System.Drawing.Size(167, 68)
        Me.cmdAddItem.TabIndex = 109
        Me.cmdAddItem.Text = "ADD ITEM"
        Me.cmdAddItem.UseVisualStyleBackColor = True
        '
        'txtamountrendered
        '
        Me.txtamountrendered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtamountrendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtamountrendered.Location = New System.Drawing.Point(9, 44)
        Me.txtamountrendered.Margin = New System.Windows.Forms.Padding(2)
        Me.txtamountrendered.Multiline = True
        Me.txtamountrendered.Name = "txtamountrendered"
        Me.txtamountrendered.ReadOnly = True
        Me.txtamountrendered.Size = New System.Drawing.Size(324, 60)
        Me.txtamountrendered.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(10, 17)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 22)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "TOTAL AMOUNT:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 566)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 18)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "RECEIPT NUMBER:"
        '
        'txtqty
        '
        Me.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtqty.Location = New System.Drawing.Point(393, 743)
        Me.txtqty.Margin = New System.Windows.Forms.Padding(2)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(324, 31)
        Me.txtqty.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(395, 722)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 18)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "QUANTITY:"
        '
        'txtpprice
        '
        Me.txtpprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtpprice.Location = New System.Drawing.Point(393, 662)
        Me.txtpprice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpprice.Multiline = True
        Me.txtpprice.Name = "txtpprice"
        Me.txtpprice.ReadOnly = True
        Me.txtpprice.Size = New System.Drawing.Size(324, 49)
        Me.txtpprice.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(396, 641)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 18)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "PRODUCT PRICE:"
        '
        'txtpdescription
        '
        Me.txtpdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtpdescription.Location = New System.Drawing.Point(23, 743)
        Me.txtpdescription.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpdescription.Multiline = True
        Me.txtpdescription.Name = "txtpdescription"
        Me.txtpdescription.ReadOnly = True
        Me.txtpdescription.Size = New System.Drawing.Size(324, 49)
        Me.txtpdescription.TabIndex = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 722)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 18)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "PRODUCT NAME:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(390, 567)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 18)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "TRANSACTION DATE:"
        '
        'txtpcode
        '
        Me.txtpcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpcode.Location = New System.Drawing.Point(23, 662)
        Me.txtpcode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpcode.Name = "txtpcode"
        Me.txtpcode.Size = New System.Drawing.Size(324, 31)
        Me.txtpcode.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 642)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 18)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "PRODUCT CODE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(30, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 18)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "CUSTOMER NAME:"
        '
        'txtCustName
        '
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtCustName.Location = New System.Drawing.Point(27, 113)
        Me.txtCustName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustName.Multiline = True
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.ReadOnly = True
        Me.txtCustName.Size = New System.Drawing.Size(292, 43)
        Me.txtCustName.TabIndex = 94
        '
        'txtCustID
        '
        Me.txtCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustID.Location = New System.Drawing.Point(27, 42)
        Me.txtCustID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(292, 31)
        Me.txtCustID.TabIndex = 92
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Controls.Add(Me.cmdAddNewCust)
        Me.GroupBox1.Controls.Add(Me.txtCustName)
        Me.GroupBox1.Controls.Add(Me.txtCustID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(740, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 241)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'cmdAddNewCust
        '
        Me.cmdAddNewCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNewCust.ForeColor = System.Drawing.Color.Black
        Me.cmdAddNewCust.Location = New System.Drawing.Point(27, 165)
        Me.cmdAddNewCust.Name = "cmdAddNewCust"
        Me.cmdAddNewCust.Size = New System.Drawing.Size(292, 62)
        Me.cmdAddNewCust.TabIndex = 96
        Me.cmdAddNewCust.Text = "ADD NEW CUSTOMER"
        Me.cmdAddNewCust.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAddItem, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdLinevoid, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdVoidAll, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdSave, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(740, 566)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(343, 145)
        Me.TableLayoutPanel1.TabIndex = 119
        '
        'txtCashTendered
        '
        Me.txtCashTendered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashTendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtCashTendered.Location = New System.Drawing.Point(9, 144)
        Me.txtCashTendered.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCashTendered.Multiline = True
        Me.txtCashTendered.Name = "txtCashTendered"
        Me.txtCashTendered.Size = New System.Drawing.Size(324, 55)
        Me.txtCashTendered.TabIndex = 122
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(12, 117)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 22)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "CASH TENDERED:"
        '
        'lblChangeDue
        '
        Me.lblChangeDue.AutoSize = True
        Me.lblChangeDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeDue.Location = New System.Drawing.Point(20, 229)
        Me.lblChangeDue.Name = "lblChangeDue"
        Me.lblChangeDue.Size = New System.Drawing.Size(25, 25)
        Me.lblChangeDue.TabIndex = 123
        Me.lblChangeDue.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblChange)
        Me.GroupBox2.Controls.Add(Me.txtCashTendered)
        Me.GroupBox2.Controls.Add(Me.lblChangeDue)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtamountrendered)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(742, 271)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 271)
        Me.GroupBox2.TabIndex = 124
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Controls"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(11, 201)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(103, 24)
        Me.lblChange.TabIndex = 124
        Me.lblChange.Text = "CHANGE:"
        '
        'btnEndSession
        '
        Me.btnEndSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnEndSession.Location = New System.Drawing.Point(740, 714)
        Me.btnEndSession.Name = "btnEndSession"
        Me.btnEndSession.Size = New System.Drawing.Size(345, 79)
        Me.btnEndSession.TabIndex = 125
        Me.btnEndSession.Text = "END SESSION"
        Me.btnEndSession.UseVisualStyleBackColor = True
        '
        'dgvCashiering
        '
        Me.dgvCashiering.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCashiering.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCashiering.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCashiering.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPcode, Me.colPdesc, Me.colPrice, Me.colQty, Me.colTotal})
        Me.dgvCashiering.Location = New System.Drawing.Point(23, 24)
        Me.dgvCashiering.Name = "dgvCashiering"
        Me.dgvCashiering.Size = New System.Drawing.Size(689, 518)
        Me.dgvCashiering.TabIndex = 126
        '
        'colPcode
        '
        Me.colPcode.HeaderText = "Product Code"
        Me.colPcode.Name = "colPcode"
        '
        'colPdesc
        '
        Me.colPdesc.HeaderText = "Product Description"
        Me.colPdesc.Name = "colPdesc"
        '
        'colPrice
        '
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Line Total"
        Me.colTotal.Name = "colTotal"
        '
        'lblrno
        '
        Me.lblrno.AutoSize = True
        Me.lblrno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrno.ForeColor = System.Drawing.Color.GreenYellow
        Me.lblrno.Location = New System.Drawing.Point(24, 594)
        Me.lblrno.Name = "lblrno"
        Me.lblrno.Size = New System.Drawing.Size(100, 25)
        Me.lblrno.TabIndex = 127
        Me.lblrno.Text = "RNO111"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(120, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(214, 15)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "[PRESS ENTER TO CALCULATE]"
        '
        'frmCashiering
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1110, 824)
        Me.Controls.Add(Me.lblrno)
        Me.Controls.Add(Me.dgvCashiering)
        Me.Controls.Add(Me.btnEndSession)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TransactionDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpprice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpdescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtpcode)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmCashiering"
        Me.Text = "OHANA HARDWARE DEPOT POS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvCashiering, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TransactionDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdVoidAll As Button
    Friend WithEvents cmdLinevoid As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdAddItem As Button
    Friend WithEvents txtamountrendered As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpprice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpdescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtpcode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmdAddNewCust As Button
    Friend WithEvents txtCashTendered As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblChangeDue As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEndSession As Button
    Friend WithEvents dgvCashiering As DataGridView
    Friend WithEvents lblrno As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents colPcode As DataGridViewTextBoxColumn
    Friend WithEvents colPdesc As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
End Class
