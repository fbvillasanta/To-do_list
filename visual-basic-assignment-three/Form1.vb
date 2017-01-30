Public Class todoForm
    Dim regular As New ArrayList
    Dim priority As New ArrayList

    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        Dim entry As String
        entry = todo.Text.Trim()
        If entry = "" Then
            Return
        End If
        If regular.Contains(entry) Or priority.Contains(entry) Then
            MsgBox("Already in the list!", 0, "Warning")
        Else
            If isPriority.Checked() = True Then
                priority.Add(entry)
                prioritylist.Items.Add(entry)
                todo.Text = ""
            Else
                regular.Add(entry)
                regularlist.Items.Add(entry)
                todo.Text = ""
            End If
        End If
    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        regular.Clear()
        priority.Clear()
        prioritylist.Items.Clear()
        regularlist.Items.Clear()
    End Sub

    Private Sub remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remove.Click
        If prioritylist.CheckedItems.Count > 0 Then
            For i As Integer = 0 To prioritylist.CheckedItems.Count - 1
                Dim index As Integer = priority.IndexOf(prioritylist.CheckedItems(i).ToString())
                priority.RemoveAt(index)
            Next
            prioritylist.Items.Clear()
            For Each i In priority
                prioritylist.Items.Add(i)
            Next
        End If
        If regularlist.CheckedItems.Count > 0 Then
            For i As Integer = 0 To regularlist.CheckedItems.Count - 1
                Dim index As Integer = regular.IndexOf(regularlist.CheckedItems(i).ToString())
                regular.RemoveAt(index)
            Next
            regularlist.Items.Clear()
            For Each i In regular
                regularlist.Items.Add(i)
            Next
        End If
        MsgBox("Awesome! Good for you, lad! On to the next.", 0, "Success")
    End Sub
End Class
