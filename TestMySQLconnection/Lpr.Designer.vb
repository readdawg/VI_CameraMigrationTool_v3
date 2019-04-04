<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lpr
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvLpr = New System.Windows.Forms.DataGridView()
        Me.collectDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plateNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.camera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.viewCollect = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.plateCollect = New System.Windows.Forms.DataGridViewImageColumn()
        Me.timerRefresh = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvLpr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLpr
        '
        Me.dgvLpr.AllowUserToAddRows = False
        Me.dgvLpr.AllowUserToDeleteRows = False
        Me.dgvLpr.AllowUserToResizeRows = False
        Me.dgvLpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLpr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.collectDate, Me.plateNum, Me.camera, Me.viewCollect, Me.plateCollect})
        Me.dgvLpr.Location = New System.Drawing.Point(10, 40)
        Me.dgvLpr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvLpr.Name = "dgvLpr"
        Me.dgvLpr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvLpr.RowTemplate.Height = 24
        Me.dgvLpr.Size = New System.Drawing.Size(657, 366)
        Me.dgvLpr.TabIndex = 0
        '
        'collectDate
        '
        Me.collectDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.collectDate.HeaderText = "Collect Date"
        Me.collectDate.Name = "collectDate"
        Me.collectDate.ReadOnly = True
        Me.collectDate.Width = 90
        '
        'plateNum
        '
        Me.plateNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.plateNum.HeaderText = "Plate Number"
        Me.plateNum.Name = "plateNum"
        Me.plateNum.ReadOnly = True
        Me.plateNum.Width = 96
        '
        'camera
        '
        Me.camera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.camera.HeaderText = "Camera"
        Me.camera.Name = "camera"
        Me.camera.ReadOnly = True
        Me.camera.Width = 68
        '
        'viewCollect
        '
        Me.viewCollect.HeaderText = "View"
        Me.viewCollect.Name = "viewCollect"
        Me.viewCollect.ReadOnly = True
        '
        'plateCollect
        '
        Me.plateCollect.HeaderText = "Plate Image"
        Me.plateCollect.Name = "plateCollect"
        Me.plateCollect.ReadOnly = True
        '
        'timerRefresh
        '
        Me.timerRefresh.Interval = 10000
        '
        'Lpr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 415)
        Me.Controls.Add(Me.dgvLpr)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Lpr"
        Me.Text = "Lpr"
        CType(Me.dgvLpr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvLpr As DataGridView
    Friend WithEvents timerRefresh As Timer
    Friend WithEvents collectDate As DataGridViewTextBoxColumn
    Friend WithEvents plateNum As DataGridViewTextBoxColumn
    Friend WithEvents camera As DataGridViewTextBoxColumn
    Friend WithEvents viewCollect As DataGridViewButtonColumn
    Friend WithEvents plateCollect As DataGridViewImageColumn
End Class
