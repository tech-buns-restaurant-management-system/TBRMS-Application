Public Class DBTestForm
    Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        NewTestRecordForm.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim updateQuery As String = "UPDATE TestTable SET TestName = '" + txtName.Text + "', TestAddress = '" + txtAddress.Text + "', TestCity = '" + txtCity.Text + "', TestState = '" + txtState.Text + "', TestZip = '" + txtZip.Text + "', TestPhoneNumber = '" + txtPhone.Text + "' WHERE Test_ID = '" + txtID.Text + "';"

        ExecuteQuery(updateQuery)

        MessageBox.Show("Record has been updated.")

        SelectTest()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim deleteQuery As String = "DELETE FROM TestTable WHERE Test_ID = '" + txtID.Text + "';"
        ExecuteQuery(deleteQuery)

        MessageBox.Show("Record has been deleted.")

        SelectTest()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        SelectTest()
    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlClient.SqlCommand(query, connection)
        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()
    End Sub

    Function SelectTest()
        txtID.Clear()
        txtName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()
        txtPhone.Clear()

        connection.Open()

        Dim strID() As String
        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "Select * from TestTable;"
        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("colID", "ID")
        DataGridView1.Columns.Add("colName", "Name")
        DataGridView1.Columns.Add("colAddress", "Address")
        DataGridView1.Columns.Add("colCity", "City")
        DataGridView1.Columns.Add("colState", "State")
        DataGridView1.Columns.Add("colZip", "Zip")
        DataGridView1.Columns.Add("colPhone", "Phone")


        While SQLReader.Read()
            DataGridView1.Rows.Add({SQLReader.Item("Test_ID"), SQLReader.Item("TestName"), SQLReader.Item("TestAddress"), SQLReader.Item("TestCity"), SQLReader.Item("TestState"), SQLReader.Item("TestZip"), SQLReader.Item("TestPhoneNumber")})
        End While

        connection.Close()
        DataGridView1.ClearSelection()
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        If (selectedRow.Cells(0).Value = Nothing) Then
            txtID.Clear()
            txtName.Clear()
            txtAddress.Clear()
            txtCity.Clear()
            txtState.Clear()
            txtZip.Clear()
            txtPhone.Clear()
        Else
            txtID.Text = selectedRow.Cells(0).Value.ToString.TrimEnd(" ")
            txtName.Text = selectedRow.Cells(1).Value.ToString.TrimEnd(" ")
            txtAddress.Text = selectedRow.Cells(2).Value.ToString.TrimEnd(" ")
            txtCity.Text = selectedRow.Cells(3).Value.ToString.TrimEnd(" ")
            txtState.Text = selectedRow.Cells(4).Value.ToString.TrimEnd(" ")
            txtZip.Text = selectedRow.Cells(5).Value.ToString.TrimEnd(" ")
            txtPhone.Text = selectedRow.Cells(6).Value.ToString.TrimEnd(" ")
        End If
    End Sub
End Class