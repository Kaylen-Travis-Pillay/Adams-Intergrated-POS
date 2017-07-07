
Imports System.Net.Mail
Public Class Main_MDIForm

    Dim employee_type As Integer
    Dim employee_name As String
    Dim employee_type_STR As String
    Public employeeID As Integer

    Private Property Adams_POS_Neurosolutions As Form

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LOGOUT.Click
        Dim result = MessageBox.Show(" Are you sure you want to logout", "Are you sure?", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Public Sub FormSetUp(ByVal ChildForm As Form)
        Try
            If Not (ChildForm.Equals(Me.ActiveMdiChild)) Then
                Me.ActiveMdiChild.Close()
            End If
        Catch ex As Exception
        End Try
        With ChildForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub Main_MDIForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.Sleep(3000) 'Splash screen display time
        Me.WindowState = FormWindowState.Maximized
        FormSetUp(WelcomeScreen)
        btn_POS.Enabled = False
        btn_KITCHEN.Enabled = False
        btn_MANAGER.Enabled = False
        btn_CALLMANAGER.Enabled = False
    End Sub

    Private Sub btn_HELP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HELP.Click
        AboutBox1.Show()
    End Sub

    Private Sub btn_LOGIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LOGIN.Click
        FormSetUp(Login)
    End Sub

    Private Sub btn_POS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_POS.Click
        FormSetUp(POSForm)
    End Sub

    Private Sub btn_CALLMANAGER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CALLMANAGER.Click

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("neurosolutions.igp@gmail.com", "password123!")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("neurosolutions.igp@gmail.com")
            e_mail.To.Add("msmaphanga07@gmail.com")
            e_mail.Subject = employee_type_STR & " Assistance Required"
            e_mail.IsBodyHtml = False
            e_mail.Body = employee_name & " is in need of your assistance"
            Smtp_Server.Send(e_mail)
            MsgBox("Manager has been notified")

        Catch error_t As Exception
            MessageBox.Show("Please try connecting using different data source for sending this message")
            MsgBox(error_t.ToString)
        End Try

    End Sub

    Public Sub SetEmployeeName(ByVal e As String)
        employee_name = e
    End Sub

    Public Sub SetEmployeeType(ByVal e As Integer)
        employee_type = e
    End Sub

    Public Function GetEmployeeType() As Integer
        Return employee_type
    End Function

    Public Sub SetEmployeeTpeString(ByVal e As String)
        employee_type_STR = e
    End Sub

    Public Function GetEmployeeName() As String
        Return employee_name
    End Function

    Private Sub btn_MANAGER_Click(sender As System.Object, e As System.EventArgs) Handles btn_MANAGER.Click
        FormSetUp(Manager_Main)
    End Sub

    Private Sub btn_KITCHEN_Click(sender As System.Object, e As System.EventArgs) Handles btn_KITCHEN.Click
        FormSetUp(Chef)
    End Sub
End Class
