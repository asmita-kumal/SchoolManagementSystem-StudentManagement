Imports System.Data.SqlClient
Imports System.Object

Public Class OldAddmission

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dashboard.Show()

    End Sub



    Private Sub OldAddmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getRoll()
        getclass()
        getsection()
    End Sub
    Public Sub getRoll()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("select * from newAddmission", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            sda.Fill(dt)
            ComboBox1.ValueMember = "Stu_Rollno"
            ComboBox1.DisplayMember = "Stu_Rollno"
            ComboBox1.DataSource = dt
            conn.Close()
            ComboBox1.Text = "Please select rollNo"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub getclass()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("select * from newAddmission", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            sda.Fill(dt)
            oldClass.ValueMember = "Class"
            oldClass.DisplayMember = "Class"
            oldClass.DataSource = dt
            conn.Close()
            ComboBox1.Text = "Please select Class"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub getsection()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("select * from newAddmission", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            sda.Fill(dt)
            oldSection.ValueMember = "section"
            oldSection.DisplayMember = "section"
            oldSection.DataSource = dt
            conn.Close()
            ComboBox1.Text = "Please select section"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        ShowDVG()

    End Sub

    Public Sub ShowDVG()

        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("select id,Stu_Rollno,studentName,Class,section  from newAddmission where Stu_Rollno = '" & ComboBox1.Text & "'", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            sda.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        oldClass.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        oldSection.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = String.Empty
        oldClass.Text = String.Empty
        oldSection.Text = String.Empty
        newRoll.Text = String.Empty
        NewClass.Text = String.Empty
        NewSection.Text = String.Empty
    End Sub
End Class