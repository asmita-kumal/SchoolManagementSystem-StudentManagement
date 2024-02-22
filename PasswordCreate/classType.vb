Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button


Public Class classType

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
        conn.Open()
        Dim classes As String = TextBox1.Text

        Dim cmd As SqlCommand
        Try

            If (TextBox2.Text = "") Then
                cmd = New SqlCommand("insert into classSetupMaster values('" & classes & "')", conn)


            Else
                cmd = New SqlCommand("UPDATE  classSetupMaster SET className='" & classes & "' where id='" & TextBox2.Text & "'", conn)


            End If



            cmd.ExecuteNonQuery()
            MessageBox.Show("Succesfully Save")
            ShowDVG()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()

    End Sub




    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells("ClassName").Value.ToString()
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells("id").Value.ToString()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub classType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDVG()

        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Ascending)

    End Sub
    Public Sub ShowDVG()

        DataGridView1.DataSource = CommonClass.loaddata("select * from classSetupMaster ")

        'Try
        '    Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO;Initial Catalog=project;Integrated Security=True")
        '    conn.Open()
        '    Dim cmd As New SqlCommand("select * from classSetupMaster ", conn)
        '    Dim sda As New SqlDataAdapter(cmd)
        '    Dim dt As New DataTable()
        '    sda.Fill(dt)
        '    DataGridView1.DataSource = dt
        '    conn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try


    End Sub







End Class