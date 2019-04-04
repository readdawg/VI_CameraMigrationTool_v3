<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceRestart
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
        Me.btn_servStop = New System.Windows.Forms.Button()
        Me.btn_servStart = New System.Windows.Forms.Button()
        Me.dgvServerList = New System.Windows.Forms.DataGridView()
        Me.Selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ServerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbAll = New System.Windows.Forms.CheckBox()
        CType(Me.dgvServerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_servStop
        '
        Me.btn_servStop.Location = New System.Drawing.Point(13, 12)
        Me.btn_servStop.Name = "btn_servStop"
        Me.btn_servStop.Size = New System.Drawing.Size(120, 23)
        Me.btn_servStop.TabIndex = 0
        Me.btn_servStop.Text = "Service Stop"
        Me.btn_servStop.UseVisualStyleBackColor = True
        '
        'btn_servStart
        '
        Me.btn_servStart.Location = New System.Drawing.Point(139, 10)
        Me.btn_servStart.Name = "btn_servStart"
        Me.btn_servStart.Size = New System.Drawing.Size(120, 23)
        Me.btn_servStart.TabIndex = 1
        Me.btn_servStart.Text = "Service Start"
        Me.btn_servStart.UseVisualStyleBackColor = True
        '
        'dgvServerList
        '
        Me.dgvServerList.AllowUserToAddRows = False
        Me.dgvServerList.AllowUserToDeleteRows = False
        Me.dgvServerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServerList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selected, Me.ServerName, Me.IPAddress})
        Me.dgvServerList.Location = New System.Drawing.Point(13, 41)
        Me.dgvServerList.Name = "dgvServerList"
        Me.dgvServerList.Size = New System.Drawing.Size(499, 351)
        Me.dgvServerList.TabIndex = 4
        '
        'Selected
        '
        Me.Selected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Selected.HeaderText = "Select"
        Me.Selected.Name = "Selected"
        Me.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Selected.Width = 62
        '
        'ServerName
        '
        Me.ServerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ServerName.HeaderText = "Server Name"
        Me.ServerName.Name = "ServerName"
        Me.ServerName.ReadOnly = True
        Me.ServerName.Width = 94
        '
        'IPAddress
        '
        Me.IPAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IPAddress.HeaderText = "IP Address"
        Me.IPAddress.Name = "IPAddress"
        Me.IPAddress.ReadOnly = True
        Me.IPAddress.Width = 83
        '
        'cbAll
        '
        Me.cbAll.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbAll.Location = New System.Drawing.Point(58, 45)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(51, 16)
        Me.cbAll.TabIndex = 5
        Me.cbAll.Text = "All"
        Me.cbAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbAll.UseVisualStyleBackColor = True
        '
        'ServiceRestart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 410)
        Me.Controls.Add(Me.cbAll)
        Me.Controls.Add(Me.dgvServerList)
        Me.Controls.Add(Me.btn_servStart)
        Me.Controls.Add(Me.btn_servStop)
        Me.Name = "ServiceRestart"
        Me.Text = "ServiceRestart"
        CType(Me.dgvServerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_servStop As Button
    Friend WithEvents btn_servStart As Button
    Friend WithEvents dgvServerList As DataGridView
    Friend WithEvents Selected As DataGridViewCheckBoxColumn
    Friend WithEvents ServerName As DataGridViewTextBoxColumn
    Friend WithEvents IPAddress As DataGridViewTextBoxColumn
    Friend WithEvents cbAll As CheckBox
End Class
