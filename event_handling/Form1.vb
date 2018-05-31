Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm2 As New Form2
        frm2.ShowDialog()
    End Sub

    ' Declare an event.
    Public Event Ev_Event()

    Sub CauseSomeEvent()
        ' Raise an event.
        RaiseEvent Ev_Event()
        Label1.Text = "clicked on form 2"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
