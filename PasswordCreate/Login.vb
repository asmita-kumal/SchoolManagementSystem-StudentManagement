Imports System.Data.SqlClient

Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Username As String = TextBox1.Text
        Dim Password As String = TextBox2.Text
        Dim rd As SqlDataReader

        If (TextBox1.Text = "") Then
            MessageBox.Show("Enter the Username")
            TextBox1.Focus()
            Exit Sub
        End If

        If (TextBox2.Text = "") Then
            MessageBox.Show("Enter the Password")
            TextBox2.Focus()
            Exit Sub

        End If


        'Try


        'Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")

        'conn.Open()
        'Dim cmd As New SqlCommand("select * from loginRegister where  Username = '" & TextBox1.Text & "' and Password = '" & TextBox2.Text & "' ")


        '    rd = cmd.ExecuteReader()
        'If (rd.Read()) Then
        Dim qry As String = "select * from loginRegister where  Username = '" & TextBox1.Text & "' and Password = '" & TextBox2.Text & "' "
        If (CommonClass.loaddata(qry).Rows.Count >= 1) Then
            MessageBox.Show("Done")
            Dashboard.Show()
            Me.Hide()
            Return
        End If

        '  MessageBox.Show("Done")
        'Else

        MessageBox.Show("Enter valid  Username and  Password ")

        'End If

        'Catch ex As Exception

        'End Try

    End sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label3.Text = Date.Now.ToString("dd-MM-yyyy    hh: mm:ss")
    End Sub





    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Registration.ShowDialog()
    End Sub


    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyCode = Keys.Enter) Then

            SendKeys.Send("{TAB}")


        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If (e.KeyCode = Keys.Enter) Then

            SendKeys.Send("{TAB}")


        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
