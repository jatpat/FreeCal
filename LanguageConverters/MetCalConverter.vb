'
' Created by SharpDevelop.
' User: Amber
' Date: 5/17/2005
' Time: 5:18 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Threading
Imports Microsoft.VisualBasic.ControlChars
Imports System.IO
Imports Microsoft.VisualBasic

Public Class MetCalConverter
    Inherits System.Windows.Forms.Form
    Private ModifedText As String
    Private WithEvents fdLoadFile As System.Windows.Forms.OpenFileDialog
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnLoad As System.Windows.Forms.Button
    Private WithEvents btnConvert As System.Windows.Forms.Button
    Private WithEvents tbSaveFile As System.Windows.Forms.TextBox
    Private WithEvents tbLoadFile As System.Windows.Forms.TextBox
    Private WithEvents tbModified As System.Windows.Forms.TextBox
    Private WithEvents btnBrowseForLoadFile As System.Windows.Forms.Button
    Private WithEvents tbLoaded As System.Windows.Forms.TextBox
    Private WithEvents btnBrowseForSaveFile As System.Windows.Forms.Button

    Public Shared Sub Main()
        Dim fMainForm As New MetCalConverter
        fMainForm.ShowDialog()
    End Sub

    Public Sub New()
        MyBase.New()
        '
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        '
        Me.InitializeComponent()
    End Sub

