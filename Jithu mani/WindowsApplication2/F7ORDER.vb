Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Public Class F7ORDER
    Public cn As New SqlConnection("Data Source=(local);Initial Catalog=milk;Integrated Security=True")
    Private Sub F7ORDER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Milkdetails.milktype' table. You can move, or remove it, as needed.
        Me.MilktypeTableAdapter.Fill(Me.Milkdetails.milktype)
        idcalc()
    End Sub

    Private Sub plceordr_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plceordr_btn.Click
        Dim code, agentname, date_, time_, milkname, qty, rate As String
        Try
            'If mlkname_combo.SelectedValue.ToString.Equals("") Then
            '    MsgBox("Please select proper milk name...")
            '    Return
            'ElseIf qty_txt.Enabled.Equals(False) Then
            '    MsgBox("Please enter the quantity...")
            '    Return
            'ElseIf rate_txt.Text.Equals("") Then
            '    MsgBox("Please select proper milk name...")
            'ElseIf amt_txt.Text.Equals("") Then
            '    MsgBox("Please select proper milk name...")
            'End If
            Dim rowcount As Int16 = TABLE.RowCount - 2
            For i = 0 To rowcount Step 1

                code = ordrid_txt.Text
                agentname = F1LOGIN.username_txt.Text
                date_ = date_cal.Value.ToString
                time_ = TABLE.Item(0, i).Value
                milkname = TABLE.Item(1, i).Value
                qty = TABLE.Item(2, i).Value
                rate = TABLE.Item(3, i).Value

                Dim valid As New valid

                cn.Close()
                cn.Open()
                MsgBox(milkname)

                Dim cmd As New SqlCommand("insert into milkorder values(@code,@aname,@date,@time,@mname,@qty,@rate);", cn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@code", code)
                cmd.Parameters.AddWithValue("@aname", agentname)
                cmd.Parameters.AddWithValue("@date", date_)
                cmd.Parameters.AddWithValue("@time", time_)
                cmd.Parameters.AddWithValue("@mname", milkname)
                cmd.Parameters.AddWithValue("@qty", qty)
                cmd.Parameters.AddWithValue("@rate", rate)
                cmd.ExecuteNonQuery()

                'idcalc()
                'TABLE.DataSource = cmd


                cn.Close()
            Next
            MsgBox("Order placed....")
            idcalc()
            TABLE.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub idcalc()
        Try
            cn.Close()
            cn.Open()
            Dim reader As SqlDataReader
            Dim id As String
            id = "1"
            Dim cmd1 As New SqlCommand("select max(code)+1 as max from milkorder;", cn)
            reader = cmd1.ExecuteReader
            While reader.Read ' reader.NextResult()
                id = reader.Item("max").ToString()
            End While
            ordrid_txt.Text = id
            '  MsgBox(id)
            reader.Close()

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton2.Checked = False
            RadioButton3.Checked = False
        End If
        If RadioButton2.Checked Then
            RadioButton1.Checked = False
            RadioButton3.Checked = False
        End If
        If RadioButton3.Checked Then
            RadioButton2.Checked = False
            RadioButton1.Checked = False
        End If
    End Sub

    Private Sub mlkname_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mlkname_combo.DropDownClosed
        'MsgBox("here")
        Try
            Dim milkname As String = mlkname_combo.SelectedValue.ToString
            cn.Close()
            cn.Open()
            Dim cmd As New SqlCommand("select rate from milktype where pr_name=@name", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", milkname)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            While reader.Read
                rate_txt.Text = reader.Item("rate").ToString
            End While
            qty_txt.Enabled = True
            reader.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub qty_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qty_txt.TextChanged
        Try
            If rate_txt.Text.Equals("") Then
                MsgBox("Please select proper prduct name....")
                Return
            End If
            If qty_txt.Text.Equals("") Then
                MsgBox("Please enter valid quantity....")
                Return
            End If
            Dim valid As New valid
            If Not valid.is_postive_number_only(qty_txt.Text) Then
                MsgBox("Enter a positive value....")
            Else
                amt_txt.Text = (Convert.ToInt32(qty_txt.Text) * Convert.ToInt32(rate_txt.Text)).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changepwd_txt.Click
        F12agentchangepwd.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        milktypedetails.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        F1LOGIN.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim MILKNAME As String = mlkname_combo.SelectedValue.ToString
        Dim QTY As String = qty_txt.Text.ToString
        Dim RATE As String = amt_txt.Text
        Dim time_ As String = ""
        If RATE.Equals("") Or QTY.Equals("") Then
            MsgBox("Please select all fields...")
            Return
        End If
        If RadioButton1.Checked Then
            time_ = "morning"
        ElseIf RadioButton2.Checked Then
            time_ = "evening"
        ElseIf RadioButton3.Checked Then
            time_ = "morning/evening"
        End If
        TABLE.Rows.Add(1)
        TABLE.Item(0, TABLE.RowCount - 2).Value = time_
        TABLE.Item(1, TABLE.RowCount - 2).Value = MILKNAME
        TABLE.Item(2, TABLE.RowCount - 2).Value = QTY
        TABLE.Item(3, TABLE.RowCount - 2).Value = RATE
        qty_txt.Enabled = False
        rate_txt.Text = "0"
        qty_txt.Text = "0"
        amt_txt.Text = ""

    End Sub

    Private Sub prevordr_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prevordr_btn.Click
        preorder.Show()
    End Sub
End Class
