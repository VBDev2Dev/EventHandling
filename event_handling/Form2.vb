Public Class Form2

	' Declare an event.
	Public Event Ev_Event(sender As Object, e As EventArgs)

	Protected Overridable Sub OnEv_Event()
		' Raise an event.
		RaiseEvent Ev_Event(Me, EventArgs.Empty)

    End Sub
	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		'STOP using call.  It is only needed in very special cases
		OnEv_Event()

    End Sub
End Class