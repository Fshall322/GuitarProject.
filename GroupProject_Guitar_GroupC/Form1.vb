Public Class Form1
    'Procedure to clear all Check Boxes.
    Public Sub clearcheckboxes()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).CheckState = CheckState.Unchecked
            End If
        Next ctrl
    End Sub
    'Porcedure To Hide all Checkboxes
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
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Calls the HideBoxes procedure to hide all check boxes on Form1 load.
        Call HideBoxes()
        'Code to hide all StringToPick labels on Form1 load
        Me.lblStringToPick1.Hide()
        Me.lblStringToPick2.Hide()
        Me.lblStringToPick3.Hide()
        Me.lblStringToPick4.Hide()
        Me.lblStringToPick5.Hide()
        Me.lblStringToPick6.Hide()
    End Sub

    Private Sub btnAChord_Click(sender As Object, e As EventArgs) Handles btnAChord.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnAchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check the following checkboxes
        Me.ckbFingerPosition2.Checked = True
        Me.ckbFingerPosition3.Checked = True
        Me.ckbFingerPosition4.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition4.Show()
        'Code to show the 6 StringToPick labels
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "O"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnBChord_Click(sender As Object, e As EventArgs) Handles btnBChord.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnBchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check three following checkboxes
        Me.ckbFingerPosition7.Checked = True
        Me.ckbFingerPosition20.Checked = True
        Me.ckbFingerPosition21.Checked = True
        Me.ckbFingerPosition22.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show the 6 StringToPick labels
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition20.Show()
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

    Private Sub btnCChord_Click(sender As Object, e As EventArgs) Handles btnCChord.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnCchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check the following checkboxes
        Me.ckbFingerPosition2.Checked = True
        Me.ckbFingerPosition10.Checked = True
        Me.ckbFingerPosition17.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition17.Show()
        'Code to show the 6 StringToPick labels
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = "O"
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnDChord_Click(sender As Object, e As EventArgs) Handles btnDChord.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnDchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check the following checkboxes
        Me.ckbFingerPosition7.Checked = True
        Me.ckbFingerPosition9.Checked = True
        Me.ckbFingerPosition14.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition14.Show()
        'Code to show the 6 StringToPick labels
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = "O"
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnEChord_Click(sender As Object, e As EventArgs) Handles btnEChord.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnEchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check the following checkboxes
        Me.ckbFingerPosition3.Checked = True
        Me.ckbFingerPosition10.Checked = True
        Me.ckbFingerPosition11.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition11.Show()
        'Code to show the 6 StringToPick labels
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = "O"
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "O"
    End Sub

    Private Sub btnFChord_Click(sender As Object, e As EventArgs) Handles btnFChord.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnFchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check the following checkboxes
        Me.ckbFingerPosition1.Checked = True
        Me.ckbFingerPosition2.Checked = True
        Me.ckbFingerPosition9.Checked = True
        Me.ckbFingerPosition17.Checked = True
        Me.ckbFingerPosition18.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition17.Show()
        Me.ckbFingerPosition18.Show()
        'Code to show the 6 StringToPick labels
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnGChord_Click(sender As Object, e As EventArgs) Handles btnGChord.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnGchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check the following checkboxes
        Me.ckbFingerPosition11.Checked = True
        Me.ckbFingerPosition13.Checked = True
        Me.ckbFingerPosition18.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition11.Show()
        Me.ckbFingerPosition13.Show()
        Me.ckbFingerPosition18.Show()
        'Code to show the 6 StringToPick labels
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = "O"
        Me.lblStringToPick3.Text = "O"
        Me.lblStringToPick4.Text = "O"
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnAMinor_Click(sender As Object, e As EventArgs) Handles btnAMinor.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnAMinorchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check the following checkboxes
        Me.ckbFingerPosition2.Checked = True
        Me.ckbFingerPosition9.Checked = True
        Me.ckbFingerPosition10.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition10.Show()
        'Code to show the 6 StringToPick labels
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = "O"
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnBMinor_Click(sender As Object, e As EventArgs) Handles btnBMinor.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnBMinorchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check the following checkboxes
        Me.ckbFingerPosition7.Checked = True
        Me.ckbFingerPosition11.Checked = True
        Me.ckbFingerPosition14.Checked = True
        Me.ckbFingerPosition21.Checked = True
        Me.ckbFingerPosition22.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition7.Show()
        Me.ckbFingerPosition11.Show()
        Me.ckbFingerPosition14.Show()
        Me.ckbFingerPosition21.Show()
        Me.ckbFingerPosition22.Show()
        'Code to show the 6 StringToPick labels
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnCMinor_Click(sender As Object, e As EventArgs) Handles btnCMinor.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnCMinorchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check the following checkboxes
        Me.ckbFingerPosition13.Checked = True
        Me.ckbFingerPosition17.Checked = True
        Me.ckbFingerPosition20.Checked = True
        Me.ckbFingerPosition27.Checked = True
        Me.ckbFingerPosition28.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition13.Show()
        Me.ckbFingerPosition17.Show()
        Me.ckbFingerPosition20.Show()
        Me.ckbFingerPosition27.Show()
        Me.ckbFingerPosition28.Show()
        'Code to show the 6 StringToPick labels
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnDMinor_Click(sender As Object, e As EventArgs) Handles btnDMinor.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnDMinorchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check the following checkboxes
        Me.ckbFingerPosition1.Checked = True
        Me.ckbFingerPosition9.Checked = True
        Me.ckbFingerPosition14.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition9.Show()
        Me.ckbFingerPosition14.Show()
        'Code to show the 6 StringToPick labels
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = "O"
        Me.lblStringToPick5.Text = "X"
        Me.lblStringToPick6.Text = "X"
    End Sub

    Private Sub btnEMinor_Click(sender As Object, e As EventArgs) Handles btnEMinor.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnEMinorchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check the following checkboxes
        Me.ckbFingerPosition10.Checked = True
        Me.ckbFingerPosition11.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition11.Show()
        'Code to show the 6 StringToPick labels
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = "O"
        Me.lblStringToPick2.Text = "O"
        Me.lblStringToPick3.Text = "O"
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = "O"
    End Sub

    Private Sub btnFMinor_Click(sender As Object, e As EventArgs) Handles btnFMinor.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnFMinorchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check the following checkboxes
        Me.ckbFingerPosition1.Checked = True
        Me.ckbFingerPosition2.Checked = True
        Me.ckbFingerPosition3.Checked = True
        Me.ckbFingerPosition6.Checked = True
        Me.ckbFingerPosition10.Checked = True
        Me.ckbFingerPosition11.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition1.Show()
        Me.ckbFingerPosition2.Show()
        Me.ckbFingerPosition3.Show()
        Me.ckbFingerPosition6.Show()
        Me.ckbFingerPosition10.Show()
        Me.ckbFingerPosition11.Show()
        'Code to show the 6 StringToPick labels
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub

    Private Sub btnGMinor_Click(sender As Object, e As EventArgs) Handles btnGMinor.Click
        'Calls HideBoxes and ClearCheckBoxes procedures when btnGMinorchord is clicked.
        Call clearcheckboxes()
        Call HideBoxes()
        'Code to check the following checkboxes
        Me.ckbFingerPosition13.Checked = True
        Me.ckbFingerPosition14.Checked = True
        Me.ckbFingerPosition15.Checked = True
        Me.ckbFingerPosition18.Checked = True
        Me.ckbFingerPosition28.Checked = True
        Me.ckbFingerPosition29.Checked = True
        'Code For the check box to show the finger position of the chord.
        Me.ckbFingerPosition13.Show()
        Me.ckbFingerPosition14.Show()
        Me.ckbFingerPosition15.Show()
        Me.ckbFingerPosition18.Show()
        Me.ckbFingerPosition28.Show()
        Me.ckbFingerPosition29.Show()
        'Code to show the 6 StringToPick labels
        Me.lblStringToPick1.Show()
        Me.lblStringToPick2.Show()
        Me.lblStringToPick3.Show()
        Me.lblStringToPick4.Show()
        Me.lblStringToPick5.Show()
        Me.lblStringToPick6.Show()
        'Code to show what strings to pick and which ones not to. X is strings that do not get picked in the chord.
        Me.lblStringToPick1.Text = ""
        Me.lblStringToPick2.Text = ""
        Me.lblStringToPick3.Text = ""
        Me.lblStringToPick4.Text = ""
        Me.lblStringToPick5.Text = ""
        Me.lblStringToPick6.Text = ""
    End Sub
End Class
