Public Class frmGuitarChordHero

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub HowToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToToolStripMenuItem.Click
        frmHelp.Show()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Select Case lblChord.Text
            Case "A"
                My.Computer.Audio.Play(My.Resources.A, AudioPlayMode.Background)
            Case "Ab"
                My.Computer.Audio.Play(My.Resources.Ab, AudioPlayMode.Background)
            Case "Am"
                My.Computer.Audio.Play(My.Resources.Am, AudioPlayMode.Background)
            Case "Amaj7"
                My.Computer.Audio.Play(My.Resources.Amaj7, AudioPlayMode.Background)
            Case "Abmaj7"
                My.Computer.Audio.Play(My.Resources.Abmaj7, AudioPlayMode.Background)
            Case "A7"
                My.Computer.Audio.Play(My.Resources.A7, AudioPlayMode.Background)
            Case "Ab7"
                My.Computer.Audio.Play(My.Resources.Ab7, AudioPlayMode.Background)
            Case "Am7"
                My.Computer.Audio.Play(My.Resources.Am7, AudioPlayMode.Background)
            Case "A sus"
                My.Computer.Audio.Play(My.Resources.Asus, AudioPlayMode.Background)
            Case "Ab sus"
                My.Computer.Audio.Play(My.Resources.Absus, AudioPlayMode.Background)
            Case "B"
                My.Computer.Audio.Play(My.Resources.B, AudioPlayMode.Background)
            Case "Bmaj7"
                My.Computer.Audio.Play(My.Resources.Bmaj7, AudioPlayMode.Background)
            Case "B7"
                My.Computer.Audio.Play(My.Resources.B7, AudioPlayMode.Background)
            Case "B sus"
                My.Computer.Audio.Play(My.Resources.Bsus, AudioPlayMode.Background)
            Case "Bm"
                My.Computer.Audio.Play(My.Resources.Bm, AudioPlayMode.Background)
            Case "Bm7"
                My.Computer.Audio.Play(My.Resources.Bm7, AudioPlayMode.Background)
            Case "Bb"
                My.Computer.Audio.Play(My.Resources.Bb, AudioPlayMode.Background)
            Case "Bbmaj7"
                My.Computer.Audio.Play(My.Resources.Bbmaj7, AudioPlayMode.Background)
            Case "Bb7"
                My.Computer.Audio.Play(My.Resources.Bb7, AudioPlayMode.Background)
            Case "Bb sus"
                My.Computer.Audio.Play(My.Resources.Bbsus, AudioPlayMode.Background)
            Case "Bbm"
                My.Computer.Audio.Play(My.Resources.Bbm, AudioPlayMode.Background)
            Case "Bbm7"
                My.Computer.Audio.Play(My.Resources.Bbm7, AudioPlayMode.Background)
            Case "C"
                My.Computer.Audio.Play(My.Resources.C, AudioPlayMode.Background)
            Case "Cmaj7"
                My.Computer.Audio.Play(My.Resources.Cmaj7, AudioPlayMode.Background)
            Case "C7"
                My.Computer.Audio.Play(My.Resources.C7, AudioPlayMode.Background)
            Case "C sus"
                My.Computer.Audio.Play(My.Resources.Csus, AudioPlayMode.Background)
            Case "Cm"
                My.Computer.Audio.Play(My.Resources.Cm, AudioPlayMode.Background)
            Case "Cm7"
                My.Computer.Audio.Play(My.Resources.Cm7, AudioPlayMode.Background)
            Case "C#m"
                My.Computer.Audio.Play(My.Resources.C_m, AudioPlayMode.Background)
            Case "C#m7"
                My.Computer.Audio.Play(My.Resources.C_m7, AudioPlayMode.Background)
            Case "D"
                My.Computer.Audio.Play(My.Resources.D, AudioPlayMode.Background)
            Case "Dmaj7"
                My.Computer.Audio.Play(My.Resources.Dmaj7, AudioPlayMode.Background)
            Case "D7"
                My.Computer.Audio.Play(My.Resources.D7, AudioPlayMode.Background)
            Case "D sus"
                My.Computer.Audio.Play(My.Resources.Dsus, AudioPlayMode.Background)
            Case "Dm"
                My.Computer.Audio.Play(My.Resources.Dm, AudioPlayMode.Background)
            Case "Dm7"
                My.Computer.Audio.Play(My.Resources.Dm7, AudioPlayMode.Background)
            Case "Db"
                My.Computer.Audio.Play(My.Resources.Db, AudioPlayMode.Background)
            Case "Dbmaj7"
                My.Computer.Audio.Play(My.Resources.Dbmaj7, AudioPlayMode.Background)
            Case "Db7"
                My.Computer.Audio.Play(My.Resources.Db7, AudioPlayMode.Background)
            Case "Db sus"
                My.Computer.Audio.Play(My.Resources.Dbsus, AudioPlayMode.Background)
            Case "E"
                My.Computer.Audio.Play(My.Resources.E, AudioPlayMode.Background)
            Case "Emaj7"
                My.Computer.Audio.Play(My.Resources.Emaj7, AudioPlayMode.Background)
            Case "E7"
                My.Computer.Audio.Play(My.Resources.E7, AudioPlayMode.Background)
            Case "E sus"
                My.Computer.Audio.Play(My.Resources.Esus, AudioPlayMode.Background)
            Case "Em"
                My.Computer.Audio.Play(My.Resources.Em, AudioPlayMode.Background)
            Case "Em7"
                My.Computer.Audio.Play(My.Resources.Em7, AudioPlayMode.Background)
            Case "Eb"
                My.Computer.Audio.Play(My.Resources.Eb, AudioPlayMode.Background)
            Case "Ebmaj7"
                My.Computer.Audio.Play(My.Resources.Ebmaj7, AudioPlayMode.Background)
            Case "Eb7"
                My.Computer.Audio.Play(My.Resources.Eb7, AudioPlayMode.Background)
            Case "Eb sus"
                My.Computer.Audio.Play(My.Resources.Ebsus, AudioPlayMode.Background)
            Case "Ebm"
                My.Computer.Audio.Play(My.Resources.Ebm, AudioPlayMode.Background)
            Case "Ebm7"
                My.Computer.Audio.Play(My.Resources.Ebm7, AudioPlayMode.Background)
            Case "F"
                My.Computer.Audio.Play(My.Resources.F, AudioPlayMode.Background)
            Case "Fmaj7"
                My.Computer.Audio.Play(My.Resources.Fmaj7, AudioPlayMode.Background)
            Case "F7"
                My.Computer.Audio.Play(My.Resources.F7, AudioPlayMode.Background)
            Case "F sus"
                My.Computer.Audio.Play(My.Resources.Fsus, AudioPlayMode.Background)
            Case "Fm"
                My.Computer.Audio.Play(My.Resources.Fm, AudioPlayMode.Background)
            Case "Fm7"
                My.Computer.Audio.Play(My.Resources.Fm7, AudioPlayMode.Background)
            Case "F#"
                My.Computer.Audio.Play(My.Resources.F_, AudioPlayMode.Background)
            Case "F#7"
                My.Computer.Audio.Play(My.Resources.F_7, AudioPlayMode.Background)
            Case "F#m"
                My.Computer.Audio.Play(My.Resources.F_m, AudioPlayMode.Background)
            Case "F#m7"
                My.Computer.Audio.Play(My.Resources.F_m7, AudioPlayMode.Background)
            Case "G"
                My.Computer.Audio.Play(My.Resources.G, AudioPlayMode.Background)
            Case "Gmaj7"
                My.Computer.Audio.Play(My.Resources.Gmaj7, AudioPlayMode.Background)
            Case "G7"
                My.Computer.Audio.Play(My.Resources.G7, AudioPlayMode.Background)
            Case "G sus"
                My.Computer.Audio.Play(My.Resources.Gsus, AudioPlayMode.Background)
            Case "Gm"
                My.Computer.Audio.Play(My.Resources.Gm, AudioPlayMode.Background)
            Case "Gm7"
                My.Computer.Audio.Play(My.Resources.Gm7, AudioPlayMode.Background)
            Case "G#m"
                My.Computer.Audio.Play(My.Resources.G_m, AudioPlayMode.Background)
            Case "G#m7"
                My.Computer.Audio.Play(My.Resources.G_m7, AudioPlayMode.Background)
            Case "Gbmaj7"
                My.Computer.Audio.Play(My.Resources.Gbmaj7, AudioPlayMode.Background)
            Case "Gb sus"
                My.Computer.Audio.Play(My.Resources.Gbsus, AudioPlayMode.Background)

        End Select
    End Sub

    Public Sub HideBoxes()
        Me.ckbFingerPosition1.Hide()
        Me.ckbFingerPosition2.Hide()
        Me.ckbFingerPosition3.Hide()
        Me.ckbFingerPosition4.Hide()
        Me.ckbFingerPosition5.Hide()
        Me.ckbFingerPosition6.Hide()
        Me.ckbFingerPosition7.Hide()
        Me.ckbFingerPosition8.Hide()
        Me.ckbFingerPosition9.Hide()
        Me.ckbFingerPosition10.Hide()
        Me.ckbFingerPosition11.Hide()
        Me.ckbFingerPosition12.Hide()
        Me.ckbFingerPosition13.Hide()
        Me.ckbFingerPosition14.Hide()
        Me.ckbFingerPosition15.Hide()
        Me.ckbFingerPosition16.Hide()
        Me.ckbFingerPosition17.Hide()
        Me.ckbFingerPosition18.Hide()
        Me.ckbFingerPosition19.Hide()
        Me.ckbFingerPosition20.Hide()
        Me.ckbFingerPosition21.Hide()
        Me.ckbFingerPosition22.Hide()
        Me.ckbFingerPosition23.Hide()
        Me.ckbFingerPosition24.Hide()
        Me.ckbFingerPosition25.Hide()
        Me.ckbFingerPosition26.Hide()
        Me.ckbFingerPosition27.Hide()
        Me.ckbFingerPosition28.Hide()
        Me.ckbFingerPosition29.Hide()
        Me.ckbFingerPosition30.Hide()
        Me.ckbFingerPosition31.Hide()
        Me.ckbFingerPosition32.Hide()
        Me.ckbFingerPosition33.Hide()
        Me.ckbFingerPosition34.Hide()
        Me.ckbFingerPosition35.Hide()
        Me.ckbFingerPosition36.Hide()
        Me.ckbFingerPosition38.Hide()
    End Sub

    Private Sub btnAChord_Click(sender As Object, e As EventArgs) Handles btnAMajor.Click
        Me.lblChord.Text = "A"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition10.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "O"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnBChord_Click(sender As Object, e As EventArgs) Handles btnAbMajor.Click
        Me.lblChord.Text = "Ab"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition19.Show()
        Me.ckbFingerPosition20.Show()
        Me.ckbFingerPosition24.Show()
        Me.ckbFingerPosition27.Show()
        Me.ckbFingerPosition34.Show()
        Me.ckbFingerPosition35.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnCChord_Click(sender As Object, e As EventArgs) Handles btnBMajor.Click
        Me.lblChord.Text = "B"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition11.Show()
        Me.ckbFingerPosition20.Show()
        Me.ckbFingerPosition21.Show()
        Me.ckbFingerPosition22.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnBbMajor_Click(sender As Object, e As EventArgs) Handles btnBbMajor.Click
        Me.lblChord.Text = "Bb"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition5.Show()
        Me.ckbFingerPosition14.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition16.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnCMajor_Click(sender As Object, e As EventArgs) Handles btnCMajor.Click
        Me.lblChord.Text = "C"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition17.Show()
        Me.ckbFingerPosition18.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = "O"
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnDMajor_Click(sender As Object, e As EventArgs) Handles btnDMajor.Click
        Me.lblChord.Text = "D"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition14.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = "O"
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnDbMajor_Click(sender As Object, e As EventArgs) Handles btnDbMajor.Click
        Me.lblChord.Text = "Db"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition16.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnEMajor_Click_1(sender As Object, e As EventArgs) Handles btnEMajor.Click
        Me.lblChord.Text = "E"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition11.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = "O"
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "O"
    End Sub

    Private Sub btnEbMajor_Click(sender As Object, e As EventArgs) Handles btnEbMajor.Click
        Me.lblChord.Text = "Eb"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition13.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition20.Show()
        Me.ckbFingerPosition28.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnFMajor_Click_1(sender As Object, e As EventArgs) Handles btnFMajor.Click
        Me.lblChord.Text = "F"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition6.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition16.Show()
        Me.ckbFingerPosition17.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnFSharpMajor_Click(sender As Object, e As EventArgs) Handles btnFSharpMajor.Click
        Me.lblChord.Text = "F#"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition12.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition22.Show()
        Me.ckbFingerPosition23.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnGMajor_Click_1(sender As Object, e As EventArgs) Handles btnGMajor.Click
        Me.lblChord.Text = "G"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition11.Show()
        Me.ckbFingerPosition13.Show()
        Me.ckbFingerPosition18.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = "O"
        Me.lblStringToPick3.Text = "O"
        Me.lblStringToPick4.Text = "O"
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnAMinor_Click(sender As Object, e As EventArgs) Handles btnAMinor.Click
        Me.lblChord.Text = "Am"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition10.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "O"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnBMinor_Click(sender As Object, e As EventArgs) Handles btnBMinor.Click
        Me.lblChord.Text = "Bm"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition11.Show()
        Me.ckbFingerPosition14.Show()
        Me.ckbFingerPosition21.Show()
        Me.ckbFingerPosition22.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnBbMinor_Click(sender As Object, e As EventArgs) Handles btnBbMinor.Click
        Me.lblChord.Text = "Bbm"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition5.Show()
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition16.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnCMinor_Click(sender As Object, e As EventArgs) Handles btnCMinor.Click
        Me.lblChord.Text = "Cm"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition13.Show()
        Me.ckbFingerPosition17.Show()
        Me.ckbFingerPosition20.Show()
        Me.ckbFingerPosition27.Show()
        Me.ckbFingerPosition28.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnCSharpMinor_Click(sender As Object, e As EventArgs) Handles btnCSharpMinor.Click
        Me.lblChord.Text = "C#m"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition10.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnDMinor_Click(sender As Object, e As EventArgs) Handles btnDMinor.Click
        Me.lblChord.Text = "Dm"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition14.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = "O"
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnEMinor_Click(sender As Object, e As EventArgs) Handles btnEMinor.Click
        Me.lblChord.Text = "Em"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition11.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = "O"
        Me.lblStringToPick3.Text = "O"
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "O"
    End Sub

    Private Sub btnEbMinor_Click(sender As Object, e As EventArgs) Handles btnEbMinor.Click
        Me.lblChord.Text = "Ebm"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition20.Show()
        Me.ckbFingerPosition22.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnFMinor_Click(sender As Object, e As EventArgs) Handles btnFMinor.Click
        Me.lblChord.Text = "Fm"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition6.Show()
        Me.ckbFingerPosition16.Show()
        Me.ckbFingerPosition17.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnFSharpMinor_Click(sender As Object, e As EventArgs) Handles btnFSharpMinor.Click
        Me.lblChord.Text = "F#m"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition12.Show()
        Me.ckbFingerPosition22.Show()
        Me.ckbFingerPosition23.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnGMinor_Click(sender As Object, e As EventArgs) Handles btnGMinor.Click
        Me.lblChord.Text = "Gm"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition13.Show()
        Me.ckbFingerPosition14.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition18.Show()
        Me.ckbFingerPosition28.Show()
        Me.ckbFingerPosition29.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnGSharpMinor_Click(sender As Object, e As EventArgs) Handles btnGSharpMinor.Click
        Me.lblChord.Text = "G#m"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition19.Show()
        Me.ckbFingerPosition20.Show()
        Me.ckbFingerPosition21.Show()
        Me.ckbFingerPosition24.Show()
        Me.ckbFingerPosition34.Show()
        Me.ckbFingerPosition35.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnAsus_Click(sender As Object, e As EventArgs) Handles btnAsus.Click
        Me.lblChord.Text = "A sus"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition14.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnAbsus_Click(sender As Object, e As EventArgs) Handles btnAbsus.Click
        Me.lblChord.Text = "Ab sus"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition4.Show()
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition19.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnBsus_Click(sender As Object, e As EventArgs) Handles btnBsus.Click
        Me.lblChord.Text = "B sus"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition21.Show()
        Me.ckbFingerPosition22.Show()
        Me.ckbFingerPosition26.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnBbsus_Click(sender As Object, e As EventArgs) Handles btnBbsus.Click
        Me.lblChord.Text = "Bb sus"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition16.Show()
        Me.ckbFingerPosition20.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnCsus_Click(sender As Object, e As EventArgs) Handles btnCsus.Click
        Me.lblChord.Text = "C sus"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition13.Show()
        Me.ckbFingerPosition16.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = "O"
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnDsus_Click(sender As Object, e As EventArgs) Handles btnDsus.Click
        Me.lblChord.Text = "D sus"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition13.Show()
        Me.ckbFingerPosition14.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = "O"
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnDbsus_Click(sender As Object, e As EventArgs) Handles btnDbsus.Click
        Me.lblChord.Text = "Db sus"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition19.Show()
        Me.ckbFingerPosition33.Show()
        Me.ckbFingerPosition34.Show()
        Me.ckbFingerPosition38.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnEsus_Click(sender As Object, e As EventArgs) Handles btnEsus.Click
        Me.lblChord.Text = "E sus"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition11.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = "O"
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "O"
    End Sub

    Private Sub btnEbsus_Click(sender As Object, e As EventArgs) Handles btnEbsus.Click
        Me.lblChord.Text = "Eb sus"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition4.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition19.Show()
        Me.ckbFingerPosition20.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnFsus_Click(sender As Object, e As EventArgs) Handles btnFsus.Click
        Me.lblChord.Text = "F sus"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition16.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnGsus_Click(sender As Object, e As EventArgs) Handles btnGsus.Click
        Me.lblChord.Text = "G sus"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition13.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = "O"
        Me.lblStringToPick4.Text = "O"
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnGbsus_Click(sender As Object, e As EventArgs) Handles btnGbsus.Click
        Me.lblChord.Text = "Gb sus"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition21.Show()
        Me.ckbFingerPosition22.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnAMajor7th_Click(sender As Object, e As EventArgs) Handles btnAMajor7th.Click
        Me.lblChord.Text = "Amaj7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition10.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "O"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnAbMajor7th_Click(sender As Object, e As EventArgs) Handles btnAbMajor7th.Click
        Me.lblChord.Text = "Abmaj7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition4.Show()
        Me.ckbFingerPosition13.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnBMajor7th_Click(sender As Object, e As EventArgs) Handles btnBMajor7th.Click
        Me.lblChord.Text = "Bmaj7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition11.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition20.Show()
        Me.ckbFingerPosition22.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "X"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnBbMajor7th_Click(sender As Object, e As EventArgs) Handles btnBbMajor7th.Click
        Me.lblChord.Text = "Bbmaj7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition5.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition14.Show()
        Me.ckbFingerPosition16.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "X"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnCMajor7th_Click(sender As Object, e As EventArgs) Handles btnCMajor7th.Click
        Me.lblChord.Text = "Cmaj7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition17.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = "O"
        Me.lblStringToPick3.Text = "O"
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnDMajor7th_Click(sender As Object, e As EventArgs) Handles btnDMajor7th.Click
        Me.lblChord.Text = "Dmaj7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition9.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = "O"
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnDbMajor7th_Click(sender As Object, e As EventArgs) Handles btnDbMajor7th.Click
        Me.lblChord.Text = "Dbmaj7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition16.Show()
        Me.ckbFingerPosition23.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnEMajor7th_Click(sender As Object, e As EventArgs) Handles btnEMajor7th.Click
        Me.lblChord.Text = "Emaj7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition4.Show()
        Me.ckbFingerPosition11.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "X"
        Me.lblStringToPick2.Text = "O"
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "O"
    End Sub

    Private Sub btnEbMajor7th_Click(sender As Object, e As EventArgs) Handles btnEbMajor7th.Click
        Me.lblChord.Text = "Ebmaj7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition4.Show()
        Me.ckbFingerPosition13.Show()
        Me.ckbFingerPosition14.Show()
        Me.ckbFingerPosition15.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnFMajor7th_Click(sender As Object, e As EventArgs) Handles btnFMajor7th.Click
        Me.lblChord.Text = "Fmaj7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition16.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnGMajor7th_Click(sender As Object, e As EventArgs) Handles btnGMajor7th.Click
        Me.lblChord.Text = "Gmaj7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition14.Show()
        Me.ckbFingerPosition21.Show()
        Me.ckbFingerPosition28.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnGbMajor7th_Click(sender As Object, e As EventArgs) Handles btnGbMajor7th.Click
        Me.lblChord.Text = "Gbmaj7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition22.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnAMinor7th_Click(sender As Object, e As EventArgs) Handles btnAMinor7th.Click
        Me.lblChord.Text = "Am7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition13.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "O"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnBMinor7th_Click(sender As Object, e As EventArgs) Handles btnBMinor7th.Click
        Me.lblChord.Text = "Bm7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition11.Show()
        Me.ckbFingerPosition14.Show()
        Me.ckbFingerPosition22.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnBbMinor7th_Click(sender As Object, e As EventArgs) Handles btnBbMinor7th.Click
        Me.lblChord.Text = "Bbm7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition16.Show()
        Me.ckbFingerPosition19.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnCMinor7th_Click(sender As Object, e As EventArgs) Handles btnCMinor7th.Click
        Me.lblChord.Text = "Cm7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition4.Show()
        Me.ckbFingerPosition13.Show()
        Me.ckbFingerPosition15.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnCSharpMinor7th_Click(sender As Object, e As EventArgs) Handles btnCSharpMinor7th.Click
        Me.lblChord.Text = "C#m7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition19.Show()
        Me.ckbFingerPosition21.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnDMinor7th_Click(sender As Object, e As EventArgs) Handles btnDMinor7th.Click
        Me.lblChord.Text = "Dm7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition9.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = "O"
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnEMinor7th_Click(sender As Object, e As EventArgs) Handles btnEMinor7th.Click
        Me.lblChord.Text = "Em7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition11.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = "O"
        Me.lblStringToPick3.Text = "O"
        Me.lblStringToPick4.Text = "O"
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "O"
    End Sub

    Private Sub btnEbMinor7th_Click(sender As Object, e As EventArgs) Handles btnEbMinor7th.Click
        Me.lblChord.Text = "Ebm7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition4.Show()
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition15.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnFMinor7th_Click(sender As Object, e As EventArgs) Handles btnFMinor7th.Click
        Me.lblChord.Text = "Fm7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition4.Show()
        Me.ckbFingerPosition6.Show()
        Me.ckbFingerPosition17.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnFSharpMinor7th_Click(sender As Object, e As EventArgs) Handles btnFSharpMinor7th.Click
        Me.lblChord.Text = "F#m7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition10.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnGMinor7th_Click(sender As Object, e As EventArgs) Handles btnGMinor7th.Click
        Me.lblChord.Text = "Gm7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition13.Show()
        Me.ckbFingerPosition14.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition16.Show()
        Me.ckbFingerPosition18.Show()
        Me.ckbFingerPosition29.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnGSharpMinor7th_Click(sender As Object, e As EventArgs) Handles btnGSharpMinor7th.Click
        Me.lblChord.Text = "G#m7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition4.Show()
        Me.ckbFingerPosition7.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = "O"
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnA7th_Click(sender As Object, e As EventArgs) Handles btnA7th.Click
        Me.lblChord.Text = "A7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition13.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "O"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnAflat7th_Click(sender As Object, e As EventArgs) Handles btnAflat7th.Click
        Me.lblChord.Text = "Ab7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition4.Show()
        Me.ckbFingerPosition7.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnB7th_Click(sender As Object, e As EventArgs) Handles btnB7th.Click
        Me.lblChord.Text = "B7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition4.Show()
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition11.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = "O"
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "O"
    End Sub

    Private Sub btnBb7th_Click(sender As Object, e As EventArgs) Handles btnBb7th.Click
        Me.lblChord.Text = "Bb7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition14.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition16.Show()
        Me.ckbFingerPosition19.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnC7th_Click(sender As Object, e As EventArgs) Handles btnC7th.Click
        Me.lblChord.Text = "C7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition17.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "O"
    End Sub

    Private Sub btnD7th_Click(sender As Object, e As EventArgs) Handles btnD7th.Click
        Me.lblChord.Text = "D7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition9.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = "O"
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnDb7th_Click(sender As Object, e As EventArgs) Handles btnDb7th.Click
        Me.lblChord.Text = "Db7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition16.Show()
        Me.ckbFingerPosition19.Show()
        Me.ckbFingerPosition21.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnE7th_Click(sender As Object, e As EventArgs) Handles btnE7th.Click
        Me.lblChord.Text = "E7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition11.Show()
        Me.ckbFingerPosition14.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "O"
    End Sub

    Private Sub btnEb7th_Click(sender As Object, e As EventArgs) Handles btnEb7th.Click
        Me.lblChord.Text = "Eb7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition4.Show()
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition13.Show()
        Me.ckbFingerPosition15.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnF7th_Click(sender As Object, e As EventArgs) Handles btnF7th.Click
        Me.lblChord.Text = "F7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition4.Show()
        Me.ckbFingerPosition6.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition17.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnFSharp7th_Click(sender As Object, e As EventArgs) Handles btnFSharp7th.Click
        Me.lblChord.Text = "F#7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition8.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition22.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnG7th_Click(sender As Object, e As EventArgs) Handles btnG7th.Click
        Me.lblChord.Text = "G7"
        Me.lblChord.Visible = True
        'Calls HideBoxes procedure
        Call HideBoxes()
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition11.Show()
        Me.ckbFingerPosition18.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = "O"
        Me.lblStringToPick3.Text = "O"
        Me.lblStringToPick4.Text = "O"
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

End Class
