Imports Microsoft.SqlServer
Imports System.Data.SqlClient

Public Class F11changepwd
    Public cn As New SqlConnection("Data Source=(local);Initial Catalog=milk;Integrated Security=True")
    Dim reader As SqlDataReader
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changepwd_btn.Click
        Try
            Dim currentpassword As String = cpwd_txt.Text
            Dim newpassword As String = newpwd_txt.Text
            Dim verifypassword As String = verify_txt.Text
            cn.Open()
            Dim dbpassword As String = ""
            Dim cmd As New SqlCommand("select * from admin;", cn)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            While reader.Read
                dbpassword = reader.Item("password")

            End While
            reader.Close()
            cn.Close()
            If currentpassword.Equals(dbpassword) Then
                '  MsgBox("ok")
                cn.Open()
                Dim cmd1 As New SqlCommand("update admin set password=@password ", cn)
                cmd1.Parameters.Clear()
                cmd1.Parameters.AddWithValue("@password", newpassword)
                cmd1.Parameters.AddWithValue("@pre", currentpassword)
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