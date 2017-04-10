
Public Class ReportForm

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSales.Text = ""
        txtRate.Text = ""
        lblCommission.Text = ""
        'Send focus to the txtSales text box
        txtSales.Focus()

    End Sub

    Private Sub btnCommission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommission.Click
        Dim dblCommission, dblSales, dblRate As Double
        Try
            'copy the input to the variables
            dblSales = CDbl(txtSales.Text)
            dblRate = CDbl(txtRate.Text)

            'Compute the commission and display it
            dblCommission = dblSales * dblRate / 100
            lblCommission.Text = dblCommission.ToString("c")

            'Now let's copy the results back to the Main Form
            If lblRegion.Text = "Eastern Regional Sales" Then
                MainForm.lblEasternCommission.Text = lblCommission.Text

                'Now do this for the Western Regional Sales
            ElseIf lblRegion.Text = "Western Regional Sales" Then
                MainForm.lblWesternCommission.Text = lblCommission.Text

            End If
        Catch
            MessageBox.Show("You must enter both Sales and Commission Rate")
            'Send focus to txtSales
            txtSales.Focus()

        End Try
    End Sub

    Private Sub ReportForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class


