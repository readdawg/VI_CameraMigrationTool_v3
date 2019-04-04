Public Class SettingsForm

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        'Set public variables for Data Connection String
        Instance = txtInstance.Text
        UserName = txtUser.Text
        Password = txtPassword.Text
        Database = txtDatabase.Text
        DataConnection = "SERVER=" & Instance & ";UID=" & UserName & ";PWD=" & Password & ";Database=" & Database

        My.Settings.instance = txtInstance.Text
        My.Settings.userName = txtUser.Text
        My.Settings.password = txtPassword.Text
        My.Settings.database = txtDatabase.Text

        My.Settings.isConfigured = True

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub txtTest_Click(sender As Object, e As EventArgs) Handles txtTest.Click

        'Set public variables for Data Connection String
        Instance = txtInstance.Text
        UserName = txtUser.Text
        Password = txtPassword.Text
        Database = txtDatabase.Text

        'Message box with Data Connection String
        MsgBox("Data Connection String Will Be" & vbNewLine & "SERVER=" & Instance & ";UID=" & UserName & ";PWD=" & Password & ";Database=" & Database)



    End Sub

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set Parent
        MdiParent = LandingPad

        'Load saved values for settings
        txtInstance.Text = My.Settings.instance
        txtUser.Text = My.Settings.userName
        txtPassword.Text = My.Settings.password
        txtDatabase.Text = My.Settings.database

    End Sub
End Class