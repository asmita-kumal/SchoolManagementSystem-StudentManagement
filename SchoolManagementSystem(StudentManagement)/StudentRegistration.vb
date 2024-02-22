Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class StudentRegistration
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim studenstudentName As String = TextBox1.Text
            Dim classes As String = ComboBox1.Text
            Dim medium As String = Me.medium.Text
            Dim section As String = Me.section.Text
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
            Dim cmd As New SqlCommand("insert into studentRegistration values('" & studenstudentName & "','" & classes & "','" & medium & "','" & section & "',
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

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        getDvgCls()
    End Sub

    Private Sub StudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getclass()
        getDvgCls()
        getSection()
        getmedium()
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
            Dim cmd As New SqlCommand("select * from studentRegistration where class like '%" + ComboBox4.Text + "%'", conn)
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

    Public Sub getSection()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("select * from tblSectionSetup", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            sda.Fill(dt)


            section.ValueMember = "Section"
            section.DisplayMember = "Section"
            section.DataSource = dt
            conn.Close()
            ComboBox1.Text = "Please select Section"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub getmedium()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("select * from tblMediumsetup", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            sda.Fill(dt)


            medium.ValueMember = "MediumName"
            medium.DisplayMember = "MediumName"
            medium.DataSource = dt
            conn.Close()
            ComboBox1.Text = "Please select Medium"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = String.Empty
        ComboBox1.Text = String.Empty
        medium.Text = String.Empty
        section.Text = String.Empty
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
        getDvgCls()
    End Sub


End Class