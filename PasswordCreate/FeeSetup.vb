Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FeeSetup


    Private Sub addNew_Click(sender As Object, e As EventArgs) Handles addNew.Click


        TextBox2.Clear()
        ComboBox1.Focus()
        ShowDVG()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        insert()
        ShowDVG()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
            Dim con As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")

            Dim cmd As New SqlCommand("delete from feeDetail where feid = @feid", con)
            cmd.Parameters.AddWithValue("feid", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
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

    Private Sub FeeSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetFee()
        getclass()
        ShowDVG()
    End Sub


    Public Sub ShowDVG()



        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("select * from feeDetail ", conn)
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
        Try

            Dim sclass As String = ComboBox1.Text
            Dim sname As String = ComboBox2.Text
            Dim amount As Double = TextBox2.Text
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("insert into feeDetail values('" & sclass & "','" & sname & "','" & amount & "')", conn)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Succesfully Save")
            ShowDVG()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Getclass()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("select * from classSetupMaster", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            sda.Fill(dt)


            ComboBox1.ValueMember = "className"
            ComboBox1.DisplayMember = "className"
            ComboBox1.DataSource = dt
            conn.Close()
            ComboBox2.Text = "Please select className"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub GetFee()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("select * from FeeTypeMaster", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            sda.Fill(dt)


            ComboBox2.ValueMember = "FeeName"
            ComboBox2.DisplayMember = "FeeName"
            ComboBox2.DataSource = dt
            conn.Close()
            ComboBox2.Text = "Please select FeeName"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class