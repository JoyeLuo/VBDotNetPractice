Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentsTestDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.StudentsTestDataSet.Students)

    End Sub
End Class
