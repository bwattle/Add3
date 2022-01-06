Public Class Add3
    Private total As Integer
    Private Sub BtnCalcSum_Click(sender As Object, e As EventArgs) Handles BtnCalcSum.Click
        total = txtNumber_1.Text + txtNumber_2.Text + txtNumber_3.Text
        txtTotalSum.Text = total
    End Sub
End Class
