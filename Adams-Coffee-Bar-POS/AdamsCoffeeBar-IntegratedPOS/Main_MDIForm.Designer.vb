<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_MDIForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_MDIForm))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btn_LOGIN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_POS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_KITCHEN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_MANAGER = New System.Windows.Forms.ToolStripButton()
        Me.btn_LOGOUT = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_HELP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_CALLMANAGER = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_CURRENTSTATUS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_LOGGINAS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        resources.ApplyResources(Me.ToolStrip2, "ToolStrip2")
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_LOGIN, Me.ToolStripSeparator1, Me.btn_POS, Me.ToolStripSeparator2, Me.btn_KITCHEN, Me.ToolStripSeparator3, Me.btn_MANAGER, Me.btn_LOGOUT, Me.ToolStripSeparator4, Me.btn_HELP, Me.ToolStripSeparator5, Me.btn_CALLMANAGER})
        Me.ToolStrip2.Name = "ToolStrip2"
        '
        'btn_LOGIN
        '
        resources.ApplyResources(Me.btn_LOGIN, "btn_LOGIN")
        Me.btn_LOGIN.AutoToolTip = False
        Me.btn_LOGIN.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_LOGIN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_LOGIN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_LOGIN.Name = "btn_LOGIN"
        Me.btn_LOGIN.Padding = New System.Windows.Forms.Padding(10, 10, 200, 200)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'btn_POS
        '
        Me.btn_POS.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_POS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_POS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.btn_POS, "btn_POS")
        Me.btn_POS.Name = "btn_POS"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'btn_KITCHEN
        '
        Me.btn_KITCHEN.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_KITCHEN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_KITCHEN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.btn_KITCHEN, "btn_KITCHEN")
        Me.btn_KITCHEN.Name = "btn_KITCHEN"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'btn_MANAGER
        '
        Me.btn_MANAGER.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_MANAGER.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_MANAGER.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.btn_MANAGER, "btn_MANAGER")
        Me.btn_MANAGER.Name = "btn_MANAGER"
        '
        'btn_LOGOUT
        '
        Me.btn_LOGOUT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_LOGOUT.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_LOGOUT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_LOGOUT.ForeColor = System.Drawing.Color.Maroon
        resources.ApplyResources(Me.btn_LOGOUT, "btn_LOGOUT")
        Me.btn_LOGOUT.Name = "btn_LOGOUT"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'btn_HELP
        '
        Me.btn_HELP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_HELP.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_HELP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_HELP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.btn_HELP, "btn_HELP")
        Me.btn_HELP.Name = "btn_HELP"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        '
        'btn_CALLMANAGER
        '
        Me.btn_CALLMANAGER.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_CALLMANAGER.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_CALLMANAGER.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_CALLMANAGER.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.btn_CALLMANAGER, "btn_CALLMANAGER")
        Me.btn_CALLMANAGER.Name = "btn_CALLMANAGER"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1, Me.lbl_CURRENTSTATUS, Me.ToolStripStatusLabel3, Me.lbl_LOGGINAS})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        resources.ApplyResources(Me.ToolStripProgressBar1, "ToolStripProgressBar1")
        '
        'lbl_CURRENTSTATUS
        '
        Me.lbl_CURRENTSTATUS.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_CURRENTSTATUS.Name = "lbl_CURRENTSTATUS"
        resources.ApplyResources(Me.lbl_CURRENTSTATUS, "lbl_CURRENTSTATUS")
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        resources.ApplyResources(Me.ToolStripStatusLabel3, "ToolStripStatusLabel3")
        '
        'lbl_LOGGINAS
        '
        Me.lbl_LOGGINAS.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_LOGGINAS.Name = "lbl_LOGGINAS"
        resources.ApplyResources(Me.lbl_LOGGINAS, "lbl_LOGGINAS")
        '
        'Main_MDIForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IsMdiContainer = True
        Me.Name = "Main_MDIForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_LOGIN As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_POS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_KITCHEN As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_MANAGER As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_HELP As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_LOGOUT As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_CURRENTSTATUS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_LOGGINAS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_CALLMANAGER As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator

End Class
