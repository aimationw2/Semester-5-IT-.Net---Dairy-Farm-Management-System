Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Public Class preorder
    Public cn As New SqlConnection("Data Source=(local);Initial Catalog=milk;Integrated Security=True")
    Private Sub preorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("select * from milkorder where agentname=@usr;", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@usr", F1LOGIN.username_txt.Text)
            cn.Close()
            cn.Open()
            Dim reader As SqlDataReader

            Dim dt = New DataTable()
            reader = cmd.ExecuteReader
            dt.Load(reader)
            DataGridView1.AutoGenerateColumns = True
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class