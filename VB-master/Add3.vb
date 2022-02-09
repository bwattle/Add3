Public Class Add3
	Private number_1, number_2, number_3 As String  'this is a deliberate error
	Private total As Integer                        'declaration of variables
	Private Sub BtnCalcSum_Click(sender As Object, e As EventArgs) Handles BtnCalcSum.Click
		number_1 = txtNumber_1.Text                 'read user inputs
		number_2 = txtNumber_2.Text
		number_3 = txtNumber_3.Text
		total = number_1 + number_2 + number_3      'assignment step
		txtTotalSum.Text = total                    'display step
	End Sub
End Class
