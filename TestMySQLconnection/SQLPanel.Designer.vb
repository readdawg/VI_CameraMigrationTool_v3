<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SQLPanel
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
        Me.dgvSql = New System.Windows.Forms.DataGridView()
        Me.sqlQuery = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sqlExecute = New System.Windows.Forms.Button()
        Me.sqlClear = New System.Windows.Forms.Button()
        CType(Me.dgvSql, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSql
        '
        Me.dgvSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSql.Location = New System.Drawing.Point(12, 80)
        Me.dgvSql.Name = "dgvSql"
        Me.dgvSql.Size = New System.Drawing.Size(767, 471)
        Me.dgvSql.TabIndex = 0
        '
        'sqlQuery
        '
        Me.sqlQuery.Location = New System.Drawing.Point(12, 25)
        Me.sqlQuery.Name = "sqlQuery"
        Me.sqlQuery.Size = New System.Drawing.Size(766, 20)
        Me.sqlQuery.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SQL Command"
        '
        'sqlExecute
        '
        Me.sqlExecute.Location = New System.Drawing.Point(12, 51)
        Me.sqlExecute.Name = "sqlExecute"
        Me.sqlExecute.Size = New System.Drawing.Size(75, 23)
        Me.sqlExecute.TabIndex = 3
        Me.sqlExecute.Text = "Execute"
        Me.sqlExecute.UseVisualStyleBackColor = True
        '
        'sqlClear
        '
        Me.sqlClear.Location = New System.Drawing.Point(93, 51)
        Me.sqlClear.Name = "sqlClear"
        Me.sqlClear.Size = New System.Drawing.Size(75, 23)
        Me.sqlClear.TabIndex = 4
        Me.sqlClear.Text = "Clear"
        Me.sqlClear.UseVisualStyleBackColor = True
        '
        'SQLPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 563)
        Me.Controls.Add(Me.sqlClear)
        Me.Controls.Add(Me.sqlExecute)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sqlQuery)
        Me.Controls.Add(Me.dgvSql)
        Me.Name = "SQLPanel"
        Me.Text = "SQLPanel"
        CType(Me.dgvSql, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSql As DataGridView
    Friend WithEvents sqlQuery As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sqlExecute As Button
    Friend WithEvents sqlClear As Button
End Class
