<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LandingPad
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
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miHardware = New System.Windows.Forms.ToolStripMenuItem()
        Me.CameraListingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeRecordingTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeServerPropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirmwareUpgradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BitrateUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLQueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceRestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LPRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.miHardware, Me.SQLToolStripMenuItem, Me.SoftwareToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(1171, 24)
        Me.msMain.TabIndex = 1
        Me.msMain.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectionInfoToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ConnectionInfoToolStripMenuItem
        '
        Me.ConnectionInfoToolStripMenuItem.Name = "ConnectionInfoToolStripMenuItem"
        Me.ConnectionInfoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConnectionInfoToolStripMenuItem.Text = "Connection Info"
        '
        'miHardware
        '
        Me.miHardware.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CameraListingToolStripMenuItem, Me.ChangeRecordingTypeToolStripMenuItem, Me.ChangeServerPropertiesToolStripMenuItem, Me.FirmwareUpgradeToolStripMenuItem, Me.BitrateUpdateToolStripMenuItem})
        Me.miHardware.Name = "miHardware"
        Me.miHardware.Size = New System.Drawing.Size(65, 20)
        Me.miHardware.Text = "Cameras"
        '
        'CameraListingToolStripMenuItem
        '
        Me.CameraListingToolStripMenuItem.Name = "CameraListingToolStripMenuItem"
        Me.CameraListingToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.CameraListingToolStripMenuItem.Text = "Camera Listing"
        '
        'ChangeRecordingTypeToolStripMenuItem
        '
        Me.ChangeRecordingTypeToolStripMenuItem.Name = "ChangeRecordingTypeToolStripMenuItem"
        Me.ChangeRecordingTypeToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ChangeRecordingTypeToolStripMenuItem.Text = "Change Camera Properties"
        '
        'ChangeServerPropertiesToolStripMenuItem
        '
        Me.ChangeServerPropertiesToolStripMenuItem.Name = "ChangeServerPropertiesToolStripMenuItem"
        Me.ChangeServerPropertiesToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ChangeServerPropertiesToolStripMenuItem.Text = "Change Server Properties"
        '
        'FirmwareUpgradeToolStripMenuItem
        '
        Me.FirmwareUpgradeToolStripMenuItem.Name = "FirmwareUpgradeToolStripMenuItem"
        Me.FirmwareUpgradeToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.FirmwareUpgradeToolStripMenuItem.Text = "Firmware Upgrade"
        '
        'BitrateUpdateToolStripMenuItem
        '
        Me.BitrateUpdateToolStripMenuItem.Name = "BitrateUpdateToolStripMenuItem"
        Me.BitrateUpdateToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.BitrateUpdateToolStripMenuItem.Text = "Bitrate Update"
        '
        'SQLToolStripMenuItem
        '
        Me.SQLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SQLQueryToolStripMenuItem})
        Me.SQLToolStripMenuItem.Name = "SQLToolStripMenuItem"
        Me.SQLToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.SQLToolStripMenuItem.Text = "SQL"
        '
        'SQLQueryToolStripMenuItem
        '
        Me.SQLQueryToolStripMenuItem.Name = "SQLQueryToolStripMenuItem"
        Me.SQLQueryToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SQLQueryToolStripMenuItem.Text = "SQL Query"
        '
        'SoftwareToolStripMenuItem
        '
        Me.SoftwareToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServiceRestartToolStripMenuItem, Me.LPRToolStripMenuItem})
        Me.SoftwareToolStripMenuItem.Name = "SoftwareToolStripMenuItem"
        Me.SoftwareToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SoftwareToolStripMenuItem.Text = "Software"
        '
        'ServiceRestartToolStripMenuItem
        '
        Me.ServiceRestartToolStripMenuItem.Name = "ServiceRestartToolStripMenuItem"
        Me.ServiceRestartToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ServiceRestartToolStripMenuItem.Text = "Service Restart"
        '
        'LPRToolStripMenuItem
        '
        Me.LPRToolStripMenuItem.Name = "LPRToolStripMenuItem"
        Me.LPRToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LPRToolStripMenuItem.Text = "LPR"
        '
        'LandingPad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 588)
        Me.Controls.Add(Me.msMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msMain
        Me.Name = "LandingPad"
        Me.Text = "Camera Migration Tool"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msMain As MenuStrip
    Friend WithEvents miHardware As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectionInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CameraListingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeRecordingTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeServerPropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SQLQueryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoftwareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiceRestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FirmwareUpgradeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LPRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BitrateUpdateToolStripMenuItem As ToolStripMenuItem
End Class
