Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Public Class agentdel
    Public cn As New SqlConnection("Data Source=(local);Initial Catalog=milk;Integrated Security=True")

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MilkDataSet.agent' table. You can move, or remove it, as needed.
        Me.AgentTableAdapter.Fill(Me.MilkDataSet.agent)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cn.Close()
            cn.Open()
            Dim cmd As New SqlCommand("delete from agent where username=@username", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", ComboBox1.SelectedValue.ToString)
            cmd.ExecuteNonQuery()
            ' MsgBox(ComboBox1.SelectedValue.ToString)
            MsgBox("agent deleted successfully")
            Me.AgentTableAdapter.Fill(Me.MilkDataSet.agent)


            cn.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class