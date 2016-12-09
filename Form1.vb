Imports SKYPE4COMLib
Imports System.Net

Public Class Form1
    Dim valid As Boolean = False
    Dim WithEvents oSkype As New Skype
    Dim Trigger As String = "!"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oSkype.Attach(7, False)
    End Sub

    Private Sub oSkype_MessageStatus(pMessage As ChatMessage, Status As TChatMessageStatus) Handles oSkype.MessageStatus
        If Status = TChatMessageStatus.cmsReceived Or Status = TChatMessageStatus.cmsSent Then
            Dim msg As String = pMessage.Body
            Dim c As Chat = pMessage.Chat

            If msg.StartsWith(Trigger) Then
                ListBox1.Items.Add(DateTime.Now.ToLongTimeString() + ":" + "command " + "'" + msg + "'" + "from " + pMessage.Sender.Handle)
                msg = msg.Remove(0, 1).ToLower

                If msg = "test" Then
                    c.SendMessage("This is working!")
                ElseIf msg = "hello" Then
                    c.SendMessage("Hi")
                Else
                    c.SendMessage("That is not a command")
                End If
            End If
        End If
    End Sub

    Private Sub oskype_userauthorizationrequestreceived(pUser As User) Handles oSkype.UserAuthorizationRequestReceived
        If chkAFR.Checked = True And pUser.IsAuthorized = False Then
            pUser.IsAuthorized = True
            oSkype.SendMessage(pUser.Handle, "Welcome!")
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim msg As String = txtMassMessage.Text
        For Each u As SKYPE4COMLib.User In oSkype.Friends
            oSkype.SendMessage(u.Handle, msg)
        Next
    End Sub
End Class
