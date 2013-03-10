Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBAutoDataSet1.Vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter1.Fill(Me.VBAutoDataSet1.Vehicle)
        'TODO: This line of code loads data into the 'VBAutoDataSet.Vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter.Fill(Me.VBAutoDataSet.Vehicle)

    End Sub

   
    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.VehicleTableAdapter.FillBy1(Me.VBAutoDataSet.Vehicle)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
