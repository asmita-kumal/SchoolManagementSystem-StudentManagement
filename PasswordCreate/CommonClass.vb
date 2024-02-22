Imports System.Data.SqlClient
Imports System.IO
'Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports System.Net
Imports System
Imports System.Threading.Tasks
Imports Microsoft.Win32
Imports System.IO.Compression

Public Class CommonClass


    Public Shared server As String = "DESKTOP-M655GHO\SQLEXPRESS"
    Public Shared Password As String = "12345"
    Public Shared UID As String = "asu"
    Public Shared Username As String = ""

    Public Shared UserType As String = ""

    Public Shared database As String = "project"
    Public Shared constr As String = "Data Source=" + server + ";Initial Catalog=" + database + ";UID=" + UID + ";Password=" + Password + ""
    Public Shared cn As New SqlConnection(constr)

    '  constr = "Data Source=" + server + ";Initial Catalog=" + database + ";UID=" + UID + ";Password=" + Password + ""
    'MessageBox.Show(constr)

    '   cn = New SqlConnection(constr)

    ' open connection of server
    Public Shared Sub cnopen()



        ' constr = "Data Source=" + server + ";Initial Catalog=" + database + ";UID=" + UID + ";Password=" + Password + ""
        'MessageBox.Show(constr)

        'cn = New SqlConnection(constr)


        Try

            If cn.State = 0 Then
                ' MsgBox(cn.State)
                cn.Open()
                '  MsgBox(cn.State)
                Return
            End If

            ' cn.Open()
            '  MessageBox.Show("Connection opened")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            ' Throw
        End Try



    End Sub

    Public Shared Sub cnclose()

        Try

            If cn.State = 1 Then
                ' MsgBox(cn.State)
                cn.Close()
                '  MsgBox(cn.State)
                Return
            End If

            ' cn.Open()
            '  MessageBox.Show("Connection opened")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            ' Throw
        End Try
    End Sub


    ' query execute to database
    Public Shared Sub query_execute(ByVal q As String)
        Dim transaction As SqlTransaction
        cnopen()


        Try
            transaction = cn.BeginTransaction()
            Dim cmd As SqlCommand = New SqlCommand(q, cn, transaction)
            cmd.ExecuteNonQuery()
            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show(ex.Message)
            Return
            Throw
        End Try
        cnclose()
    End Sub

    'load data from database
    Public Shared Function loaddata(ByVal q As String) As DataTable
        Dim dt As DataTable = New DataTable()

        Try
            cnopen()
            Dim cmd As SqlCommand = New SqlCommand(q, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            dt.Columns.Add("Server Error")
        End Try

        Return dt
    End Function

    '' Go to next tab when pressed enter
    Public Shared Sub GoToNextTab(ByVal e As KeyEventArgs, ByVal form As ContainerControl)
        'ByVal panel As Control
        If (e.KeyCode = Keys.Enter) Then

            If (e.KeyCode = Keys.Enter) Then

                SendKeys.Send("{TAB}")


            End If






        End If




    End Sub

    '' reset alll controls
    Public Shared Sub ResetAllControls(ByVal form As Control)
        For Each control As Control In form.Controls

            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = CType(control, TextBox)
                textBox.Text = Nothing
            End If

            If TypeOf control Is RichTextBox Then
                Dim richtextBox As RichTextBox = CType(control, RichTextBox)
                richtextBox.Text = Nothing
            End If

            If TypeOf control Is ComboBox Then
                Dim comboBox As ComboBox = CType(control, ComboBox)

                If comboBox.Items.Count > 0 Then
                    comboBox.SelectedIndex = 0
                End If
            End If

            If TypeOf control Is CheckBox Then
                Dim checkBox As CheckBox = CType(control, CheckBox)
                checkBox.Checked = False
            End If

            If TypeOf control Is ListBox Then
                Dim listBox As ListBox = CType(control, ListBox)
                listBox.ClearSelected()
            End If
        Next
    End Sub

    '' get data to combobox control
    Public Shared Sub comboboxsearch(ByVal qry As String, ByVal comboBox As ComboBox)
        Dim dt As DataTable = New DataTable()
        dt = loaddata(qry)

        For i As Integer = 0 To dt.Rows.Count - 1

            If Not comboBox.Items.Contains(dt.Rows(i)(0).ToString()) Then
                '   comboBox.Items.Clear()
                comboBox.Items.Insert(i, dt.Rows(i)(0).ToString())
            End If
        Next
    End Sub


    '' suggest data to textbox custom source

    Public Shared Sub textboxsuggest(ByVal qry As String, ByVal textbox As TextBox)
        Dim dt As DataTable = New DataTable()
        dt = loaddata(qry)
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            If Not textbox.AutoCompleteCustomSource.Contains(dt.Rows(i)(0).ToString()) Then
                '   comboBox.Items.Clear()
                'textbox.AutoCompleteCustomSource.Insert(i, dt.Rows(i)(0).ToString())

                '  Company_Name.Invoke(New EventHandler(Sub() Company_Name.Text = index.ToString()))
                textbox.Invoke(New EventHandler(Sub() textbox.AutoCompleteCustomSource.Insert(i, dt.Rows(i)(0).ToString())))
            End If

        Next
        'For i As Integer = 0 To dt.Rows.Count - 1

        '    If Not comboBox.Items.Contains(dt.Rows(i)(0).ToString()) Then
        '        '   comboBox.Items.Clear()
        '        comboBox.Items.Insert(i, dt.Rows(i)(0).ToString())
        '    End If
        'Next
    End Sub



    '' export datagridview data to excel

    'Public Shared Sub exportToexcel(ByVal dataGridView As DataGridView, ByVal header As String)
    '    If dataGridView.Rows.Count > 0 Then
    '        Dim xcelApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()
    '        xcelApp.Application.Workbooks.Add(Type.Missing)
    '        xcelApp.Rows(1).Font.Bold = True

    '        For i As Integer = 1 To dataGridView.Columns.Count + 1 - 1
    '            xcelApp.Cells(1, i) = dataGridView.Columns(i - 1).HeaderText
    '        Next

    '        For i As Integer = 0 To dataGridView.Rows.Count - 1

    '            For j As Integer = 0 To dataGridView.Columns.Count - 1
    '                xcelApp.Cells(i + 2, j + 1) = dataGridView.Rows(i).Cells(j).Value.ToString()
    '            Next
    '        Next

    '        xcelApp.Rows(1).Insert()
    '        xcelApp.Rows(1).Font.Bold = True
    '        xcelApp.Range(xcelApp.Cells(1, 1), xcelApp.Cells(1, dataGridView.Columns.Count)).Merge()
    '        xcelApp.Cells(1, 1) = header
    '        xcelApp.Rows(1).Cells(1).Font.Size = 20
    '        xcelApp.Columns.AutoFit()
    '        xcelApp.Cells(1, 1).Style.VerticalAlignment = HorizontalAlignment.Center
    '        xcelApp.Cells.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
    '        xcelApp.Visible = True
    '    End If
    'End Sub



    '' load datagridview column to combobox 
    Public Shared Sub DataGridViewColumnHeaderToComboBox(ByVal dataGridView As DataGridView, ByVal searchcombobox As ComboBox)

        Dim j As Integer
        Dim i As Integer = dataGridView.ColumnCount

        For j = 0 To i - 1

            If Not searchcombobox.Items.Contains(dataGridView.Columns(j).HeaderCell.Value) Then
                searchcombobox.Items.Add(dataGridView.Columns(j).HeaderCell.Value)
            End If
        Next


    End Sub

    Public Shared Sub RunAppOnStartUp(ByVal SetOrNot As Boolean)
        Dim rk As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        If (SetOrNot = True) Then
            rk.SetValue(Process.GetCurrentProcess().ProcessName.ToString, Application.ExecutablePath.ToString)
        Else
            rk.DeleteValue(Process.GetCurrentProcess().ProcessName, False)
        End If
    End Sub

    Public Shared Function CheckRunAppOnStartUp()

        If (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", Process.GetCurrentProcess().ProcessName, "") = Application.ExecutablePath) Then
            Return True
        End If
        Return False
    End Function

End Class