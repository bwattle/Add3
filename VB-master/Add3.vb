Public Class Add3
	Private Number_1, Number_2, Number_3 As String  'this is a deliberate error
	Private total As Integer                        'declaration of variables
	Private Sub BtnCalcSum_Click(sender As Object, e As EventArgs) Handles BtnCalcSum.Click
		Number_1 = txtNumber_1.Text                 'read user inputs
		Number_2 = txtNumber_2.Text
		Number_3 = txtNumber_3.Text
		total = Number_1 + Number_2 + Number_3      'assignment step
		txtTotalSum.Text = total                    'display step
	End Sub
End Class
