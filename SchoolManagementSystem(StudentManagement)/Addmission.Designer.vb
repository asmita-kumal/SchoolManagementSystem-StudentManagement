<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Addmission
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        ComboBox4 = New ComboBox()
        Label13 = New Label()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Panel2 = New Panel()
        Label12 = New Label()
        TextBox6 = New TextBox()
        ComboBox3 = New ComboBox()
        Label11 = New Label()
        ComboBox2 = New ComboBox()
        Label10 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        MaskedTextBox1 = New MaskedTextBox()
        Label9 = New Label()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        MenuStrip1 = New MenuStrip()
        NewToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem1 = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        SearchToolStripMenuItem = New ToolStripMenuItem()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Panel1.Controls.Add(ComboBox4)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1222, 591)
        Panel1.TabIndex = 0
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(934, 14)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(163, 28)
        ComboBox4.TabIndex = 3
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.White
        Label13.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = SystemColors.ControlText
        Label13.Location = New Point(732, 15)
        Label13.Name = "Label13"
        Label13.Size = New Size(167, 29)
        Label13.TabIndex = 2
        Label13.Text = "Search by Class :-"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(661, 59)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(549, 517)
        DataGridView1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(175, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(303, 41)
        Label1.TabIndex = 0
        Label1.Text = "Student Addmission" & vbCrLf
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gainsboro
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(ComboBox3)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(ComboBox2)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(RadioButton3)
        Panel2.Controls.Add(RadioButton2)
        Panel2.Controls.Add(RadioButton1)
        Panel2.Controls.Add(MaskedTextBox1)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(7, 90)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(648, 520)
        Panel2.TabIndex = 1
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(74, 30)
        Label12.Name = "Label12"
        Label12.Size = New Size(102, 25)
        Label12.TabIndex = 25
        Label12.Text = "Roll No.  :-"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(243, 28)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(125, 27)
        TextBox6.TabIndex = 24
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"A", "B"})
        ComboBox3.Location = New Point(203, 185)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(134, 28)
        ComboBox3.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(68, 188)
        Label11.Name = "Label11"
        Label11.Size = New Size(85, 25)
        Label11.TabIndex = 22
        Label11.Text = "Section :"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Nepali", "English"})
        ComboBox2.Location = New Point(475, 131)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(377, 130)
        Label10.Name = "Label10"
        Label10.Size = New Size(92, 25)
        Label10.TabIndex = 20
        Label10.Text = "Medium :"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(349, 469)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 48)
        Button2.TabIndex = 19
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(184, 469)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 48)
        Button1.TabIndex = 18
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(253, 420)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(358, 27)
        TextBox5.TabIndex = 17
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(253, 373)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(358, 27)
        TextBox4.TabIndex = 16
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(253, 328)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(358, 27)
        TextBox3.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(253, 283)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(358, 27)
        TextBox2.TabIndex = 14
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButton3.Location = New Point(504, 242)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(84, 27)
        RadioButton3.TabIndex = 13
        RadioButton3.TabStop = True
        RadioButton3.Text = "Others"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButton2.Location = New Point(332, 242)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(93, 27)
        RadioButton2.TabIndex = 12
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female "
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButton1.Location = New Point(203, 242)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(75, 27)
        RadioButton1.TabIndex = 11
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male "
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        MaskedTextBox1.Location = New Point(524, 179)
        MaskedTextBox1.Mask = "00/00/0000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(102, 30)
        MaskedTextBox1.TabIndex = 10
        MaskedTextBox1.ValidatingType = GetType(Date)
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(68, 422)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 25)
        Label9.TabIndex = 9
        Label9.Text = "Phone no. :"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Nursery", "LKG", "Ukg", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"})
        ComboBox1.Location = New Point(213, 130)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(134, 28)
        ComboBox1.TabIndex = 8
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(243, 77)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(383, 27)
        TextBox1.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(68, 375)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 25)
        Label8.TabIndex = 6
        Label8.Text = "Address :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(68, 330)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 25)
        Label7.TabIndex = 5
        Label7.Text = "Mother's name :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(68, 285)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 25)
        Label6.TabIndex = 4
        Label6.Text = "Father's Name :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(68, 244)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 25)
        Label5.TabIndex = 3
        Label5.Text = "Gender :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(371, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 25)
        Label4.TabIndex = 2
        Label4.Text = "Date of birth :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(68, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 25)
        Label3.TabIndex = 1
        Label3.Text = "Choose class :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(73, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 0
        Label2.Text = "Student Name :"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {NewToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1222, 31)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem1, EditToolStripMenuItem, DeleteToolStripMenuItem, SearchToolStripMenuItem})
        NewToolStripMenuItem.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(52, 27)
        NewToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem1
        ' 
        NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        NewToolStripMenuItem1.Size = New Size(147, 28)
        NewToolStripMenuItem1.Text = "New"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(147, 28)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(147, 28)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' SearchToolStripMenuItem
        ' 
        SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        SearchToolStripMenuItem.Size = New Size(147, 28)
        SearchToolStripMenuItem.Text = "Search"
        ' 
        ' Addmission
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1222, 622)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Addmission"
        Text = "Addmission"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
