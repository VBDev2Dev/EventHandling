Imports System.ComponentModel

Public Class Form1
	Dim WithEvents frm2 As Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		frm2 = New Form2
		frm2.Show(Me)
		Button1.Enabled = False



    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

	Private Sub frm2_Ev_Event(sender As Object, e As EventArgs) Handles frm2.Ev_Event
		Label1.Text = $"You clicked the button on the other form {Now}"
	End Sub

	Private Sub frm2_Closing(sender As Object, e As CancelEventArgs) Handles frm2.Closing
		Button1.Enabled = True
	End Sub
End Class
