Option Explicit On
Option Strict On

Public Class Start
    'When Form is started
    Private Sub Start_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
        Me.ToolStripStatusLabel1.Text = My.User.Name
    End Sub

    Private Sub InformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InformationToolStripMenuItem.Click
        Info.Show()
    End Sub
    '******************************
    'XML
    '******************************
    Private Sub XMLWriter(ByVal txt_bereich As String, ByVal txt_info As String, ByVal date_time As Date)
        Dim myWriter As New IO.StreamWriter("log.xml", True)
        myWriter.WriteLine("<Log " & txt_bereich & "=" & Chr(34) & txt_info & Chr(34) & " Datum=" & Chr(34) & date_time.ToString("G") & Chr(34) & " " & Chr(47) & ">")
        myWriter.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        XMLWriter("test", "Das ist ein Test", Date.Now)
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        End
    End Sub
End Class
