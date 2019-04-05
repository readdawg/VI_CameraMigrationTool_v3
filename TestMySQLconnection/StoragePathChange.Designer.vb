<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StoragePathChange
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbxServerList = New System.Windows.Forms.ComboBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.dgvCameras = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpgrade = New System.Windows.Forms.Button()
        Me.Selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordingPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CameraID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCameras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxServerList
        '
        Me.cbxServerList.FormattingEnabled = True
        Me.cbxServerList.Items.AddRange(New Object() {"Please Choose A Server"})
        Me.cbxServerList.Location = New System.Drawing.Point(12, 12)
        Me.cbxServerList.Name = "cbxServerList"
        Me.cbxServerList.Size = New System.Drawing.Size(401, 21)
        Me.cbxServerList.Sorted = True
        Me.cbxServerList.TabIndex = 12
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(477, 427)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(129, 23)
        Me.btnBrowse.TabIndex = 11
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(12, 428)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(459, 20)
        Me.txtPath.TabIndex = 10
        '
        'dgvCameras
        '
        Me.dgvCameras.AllowUserToAddRows = False
        Me.dgvCameras.AllowUserToDeleteRows = False
        Me.dgvCameras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCameras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCameras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCameras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selected, Me.CName, Me.IP, Me.RecordingPath, Me.CameraID})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCameras.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCameras.Location = New System.Drawing.Point(12, 39)
        Me.dgvCameras.Name = "dgvCameras"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCameras.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCameras.Size = New System.Drawing.Size(594, 374)
        Me.dgvCameras.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(477, 456)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(129, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpgrade
        '
        Me.btnUpgrade.Location = New System.Drawing.Point(11, 454)
        Me.btnUpgrade.Name = "btnUpgrade"
        Me.btnUpgrade.Size = New System.Drawing.Size(129, 23)
        Me.btnUpgrade.TabIndex = 7
        Me.btnUpgrade.Text = "Update Storage Path"
        Me.btnUpgrade.UseVisualStyleBackColor = True
        '
        'Selected
        '
        Me.Selected.HeaderText = "Selected"
        Me.Selected.Name = "Selected"
        Me.Selected.Width = 55
        '
        'CName
        '
        Me.CName.HeaderText = "Camera Name"
        Me.CName.Name = "CName"
        Me.CName.Width = 99
        '
        'IP
        '
        Me.IP.HeaderText = "IP Address"
        Me.IP.Name = "IP"
        Me.IP.Width = 83
        '
        'RecordingPath
        '
        Me.RecordingPath.HeaderText = "Recording Path"
        Me.RecordingPath.Name = "RecordingPath"
        Me.RecordingPath.Width = 97
        '
        'CameraID
        '
        Me.CameraID.HeaderText = "CameraID"
        Me.CameraID.Name = "CameraID"
        Me.CameraID.ReadOnly = True
        Me.CameraID.Visible = False
        Me.CameraID.Width = 79
        '
        'StoragePathChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 489)
        Me.Controls.Add(Me.cbxServerList)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.dgvCameras)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpgrade)
        Me.Name = "StoragePathChange"
        Me.Text = "StoragePathChange"
        CType(Me.dgvCameras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxServerList As ComboBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents dgvCameras As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents btnUpgrade As Button
    Friend WithEvents Selected As DataGridViewCheckBoxColumn
    Friend WithEvents CName As DataGridViewTextBoxColumn
    Friend WithEvents IP As DataGridViewTextBoxColumn
    Friend WithEvents RecordingPath As DataGridViewTextBoxColumn
    Friend WithEvents CameraID As DataGridViewTextBoxColumn
End Class
