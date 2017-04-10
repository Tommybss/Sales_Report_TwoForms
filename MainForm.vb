Public Class MainForm

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim intResponse As Integer

        'Display a message box asking user if they want to quit
        intResponse = MessageBox.Show("Do you want to quit?", "Confrim Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        'Ask the user to confirm Exiting the program
        If intResponse = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnEasternSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEasternSales.Click
        Dim frmEasternReport As New ReportForm

        'Put the word Eastern into the lblRegion label
        frmEasternReport.lblRegion.Text = "Eastern Regional Sales"


        'now show the form
        frmEasternReport.ShowDialog()

        'If both commissions have been calculated, enable the Total Commission button
        If lblEasternCommission.Text <> "" And lblWesternCommission.Text <> "" Then
            btnTotalCommission.Enabled = True

        End If

    End Sub

    Private Sub btnWesternSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWesternSales.Click
        Dim frmWesternReport As New ReportForm

        'Put the word Eastern into the lblRegion label
        frmWesternReport.lblRegion.Text = "Western Regional Sales"


        'now show the form
        frmWesternReport.ShowDialog()

        'If both commissions have been calculated, enable the Total Commission button
        If lblWesternCommission.Text <> "" And lblEasternCommission.Text <> "" Then
            btnTotalCommission.Enabled = True
        End If
    End Sub

    
    Private Sub btnTotalCommission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalCommission.Click
        Dim dblTotalCommission As Double
        dblTotalCommission = CDbl(lblEasternCommission.Text) + CDbl(lblWesternCommission.Text)

        'Display the result in the Total Commission label
        lblTotalComm.Text = dblTotalCommission.ToString("c")

    End Sub

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class