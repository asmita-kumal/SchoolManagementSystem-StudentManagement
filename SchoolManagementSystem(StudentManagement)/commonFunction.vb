Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Module commonFunction
    Public Sub GoToNextTab(ByVal e As KeyEventArgs, ByVal form As ContainerControl)
        'ByVal panel As Control
        If (e.KeyCode = Keys.Enter) Then

            If (e.KeyCode = Keys.Enter) Then

                SendKeys.Send("{TAB}")

            End If
        End If
    End Sub

    Public Sub showconn()
        Try
            Dim conn As New SqlConnection("Data Source=DESKTOP-M655GHO\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Module


