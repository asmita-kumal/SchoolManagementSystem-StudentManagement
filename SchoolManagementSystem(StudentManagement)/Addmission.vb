Imports System.Data.SqlClient
Imports System.Net.NetworkInformation

Public Class Addmission
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim rollNo As Integer = TextBox6.Text
            Dim studenstudentName As String = TextBox1.Text
            Dim classes As String = ComboBox1.Text
            Dim medium As String = ComboBox2.Text
            Dim section As String = ComboBox3.Text
            Dim dateofBirth As String = MaskedTextBox1.Text
            Dim gender As String = ""
            If RadioButton1.Checked = True Then
                gender = "Male"
            ElseIf RadioButton2.Checked = True Then
                gender = "Female"
            Else
                gender = "Others"
            End If
            Dim fathersName As String = TextBox2.Text
            Dim mothersName As String = TextBox3.Text
            Dim address As String = TextBox4.Text
            Dim phoneNo As Integer = TextBox5.Text


            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("insert into newAddmission values('" & rollNo & "','" & studenstudentName & "','" & classes & "','" & medium & "','" & section & "',
         '" & dateofBirth & "','" & gender & "','" & fathersName & "','" & mothersName & "','" & address & "','" & phoneNo & "')", conn)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Succesfully Save")
            getDvgCls()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dashboard.Show()


    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        TextBox1.Text = String.Empty
        ComboBox1.Text = String.Empty
        MaskedTextBox1.Text = String.Empty
        Dim gender As String = ""
        If RadioButton1.Checked = True Then
            gender = "Male"
        ElseIf RadioButton2.Checked = True Then
            gender = "Female"
        Else
            gender = "Others"
        End If
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Me.Hide()
        Sraech.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub



    Private Sub Addmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getclass()
        getDvgCls()
    End Sub
    Public Sub getclass()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("select className from classSetupMaster", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            sda.Fill(dt)


            ComboBox1.ValueMember = "className"
            ComboBox1.DisplayMember = "className"
            ComboBox1.DataSource = dt
            conn.Close()
            ComboBox1.Text = "Please select ClassName"

            ComboBox4.ValueMember = "className"
            ComboBox4.DisplayMember = "className"
            ComboBox4.DataSource = dt
            conn.Close()
            ComboBox1.Text = "Please select ClassName"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub getDvgCls()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim dt As DataTable = New DataTable()
            Dim cmd As New SqlCommand("select * from newAddmission where class like '%" + ComboBox4.Text + "%'", conn)
            Dim sda As New SqlDataAdapter(cmd)
            sda.Fill(dt)
            DataGridView1.DataSource = dt

            '        da.Fill(ds, "result");  
            '        Return ds;  
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        getDvgCls()

    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells("Stu_Rollno").Value.ToString()
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells("studentName").Value.ToString()
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells("Class").Value.ToString()
        ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells("medium").Value.ToString()
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells("section").Value.ToString()
        MaskedTextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells("dateofBirth").Value.ToString()
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells("fathersName").Value.ToString()
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells("mothersName").Value.ToString()
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells("address").Value.ToString()
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells("phoneNo").Value.ToString()
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        GoToNextTab(e, Me)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        GoToNextTab(e, Me)
    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        GoToNextTab(e, Me)
    End Sub

    Private Sub ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox2.KeyDown
        GoToNextTab(e, Me)
    End Sub

    Private Sub ComboBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox3.KeyDown
        GoToNextTab(e, Me)
    End Sub
End Class