<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class classType
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        Save = New Button()
        Button3 = New Button()
        TextBox2 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Gray
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(467, 67)
        Label1.TabIndex = 0
        Label1.Text = "New Class Setup"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 42)
        Button1.TabIndex = 1
        Button1.Text = "Add New"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(41, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 25)
        Label2.TabIndex = 2
        Label2.Text = "Class Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(197, 97)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(260, 27)
        TextBox1.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(41, 141)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(393, 210)
        DataGridView1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.ForeColor = SystemColors.ControlText
        Label3.ImageAlign = ContentAlignment.MiddleRight
        Label3.Location = New Point(3, 397)
        Label3.Name = "Label3"
        Label3.Size = New Size(531, 54)
        Label3.TabIndex = 5
        Label3.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Save
        ' 
        Save.BackColor = SystemColors.ActiveCaption
        Save.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Save.Location = New Point(80, 409)
        Save.Name = "Save"
        Save.Size = New Size(93, 42)
        Save.TabIndex = 6
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(324, 409)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 42)
        Button3.TabIndex = 7
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 69)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(86, 27)
        TextBox2.TabIndex = 9
        ' 
        ' classType
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(470, 450)
        Controls.Add(TextBox2)
        Controls.Add(Button3)
        Controls.Add(Save)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "classType"
        Text = "classType"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Save As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
End Class
