<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CameraProperties
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cbxCamServer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxRecType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFps = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxCapRes = New System.Windows.Forms.ComboBox()
        Me.btnRecType = New System.Windows.Forms.Button()
        Me.btnCapRes = New System.Windows.Forms.Button()
        Me.btnCapQual = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxCapQual = New System.Windows.Forms.ComboBox()
        Me.btnCapFps = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCamMD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(165, 245)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cbxCamServer
        '
        Me.cbxCamServer.FormattingEnabled = True
        Me.cbxCamServer.Location = New System.Drawing.Point(61, 33)
        Me.cbxCamServer.Name = "cbxCamServer"
        Me.cbxCamServer.Size = New System.Drawing.Size(232, 21)
        Me.cbxCamServer.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Server: "
        '
        'cbxRecType
        '
        Me.cbxRecType.FormattingEnabled = True
        Me.cbxRecType.Items.AddRange(New Object() {"Record Off", "Record Always", "Motion Only"})
        Me.cbxRecType.Location = New System.Drawing.Point(124, 64)
        Me.cbxRecType.Name = "cbxRecType"
        Me.cbxRecType.Size = New System.Drawing.Size(169, 21)
        Me.cbxRecType.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Set Recording Type: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Set Capture Resolution: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Set Capture Quality: "
        '
        'txtFps
        '
        Me.txtFps.Location = New System.Drawing.Point(130, 150)
        Me.txtFps.Name = "txtFps"
        Me.txtFps.Size = New System.Drawing.Size(136, 20)
        Me.txtFps.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(272, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "fps"
        '
        'cbxCapRes
        '
        Me.cbxCapRes.FormattingEnabled = True
        Me.cbxCapRes.Items.AddRange(New Object() {"Camera Settings", "Low", "Normal", "High", "Highest"})
        Me.cbxCapRes.Location = New System.Drawing.Point(133, 94)
        Me.cbxCapRes.Name = "cbxCapRes"
        Me.cbxCapRes.Size = New System.Drawing.Size(160, 21)
        Me.cbxCapRes.TabIndex = 20
        '
        'btnRecType
        '
        Me.btnRecType.Location = New System.Drawing.Point(299, 63)
        Me.btnRecType.Name = "btnRecType"
        Me.btnRecType.Size = New System.Drawing.Size(75, 23)
        Me.btnRecType.TabIndex = 21
        Me.btnRecType.Text = "Set"
        Me.btnRecType.UseVisualStyleBackColor = True
        '
        'btnCapRes
        '
        Me.btnCapRes.Location = New System.Drawing.Point(299, 92)
        Me.btnCapRes.Name = "btnCapRes"
        Me.btnCapRes.Size = New System.Drawing.Size(75, 23)
        Me.btnCapRes.TabIndex = 22
        Me.btnCapRes.Text = "Set"
        Me.btnCapRes.UseVisualStyleBackColor = True
        '
        'btnCapQual
        '
        Me.btnCapQual.Location = New System.Drawing.Point(299, 119)
        Me.btnCapQual.Name = "btnCapQual"
        Me.btnCapQual.Size = New System.Drawing.Size(75, 23)
        Me.btnCapQual.TabIndex = 23
        Me.btnCapQual.Text = "Set"
        Me.btnCapQual.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Capture Frame Rate:"
        '
        'cbxCapQual
        '
        Me.cbxCapQual.FormattingEnabled = True
        Me.cbxCapQual.Items.AddRange(New Object() {"Camera Settings", "Lowest", "Low", "Normal", "High", "Highest"})
        Me.cbxCapQual.Location = New System.Drawing.Point(115, 122)
        Me.cbxCapQual.Name = "cbxCapQual"
        Me.cbxCapQual.Size = New System.Drawing.Size(178, 21)
        Me.cbxCapQual.TabIndex = 26
        '
        'btnCapFps
        '
        Me.btnCapFps.Location = New System.Drawing.Point(299, 148)
        Me.btnCapFps.Name = "btnCapFps"
        Me.btnCapFps.Size = New System.Drawing.Size(75, 23)
        Me.btnCapFps.TabIndex = 27
        Me.btnCapFps.Text = "Set"
        Me.btnCapFps.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(250, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Set All Cameras To Camera Side Motion Detection?"
        '
        'btnCamMD
        '
        Me.btnCamMD.Location = New System.Drawing.Point(299, 177)
        Me.btnCamMD.Name = "btnCamMD"
        Me.btnCamMD.Size = New System.Drawing.Size(75, 23)
        Me.btnCamMD.TabIndex = 29
        Me.btnCamMD.Text = "Set"
        Me.btnCamMD.UseVisualStyleBackColor = True
        '
        'CameraProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 302)
        Me.Controls.Add(Me.btnCamMD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCapFps)
        Me.Controls.Add(Me.cbxCapQual)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCapQual)
        Me.Controls.Add(Me.btnCapRes)
        Me.Controls.Add(Me.btnRecType)
        Me.Controls.Add(Me.cbxCapRes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFps)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxRecType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxCamServer)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "CameraProperties"
        Me.Text = "CameraProperties"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents cbxCamServer As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxRecType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFps As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxCapRes As ComboBox
    Friend WithEvents btnRecType As Button
    Friend WithEvents btnCapRes As Button
    Friend WithEvents btnCapQual As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxCapQual As ComboBox
    Friend WithEvents btnCapFps As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCamMD As Button
End Class
