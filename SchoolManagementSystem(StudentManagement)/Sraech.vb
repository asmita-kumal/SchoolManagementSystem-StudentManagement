Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.Logging

Public Class Sraech


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim studentid As String = TextBox1.Text
        Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
        conn.Open()
        Dim dt As DataTable = New DataTable()
        Dim cmd As New SqlCommand("select * from newAddmission where studentName like '%" + TextBox1.Text + "%'", conn)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

        '        da.Fill(ds, "result");  
        '        Return ds;  
        cmd.ExecuteNonQuery()
        MessageBox.Show("done")


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim searchQuery As String = "SELECT * From newAddmission  WHERE id like '%" & TextBox1.Text & "%'"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
            Dim con As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")

            Dim cmd As New SqlCommand("delete from newAddmission where id = @id", con)
            cmd.Parameters.AddWithValue("id", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Next

        MessageBox.Show("succesfully deleted")
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Exit_Btn.Click
        Me.Hide()
        Dashboard.Show()

    End Sub
End Class