#Region " Windows Forms Designer generated code "
    ' This method is required for Windows Forms designer support.
    ' Do not change the method contents inside the source code editor. The Forms designer might
    ' not be able to load this method if it was changed manually.
    Private Sub InitializeComponent()
        Me.btnBrowseForSaveFile = New System.Windows.Forms.Button()
        Me.tbLoaded = New System.Windows.Forms.TextBox()
        Me.btnBrowseForLoadFile = New System.Windows.Forms.Button()
        Me.tbModified = New System.Windows.Forms.TextBox()
        Me.tbLoadFile = New System.Windows.Forms.TextBox()
        Me.tbSaveFile = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.fdLoadFile = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnBrowseForSaveFile
        '
        Me.btnBrowseForSaveFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseForSaveFile.Location = New System.Drawing.Point(1488, 804)
        Me.btnBrowseForSaveFile.Name = "btnBrowseForSaveFile"
        Me.btnBrowseForSaveFile.Size = New System.Drawing.Size(48, 42)
        Me.btnBrowseForSaveFile.TabIndex = 8
        Me.btnBrowseForSaveFile.Text = "..."
        '
        'tbLoaded
        '
        Me.tbLoaded.Location = New System.Drawing.Point(16, 15)
        Me.tbLoaded.MaxLength = 100000
        Me.tbLoaded.Multiline = True
        Me.tbLoaded.Name = "tbLoaded"
        Me.tbLoaded.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbLoaded.Size = New System.Drawing.Size(752, 679)
        Me.tbLoaded.TabIndex = 0
        Me.tbLoaded.WordWrap = False
        '
        'btnBrowseForLoadFile
        '
        Me.btnBrowseForLoadFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseForLoadFile.Location = New System.Drawing.Point(720, 804)
        Me.btnBrowseForLoadFile.Name = "btnBrowseForLoadFile"
        Me.btnBrowseForLoadFile.Size = New System.Drawing.Size(48, 42)
        Me.btnBrowseForLoadFile.TabIndex = 7
        Me.btnBrowseForLoadFile.Text = "..."
        '
        'tbModified
        '
        Me.tbModified.Location = New System.Drawing.Point(784, 15)
        Me.tbModified.MaxLength = 200000
        Me.tbModified.Multiline = True
        Me.tbModified.Name = "tbModified"
        Me.tbModified.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbModified.Size = New System.Drawing.Size(752, 679)
        Me.tbModified.TabIndex = 2
        Me.tbModified.WordWrap = False
        '
        'tbLoadFile
        '
        Me.tbLoadFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbLoadFile.Location = New System.Drawing.Point(16, 804)
        Me.tbLoadFile.Name = "tbLoadFile"
        Me.tbLoadFile.Size = New System.Drawing.Size(704, 31)
        Me.tbLoadFile.TabIndex = 5
        Me.tbLoadFile.Text = "Agilent8564E\Agilent8564E.txt"
        '
        'tbSaveFile
        '
        Me.tbSaveFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbSaveFile.Location = New System.Drawing.Point(784, 804)
        Me.tbSaveFile.Name = "tbSaveFile"
        Me.tbSaveFile.Size = New System.Drawing.Size(704, 31)
        Me.tbSaveFile.TabIndex = 6
        '
        'btnConvert
        '
        Me.btnConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConvert.Location = New System.Drawing.Point(704, 863)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(150, 42)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Convert"
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLoad.Location = New System.Drawing.Point(272, 863)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(150, 42)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Load"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(1104, 863)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 42)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        '
        'fdLoadFile
        '
        Me.fdLoadFile.Filter = "Text files|*.txt"
        Me.fdLoadFile.Title = "Choose file to load"
        '
        'MetCalConverter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(10, 24)
        Me.ClientSize = New System.Drawing.Size(1600, 918)
        Me.Controls.Add(Me.btnBrowseForSaveFile)
        Me.Controls.Add(Me.btnBrowseForLoadFile)
        Me.Controls.Add(Me.tbSaveFile)
        Me.Controls.Add(Me.tbLoadFile)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.tbModified)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.tbLoaded)
        Me.Name = "MetCalConverter"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private Sub BtnLoadClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        If Not File.Exists(Me.tbLoadFile.Text.Trim) Then
            MessageBox.Show("You must select a valid file to load from before proceeding!")
            Return
        End If
        Dim FS As New FileStream(Me.tbLoadFile.Text, FileMode.Open)
        Dim SR As New StreamReader(FS)
        Me.tbLoaded.Text = SR.ReadToEnd
        SR.Close()
    End Sub

    Private Sub BtnBrowseForLoadFileClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseForLoadFile.Click
        If Me.fdLoadFile.ShowDialog = DialogResult.OK Then
            Me.tbLoadFile.Text = Me.fdLoadFile.FileName
        End If
    End Sub

    Private Sub BtnBrowseForSaveFileClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseForSaveFile.Click
        Dim FI As New FileInfo(Me.tbLoadFile.Text.Trim)
        Me.fdLoadFile.InitialDirectory = FI.DirectoryName
        If Me.fdLoadFile.ShowDialog = DialogResult.OK Then
            Me.tbSaveFile.Text = Me.fdLoadFile.FileName
            If Not File.Exists(Me.tbSaveFile.Text) Then
                File.Create(Me.tbSaveFile.Text)
            End If
        End If
    End Sub

    Private Sub BtnConvertClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Me.ModifedText = ""
        Me.tbModified.Text = ""
        For Each CurrentLine As String In Me.tbLoaded.Lines
            CurrentLine = Me.RemoveLineNumber(CurrentLine)
            CurrentLine = Trim(CurrentLine)
            If CurrentLine.StartsWith("IEEE") Then
                CurrentLine = Me.ProcessDelayTime(CurrentLine)
            End If
            Me.ModifedText = Me.ModifedText & CurrentLine
        Next
        Me.tbModified.Text = Me.ModifedText
    End Sub

    Private Sub BtnSaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not File.Exists(Me.tbSaveFile.Text.Trim) Then
            MessageBox.Show("You must provide a valid filename and directory to save!")
            Return
        End If
        Dim FS As New FileStream(Me.tbSaveFile.Text.Trim, FileMode.CreateNew)
        Dim SW As New StreamWriter(FS)
        SW.Write(Me.tbModified.Text)
        SW.Close()
    End Sub

    Public Function RemoveLineNumber(ByVal currentLine As String) As String
        If currentLine.Length > 9 Then
            Return currentLine.Remove(0, 8) & NewLine
        End If
        Return currentLine
    End Function

    Private Function ProcessDelayTime(ByVal currentLine As String) As String
        Dim ModifiedLine As String = String.Empty
        If currentLine.Contains("[D") Then
            Dim BeginingSegment As String = currentLine.Substring(0, currentLine.IndexOf("[D"))
            Dim RemainingSegment As String = currentLine.Replace(BeginingSegment, "")
            BeginingSegment = BeginingSegment.Replace("IEEE", "").Trim
            ModifiedLine = "Me.DUT.Write(" & Quote & BeginingSegment & Quote & ")" & NewLine
            Dim TimeSegment As String = RemainingSegment.Substring(0, RemainingSegment.IndexOf("]"))
            ModifiedLine = ModifiedLine & "Me.Sleep(" & TimeSegment.Replace("[D", "").Replace("]", "") & ")" & NewLine
            RemainingSegment = RemainingSegment.Remove(0, RemainingSegment.IndexOf("]") + 1)
            ModifiedLine = ModifiedLine & RemainingSegment & NewLine
            If RemainingSegment.Contains("[D") Then
                currentLine = RemainingSegment
                BeginingSegment = currentLine.Substring(0, currentLine.IndexOf("[D"))
                RemainingSegment = currentLine.Replace(BeginingSegment, "")
                BeginingSegment = BeginingSegment.Replace("IEEE", "").Trim
                ModifiedLine = "Me.DUT.Write(" & Quote & BeginingSegment & Quote & ")" & NewLine
                TimeSegment = RemainingSegment.Substring(0, RemainingSegment.IndexOf("]"))
                ModifiedLine = ModifiedLine & "Me.Sleep(" & TimeSegment.Replace("[D", "").Replace("]", "") & ")" & NewLine
                RemainingSegment = RemainingSegment.Remove(0, RemainingSegment.IndexOf("]") + 1)
                ModifiedLine = ModifiedLine & RemainingSegment & NewLine
                If RemainingSegment.Contains("[D") Then
                    currentLine = RemainingSegment
                    BeginingSegment = currentLine.Substring(0, currentLine.IndexOf("[D"))
                    RemainingSegment = currentLine.Replace(BeginingSegment, "")
                    BeginingSegment = BeginingSegment.Replace("IEEE", "").Trim
                    ModifiedLine = "Me.DUT.Write(" & Quote & BeginingSegment & Quote & ")" & NewLine
                    TimeSegment = RemainingSegment.Substring(0, RemainingSegment.IndexOf("]"))
                    ModifiedLine = ModifiedLine & "Me.Sleep(" & TimeSegment.Replace("[D", "").Replace("]", "") & ")" & NewLine
                    RemainingSegment = RemainingSegment.Remove(0, RemainingSegment.IndexOf("]") + 1)
                    ModifiedLine = ModifiedLine & RemainingSegment & NewLine
                End If
            End If

            '			Dim TimeStartPosition As Integer = Line.IndexOf("[D")
            '			Dim TimeStopPosistion As Integer = Line.IndexOf("]", TimeStartPosition)
            '			Dim SleepTimeAndRestOfLine As String = Line.Substring(TimeStartPosition)
            '			Dim SleepTime As String = Line.Substring(TimeStartPosition, TimeStopPosistion - TimeStartPosition + 1)
            '			Dim StartOfNewL As String = Line.Replace(SleepTimeAndRestOfLine, "")
            '			SleepTimeAndRestOfLine = SleepTimeAndRestOfLine.Replace(SleepTime, "")
            '			Me.ModifedText = Me.ModifedText & "Me.DUT.Write(" & Quote & StartOfNewL & Quote & ")" & NewLine
            '			Me.ModifedText = Me.ModifedText & "Me.Sleep(" & SleepTime.Replace("[D", "").Replace("]", "") & ")" & NewLine
            '			Me.ModifedText = Me.ModifedText & "Me.DUT.Write(" & Quote & SleepTimeAndRestOfLine & Quote & ")" & NewLine
            '			If InStr(StartOfNewL, "[D") Then
            '				ProcessTime(StartOfNewL)
            '			End If
            '			If InStr(SleepTimeAndRestOfLine, "[D") Then
            '				ProcessTime(SleepTimeAndRestOfLine)
            '			End If
            '			If InStr(StartOfNewL, "[D") Then
            '				ProcessTime(StartOfNewL)
            '			End If
            '			If InStr(SleepTimeAndRestOfLine, "[D") Then
            '				ProcessTime(SleepTimeAndRestOfLine)
            '			End If
            Return ModifiedLine
        End If
        Return ModifiedLine
    End Function

End Class

