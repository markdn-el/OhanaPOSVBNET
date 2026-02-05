Imports System.Data.OleDb
Imports System.Data

Public Class frmCashiering
    Dim grandtotal As Double

    Public con As OleDbConnection
    Public com As OleDbCommand

    'To connect to my database
    Public Sub OLEdbconnect(ByVal strQuery As String)
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= IS_OHD.accdb")
        com = New OleDbCommand(strQuery, con)
        con.Open()
        com.ExecuteNonQuery()
        com = Nothing
        con.Close()
    End Sub

    'exit button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEndSession.Click
        Me.Close()
    End Sub

    'This is to search product in product table in database
    Private Sub txtpcode_KeyDOwn(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpcode.KeyDown
        Dim RsohdProduct As ADODB.Recordset

        If e.KeyCode = Keys.Return Then
            txtpdescription.Text = ""
            txtpprice.Text = ""

            Dim ohdpdescription As String
            Dim ohdprice As Double

            RsohdProduct = New ADODB.Recordset
            RsohdProduct.Open("select * from Product_Table where Pcode = '" & txtpcode.Text.Trim() & "'", dbConnection, 1, 2)

            If Not RsohdProduct.EOF Then
                RsohdProduct.MoveFirst()
                ohdpdescription = "" & RsohdProduct.Fields("Pdescription").Value
                ohdprice = "" & RsohdProduct.Fields("PPrice").Value
                txtpdescription.Text = ohdpdescription
                txtpprice.Text = ohdprice
                txtqty.Focus()
            Else
                MsgBox("Product Code not Found.")
                txtpcode.SelectAll()
            End If

            If RsohdProduct.State = 1 Then
                RsohdProduct.Close()
            End If

            RsohdProduct = Nothing
        End If
    End Sub

    'This is to search customer in customer table in database

    Private Sub txtcustID_KeyDOwn(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustID.KeyDown
        Dim RsohdCustomer As ADODB.Recordset

        If e.KeyCode = Keys.Return Then
            txtCustName.Text = ""

            Dim fullCustomerName As String
            RsohdCustomer = New ADODB.Recordset

            RsohdCustomer.Open("select * from Customer_Table where CustID = " & txtCustID.Text.Trim(), dbConnection, 1, 2)

            If Not RsohdCustomer.EOF Then
                RsohdCustomer.MoveFirst()

                Dim fName As String = "" & RsohdCustomer.Fields("Custfname").Value
                Dim lName As String = "" & RsohdCustomer.Fields("Custlname").Value
                Dim mInitial As String = "" & RsohdCustomer.Fields("CustInitial").Value

                fullCustomerName = lName & ", " & fName & " " & mInitial & "."
                txtCustName.Text = fullCustomerName
            Else
                MsgBox("Customer ID not Found.")
                txtCustID.SelectAll()
            End If

            If RsohdCustomer.State = 1 Then
                RsohdCustomer.Close()
            End If

            RsohdCustomer = Nothing
        End If
    End Sub

    'This is the first thing to load
    Private Sub frmCashiering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnect()
        generateReceiptNo()
    End Sub

    'ADD ITEM TO CART
    Private Sub cmdAddItem_Click(sender As Object, e As EventArgs) Handles cmdAddItem.Click

        If txtpcode.Text.Trim() = "" Then
            MsgBox("Please search for a product first.", MsgBoxStyle.Exclamation, "Missing Product")
            txtpcode.Focus()
            Exit Sub ' STOP THE CODE HERE
        End If

        ' Check if Quantity is empty or 0
        If Val(txtqty.Text) <= 0 Then
            MsgBox("Please enter a valid quantity.", MsgBoxStyle.Exclamation, "Invalid Quantity")
            txtqty.Focus()
            Exit Sub ' STOP THE CODE HERE
        End If



        Dim rsDummy As New ADODB.Recordset

        rsDummy.Open("select * from dummyTrans", dbConnection, 1, 2)
        rsDummy.AddNew()

        rsDummy.Fields("receiptno").Value = lblrno.Text
        rsDummy.Fields("transdate").Value = TransactionDate.Value
        rsDummy.Fields("custid").Value = Val(txtCustID.Text)
        rsDummy.Fields("pcode").Value = txtpcode.Text
        rsDummy.Fields("pdescription").Value = txtpdescription.Text
        rsDummy.Fields("pprice").Value = txtpprice.Text
        rsDummy.Fields("qty").Value = txtqty.Text
        rsDummy.Fields("lineamount").Value = txtpprice.Text * txtqty.Text
        grandtotal = grandtotal + (txtpprice.Text * txtqty.Text)
        txtamountrendered.Text = grandtotal
        rsDummy.Update()

        Dim dgvRow As New DataGridViewRow
        Dim dgvCell As DataGridViewCell
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = txtpcode.Text
        dgvRow.Cells.Add(dgvCell)
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = txtpdescription.Text
        dgvRow.Cells.Add(dgvCell)
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Format(Val(txtpprice.Text), "#,##0.00")
        dgvRow.Cells.Add(dgvCell)
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = txtqty.Text
        dgvRow.Cells.Add(dgvCell)
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Format((txtqty.Text * txtpprice.Text), "###,###.##")
        dgvRow.Cells.Add(dgvCell)
        dgvCashiering.Rows.Add(dgvRow)
    End Sub



    'AUTO GENERATE RECEIPT
    Private Sub generateReceiptNo()
        Dim rsReceipt As ADODB.Recordset
        Dim rno As String
        Dim lastSrno As String
        Dim lastNrno As Integer

        rsReceipt = New ADODB.Recordset
        rsReceipt.Open("select * from mastertrans", dbConnection, 1, 2)

        If rsReceipt.RecordCount <= 0 Then
            rno = "RC00001"
        Else
            rsReceipt.MoveLast()
            lastSrno = rsReceipt.Fields("receiptno").Value
            lastNrno = Val(Mid(lastSrno, 3, 5)) + 1
            rno = "RC" & Format(lastNrno, "00000")
        End If

        lblrno.Text = rno
        rsReceipt = Nothing
    End Sub

    'UPDATE PRODUCT INVENTORY
    Private Sub UpdateInventory()

        Dim rsCart As New ADODB.Recordset
        Dim rsProductCheck As ADODB.Recordset

        Dim currentPcode As String
        Dim soldQty As Double
        Dim currentStock As Double
        Dim reorderPoint As Double
        Dim newStock As Double
        Dim pName As String


        rsCart.Open("select * from dummyTrans", dbConnection, 1, 2)

        If Not rsCart.EOF Then
            rsCart.MoveFirst()

            Do While Not rsCart.EOF
                currentPcode = rsCart.Fields("Pcode").Value.ToString()
                soldQty = Val(rsCart.Fields("qty").Value)



                rsProductCheck = New ADODB.Recordset
                rsProductCheck.Open("select * from Product_Table where Pcode = '" & currentPcode & "'", dbConnection, 1, 2)

                If Not rsProductCheck.EOF Then

                    currentStock = Val(rsProductCheck.Fields("Pstock").Value)
                    reorderPoint = Val(rsProductCheck.Fields("ROP").Value)
                    pName = rsProductCheck.Fields("Pdescription").Value.ToString()


                    newStock = currentStock - soldQty


                    If newStock <= reorderPoint Then
                        MsgBox("CRITICAL STOCK ALERT!" & vbCrLf & vbCrLf &
                               "Product: " & pName & vbCrLf &
                               "Remaining Stock: " & newStock & vbCrLf &
                               "Reorder Point: " & reorderPoint,
                               MsgBoxStyle.Exclamation, "Inventory Warning")
                    End If


                    rsProductCheck.Fields("Pstock").Value = newStock
                    rsProductCheck.Update()
                End If


                rsProductCheck.Close()
                rsProductCheck = Nothing


                rsCart.MoveNext()
            Loop
        End If

        If rsCart.State = 1 Then rsCart.Close()
        rsCart = Nothing

    End Sub


    'SAVE TRANSACTION 
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim cash As Double = Val(txtCashTendered.Text)
        Dim change As Double = cash - grandtotal

        If cash < grandtotal Then
            MsgBox("Insufficient Cash!", MsgBoxStyle.Exclamation)
            txtCashTendered.Focus()
            Exit Sub
        End If

        Dim sqlCopy As String
        sqlCopy = "INSERT INTO MasterTrans ([ReceiptNo], [CustID], [Pcode], [Pdescription], [PPrice], [qty], [lineAmount], [TransDate]) " &
              "SELECT [ReceiptNo], [CustID], [Pcode], [Pdescription], [PPrice], [qty], [lineAmount], [TransDate] FROM dummyTrans"
        OLEdbconnect(sqlCopy)

        Dim sqlSummary As String
        sqlSummary = "INSERT INTO SalesSummary ([ReceiptNo], [CustID], [TotalAmount], [Cash], [Change], [TransactionDate]) VALUES (" &
                 "'" & lblrno.Text & "', " &
                 Val(txtCustID.Text) & ", " &
                 grandtotal & ", " &
                 cash & ", " &
                 change & ", " &
                 "'" & TransactionDate.Value & "')"
        OLEdbconnect(sqlSummary)

        UpdateInventory()

        Try
            Dim rsReceipt As New ADODB.Recordset
            rsReceipt.Open("select * from dummyTrans", dbConnection, 1, 2)

            Dim rptDoc As New GReceipt
            rptDoc.SetDataSource(rsReceipt)


            rptDoc.SetParameterValue("pCash", cash)
            rptDoc.SetParameterValue("pChange", change)
            rptDoc.SetParameterValue("pTotal", grandtotal)

            'If the name box is empty, print "Walk-in Customer"
            Dim nameToPrint As String = txtCustName.Text
            If nameToPrint.Trim() = "" Then
                nameToPrint = "Walk-in Customer"
            End If

            rptDoc.SetParameterValue("pCustomerName", nameToPrint)

            'SHOW REPORT
            Dim frmView As New frmProductView
            frmView.CrystalReportViewer1.ReportSource = rptDoc
            frmView.ShowDialog()
            frmView.Dispose()

            If rsReceipt.State = 1 Then rsReceipt.Close()
            rsReceipt = Nothing

        Catch ex As Exception
            MsgBox("Receipt printing failed: " & ex.Message)
        End Try

        OLEdbconnect("DELETE * FROM dummyTrans")
        dgvCashiering.Rows.Clear()

        txtpcode.Text = ""
        txtpdescription.Text = ""
        txtpprice.Text = ""
        txtqty.Text = ""
        txtamountrendered.Text = "0.00"
        grandtotal = 0
        txtCashTendered.Text = ""
        lblChangeDue.Text = "0.00"
        txtCustID.Text = ""
        txtCustName.Text = ""

        generateReceiptNo()
        MsgBox("Transaction Saved Successfully!")
    End Sub


    ' DELETE A SINGLE PRODUCT IN CART / TABLE
    Private Sub cmdLinevoid_Click(sender As Object, e As EventArgs) Handles cmdLinevoid.Click
        If dgvCashiering.SelectedRows.Count = 0 Then
            MsgBox("Please select an item to void.", MsgBoxStyle.Exclamation, "Void Error")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to void this item?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Void") = MsgBoxResult.Yes Then

            'Get Pcode for DB deletion
            Dim pcodeToRemove As String = dgvCashiering.SelectedRows(0).Cells(0).Value.ToString()

            ' 2. Remove from Database
            Dim deleteQuery As String = "DELETE FROM dummyTrans WHERE pcode = '" & pcodeToRemove & "' AND custID = '" & txtCustID.Text & "'"
            OLEdbconnect(deleteQuery)


            dgvCashiering.Rows.RemoveAt(dgvCashiering.SelectedRows(0).Index)

            RecomputeTotal()

            MsgBox("Item voided successfully.")
        End If
    End Sub

    'DELETE ALL PRODUCT IN CART
    Private Sub cmdVoidAll_Click(sender As Object, e As EventArgs) Handles cmdVoidAll.Click
        ' Safety Check: Don't void an empty cart
        If dgvCashiering.Rows.Count = 0 Then
            MsgBox("Transaction is already empty.", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Ask for strict confirmation
        If MsgBox("WARNING: This will cancel the entire transaction." & vbCrLf & "Are you sure you want to proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Void All") = MsgBoxResult.Yes Then

            ' Wipe the Database (dummyTrans)
            OLEdbconnect("DELETE * FROM dummyTrans")

            ' Wipe the Visual Grid
            dgvCashiering.Rows.Clear()

            ' FORCE RESET EVERYTHING TO ZERO
            '   
            grandtotal = 0
            txtamountrendered.Text = "0.00"

            ' Clear inputs
            txtpcode.Text = ""
            txtpdescription.Text = ""
            txtpprice.Text = ""
            txtqty.Text = ""

            ' Clear payment info
            txtCashTendered.Text = ""
            lblChangeDue.Text = "0.00"

            ' Reset Receipt Number
            generateReceiptNo()

            MsgBox("Transaction cancelled.", MsgBoxStyle.Information)
            txtpcode.Focus()
        End If
    End Sub

    Private Sub txtCashTendered_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCashTendered.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim cash As Double = Val(txtCashTendered.Text)
            Dim total As Double = grandtotal

            If cash < total Then
                MsgBox("Insufficient Cash! Amount is less than the total.", MsgBoxStyle.Exclamation)
                lblChangeDue.Text = "0.00"
                Exit Sub
            End If

            Dim change As Double = cash - total
            lblChangeDue.Text = Format(change, "#,##0.00")
            cmdSave.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdAddNewCust.Click
        Dim frm As New frmCustomer()
        frm.ShowDialog()
        txtCustID.Focus()
    End Sub

    Private Sub RecomputeTotal()
        Dim total As Double = 0
        Dim rowAmount As Double = 0

        ' Loop through every row in the grid
        For Each row As DataGridViewRow In dgvCashiering.Rows
            ' Get the value from the last column (Amount)

            If row.Cells(4).Value IsNot Nothing Then
                Dim amountText As String = row.Cells(4).Value.ToString().Replace(",", "")
                rowAmount = Val(amountText)
                total += rowAmount
            End If
        Next

        ' Update the global variable
        grandtotal = total

        ' Update the display
        txtamountrendered.Text = grandtotal.ToString("N2")

        ' Update change if needed
        If Val(txtCashTendered.Text) > 0 Then
            lblChange.Text = Format(Val(txtCashTendered.Text) - grandtotal, "#,##0.00")
        End If
    End Sub

    Private Sub txtqty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqty.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdAddItem.PerformClick()
        End If
    End Sub

End Class