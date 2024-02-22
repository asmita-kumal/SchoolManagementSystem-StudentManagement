<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeeTypeName
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
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Save = New Button()
        delete = New Button()
        exitbtn = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Gray
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(-2, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(436, 67)
        Label1.TabIndex = 2
        Label1.Text = "Fee Type Setup"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' addNew
        ' 
        addNew.BackColor = SystemColors.ActiveCaption
        addNew.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        addNew.Location = New Point(12, 15)
        addNew.Name = "addNew"
        addNew.Size = New Size(94, 42)
        addNew.TabIndex = 3
        addNew.Text = "Add New"
        addNew.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(45, 134)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(348, 228)
        DataGridView1.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(194, 89)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(199, 27)
        TextBox1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(45, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 25)
        Label2.TabIndex = 12
        Label2.Text = "Fee Name:"
        ' 
        ' Save
        ' 
        Save.BackColor = SystemColors.ActiveCaption
        Save.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Save.Location = New Point(45, 396)
        Save.Name = "Save"
        Save.Size = New Size(93, 42)
        Save.TabIndex = 13
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = False
        ' 
        ' delete
        ' 
        delete.BackColor = SystemColors.ActiveCaption
        delete.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        delete.Location = New Point(194, 396)
        delete.Name = "delete"
        delete.Size = New Size(82, 42)
        delete.TabIndex = 16
        delete.Text = "Delete"
        delete.UseVisualStyleBackColor = False
        ' 
        ' exitbtn
        ' 
        exitbtn.BackColor = SystemColors.ActiveCaption
        exitbtn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        exitbtn.Location = New Point(320, 396)
        exitbtn.Name = "exitbtn"
        exitbtn.Size = New Size(94, 42)
        exitbtn.TabIndex = 17
        exitbtn.Text = "Exit"
        exitbtn.UseVisualStyleBackColor = False
        ' 
        ' FeeTypeName
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(437, 450)
        Controls.Add(exitbtn)
        Controls.Add(delete)
        Controls.Add(Save)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(addNew)
        Controls.Add(Label1)
        Name = "FeeTypeName"
        Text = "FeeTypeName"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents addNew As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Save As Button
    Friend WithEvents delete As Button
    Friend WithEvents exitbtn As Button
End Class
