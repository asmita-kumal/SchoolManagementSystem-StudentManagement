Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FeeTypeName

    Public Shared mode As String = "save"
    Public Shared id As Integer

    Private Sub FeeTypeName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDVG()
    End Sub

    Public Sub ShowDVG()

        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("select * from FeeTypeMaster ", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            sda.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub insert()
        CommonClass.query_execute("insert into FeeTypeMaster values('" & TextBox1.Text & "')")
        Return
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
            conn.Open()
            Dim cmd As New SqlCommand("insert into FeeTypeMaster values('" & TextBox1.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Succesfully Save")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If (mode = "save") Then
            insert()
        Else
            Fupdate()
        End If
        ShowDVG()
    End Sub

    Public Sub Fupdate()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()

            Dim stmt As String = "update FeeTypeMaster set FeeName='" & TextBox1.Text & "' where fid=" & id

            Dim cmd As New SqlCommand(stmt, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Succesfully updated")

            ShowDVG()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub addNew_Click(sender As Object, e As EventArgs) Handles addNew.Click
        TextBox1.Clear()
        TextBox1.Focus()
        ShowDVG()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
            Dim con As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")

            Dim cmd As New SqlCommand("delete from FeeTypeMaster where fid = @fid", con)
            cmd.Parameters.AddWithValue("fid", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            ShowDVG()
        Next

        MessageBox.Show("succesfully deleted")
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Hide()
        Dashboard.Show()
    End Sub







    Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells("FeeName").Value.ToString()
        id = DataGridView1.Rows(e.RowIndex).Cells("fid").Value.ToString()
        mode = "Fupdate"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class