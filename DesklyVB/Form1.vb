Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()

        NotifyIcon1.Visible = True
        NotifyIcon1.Icon = SystemIcons.Application
        NotifyIcon1.Visible = True

        ShowInTaskbar = False
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = MouseButtons.Right Then

        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    Private Sub GenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        End
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Show()
    End Sub
End Class
