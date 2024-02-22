Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Registration
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click




        Dim UserName As String = TextBox1.Text
        Dim Full_name As String = TextBox2.Text
        Dim Password As String = TextBox3.Text
        Dim Gender As String = ""
        If RadioButton1.Checked = True Then
            Gender = "Male"

        ElseIf RadioButton2.Checked = True Then
            Gender = "Female"
        Else
            Gender = "Others"
        End If
        Dim Email As String = TextBox4.Text
        Dim Mobile As String = TextBox5.Text
        Dim Address As String = TextBox6.Text
        'Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO;Initial Catalog=project;Integrated Security=True")
        'conn.Open()
        'Dim cmd As New SqlCommand("insert into registrationEmp  values('" & UserName & "','" & Full_name & "','" & Password &
        '                          "','" & Gender & "','" & Email & "','" & Mobile & "','" & Address & "')", conn)
        'cmd.ExecuteNonQuery()
        'MessageBox.Show("Succesfully Save")
        CommonClass.query_execute("insert into loginRegister  values('" & UserName & "','" & Full_name & "','" & Password & "','" & Gender & "','" & Email & "','" & Mobile & "','" & Address & "')")
        MsgBox("Data saved")

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.Hide()
        Login.ShowDialog()

    End Sub





    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If (e.KeyCode = Keys.Enter) Then

            SendKeys.Send("{TAB}")


        End If
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        If (e.KeyCode = Keys.Enter) Then

            SendKeys.Send("{TAB}")


        End If
    End Sub

    Private Sub button1_KeyDown(sender As Object, e As KeyEventArgs) Handles button1.KeyDown
        If (e.KeyCode = Keys.Enter) Then

            SendKeys.Send("{TAB}")


        End If
    End Sub
    Private Sub GoToNextTabKeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown, TextBox1.KeyDown, TextBox3.KeyDown, TextBox4.KeyDown, MyBase.KeyDown

        GoToNextTab(e, Me)



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class