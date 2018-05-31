Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub TestEvents()
        Dim Obj As New Form1
        ' Associate an event handler with an event
        AddHandler Obj.Ev_Event, AddressOf EventHandler
        ' Call the method to raise the event
        Obj.CauseSomeEvent()
    End Sub

    Sub EventHandler()
        ' Handle the event.
        MsgBox("success event")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call EventHandler()
    End Sub
End Class