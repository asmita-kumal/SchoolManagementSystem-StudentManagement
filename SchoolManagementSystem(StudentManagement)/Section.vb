Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement



Public Class Section
    Public Shared mode As String = "save"
    Public mid As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDVG()

        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Ascending)

    End Sub

    Public Sub ShowDVG()

        DataGridView1.DataSource = CommonClass.loaddata("select * from tblSectionSetup ")

        ' Try
        'Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO;Initial Catalog=project;Integrated Security=True")
        'conn.Open()
        'Dim cmd As New SqlCommand("select * from tblSectionSetup ", conn)
        'Dim sda As New SqlDataAdapter(cmd)
        'Dim dt As New DataTable()
        'sda.Fill(dt)
        'DataGridView1.DataSource = dt
        'conn.Close()
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try


    End Sub


    Public Sub save()
        CommonClass.query_execute("insert into tblSectionSetup values('" & TextBox1.Text & "')")
        Return
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
            conn.Open()
            Dim cmd As New SqlCommand("insert into tblSectionSetup values('" & TextBox1.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Succesfully Save")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Save.Click

        If (mode = "save") Then
            save()
        ElseIf (mode = "update") Then
            update()
        End If
        ShowDVG()

    End Sub

    Public Sub update()

        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            'Dim stmt As String = "UPDATE tblSectionSetup SET Section= '" + TextBox1.Text + "' where id=  '" + mid + "' "
            Dim stmt As String = "update tblSectionSetup set Section='" & TextBox1.Text & "' where id=" & mid

            Dim cmd As New SqlCommand(stmt, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Succesfully updated")

            ShowDVG()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        mode = "save"
        TextBox1.Clear()
        TextBox1.Focus()
        ShowDVG()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells("Section").Value.ToString()
        mid = DataGridView1.Rows(e.RowIndex).Cells("id").Value.ToString()
        mode = "update"

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        mode = "update()"
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click

        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
            Dim con As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")

            Dim cmd As New SqlCommand("delete from tblSectionSetup where id = @id", con)
            cmd.Parameters.AddWithValue("id", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            ShowDVG()
        Next

        MessageBox.Show("succesfully deleted")
    End Sub







End Class