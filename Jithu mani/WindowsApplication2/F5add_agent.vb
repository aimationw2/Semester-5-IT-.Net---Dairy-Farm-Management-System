Imports Microsoft.SqlServer
Imports System.Data.SqlClient

Public Class F5add_agent
    Public cn As New SqlConnection("Data Source=(local);Initial Catalog=milk;Integrated Security=True")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_btn.Click

        Try

            Dim name, address, city, phoneno, username, password As String
            username = username_txt.Text
            password = pwd_txt.Text



            name = name_txt.Text
            address = addr_txt.Text
            city = city_txt.Text
            phoneno = phone_numbe_txt.Text
            If name.Equals("") Or address.Equals("") Or city.Equals("") Or phoneno.Equals("") Or username.Equals("") Or password.Equals("") Then
                MsgBox("fill all fields...")
                Return
            End If
            Dim valid As New valid
            If Not valid.is_name(name) Then
                MsgBox("not valid name")
                Return
            End If
            If Not valid.is_alphabet_only(city) Then
                MsgBox("not valid address")
                Return

            End If
            If Not valid.is_mobile_number(phoneno) Then
                MsgBox("not valid phone no")
                Return

            End If

            cn.Close()
            ' check dup
            cn.Open()
            Dim reader As SqlDataReader
            Dim cmd As New SqlCommand("select count(*) as count from agent where username=@username", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", username)
            reader = cmd.ExecuteReader
            If reader.Read Then
                '  MsgBox(reader.RecordsAffected.ToString)
                Dim count As String = reader.Item("count")
                If (count.Equals("0")) Then
                    ' ok
                    ' MsgBox("ok")

                Else
                    ' not ok
                    MsgBox("userId already exists")
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
            'insert
            cn.Open()
            Dim cmd1 As New SqlCommand("insert into agent values(@username,@pwd,@code,@name,@addr,@city,@phno);", cn)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@username", username)
            cmd1.Parameters.AddWithValue("@pwd", password)
            cmd1.Parameters.AddWithValue("@code", id_txt.Text)
            cmd1.Parameters.AddWithValue("@name", name)
            cmd1.Parameters.AddWithValue("@addr", address)
            cmd1.Parameters.AddWithValue("@city", city)
            cmd1.Parameters.AddWithValue("@phno", phoneno)
            cmd1.ExecuteNonQuery()
            username_txt.Text = ""
            pwd_txt.Text = ""
            name_txt.Text = ""
            addr_txt.Text = ""
            city_txt.Text = ""
            phone_numbe_txt.Text = ""
            idcalc()
            MsgBox("agent added...")
            cn.Close()
            'insert
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub F5add_agent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        idcalc()
    End Sub

    Public Sub idcalc()
        Try
            cn.Close()
            cn.Open()
            Dim reader As SqlDataReader
            Dim id As String
            id = "1"
            Dim cmd1 As New SqlCommand("select max(code)+1 as max from agent", cn)
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