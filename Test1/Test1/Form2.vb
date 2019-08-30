Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\StudentsTest.accdb"
        Dim dbConnection As OleDb.OleDbConnection = TestDbSession.GetConnection(connString)
        Dim sql = "select [Last Name] from Students"
        Dim dataTable As DataTable = TestDbSession.GetDataTable(dbConnection, sql)

        DataGridView1.DataSource = dataTable
    End Sub
End Class