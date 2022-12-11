<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lastfmTrack = New System.Windows.Forms.Label()
        Me.marqueetimer = New System.Windows.Forms.Timer(Me.components)
        Me.jfmtimer = New System.Windows.Forms.Timer(Me.components)
        Me.syncbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jFMUsername = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.welcometxt = New System.Windows.Forms.Label()
        Me.midbar = New System.Windows.Forms.PictureBox()
        Me.bottombar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.midbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bottombar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Last.FM username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Now Playing:"
        '
        'Timer1
        '
        '
        'lastfmTrack
        '
        Me.lastfmTrack.AutoSize = True
        Me.lastfmTrack.Location = New System.Drawing.Point(84, 159)
        Me.lastfmTrack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lastfmTrack.Name = "lastfmTrack"
        Me.lastfmTrack.Size = New System.Drawing.Size(111, 16)
        Me.lastfmTrack.TabIndex = 0
        Me.lastfmTrack.Text = "No music playing... "
        '
        'marqueetimer
        '
        Me.marqueetimer.Interval = 125
        '
        'jfmtimer
        '
        Me.jfmtimer.Interval = 2500
        '
        'syncbtn
        '
        Me.syncbtn.Location = New System.Drawing.Point(200, 25)
        Me.syncbtn.Name = "syncbtn"
        Me.syncbtn.Size = New System.Drawing.Size(84, 23)
        Me.syncbtn.TabIndex = 7
        Me.syncbtn.Text = "Sync"
        Me.ToolTip1.SetToolTip(Me.syncbtn, "Click to sync! It may take a few seconds for the first time.")
        Me.syncbtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "About jFM"
        '
        'jFMUsername
        '
        Me.jFMUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.jFMapp.My.MySettings.Default, "jFMusername", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.jFMUsername.Location = New System.Drawing.Point(7, 25)
        Me.jFMUsername.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.jFMUsername.MaxLength = 15
        Me.jFMUsername.Name = "jFMUsername"
        Me.jFMUsername.Size = New System.Drawing.Size(188, 23)
        Me.jFMUsername.TabIndex = 2
        Me.jFMUsername.TabStop = False
        Me.jFMUsername.Text = Global.jFMapp.My.MySettings.Default.jFMusername
        '
        'welcometxt
        '
        Me.welcometxt.AutoSize = True
        Me.welcometxt.Location = New System.Drawing.Point(4, 68)
        Me.welcometxt.Name = "welcometxt"
        Me.welcometxt.Size = New System.Drawing.Size(96, 16)
        Me.welcometxt.TabIndex = 15
        Me.welcometxt.Text = "Welcome to jFM!"
        '
        'midbar
        '
        Me.midbar.Image = Global.jFMapp.My.Resources.Resources.ice
        Me.midbar.Location = New System.Drawing.Point(-6, 87)
        Me.midbar.Name = "midbar"
        Me.midbar.Size = New System.Drawing.Size(304, 13)
        Me.midbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.midbar.TabIndex = 14
        Me.midbar.TabStop = False
        '
        'bottombar
        '
        Me.bottombar.Image = Global.jFMapp.My.Resources.Resources.ice
        Me.bottombar.Location = New System.Drawing.Point(-6, 181)
        Me.bottombar.Name = "bottombar"
        Me.bottombar.Size = New System.Drawing.Size(304, 20)
        Me.bottombar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bottombar.TabIndex = 13
        Me.bottombar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.jFMapp.My.Resources.Resources.noalbum
        Me.PictureBox1.Location = New System.Drawing.Point(5, 106)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 194)
        Me.Controls.Add(Me.welcometxt)
        Me.Controls.Add(Me.midbar)
        Me.Controls.Add(Me.bottombar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.syncbtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lastfmTrack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.jFMUsername)
        Me.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "jFM Beta"
        CType(Me.midbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bottombar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents jFMUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lastfmTrack As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents marqueetimer As Timer
    Friend WithEvents jfmtimer As Timer
    Friend WithEvents syncbtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents bottombar As PictureBox
    Friend WithEvents midbar As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents welcometxt As Label
End Class
