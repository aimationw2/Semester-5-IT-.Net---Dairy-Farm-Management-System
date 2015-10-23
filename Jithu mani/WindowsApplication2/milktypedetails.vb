Public Class milktypedetails

    Private Sub milktypedetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Milkdetails.milktype' table. You can move, or remove it, as needed.
        Me.MilktypeTableAdapter.Fill(Me.Milkdetails.milktype)

    End Sub
End Class