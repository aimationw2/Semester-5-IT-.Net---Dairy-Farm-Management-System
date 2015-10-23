Public Class F10AGENTDETAILS

    Private Sub F10AGENTDETAILS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MilkDataSet.agent' table. You can move, or remove it, as needed.
        Me.AgentTableAdapter.Fill(Me.MilkDataSet.agent)

    End Sub

  
End Class