<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Section
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
        Panel1 = New Panel()
        btnAddNew = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        btn_Save = New Button()
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        delete = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleTurquoise
        Panel1.Controls.Add(btnAddNew)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(446, 56)
        Panel1.TabIndex = 0
        ' 
        ' btnAddNew
        ' 
        btnAddNew.BackColor = SystemColors.ActiveCaption
        btnAddNew.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddNew.Location = New Point(3, 11)
        btnAddNew.Name = "btnAddNew"
        btnAddNew.Size = New Size(94, 42)
        btnAddNew.TabIndex = 2
        btnAddNew.Text = "Add New"
        btnAddNew.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(184, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 38)
        Label1.TabIndex = 0
        Label1.Text = "Section Setup"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(46, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 25)
        Label2.TabIndex = 3
        Label2.Text = "Section:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(154, 79)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(247, 27)
        TextBox1.TabIndex = 4
        ' 
        ' btn_Save
        ' 
        btn_Save.BackColor = SystemColors.ActiveCaption
        btn_Save.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btn_Save.Location = New Point(46, 373)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(93, 42)
        btn_Save.TabIndex = 7
        btn_Save.Text = "Save"
        btn_Save.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(289, 373)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 42)
        Button3.TabIndex = 8
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(35, 130)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(401, 210)
        DataGridView1.TabIndex = 5
        ' 
        ' delete
        ' 
        delete.BackColor = SystemColors.ActiveCaption
        delete.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        delete.Location = New Point(165, 373)
        delete.Name = "delete"
        delete.Size = New Size(82, 42)
        delete.TabIndex = 9
        delete.Text = "Delete"
        delete.UseVisualStyleBackColor = False
        ' 
        ' Section
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(448, 427)
        Controls.Add(delete)
        Controls.Add(Button3)
        Controls.Add(btn_Save)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "Section"
        Text = "Section"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents delete As Button
End Class
