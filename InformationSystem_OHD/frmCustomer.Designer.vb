<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtMiddleI = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.btnCustLast = New System.Windows.Forms.Button()
        Me.btnCustNext = New System.Windows.Forms.Button()
        Me.btnCustPrevious = New System.Windows.Forms.Button()
        Me.btnCustFirst = New System.Windows.Forms.Button()
        Me.btnCustExit = New System.Windows.Forms.Button()
        Me.btnCustDelete = New System.Windows.Forms.Button()
        Me.btnCustEdit = New System.Windows.Forms.Button()
        Me.btnCustAdd = New System.Windows.Forms.Button()
        Me.txtCustSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCSearch = New System.Windows.Forms.Button()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboCustomerType = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.Location = New System.Drawing.Point(459, 105)
        Me.txtPhoneNo.Multiline = True
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(256, 41)
        Me.txtPhoneNo.TabIndex = 25
        '
        'txtMiddleI
        '
        Me.txtMiddleI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddleI.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleI.Location = New System.Drawing.Point(588, 186)
        Me.txtMiddleI.Multiline = True
        Me.txtMiddleI.Name = "txtMiddleI"
        Me.txtMiddleI.Size = New System.Drawing.Size(133, 41)
        Me.txtMiddleI.TabIndex = 24
        '
        'txtLName
        '
        Me.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(346, 186)
        Me.txtLName.Multiline = True
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(214, 41)
        Me.txtLName.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(63, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FIRST NAME"
        '
        'txtFname
        '
        Me.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(60, 186)
        Me.txtFname.Multiline = True
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(259, 41)
        Me.txtFname.TabIndex = 22
        '
        'btnCustLast
        '
        Me.btnCustLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustLast.Location = New System.Drawing.Point(295, 18)
        Me.btnCustLast.Name = "btnCustLast"
        Me.btnCustLast.Size = New System.Drawing.Size(82, 34)
        Me.btnCustLast.TabIndex = 21
        Me.btnCustLast.Text = "Last"
        Me.btnCustLast.UseVisualStyleBackColor = True
        '
        'btnCustNext
        '
        Me.btnCustNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustNext.Location = New System.Drawing.Point(207, 18)
        Me.btnCustNext.Name = "btnCustNext"
        Me.btnCustNext.Size = New System.Drawing.Size(82, 34)
        Me.btnCustNext.TabIndex = 20
        Me.btnCustNext.Text = "Next"
        Me.btnCustNext.UseVisualStyleBackColor = True
        '
        'btnCustPrevious
        '
        Me.btnCustPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustPrevious.Location = New System.Drawing.Point(119, 18)
        Me.btnCustPrevious.Name = "btnCustPrevious"
        Me.btnCustPrevious.Size = New System.Drawing.Size(82, 34)
        Me.btnCustPrevious.TabIndex = 19
        Me.btnCustPrevious.Text = "Previous"
        Me.btnCustPrevious.UseVisualStyleBackColor = True
        '
        'btnCustFirst
        '
        Me.btnCustFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustFirst.Location = New System.Drawing.Point(31, 18)
        Me.btnCustFirst.Name = "btnCustFirst"
        Me.btnCustFirst.Size = New System.Drawing.Size(82, 34)
        Me.btnCustFirst.TabIndex = 18
        Me.btnCustFirst.Text = "First"
        Me.btnCustFirst.UseVisualStyleBackColor = True
        '
        'btnCustExit
        '
        Me.btnCustExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustExit.Location = New System.Drawing.Point(476, 273)
        Me.btnCustExit.Name = "btnCustExit"
        Me.btnCustExit.Size = New System.Drawing.Size(82, 34)
        Me.btnCustExit.TabIndex = 17
        Me.btnCustExit.Text = "Exit"
        Me.btnCustExit.UseVisualStyleBackColor = True
        '
        'btnCustDelete
        '
        Me.btnCustDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustDelete.Location = New System.Drawing.Point(366, 273)
        Me.btnCustDelete.Name = "btnCustDelete"
        Me.btnCustDelete.Size = New System.Drawing.Size(82, 34)
        Me.btnCustDelete.TabIndex = 16
        Me.btnCustDelete.Text = "Delete"
        Me.btnCustDelete.UseVisualStyleBackColor = True
        '
        'btnCustEdit
        '
        Me.btnCustEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustEdit.Location = New System.Drawing.Point(256, 273)
        Me.btnCustEdit.Name = "btnCustEdit"
        Me.btnCustEdit.Size = New System.Drawing.Size(82, 34)
        Me.btnCustEdit.TabIndex = 15
        Me.btnCustEdit.Text = "Edit"
        Me.btnCustEdit.UseVisualStyleBackColor = True
        '
        'btnCustAdd
        '
        Me.btnCustAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustAdd.Location = New System.Drawing.Point(146, 273)
        Me.btnCustAdd.Name = "btnCustAdd"
        Me.btnCustAdd.Size = New System.Drawing.Size(82, 34)
        Me.btnCustAdd.TabIndex = 14
        Me.btnCustAdd.Text = "Add"
        Me.btnCustAdd.UseVisualStyleBackColor = True
        '
        'txtCustSearch
        '
        Me.txtCustSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustSearch.Location = New System.Drawing.Point(409, 18)
        Me.txtCustSearch.Name = "txtCustSearch"
        Me.txtCustSearch.Size = New System.Drawing.Size(253, 30)
        Me.txtCustSearch.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(210, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CUSTOMER TYPE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(456, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PHONE NO."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(585, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "MIDDLE I."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(345, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "LASTNAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(65, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CUSTOMER ID:"
        '
        'btnCSearch
        '
        Me.btnCSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCSearch.Location = New System.Drawing.Point(668, 14)
        Me.btnCSearch.Name = "btnCSearch"
        Me.btnCSearch.Size = New System.Drawing.Size(82, 34)
        Me.btnCSearch.TabIndex = 0
        Me.btnCSearch.Text = "Search"
        Me.btnCSearch.UseVisualStyleBackColor = True
        '
        'txtCustID
        '
        Me.txtCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustID.Location = New System.Drawing.Point(67, 105)
        Me.txtCustID.Multiline = True
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(133, 41)
        Me.txtCustID.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 40)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(174, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ohana Hardware Depot: Customer Data Entry"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel3.Controls.Add(Me.cboCustomerType)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtPhoneNo)
        Me.Panel3.Controls.Add(Me.txtMiddleI)
        Me.Panel3.Controls.Add(Me.txtLName)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtFname)
        Me.Panel3.Controls.Add(Me.btnCustLast)
        Me.Panel3.Controls.Add(Me.btnCustNext)
        Me.Panel3.Controls.Add(Me.btnCustPrevious)
        Me.Panel3.Controls.Add(Me.btnCustFirst)
        Me.Panel3.Controls.Add(Me.btnCustExit)
        Me.Panel3.Controls.Add(Me.btnCustDelete)
        Me.Panel3.Controls.Add(Me.btnCustEdit)
        Me.Panel3.Controls.Add(Me.btnCustAdd)
        Me.Panel3.Controls.Add(Me.txtCustSearch)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btnCSearch)
        Me.Panel3.Controls.Add(Me.txtCustID)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 435)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(781, 333)
        Me.Panel3.TabIndex = 5
        '
        'cboCustomerType
        '
        Me.cboCustomerType.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomerType.FormattingEnabled = True
        Me.cboCustomerType.Location = New System.Drawing.Point(213, 109)
        Me.cboCustomerType.Name = "cboCustomerType"
        Me.cboCustomerType.Size = New System.Drawing.Size(231, 37)
        Me.cboCustomerType.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvCustomer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 768)
        Me.Panel2.TabIndex = 4
        '
        'dgvCustomer
        '
        Me.dgvCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCustomer.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Location = New System.Drawing.Point(3, 46)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.Size = New System.Drawing.Size(775, 383)
        Me.dgvCustomer.TabIndex = 0
        '
        'frmCustomer
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(781, 768)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmCustomer"
        Me.Text = "FrmCustomer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents txtMiddleI As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents btnCustLast As Button
    Friend WithEvents btnCustNext As Button
    Friend WithEvents btnCustPrevious As Button
    Friend WithEvents btnCustFirst As Button
    Friend WithEvents btnCustExit As Button
    Friend WithEvents btnCustDelete As Button
    Friend WithEvents btnCustEdit As Button
    Friend WithEvents btnCustAdd As Button
    Friend WithEvents txtCustSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCSearch As Button
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvCustomer As DataGridView
    Friend WithEvents cboCustomerType As ComboBox
End Class
