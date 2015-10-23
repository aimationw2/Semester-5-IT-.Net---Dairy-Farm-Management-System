Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Public Class F6MILK_TYDET
    Public cn As New SqlConnection("Data Source=(local);Initial Catalog=milk;Integrated Security=True")
   

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_btn.Click
        Try
            Dim code, pname, rate As String
            code = id_txt.Text
            pname = pdname_txt.Text
            rate = rate_txt.Text
            If code.Equals("") Or pname.Equals("") Or rate.Equals("") Then
                MsgBox("fill all fields...")
            End If

            Dim valid As New valid
            If Not valid.is_name(pname) Then
                MsgBox("not valid product name")
                Return
            End If
            If Not valid.is_postive_number_only(rate) Then
                MsgBox("invalid amount entered")
                Return
            End If
            cn.Close()
            ' check dup
            cn.Open()
            Dim reader As SqlDataReader
            Dim cmd As New SqlCommand("select count(*) as count from milktype where pr_name=@name", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", pname)
            reader = cmd.ExecuteReader
            If reader.Read Then
                '  MsgBox(reader.RecordsAffected.ToString)
                Dim count As String = reader.Item("count")
                If (count.Equals("0")) Then
                    ' ok
                    ' MsgBox("ok")

                Else
                    ' not ok
                    MsgBox("milk name already exists")
                    ' invalid_input = True
                    Return
                End If
            Else
                MsgBox("invalid  data")
                ' invalid_input = True
                Return
            End If
            reader.Close()

            cn.Close()
            'dup



            cn.Open()
            Dim cmd1 As New SqlCommand("insert into milktype values(@code,@pr_name,@rate);", cn)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@code", code)
            cmd1.Parameters.AddWithValue("@pr_name", pname)
            cmd1.Parameters.AddWithValue("@rate", rate)

            cmd1.ExecuteNonQuery()
            pdname_txt.Text = ""
            rate_txt.Text = ""

            idcalc()
            MsgBox("milk type added...")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub F6MILK_TYDET_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        idcalc()
    End Sub

    Public Sub idcalc()
        Try
            cn.Close()
            cn.Open()
            Dim reader As SqlDataReader
            Dim id As String
            id = "1"
            Dim cmd1 As New SqlCommand("select max(code)+1 as max from milktype", cn)
            reader = cmd1.ExecuteReader
            While reader.Read ' reader.NextResult()
                id = reader.Item("max").ToString()
            End While
            id_txt.Text = id
            '  MsgBox(id)
            reader.Close()

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class