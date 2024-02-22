<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeeSetup
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
        addNew = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        Save = New Button()
        delete = New Button()
        exitbtn = New Button()
        ComboBox2 = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Gray
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(0, -3)
        Label1.Name = "Label1"
        Label1.Size = New Size(436, 67)
        Label1.TabIndex = 3
        Label1.Text = "Fee  Setup"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' addNew
        ' 
        addNew.BackColor = SystemColors.ActiveCaption
        addNew.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        addNew.Location = New Point(12, 12)
        addNew.Name = "addNew"
        addNew.Size = New Size(94, 42)
        addNew.TabIndex = 4
        addNew.Text = "Add New"
        addNew.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(25, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 25)
        Label2.TabIndex = 13
        Label2.Text = "Select Class :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(25, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 25)
        Label3.TabIndex = 14
        Label3.Text = "Fee Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(25, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 25)
        Label4.TabIndex = 15
        Label4.Text = "Amount(Rs) :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(58, 221)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(357, 188)
        DataGridView1.TabIndex = 16
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(170, 178)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(220, 27)
        TextBox2.TabIndex = 18
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(170, 92)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(194, 28)
        ComboBox1.TabIndex = 19
        ' 
        ' Save
        ' 
        Save.BackColor = SystemColors.ActiveCaption
        Save.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Save.Location = New Point(33, 431)
        Save.Name = "Save"
        Save.Size = New Size(93, 42)
        Save.TabIndex = 20
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = False
        ' 
        ' delete
        ' 
        delete.BackColor = SystemColors.ActiveCaption
        delete.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        delete.Location = New Point(180, 431)
        delete.Name = "delete"
        delete.Size = New Size(82, 42)
        delete.TabIndex = 21
        delete.Text = "Delete"
        delete.UseVisualStyleBackColor = False
        ' 
        ' exitbtn
        ' 
        exitbtn.BackColor = SystemColors.ActiveCaption
        exitbtn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        exitbtn.Location = New Point(311, 431)
        exitbtn.Name = "exitbtn"
        exitbtn.Size = New Size(94, 42)
        exitbtn.TabIndex = 22
        exitbtn.Text = "Exit"
        exitbtn.UseVisualStyleBackColor = False
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(170, 136)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(194, 28)
        ComboBox2.TabIndex = 23
        ' 
        ' FeeSetup
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(440, 497)
        Controls.Add(ComboBox2)
        Controls.Add(exitbtn)
        Controls.Add(delete)
        Controls.Add(Save)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(DataGridView1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(addNew)
        Controls.Add(Label1)
        Name = "FeeSetup"
        Text = "FeeSetup"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents addNew As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Save As Button
    Friend WithEvents delete As Button
    Friend WithEvents exitbtn As Button
    Friend WithEvents ComboBox2 As ComboBox
End Class
