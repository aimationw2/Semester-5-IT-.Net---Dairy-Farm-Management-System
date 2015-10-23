Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Public Class f12agentchangepwd
    Public cn As New SqlConnection("Data Source=(local);Initial Catalog=milk;Integrated Security=True")

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changepwd_btn.Click
        Try
            Dim reader As SqlDataReader
            Dim currentpassword As String = cpwd_txt.Text
            Dim newpassword As String = newpwd_txt.Text
            Dim verifypassword As String = verify_txt.Text
            cn.Close()
            cn.Open()
            Dim dbpassword As String = ""
            Dim cmd As New SqlCommand("select * from agent  where username=@username and password=@pwd;", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", F1LOGIN.username_txt.Text)
            cmd.Parameters.AddWithValue("@pwd", currentpassword)
            MsgBox(cmd.CommandText.ToString + F1LOGIN.username_txt.Text + currentpassword)
            reader = cmd.ExecuteReader
            If reader.HasRows.Equals(False) Then
                MsgBox("invalid login ..... ")
                End
            End If
            While reader.Read
                dbpassword = reader.Item("password")

            End While
            reader.Close()
            cn.Close()
            ' MsgBox(dbpassword + ":::" + currentpassword)
            If currentpassword.Equals(dbpassword) Then
                '  MsgBox("ok")
                cn.Open()
                Dim cmd1 As New SqlCommand("update agent set password=@password where username=@username", cn)
                cmd1.Parameters.Clear()
                cmd1.Parameters.AddWithValue("@username", F1LOGIN.username_txt.Text)
                cmd1.Parameters.AddWithValue("@password", newpassword)
                '   cmd1.Parameters.AddWithValue("@pre", currentpassword)
                cmd1.ExecuteNonQuery()
                MsgBox("Password changed successfully...")
                cn.Close()
            Else
                MsgBox("password is wrong")

            End If





        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class