Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.Xml

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Welcome
        welcometxt.Text = "Welcome to jFM, " & SystemInformation.UserName & ". Start syncing now!"
        Dim path As String = Application.StartupPath & "\nowplaying.txt"
        Dim fs As FileStream = File.Create(path)
        'theme
        Me.BackColor = ColorTranslator.FromHtml("#36393E") 'Background
        Me.ForeColor = Color.White 'Form text
        syncbtn.ForeColor = Color.Black 'Button text

        Timer1.Start()
        marqueetimer.Start()
        lastfmTrack.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Enable button if textbox is not empty
        If jFMUsername.Text = "" Then
            syncbtn.Enabled = False
        Else
            syncbtn.Enabled = True
        End If
    End Sub

    Private Sub marqueetimer_Tick(sender As Object, e As EventArgs) Handles marqueetimer.Tick
        'Scrolling text
        lastfmTrack.Text = lastfmTrack.Text.Substring(1) & lastfmTrack.Text.Substring(0, 1)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles syncbtn.Click
        lastfmTrack.Text = "Please wait syncing...."
        jFMUsername.Enabled = False
        jfmtimer.Start()
        welcometxt.Text = "Welcome to jFM, " & SystemInformation.UserName & ". Auto Sync active!"
    End Sub

    Private Sub jfmtimer_Tick(sender As Object, e As EventArgs) Handles jfmtimer.Tick
        Try
            Dim lastFmUserName As String = jFMUsername.Text
            Dim url As String = "https://ws.audioscrobbler.com/2.0/?method=user.getrecenttracks&user=" & lastFmUserName & "&api_key=c3f90909889108ddf6fef3407b070633"
            Dim request As WebRequest = WebRequest.Create(url)
            Dim response As WebResponse = request.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            ' parse the response from the server to get the currently playing song
            Dim xmlDoc As New XmlDocument()
            xmlDoc.LoadXml(responseFromServer)
            Dim currentlyPlayingNode As XmlNode = xmlDoc.SelectSingleNode("/lfm/recenttracks/track[@nowplaying='true']")
            Dim ArtistName As String = currentlyPlayingNode.SelectSingleNode("artist").InnerText
            Dim currentlyPlayingSong As String = currentlyPlayingNode.SelectSingleNode("name").InnerText
            Dim AlbumArt As String = currentlyPlayingNode.SelectSingleNode("image[@size='medium']").InnerText
            PictureBox1.Load(AlbumArt)
            'Convert to UTF-8 to support more languages!
            Dim play As String = " " & ArtistName & " - " & currentlyPlayingSong & " "
            Dim utf8 As New UTF8Encoding()
            Dim encodedBytes As Byte() = utf8.GetBytes(play)
            Dim decodedString As String = utf8.GetString(encodedBytes)
            lastfmTrack.Text = play

            'Write to txt
            File.WriteAllText(Application.StartupPath & "\nowplaying.txt", ArtistName & " - " & currentlyPlayingSong)
            reader.Close()
            response.Close()
        Catch ex As Exception
            PictureBox1.Image = My.Resources.noalbum
            lastfmTrack.Text = "No music playing... "
        End Try
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MsgBox("jFM by Alt - Beta 1" & Environment.NewLine & Environment.NewLine &
               "jFM requires you to have free Last.FM account to work." & Environment.NewLine & "Also your music player needs to support Last.FM scrobbling, like Spotify." & Environment.NewLine & Environment.NewLine &
               "After pushing 'Sync' button, jFM will sync automatically every few seconds and writes what is playing to nowplaying.txt located in the jFM directory!" & Environment.NewLine & Environment.NewLine &
               "If you need more detailed instructions, visit jFM website at https://sacredrift.com/jfm", MsgBoxStyle.Information, "About jFM")
    End Sub

    Private Sub jFMUsername_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles jFMUsername.MouseDoubleClick
        If jFMUsername.Enabled = False Then
            jFMUsername.Enabled = True
        Else
            jFMUsername.Enabled = False
        End If
    End Sub

    Private Sub PictureBox2_DoubleClick(sender As Object, e As EventArgs) Handles midbar.DoubleClick
        midbar.Image = My.Resources.noisia_colorbars400
    End Sub

    Private Sub bottombar_DoubleClick(sender As Object, e As EventArgs) Handles bottombar.DoubleClick
        bottombar.Image = My.Resources.noisia_colorbars400
    End Sub

    Private Sub midbar_Click(sender As Object, e As EventArgs) Handles midbar.Click
        midbar.Image = My.Resources.ice
    End Sub

    Private Sub bottombar_Click(sender As Object, e As EventArgs) Handles bottombar.Click
        bottombar.Image = My.Resources.ice
    End Sub
End Class
