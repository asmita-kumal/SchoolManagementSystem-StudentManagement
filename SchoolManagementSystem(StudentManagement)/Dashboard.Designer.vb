<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        MenuStrip1 = New MenuStrip()
        MasterToolStripMenuItem = New ToolStripMenuItem()
        ClassTypeToolStripMenuItem = New ToolStripMenuItem()
        MediumToolStripMenuItem = New ToolStripMenuItem()
        SectionToolStripMenuItem = New ToolStripMenuItem()
        FeeTypeNameToolStripMenuItem = New ToolStripMenuItem()
        FeeSetupToolStripMenuItem = New ToolStripMenuItem()
        AddmissionRegistrationToolStripMenuItem = New ToolStripMenuItem()
        StudentRegistrationToolStripMenuItem = New ToolStripMenuItem()
        TeacherRegistrationToolStripMenuItem = New ToolStripMenuItem()
        NewAddmissionToolStripMenuItem = New ToolStripMenuItem()
        OldAddmissionToolStripMenuItem = New ToolStripMenuItem()
        ReportsToolStripMenuItem = New ToolStripMenuItem()
        SearchStudentToolStripMenuItem = New ToolStripMenuItem()
        FeesToolStripMenuItem = New ToolStripMenuItem()
        StudentFeesToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.LightSlateGray
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MasterToolStripMenuItem, AddmissionRegistrationToolStripMenuItem, ReportsToolStripMenuItem, FeesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.Size = New Size(1383, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MasterToolStripMenuItem
        ' 
        MasterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClassTypeToolStripMenuItem, MediumToolStripMenuItem, SectionToolStripMenuItem, FeeTypeNameToolStripMenuItem, FeeSetupToolStripMenuItem})
        MasterToolStripMenuItem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        MasterToolStripMenuItem.Size = New Size(85, 29)
        MasterToolStripMenuItem.Text = "Master"
        ' 
        ' ClassTypeToolStripMenuItem
        ' 
        ClassTypeToolStripMenuItem.Name = "ClassTypeToolStripMenuItem"
        ClassTypeToolStripMenuItem.Size = New Size(225, 30)
        ClassTypeToolStripMenuItem.Text = "Class type"
        ' 
        ' MediumToolStripMenuItem
        ' 
        MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        MediumToolStripMenuItem.Size = New Size(225, 30)
        MediumToolStripMenuItem.Text = "Medium"
        ' 
        ' SectionToolStripMenuItem
        ' 
        SectionToolStripMenuItem.Name = "SectionToolStripMenuItem"
        SectionToolStripMenuItem.Size = New Size(225, 30)
        SectionToolStripMenuItem.Text = "Section"
        ' 
        ' FeeTypeNameToolStripMenuItem
        ' 
        FeeTypeNameToolStripMenuItem.Name = "FeeTypeNameToolStripMenuItem"
        FeeTypeNameToolStripMenuItem.Size = New Size(225, 30)
        FeeTypeNameToolStripMenuItem.Text = "Fee Type name"
        ' 
        ' FeeSetupToolStripMenuItem
        ' 
        FeeSetupToolStripMenuItem.Name = "FeeSetupToolStripMenuItem"
        FeeSetupToolStripMenuItem.Size = New Size(225, 30)
        FeeSetupToolStripMenuItem.Text = "Fee Setup"
        ' 
        ' AddmissionRegistrationToolStripMenuItem
        ' 
        AddmissionRegistrationToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StudentRegistrationToolStripMenuItem, TeacherRegistrationToolStripMenuItem, NewAddmissionToolStripMenuItem, OldAddmissionToolStripMenuItem})
        AddmissionRegistrationToolStripMenuItem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        AddmissionRegistrationToolStripMenuItem.Name = "AddmissionRegistrationToolStripMenuItem"
        AddmissionRegistrationToolStripMenuItem.Size = New Size(237, 29)
        AddmissionRegistrationToolStripMenuItem.Text = "Addmission/Registration"
        ' 
        ' StudentRegistrationToolStripMenuItem
        ' 
        StudentRegistrationToolStripMenuItem.Name = "StudentRegistrationToolStripMenuItem"
        StudentRegistrationToolStripMenuItem.Size = New Size(274, 30)
        StudentRegistrationToolStripMenuItem.Text = "Student Registration"
        ' 
        ' TeacherRegistrationToolStripMenuItem
        ' 
        TeacherRegistrationToolStripMenuItem.Name = "TeacherRegistrationToolStripMenuItem"
        TeacherRegistrationToolStripMenuItem.Size = New Size(274, 30)
        TeacherRegistrationToolStripMenuItem.Text = "Teacher Registration"
        ' 
        ' NewAddmissionToolStripMenuItem
        ' 
        NewAddmissionToolStripMenuItem.Name = "NewAddmissionToolStripMenuItem"
        NewAddmissionToolStripMenuItem.Size = New Size(274, 30)
        NewAddmissionToolStripMenuItem.Text = "New Addmission"
        ' 
        ' OldAddmissionToolStripMenuItem
        ' 
        OldAddmissionToolStripMenuItem.Name = "OldAddmissionToolStripMenuItem"
        OldAddmissionToolStripMenuItem.Size = New Size(274, 30)
        OldAddmissionToolStripMenuItem.Text = "Old Addmission"
        ' 
        ' ReportsToolStripMenuItem
        ' 
        ReportsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SearchStudentToolStripMenuItem})
        ReportsToolStripMenuItem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        ReportsToolStripMenuItem.Size = New Size(98, 29)
        ReportsToolStripMenuItem.Text = "Reports "
        ' 
        ' SearchStudentToolStripMenuItem
        ' 
        SearchStudentToolStripMenuItem.Name = "SearchStudentToolStripMenuItem"
        SearchStudentToolStripMenuItem.Size = New Size(227, 30)
        SearchStudentToolStripMenuItem.Text = "Search Student"
        ' 
        ' FeesToolStripMenuItem
        ' 
        FeesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StudentFeesToolStripMenuItem})
        FeesToolStripMenuItem.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        FeesToolStripMenuItem.Name = "FeesToolStripMenuItem"
        FeesToolStripMenuItem.Size = New Size(63, 29)
        FeesToolStripMenuItem.Text = "Fees"
        ' 
        ' StudentFeesToolStripMenuItem
        ' 
        StudentFeesToolStripMenuItem.Name = "StudentFeesToolStripMenuItem"
        StudentFeesToolStripMenuItem.Size = New Size(207, 30)
        StudentFeesToolStripMenuItem.Text = "Student Fees"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1383, 709)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4)
        Name = "Dashboard"
        Text = "Dashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeeTypeNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeeSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddmissionRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewAddmissionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OldAddmissionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentFeesToolStripMenuItem As ToolStripMenuItem
End Class
