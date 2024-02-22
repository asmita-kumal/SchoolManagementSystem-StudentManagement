Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Medium
    Public Shared mode As String = "save"
    Public mid As Integer
    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Hide()
        Dashboard.Show()
    End Sub


    Private Sub Medium_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDVG()
    End Sub

    Public Sub ShowDVG()

        DataGridView1.DataSource = CommonClass.loaddata("select * from tblMediumsetup ")

        ' Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
        'conn.Open()
        'Dim classes As String = TextBox1.Text

        'Dim cmd As SqlCommand
        'Try

        'If (TextBox1.Text = "") Then
        'cmd = New SqlCommand("select * from tblMediumsetup)", conn)


        'End If



        'cmd.ExecuteNonQuery()
        'MessageBox.Show("Succesfully Save")
        'ShowDVG()
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Public Sub insert()

        CommonClass.query_execute("insert into tblMediumsetup values('" & TextBox1.Text & "')")
        Return
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
            conn.Open()
            Dim cmd As New SqlCommand("insert into tblMediumsetup values('" & TextBox1.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Succesfully Save")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If (mode = "save") Then
            insert()
        ElseIf (mode = "Mupdate") Then
            Mupdate()
        End If
        ShowDVG()
    End Sub

    Public Sub Mupdate()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            'Dim stmt As String = "UPDATE tblMediumsetup SET Section= '" + TextBox1.Text + "' where id=  '" + mid + "' "
            Dim stmt As String = "update tblMediumsetup set MediumName='" & TextBox1.Text & "' where Mid=" & mid

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


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells("MediumName").Value.ToString()
        mid = DataGridView1.Rows(e.RowIndex).Cells("Mid").Value.ToString()
        mode = "Mupdate"
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
            Dim con As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")

            Dim cmd As New SqlCommand("delete from tblMediumsetup where Mid="  & mid, con)
            cmd.Parameters.AddWithValue("Mid", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            ShowDVG()
        Next

        MessageBox.Show("succesfully deleted")
    End Sub


End Class