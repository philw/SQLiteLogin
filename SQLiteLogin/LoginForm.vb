Imports System.Data.Sqlite


Public Class LoginForm

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        Dim dbConn As SQLiteConnection
        Dim dbCmd As SQLiteCommand
        Dim dbReader As SQLiteDataReader
        Dim SQL As String
        Dim Username As String

        Username = UsernameTextBox.Text
        SQL = String.Format("SELECT * from user where username = '{0}'", Username)

        dbConn = New SQLiteConnection("Data Source=philtest.db;Version=3;")
        dbConn.Open()

        dbCmd = dbConn.CreateCommand
        dbCmd.CommandText = SQL

        ' execute the SQL command
        dbReader = dbCmd.ExecuteReader()

        If dbReader.Read() Then
            MsgBox("User " & Username & " exists")

        Else
            MsgBox("User " & Username & " NOT found")
        End If


    End Sub

End Class
