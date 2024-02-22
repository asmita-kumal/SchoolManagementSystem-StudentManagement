Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class TeacherRegistration
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Dim teacherName As String = tName.Text
            Dim fatherName As String = fName.Text
            Dim motherName As String = mName.Text
            Dim address As String = tAddress.Text
            Dim phone As Integer = tPhone.Text
            Dim dateofBirth As String = MaskedTextBox1.Text
            Dim subject As String = tSubject.Text
            Dim skill As String = tSkill.Text
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("insert into TeacherInfo values('" & teacherName & "','" & fatherName & "',
            '" & motherName & "','" & address & "','" & phone & "','" & dateofBirth & "','" & subject & "','" & skill & "')", conn)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Succesfully Save")
            getDVG()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TeacherRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TeacherName()
        getDVG()
    End Sub

    Public Sub TeacherName()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim cmd As New SqlCommand("select * from TeacherInfo", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            sda.Fill(dt)


            searchTeacher.ValueMember = "TeacherName"
            searchTeacher.DisplayMember = "TeacherName"
            searchTeacher.DataSource = dt
            conn.Close()
            searchTeacher.Text = "Please select TeacherName"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub getDVG()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False")
            conn.Open()
            Dim dt As DataTable = New DataTable()
            Dim cmd As New SqlCommand("select * from TeacherInfo ", conn)
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

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        tName.Clear()
        fName.Clear()
        mName.Clear()
        tAddress.Clear()
        tPhone.Clear()
        MaskedTextBox1.Clear()
        tSubject.Text = String.Empty
        tSkill.Clear()
        tName.Focus()
        getDVG()



    End Sub
End Class