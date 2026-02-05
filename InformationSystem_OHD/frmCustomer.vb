Imports System.Data.OleDb
Imports System.Data

Public Class frmCustomer
    Private isNewMode As Boolean = False
    Private isEditMode As Boolean = False
    Private rsCustomer As ADODB.Recordset
    Public con As OleDbConnection
    Public com As OleDbCommand

    Public Sub OLEdbconnect(ByVal strQuery As String)
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= IS_OHD.accdb")
        com = New OleDbCommand(strQuery, con)
        con.Open()
        com.ExecuteNonQuery()
        com = Nothing
        con.Close()
    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnect()

        cboCustomerType.Items.Clear()
        cboCustomerType.Items.Add("Walk-in Customer")
        cboCustomerType.Items.Add("Retail Buyer")
        cboCustomerType.Items.Add("Wholesale Buyer")
        cboCustomerType.Items.Add("Contractor")
        cboCustomerType.Items.Add("Corporate Account")
        cboCustomerType.Items.Add("Government Agency")
        cboCustomerType.Items.Add("Repeat Customer")
        cboCustomerType.Items.Add("New Customer")
        cboCustomerType.SelectedIndex = 0

        rsCustomer = New ADODB.Recordset
        rsCustomer.Open("select * from Customer_Table order by CustID", dbConnection, 1, 2)

        dgvCustomer.ReadOnly = True

        clearEntries()

        If rsCustomer.RecordCount > 0 Then
            rsCustomer.MoveFirst()
            displayCustomer()
        End If

        disable_entry(True)
        refreshDGV()
    End Sub

    Public Sub clearEntries()
        txtCustID.Text = ""
        cboCustomerType.Text = ""
        txtPhoneNo.Text = ""
        txtFname.Text = ""
        txtLName.Text = ""
        txtMiddleI.Text = ""
    End Sub

    Public Sub disable_entry(ByVal stat As Boolean)
        txtCustID.ReadOnly = True ' Always read-only for autonumber
        cboCustomerType.Enabled = Not stat
        txtPhoneNo.ReadOnly = stat
        txtFname.ReadOnly = stat
        txtLName.ReadOnly = stat
        txtMiddleI.ReadOnly = stat
    End Sub

    Public Sub displayCustomer()
        txtCustID.Text = rsCustomer.Fields("CustID").Value
        cboCustomerType.Text = rsCustomer.Fields("CusType").Value
        txtPhoneNo.Text = rsCustomer.Fields("PhoneNo").Value
        txtFname.Text = rsCustomer.Fields("Custfname").Value
        txtLName.Text = rsCustomer.Fields("Custlname").Value
        txtMiddleI.Text = rsCustomer.Fields("CustInitial").Value
    End Sub

    Private Sub btnCustLast_Click(sender As Object, e As EventArgs) Handles btnCustLast.Click
        If rsCustomer.EOF Then
            MsgBox("Record out of bound: Last reached...", MsgBoxStyle.Exclamation, "Warning")
            rsCustomer.Close()
            rsCustomer.Open("select * from Customer_Table order by CustID", dbConnection, 1, 2)
            rsCustomer.MoveLast()
        End If
        rsCustomer.MoveLast()
        displayCustomer()
        SelectRowInGrid(txtCustID.Text)
    End Sub

    Private Sub btnCustNext_Click(sender As Object, e As EventArgs) Handles btnCustNext.Click
        rsCustomer.MoveNext()
        If rsCustomer.EOF Then
            MsgBox("Record out of bound: Last reached...", MsgBoxStyle.Exclamation, "Warning")
            rsCustomer.Close()
            rsCustomer.Open("select * from Customer_Table order by CustID", dbConnection, 1, 2)
            rsCustomer.MoveLast()
        End If
        displayCustomer()
        SelectRowInGrid(txtCustID.Text)
    End Sub

    Private Sub btnCustFirst_Click(sender As Object, e As EventArgs) Handles btnCustFirst.Click
        If rsCustomer.EOF Then
            MsgBox("Record out of bound: Last reached...", MsgBoxStyle.Exclamation, "Warning")
            rsCustomer.Close()
            rsCustomer.Open("select * from Customer_Table order by CustID", dbConnection, 1, 2)
            rsCustomer.MoveFirst()
        End If
        rsCustomer.MoveFirst()
        displayCustomer()
        SelectRowInGrid(txtCustID.Text)
    End Sub

    Private Sub btnCustPrevious_Click(sender As Object, e As EventArgs) Handles btnCustPrevious.Click
        rsCustomer.MovePrevious()
        If rsCustomer.EOF Then
            MsgBox("Record out of bound: Last reached...", MsgBoxStyle.Exclamation, "Warning")
            rsCustomer.Close()
            rsCustomer.Open("select * from Customer_Table order by CustID", dbConnection, 1, 2)
            rsCustomer.MoveFirst()
        End If
        displayCustomer()
        SelectRowInGrid(txtCustID.Text)
    End Sub

    Public Sub disable_buttons(ByVal stat As Boolean)
        btnCustAdd.Enabled = Not stat
        btnCustEdit.Enabled = Not stat
        btnCustDelete.Enabled = Not stat
        btnCSearch.Enabled = Not stat
        btnCustFirst.Enabled = Not stat
        btnCustPrevious.Enabled = Not stat
        btnCustNext.Enabled = Not stat
        btnCustLast.Enabled = Not stat
        dgvCustomer.Enabled = Not stat
    End Sub

    Private Sub btnCustExit_Click(sender As Object, e As EventArgs) Handles btnCustExit.Click
        If btnCustExit.Text = "&Cancel" Then
            isNewMode = False
            isEditMode = False

            btnCustAdd.Text = "&New"
            btnCustEdit.Text = "&Edit"
            btnCustExit.Text = "&Exit"

            disable_entry(True)
            disable_buttons(False)

            If rsCustomer.RecordCount > 0 Then
                rsCustomer.MoveLast()
                displayCustomer()
            Else
                clearEntries()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnCustAdd_Click(sender As Object, e As EventArgs) Handles btnCustAdd.Click
        If isNewMode = False Then
            isNewMode = True

            clearEntries()
            disable_entry(False)
            disable_buttons(True)

            btnCustAdd.Enabled = True
            btnCustAdd.Text = "&Save"
            btnCustExit.Text = "&Cancel"

            cboCustomerType.Focus()
        Else
            ' VALIDATION: Check for first/last name instead of CustID
            If txtFname.Text.Trim() = "" OrElse txtLName.Text.Trim() = "" Then
                MsgBox("First Name and Last Name cannot be empty.", MsgBoxStyle.Exclamation, "Input Error")
                txtFname.Focus()
                Exit Sub
            End If

            rsCustomer.AddNew()
            ' DO NOT set CustID, it's an autonumber
            rsCustomer.Fields("CusType").Value = cboCustomerType.Text
            rsCustomer.Fields("PhoneNo").Value = txtPhoneNo.Text
            rsCustomer.Fields("Custfname").Value = txtFname.Text
            rsCustomer.Fields("Custlname").Value = txtLName.Text
            rsCustomer.Fields("CustInitial").Value = txtMiddleI.Text
            rsCustomer.Update()

            ' Get the new autonumber ID *after* updating
            Dim newCustID As String = rsCustomer.Fields("CustID").Value.ToString()

            MsgBox("New Customer has been saved...", MsgBoxStyle.Information, "New Customer")

            If rsCustomer.State = 1 Then
                rsCustomer.Close()
            End If
            rsCustomer.Open("select * from Customer_Table order by CustID", dbConnection, 1, 2)

            rsCustomer.Find("CustID = '" & newCustID & "'") ' Find using the new ID

            If Not rsCustomer.EOF Then
                displayCustomer()
            Else
                rsCustomer.MoveFirst()
                displayCustomer()
            End If

            isNewMode = False
            disable_entry(True)
            disable_buttons(False)
            btnCustAdd.Text = "&New"
            btnCustExit.Text = "&Exit"

            dgvCustomer.Refresh()
            refreshDGV()
        End If
    End Sub

    Private Sub btnCustEdit_Click(sender As Object, e As EventArgs) Handles btnCustEdit.Click
        If isEditMode = False Then
            isEditMode = True

            disable_entry(False)
            ' txtCustID.Enabled = False ' This is no longer needed, disable_entry handles it
            disable_buttons(True)

            btnCustEdit.Enabled = True
            btnCustEdit.Text = "&Update"
            btnCustExit.Text = "&Cancel"

            txtFname.Focus()
        Else
            If txtFname.Text.Trim() = "" OrElse txtLName.Text.Trim() = "" Then
                MsgBox("First and Last Name fields cannot be empty. Please enter data.", MsgBoxStyle.Exclamation, "Input Error")
                txtFname.Focus()
                Exit Sub
            End If

            rsCustomer.Fields("CusType").Value = cboCustomerType.Text
            rsCustomer.Fields("PhoneNo").Value = txtPhoneNo.Text
            rsCustomer.Fields("Custfname").Value = txtFname.Text
            rsCustomer.Fields("Custlname").Value = txtLName.Text
            rsCustomer.Fields("CustInitial").Value = txtMiddleI.Text

            Dim currentCustID As String = txtCustID.Text

            rsCustomer.Update()

            MsgBox("Updated Customer has been saved...", MsgBoxStyle.Information, "Updated Customer")

            If rsCustomer.State = 1 Then
                rsCustomer.Close()
            End If

            rsCustomer.Open("select * from Customer_Table order by CustID", dbConnection, 1, 2)
            rsCustomer.Find("CustID = '" & currentCustID & "'")

            If Not rsCustomer.EOF Then
                displayCustomer()
            Else
                rsCustomer.MoveFirst()
                displayCustomer()
            End If

            isEditMode = False
            disable_entry(True)
            disable_buttons(False)
            btnCustEdit.Text = "&Edit"
            btnCustExit.Text = "&Exit"

            dgvCustomer.Refresh()
            refreshDGV()
        End If
    End Sub

    Private Sub btnCustDelete_Click(sender As Object, e As EventArgs) Handles btnCustDelete.Click
        rsCustomer.Delete()
        rsCustomer.Update()
        MsgBox("Customer: [" & txtCustID.Text & "] " & txtFname.Text & " has been deleted",
MsgBoxStyle.Information, "Deletion of Record")

        If rsCustomer.State = 1 Then
            rsCustomer.Close()
        End If
        rsCustomer.Open("select * from Customer_Table order by CustID", dbConnection, 1, 2)

        If rsCustomer.RecordCount > 0 Then
            rsCustomer.MoveFirst()
            displayCustomer()

        Else
            clearEntries()
        End If


        dgvCustomer.Refresh()
        refreshDGV()


    End Sub

    Public Sub refreshDGV()
        Try
            Dim dt As New DataTable()
            Dim adapter As New OleDbDataAdapter("Select * from Customer_Table order by CustID", dbConnection.ConnectionString)

            adapter.Fill(dt)
            dgvCustomer.DataSource = dt

            ' --- Set friendly column header names ---
            If dgvCustomer.Columns.Contains("CustID") Then
                dgvCustomer.Columns("CustID").HeaderText = "Customer ID"
            End If
            If dgvCustomer.Columns.Contains("CusType") Then
                dgvCustomer.Columns("CusType").HeaderText = "Customer Type"
            End If
            If dgvCustomer.Columns.Contains("PhoneNo") Then
                dgvCustomer.Columns("PhoneNo").HeaderText = "Phone Number"
            End If
            If dgvCustomer.Columns.Contains("Custfname") Then
                dgvCustomer.Columns("Custfname").HeaderText = "First Name"
            End If
            If dgvCustomer.Columns.Contains("Custlname") Then
                dgvCustomer.Columns("Custlname").HeaderText = "Last Name"
            End If
            If dgvCustomer.Columns.Contains("CustInitial") Then
                dgvCustomer.Columns("CustInitial").HeaderText = "Middle Initial"
            End If
            ' --- End of header name changes ---

            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            dgvCustomer.DataSource = Nothing
        End Try
    End Sub

    Private Sub dgvCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellClick
        If e.RowIndex >= 0 Then

            Dim custIDCell As Object = dgvCustomer.Rows(e.RowIndex).Cells("CustID").Value

            ' Check if the cell is empty or null (like clicking the new blank row)
            If custIDCell Is Nothing OrElse custIDCell Is DBNull.Value Then
                Return ' Ignore the click
            End If

            Dim custIDToFind As String = custIDCell.ToString()
            Dim custIDValue As Integer

            ' Try to parse the ID. If it's not a valid number, exit.
            If Integer.TryParse(custIDToFind, custIDValue) Then
                ' It's a valid number, proceed.
                If rsCustomer.State = 1 Then
                    rsCustomer.Close()
                End If
                rsCustomer.Open("select * from Customer_Table order by CustID", dbConnection, 1, 2)

                ' Find using a NUMBER (no single quotes)
                rsCustomer.Find("CustID = " & custIDValue)

                If Not rsCustomer.EOF Then
                    displayCustomer()
                Else
                    MsgBox("Could not find the selected record in the recordset.", MsgBoxStyle.Exclamation)
                End If
            Else
                ' Not a valid number, ignore
                Return
            End If
        End If
    End Sub

    Private Sub btnCSearch_Click(sender As Object, e As EventArgs) Handles btnCSearch.Click
        ' Dim safeSearch As String = txtCustSearch.Text.Replace("'", "''")
        Dim searchID As Integer

        If String.IsNullOrEmpty(txtCustSearch.Text) Then
            MsgBox("Please enter a customer ID to search.")
            Return
        End If

        ' Validate that the input is a number
        If Not Integer.TryParse(txtCustSearch.Text, searchID) Then
            MsgBox("Invalid Customer ID. Please enter a number.", MsgBoxStyle.Exclamation, "Input Error")
            txtCustSearch.Focus()
            Return
        End If

        Try
            Dim sqlQuery As String
            ' Use the numeric searchID in the query (no single quotes)
            sqlQuery = "select * from Customer_Table where CustID = " & searchID

            Dim rsSearch As ADODB.Recordset
            rsSearch = New ADODB.Recordset
            rsSearch.Open(sqlQuery, dbConnection, 1, 2)

            If rsSearch.RecordCount > 0 Then
                If rsCustomer.State = 1 Then rsCustomer.Close()

                rsCustomer.Open(sqlQuery, dbConnection, 1, 2)
                rsCustomer.MoveFirst()
                displayCustomer()
                disable_buttons(False)

                SelectRowInGrid(txtCustSearch.Text)
            Else
                MsgBox("Customer ID not Found.", MsgBoxStyle.Exclamation, "No Match")
                clearEntries()

                disable_buttons(True)
                btnCustAdd.Enabled = True
                btnCSearch.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("An error occurred during the search: " & ex.Message, MsgBoxStyle.Critical, "Search Failed")
            disable_buttons(True)
            btnCustAdd.Enabled = True
            btnCSearch.Enabled = True
        End Try
    End Sub

    Private Sub SelectRowInGrid(ByVal CustIDtoFind As String)
        dgvCustomer.ClearSelection()

        For Each row As DataGridViewRow In dgvCustomer.Rows
            If row.Cells("CustID").Value IsNot Nothing AndAlso
               row.Cells("CustID").Value.ToString().Trim() = CustIDtoFind.Trim() Then

                row.Selected = True
                dgvCustomer.FirstDisplayedScrollingRowIndex = row.Index
                Exit For
            End If
        Next
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class