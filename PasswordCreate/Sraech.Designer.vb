<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sraech
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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Exit_Btn = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(4, 4)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(862, 91)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(243, 23)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(436, 41)
        Label1.TabIndex = 0
        Label1.Text = "Students  Registration Details"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.ForeColor = Color.ForestGreen
        Label2.Location = New Point(12, 110)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 25)
        Label2.TabIndex = 2
        Label2.Text = "Enter Student Roll no. :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(236, 110)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(523, 31)
        TextBox1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(765, 102)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 46)
        Button1.TabIndex = 4
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 154)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(847, 357)
        DataGridView1.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaptionText
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(371, 517)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 42)
        Button2.TabIndex = 6
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Exit_Btn
        ' 
        Exit_Btn.BackColor = Color.Black
        Exit_Btn.ForeColor = Color.Red
        Exit_Btn.Location = New Point(537, 517)
        Exit_Btn.Name = "Exit_Btn"
        Exit_Btn.Size = New Size(94, 42)
        Exit_Btn.TabIndex = 7
        Exit_Btn.Text = "Exit"
        Exit_Btn.UseVisualStyleBackColor = False
        ' 
        ' Sraech
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(871, 562)
        Controls.Add(Exit_Btn)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Sraech"
        Text = "Sraech"
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
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Exit_Btn As Button
End Class
