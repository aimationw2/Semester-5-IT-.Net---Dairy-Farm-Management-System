Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Public Class F1LOGIN
    Public cn As New SqlConnection("Data Source=(local);Initial Catalog=milk;Integrated Security=True")
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click
        Try
            If username_txt.Text.Equals("admin") Then
                Dim username As String = username_txt.Text
                Dim pwd As String
                username = username_txt.Text
                pwd = pwd_txt.Text
                cn.Open()
                Dim cmd As New SqlCommand("select count(*) as count from admin where password=@pwd;", cn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@pwd", pwd)

                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader
                If reader.Read Then
                    '  MsgBox(reader.RecordsAffected.ToString)
                    Dim count As String = reader.Item("count")
                    If (count.Equals("1")) Then
                        ' ok
                        '   MsgBox("ok")
                        Me.Hide()
                        ' adminpage.Show()
                        pwd_txt.Text = ""
                        F4ADMIN.Show()
                    Else
                        ' not ok
                        MsgBox("not ok")
                    End If
                Else
                    MsgBox("invalid login data")
                End If
                reader.Close()
                cn.Close()
            Else
                Dim username As String = username_txt.Text
                Dim pwd As String
                username = username_txt.Text
                pwd = pwd_txt.Text
                cn.Open()
                Dim cmd As New SqlCommand("select count(*) as count from agent where username=@username and password=@pwd;", cn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@pwd", pwd)
                ' MsgBox(cmd.CommandText.ToString)

                'Form7.Show()
                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader
                If reader.Read Then
                    '  MsgBox(reader.RecordsAffected.ToString)
                    Dim count As String = reader.Item("count")
                    If (count.Equals("1")) Then
                        ' ok
                        '  MsgBox("ok")
                        Me.Hide()
                        pwd_txt.Text = ""
                        F7ORDER.Show()
                    Else
                        ' not ok
                        MsgBox("invalid login data")
                    End If
                Else
                    MsgBox("invalid login data")
                End If
                reader.Close()
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
