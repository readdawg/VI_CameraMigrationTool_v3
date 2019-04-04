<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bitrate
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
        Me.dgvCameras = New System.Windows.Forms.DataGridView()
        Me.tb_Login = New System.Windows.Forms.TextBox()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_changeBitrate = New System.Windows.Forms.Button()
        Me.tb_path = New System.Windows.Forms.TextBox()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvCameras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCameras
        '
        Me.dgvCameras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCameras.Location = New System.Drawing.Point(13, 13)
        Me.dgvCameras.Name = "dgvCameras"
        Me.dgvCameras.Size = New System.Drawing.Size(775, 258)
        Me.dgvCameras.TabIndex = 0
        '
        'tb_Login
        '
        Me.tb_Login.Location = New System.Drawing.Point(13, 278)
        Me.tb_Login.Name = "tb_Login"
        Me.tb_Login.Size = New System.Drawing.Size(144, 20)
        Me.tb_Login.TabIndex = 1
        '
        'tb_password
        '
        Me.tb_password.Location = New System.Drawing.Point(13, 305)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.Size = New System.Drawing.Size(144, 20)
        Me.tb_password.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Camera Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Camera Password"
        '
        'btn_changeBitrate
        '
        Me.btn_changeBitrate.Location = New System.Drawing.Point(13, 369)
        Me.btn_changeBitrate.Name = "btn_changeBitrate"
        Me.btn_changeBitrate.Size = New System.Drawing.Size(243, 23)
        Me.btn_changeBitrate.TabIndex = 7
        Me.btn_changeBitrate.Text = "Change Bitrate"
        Me.btn_changeBitrate.UseVisualStyleBackColor = True
        '
        'tb_path
        '
        Me.tb_path.Location = New System.Drawing.Point(13, 333)
        Me.tb_path.Name = "tb_path"
        Me.tb_path.Size = New System.Drawing.Size(286, 20)
        Me.tb_path.TabIndex = 8
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(306, 333)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(75, 23)
        Me.btn_browse.TabIndex = 9
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(387, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "XML File Path"
        '
        'Bitrate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.tb_path)
        Me.Controls.Add(Me.btn_changeBitrate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.tb_Login)
        Me.Controls.Add(Me.dgvCameras)
        Me.Name = "Bitrate"
        Me.Text = "Bitrate"
        CType(Me.dgvCameras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCameras As DataGridView
    Friend WithEvents tb_Login As TextBox
    Friend WithEvents tb_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_changeBitrate As Button
    Friend WithEvents tb_path As TextBox
    Friend WithEvents btn_browse As Button
    Friend WithEvents Label4 As Label
End Class
