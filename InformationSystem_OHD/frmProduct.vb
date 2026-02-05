Imports System.Data.OleDb
Imports System.Data

Public Class frmProduct
    Private isNewMode As Boolean = False
    Private isEditMode As Boolean = False


    Private Sub ProductDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbconnect()
        rsProduct = New ADODB.Recordset
        rsProduct.Open("select * from Product_Table order by pcode", dbConnection, 1, 2)


        dgvProduct.ReadOnly = True

        clearEntries()
        rsProduct.MoveFirst()
        displayProduct()


        disable_entry(True)

        refreshDGV()

    End Sub

    Public Sub clearEntries()
        txtPcode.Text = ""
        txtPdescription.Text = ""
        txtPPrice.Text = ""
        txtStock.Text = ""
        txtROP.Text = ""
        txtCategory.Text = ""
        txtPsearch.Text = ""

    End Sub


    Public Sub disable_entry(ByVal stat As Boolean)
        txtPcode.ReadOnly = stat
        txtPdescription.ReadOnly = stat
        txtPPrice.ReadOnly = stat
        txtStock.ReadOnly = stat
        txtROP.ReadOnly = stat
        txtCategory.ReadOnly = stat

    End Sub

    Public Sub displayProduct()
        txtPcode.Text = rsProduct.Fields("pcode").Value
        txtPdescription.Text = rsProduct.Fields("pdescription").Value
        txtPPrice.Text = rsProduct.Fields("Pprice").Value
        txtStock.Text = rsProduct.Fields("Pstock").Value
        txtROP.Text = rsProduct.Fields("ROP").Value
        txtCategory.Text = rsProduct.Fields("Category").Value


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        rsProduct.MoveLast()
        displayProduct()
        SelectRowInGrid(txtPcode.Text)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        rsProduct.MoveNext()
        If rsProduct.EOF Then
            MsgBox("Record out of bound: Last reached...", MsgBoxStyle.Exclamation, "Warning")
            rsProduct.Close()
            rsProduct.Open("select * from Product_Table order by pcode", dbConnection, 1, 2)
            rsProduct.MoveLast()
        End If
        displayProduct()
        SelectRowInGrid(txtPcode.Text)
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        rsProduct.MoveFirst()
        displayProduct()
        SelectRowInGrid(txtPcode.Text)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        rsProduct.MovePrevious()
        If rsProduct.BOF Then
            MsgBox("Record out of bound: First reached...", MsgBoxStyle.Exclamation, "Warning")
            rsProduct.Close()
            rsProduct.Open("select * from Product_Table order by pcode", dbConnection, 1, 2)
            rsProduct.MoveFirst()
        End If
        displayProduct()
        SelectRowInGrid(txtPcode.Text)
    End Sub

    Public Sub disable_buttons(ByVal stat As Boolean)
        'disable buttons 
        btnNew.Enabled = Not stat
        btnEdit.Enabled = Not stat
        btnDelete.Enabled = Not stat
        BtnPsearch.Enabled = Not stat
        btnFirst.Enabled = Not stat
        btnPrevious.Enabled = Not stat
        btnNext.Enabled = Not stat
        btnLast.Enabled = Not stat
        dgvProduct.Enabled = Not stat
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If btnExit.Text = "&Cancel" Then
            ' --- USER CLICKED "CANCEL" ---

            ' Reset the state
            isNewMode = False

            ' (You may need to add btnEdit.Text = "&Edit" logic back if you use it)
            btnNew.Text = "&New"
            btnExit.Text = "&Exit"

            ' Lock textboxes and unlock buttons
            disable_entry(True)
            disable_buttons(False)

            ' Reload the last known good record
            rsProduct.MoveLast()
            displayProduct()

        Else
            ' --- USER CLICKED "EXIT" ---
            Me.Close()
        End If


    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If isNewMode = False Then
            ' --- ENTERING "NEW MODE" ---
            isNewMode = True ' Turn on "New" mode

            clearEntries()
            disable_entry(False) ' Unlock textboxes
            disable_buttons(True) ' Lock other buttons

            ' Change button text
            btnNew.Enabled = True
            btnNew.Text = "&Save"
            btnExit.Text = "&Cancel"

            txtPcode.Focus()

        Else


            ' VALIDATION: Check if pcode is empty
            If txtPcode.Text.Trim() = "" Then
                MsgBox("Product Code cannot be empty. Please enter a code.", MsgBoxStyle.Exclamation, "Input Error")
                txtPcode.Focus()
                Exit Sub ' Stop the sub! Don't save.
            End If

            ' All checks passed, OK to save
            rsProduct.AddNew()
            rsProduct.Fields("pcode").Value = txtPcode.Text
            rsProduct.Fields("pdescription").Value = txtPdescription.Text
            rsProduct.Fields("category").Value = txtCategory.Text
            rsProduct.Fields("pprice").Value = Val(txtPPrice.Text)
            rsProduct.Fields("stock").Value = Val(txtStock.Text)
            rsProduct.Fields("ROP").Value = Val(txtROP.Text)
            rsProduct.Update()

            MsgBox("New Product has been saved...", MsgBoxStyle.Information, "New Product")

            If rsProduct.State = 1 Then
                rsProduct.Close()
            End If
            rsProduct.Open("select * from Product_Table order by pcode", dbConnection, 1, 2) '

            rsProduct.Find("pcode = '" & txtPcode.Text & "'")

            If Not rsProduct.EOF Then
                displayProduct()
            Else
                ' Fallback just in case
                rsProduct.MoveFirst()
                displayProduct()
            End If



            ' Reset the form
            isNewMode = False       ' Turn off "New" mode
            disable_entry(True)     ' Lock textboxes
            disable_buttons(False)  ' Unlock other buttons
            btnNew.Text = "&New"
            btnExit.Text = "&Exit"

            dgvProduct.Refresh()
            refreshDGV()

        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'If btnEdit.Text = "&Edit" Then
        '    disable_entry(False)
        '    disable_buttons(True)
        '    txtPcode.ReadOnly = True
        '    txtPdescription.Focus()
        '    btnEdit.Enabled = True
        '    btnEdit.Text = "&Update"
        '    btnExit.Text = "&Cancel"
        'Else
        '    rsProduct.Fields("pcode").Value = txtPcode.Text
        '    rsProduct.Fields("pdescription").Value = txtPdescription.Text
        '    rsProduct.Fields("category").Value = txtCategory.Text
        '    rsProduct.Fields("pprice").Value = Val(txtPPrice.Text)
        '    rsProduct.Fields("stock").Value = Val(txtStock.Text)
        '    rsProduct.Fields("ROP").Value = Val(txtROP.Text)
        '    rsProduct.Update()
        '    disable_entry(True)
        '    disable_buttons(False)
        '    MsgBox("Records has been modified...", MsgBoxStyle.Information, "Update Product")
        '    btnEdit.Text = "&Edit"
        '    btnExit.Text = "&Exit"



        '    refreshDGV()

        'End If

        If isEditMode = False Then
            ' --- ENTERING "NEW MODE" ---
            isEditMode = True ' Turn on "New" mode


            disable_entry(False) ' Unlock textboxes
            txtPcode.Enabled = False
            disable_buttons(True) ' Lock other buttons

            ' Change button text
            btnEdit.Enabled = True
            btnEdit.Text = "&Update"
            btnExit.Text = "&Cancel"

            txtPdescription.Focus()

        Else


            ' VALIDATION: Check if pcode is empty
            If txtPdescription.Text.Trim() = "" OrElse
            txtPPrice.Text.Trim() = "" OrElse
            txtStock.Text.Trim() = "" OrElse
            txtROP.Text.Trim() = "" OrElse
            txtCategory.Text.Trim() = "" Then

                MsgBox("These fields cannot be empty. Please enter data.", MsgBoxStyle.Exclamation, "Input Error")
                txtPdescription.Focus()
                Exit Sub ' Stop the sub! Don't save.
            End If
            ' All checks passed, OK to save


            rsProduct.Fields("pdescription").Value = txtPdescription.Text
            rsProduct.Fields("category").Value = txtCategory.Text
            rsProduct.Fields("pprice").Value = Val(txtPPrice.Text)
            rsProduct.Fields("stock").Value = Val(txtStock.Text)
            rsProduct.Fields("ROP").Value = Val(txtROP.Text)

            Dim currentPcode As String = txtPcode.Text

            rsProduct.Update()

            MsgBox("Updated Product has been saved...", MsgBoxStyle.Information, "Updated Product")

            If rsProduct.State = 1 Then
                rsProduct.Close()
            End If

            rsProduct.Open("select * from product_table order by pcode", dbConnection, 1, 2)

            rsProduct.Find("pcode = '" & currentPcode & "'")

            If Not rsProduct.EOF Then
                displayProduct()
            Else
                ' Fallback just in case, go to the first record
                rsProduct.MoveFirst()
                displayProduct()
            End If



            ' Reset the form
            isEditMode = False       ' Turn off "Edit" mode
            disable_entry(True)     ' Lock textboxes
            disable_buttons(False)  ' Unlock other buttons
            btnEdit.Text = "&Edit"
            btnExit.Text = "&Exit"

            dgvProduct.Refresh()
            refreshDGV()

        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        rsProduct.Delete()
        rsProduct.Update()
        MsgBox("Product: [" & txtPcode.Text & "] " & txtPdescription.Text & " has been deleted",
MsgBoxStyle.Information, "Deletion of Record")

        If rsProduct.State = 1 Then
            rsProduct.Close()
        End If
        rsProduct.Open("select * from product order by pcode", dbConnection, 1, 2)

        If rsProduct.RecordCount > 0 Then
            rsProduct.MoveFirst()
            displayProduct()

        Else
            clearEntries()
        End If


        dgvProduct.Refresh()
        refreshDGV()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearEntries()
        rsProduct.Close()
        rsProduct.Open("select * from Product_Table order by pcode", dbConnection, 1, 2) '
        refreshDGV()
        disable_entry(False)
        disable_buttons(False)

    End Sub

    Public Sub refreshDGV()
        Try
            Dim dt As New DataTable()
            Dim adapter As New OleDbDataAdapter("Select * from Product_Table order by pcode", dbConnection.ConnectionString)

            adapter.Fill(dt)
            dgvProduct.DataSource = dt
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Catch ex As Exception
            dgvProduct.DataSource = Nothing


        End Try
    End Sub

    Private Sub dgvProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellClick

        ' 1. Make sure the user clicked a real row, not the header
        If e.RowIndex >= 0 Then

            rsProduct.Close()
            rsProduct.Open("select * from Product_Table order by pcode", dbConnection, 1, 2)


            ' 2. Safely get the "pcode" value
            Dim pcodeCell As Object = dgvProduct.Rows(e.RowIndex).Cells("pcode").Value

            ' 3. Check if the cell is empty (null) before trying to read it
            If pcodeCell IsNot Nothing Then

                Dim pcodeToFind As String = pcodeCell.ToString()

                ' 4. Find the record in your recordset
                rsProduct.Find("pcode = '" & pcodeToFind & "'")

                ' 5. Display if found
                If Not rsProduct.EOF Then
                    displayProduct()
                Else
                    MsgBox("Could not find the selected record in the recordset.", MsgBoxStyle.Exclamation)



                End If
            End If
        End If
    End Sub






    Private Sub BtnPsearch_Click(sender As Object, e As EventArgs) Handles BtnPsearch.Click

        Dim safeSearch As String = txtPsearch.Text.Replace("'", "''")

        If String.IsNullOrEmpty(safeSearch) Then
            MsgBox("Please enter a product code to search. ")
            Return
        End If

        Try
            Dim sqlQuery As String
            sqlQuery = "select * from Product_Table where pcode = '" & safeSearch & "'"

            Dim rsSearch As ADODB.Recordset
            rsSearch = New ADODB.Recordset
            rsSearch.Open(sqlQuery, dbConnection, 1, 2)




            If rsSearch.RecordCount > 0 Then
                If rsProduct.State = 1 Then rsProduct.Close()

                rsProduct.Open(sqlQuery, dbConnection, 1, 2)
                SelectRowInGrid(txtPsearch.Text)
                rsProduct.MoveFirst()
                displayProduct()
                disable_buttons(False)




            Else

                MsgBox("Product Code not Found. ", MsgBoxStyle.Exclamation, "No Match")
                clearEntries()

                disable_buttons(True)
                btnNew.Enabled = True
                BtnPsearch.Enabled = True

            End If



        Catch ex As Exception
            MsgBox("An error occured during the search: " & ex.Message, MsgBoxStyle.Critical, "Search Failed")
            disable_buttons(True)
            btnNew.Enabled = True
            BtnPsearch.Enabled = True
        End Try

    End Sub

    Private Sub SelectRowInGrid(ByVal PcodetoFind As String)
        dgvProduct.ClearSelection()

        For Each row As DataGridViewRow In dgvProduct.Rows


            If row.Cells("pcode").Value IsNot Nothing AndAlso
               row.Cells("pcode").Value.ToString().Trim() = PcodetoFind.Trim() Then


                row.Selected = True

                dgvProduct.FirstDisplayedScrollingRowIndex = row.Index

                Exit For
            End If
        Next
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub dgvProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick

    End Sub
End Class
