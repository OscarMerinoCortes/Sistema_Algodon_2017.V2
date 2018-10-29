Public Class VentaPacasContrato
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ChAdd_CheckedChanged(sender As Object, e As EventArgs) Handles ChAdd.CheckedChanged
        If ChAdd.Checked = True Then
            TbAdd.Visible = True
        Else
            TbAdd.Visible = False
        End If
    End Sub
End Class