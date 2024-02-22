Public Class Dashboard
    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClassTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassTypeToolStripMenuItem.Click
        Dim frm = New classType
        Me.IsMdiContainer = True

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub MediumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumToolStripMenuItem.Click

        Dim frm = New Medium
        Me.IsMdiContainer = True

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub StudentRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentRegistrationToolStripMenuItem.Click
        Dim frm = New StudentRegistration
        Me.IsMdiContainer = True

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Show()

    End Sub

    Private Sub SectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionToolStripMenuItem.Click

        Dim frm = New Section
        Me.IsMdiContainer = True

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub FeeTypeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeeTypeNameToolStripMenuItem.Click
        Dim frm = New FeeTypeName
        Me.IsMdiContainer = True

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub AddmissionRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddmissionRegistrationToolStripMenuItem.Click
        Dim frm = New Addmission
        Me.IsMdiContainer = True

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub MasterToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click

    End Sub

    Private Sub FeeSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeeSetupToolStripMenuItem.Click
        Dim frm = New FeeSetup
        Me.IsMdiContainer = True

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub TeacherRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherRegistrationToolStripMenuItem.Click
        Dim frm = New TeacherRegistration
        Me.IsMdiContainer = True

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub NewAddmissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewAddmissionToolStripMenuItem.Click
        Dim frm = New Addmission
        Me.IsMdiContainer = True

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub SearchStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchStudentToolStripMenuItem.Click
        Dim frm = New Sraech
        Me.IsMdiContainer = True

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class