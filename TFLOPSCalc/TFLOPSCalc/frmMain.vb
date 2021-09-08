Public Class frmMain

    Private currentUarch As CalcCompute.uarches = CalcCompute.uarches.NvidiaFermi
    Private computeUnitName As String = "SMs"

    Private Sub tbClockSpeed_Scroll(sender As Object, e As EventArgs) Handles tbClockSpeed.Scroll
        lblClock.Text = "Clock Speed:  " & tbClockSpeed.Value & " MHz"
        lblTFLOPS.Text = CalcCompute.calculateCompute(currentUarch, nudComputeUnits.Value, tbClockSpeed.Value, False) & "TFLOPS"
        lblGFLOPS.Text = CalcCompute.calculateCompute(currentUarch, nudComputeUnits.Value, tbClockSpeed.Value, True) & "GFLOPS"
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbUarch.SelectedIndex = 0
        cbUarcha.SelectedIndex = 0
        cbUarchb.SelectedIndex = 0
    End Sub

    Private Sub nudComputeUnits_ValueChanged(sender As Object, e As EventArgs) Handles nudComputeUnits.ValueChanged
        lblTFLOPS.Text = CalcCompute.calculateCompute(currentUarch, nudComputeUnits.Value, tbClockSpeed.Value, False) & "TFLOPS"
        lblGFLOPS.Text = CalcCompute.calculateCompute(currentUarch, nudComputeUnits.Value, tbClockSpeed.Value, True) & "GFLOPS"
    End Sub

    Private Sub cbUarch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUarch.SelectedIndexChanged
        Select Case cbUarch.SelectedIndex
            Case 0
                currentUarch = CalcCompute.uarches.NvidiaFermi
                lblStep2.Text = "Step 2:  Enter number of SMs"
            Case 1
                currentUarch = CalcCompute.uarches.NvidiaKepler
                lblStep2.Text = "Step 2:  Enter number of SMs"
            Case 2
                currentUarch = CalcCompute.uarches.NvidiaMaxwell
                lblStep2.Text = "Step 2:  Enter number of SMs"
            Case 3
                currentUarch = CalcCompute.uarches.NvidiaPascal
                lblStep2.Text = "Step 2:  Enter number of SMs"
            Case 4
                currentUarch = CalcCompute.uarches.NvidiaTuring
                lblStep2.Text = "Step 2:  Enter number of SMs"
            Case 5
                currentUarch = CalcCompute.uarches.NvidiaAmpere
                lblStep2.Text = "Step 2:  Enter number of SMs"
            Case 6
                currentUarch = CalcCompute.uarches.AMDGCN1
                lblStep2.Text = "Step 2:  Enter number of CUs"
            Case 7
                currentUarch = CalcCompute.uarches.AMDGCN2
                lblStep2.Text = "Step 2:  Enter number of CUs"
            Case 8
                currentUarch = CalcCompute.uarches.AMDGCN3
                lblStep2.Text = "Step 2:  Enter number of CUs"
            Case 9
                currentUarch = CalcCompute.uarches.AMDGCN4
                lblStep2.Text = "Step 2:  Enter number of CUs"
            Case 10
                currentUarch = CalcCompute.uarches.AMDVega
                lblStep2.Text = "Step 2:  Enter number of CUs"
            Case 11
                currentUarch = CalcCompute.uarches.AMDRDNA1
                lblStep2.Text = "Step 2:  Enter number of CUs"
            Case 12
                currentUarch = CalcCompute.uarches.AMDRDNA2
                lblStep2.Text = "Step 2:  Enter number of CUs"
            Case 13
                currentUarch = CalcCompute.uarches.Intelgen8
                lblStep2.Text = "Step 2:  Enter number of EUs"
            Case 14
                currentUarch = CalcCompute.uarches.Intelgen9
                lblStep2.Text = "Step 2:  Enter number of EUs"
            Case 15
                currentUarch = CalcCompute.uarches.Intelgen11
                lblStep2.Text = "Step 2:  Enter number of EUs"
            Case 16
                currentUarch = CalcCompute.uarches.IntelAlchemist
                lblStep2a.Text = "Step 2:  Enter number of EUs"
        End Select

        lblTFLOPS.Text = CalcCompute.calculateCompute(currentUarch, nudComputeUnits.Value, tbClockSpeed.Value, False) & "TFLOPS"
        lblGFLOPS.Text = CalcCompute.calculateCompute(currentUarch, nudComputeUnits.Value, tbClockSpeed.Value, True) & "GFLOPS"
    End Sub

    Private Sub llTwitter_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llTwitter.LinkClicked
        System.Diagnostics.Process.Start("https://twitter.com/Kirby0Louise")
    End Sub

    Private Sub llMyGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llMyGithub.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/Kirby0Louise")
    End Sub

    Private Sub llTFLOPSRepo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llTFLOPSRepo.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/Kirby0Louise/TFLOPSCalc")
    End Sub

    Private Sub cbUarcha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUarcha.SelectedIndexChanged
        Select Case cbUarcha.SelectedIndex
            Case 0
                currentUarch = CalcCompute.uarches.NvidiaFermi
                lblStep2a.Text = "Step 2:  Enter number of SMs"
            Case 1
                currentUarch = CalcCompute.uarches.NvidiaKepler
                lblStep2a.Text = "Step 2:  Enter number of SMs"
            Case 2
                currentUarch = CalcCompute.uarches.NvidiaMaxwell
                lblStep2a.Text = "Step 2:  Enter number of SMs"
            Case 3
                currentUarch = CalcCompute.uarches.NvidiaPascal
                lblStep2a.Text = "Step 2:  Enter number of SMs"
            Case 4
                currentUarch = CalcCompute.uarches.NvidiaTuring
                lblStep2a.Text = "Step 2:  Enter number of SMs"
            Case 5
                currentUarch = CalcCompute.uarches.NvidiaAmpere
                lblStep2a.Text = "Step 2:  Enter number of SMs"
            Case 6
                currentUarch = CalcCompute.uarches.AMDGCN1
                lblStep2a.Text = "Step 2:  Enter number of CUs"
            Case 7
                currentUarch = CalcCompute.uarches.AMDGCN2
                lblStep2a.Text = "Step 2:  Enter number of CUs"
            Case 8
                currentUarch = CalcCompute.uarches.AMDGCN3
                lblStep2a.Text = "Step 2:  Enter number of CUs"
            Case 9
                currentUarch = CalcCompute.uarches.AMDGCN4
                lblStep2a.Text = "Step 2:  Enter number of CUs"
            Case 10
                currentUarch = CalcCompute.uarches.AMDVega
                lblStep2a.Text = "Step 2:  Enter number of CUs"
            Case 11
                currentUarch = CalcCompute.uarches.AMDRDNA1
                lblStep2a.Text = "Step 2:  Enter number of CUs"
            Case 12
                currentUarch = CalcCompute.uarches.AMDRDNA2
                lblStep2a.Text = "Step 2:  Enter number of CUs"
            Case 13
                currentUarch = CalcCompute.uarches.Intelgen8
                lblStep2a.Text = "Step 2:  Enter number of EUs"
            Case 14
                currentUarch = CalcCompute.uarches.Intelgen9
                lblStep2a.Text = "Step 2:  Enter number of EUs"
            Case 15
                currentUarch = CalcCompute.uarches.Intelgen11
                lblStep2a.Text = "Step 2:  Enter number of EUs"
            Case 16
                currentUarch = CalcCompute.uarches.IntelAlchemist
                lblStep2a.Text = "Step 2:  Enter number of EUs"
        End Select

        Dim result As Single = 0
        Dim result2 As Integer = 0
        If Single.TryParse(txtCompute.Text, result) Then
            result2 = CalcCompute.findReqClock(currentUarch, nudComputeUnitsa.Value, result)
            lblReqClock.Text = result2 & "MHz"
        Else
            lblReqClock.Text = "INVALID INPUT"
        End If
    End Sub

    Private Sub nudComputeUnitsa_ValueChanged(sender As Object, e As EventArgs) Handles nudComputeUnitsa.ValueChanged
        Dim result As Single = 0
        Dim result2 As Integer = 0
        If Single.TryParse(txtCompute.Text, result) Then
            result2 = CalcCompute.findReqClock(currentUarch, nudComputeUnitsa.Value, result)
            lblReqClock.Text = result2 & "MHz"
        Else
            lblReqClock.Text = "INVALID INPUT"
        End If
    End Sub

    Private Sub txtCompute_TextChanged(sender As Object, e As EventArgs) Handles txtCompute.TextChanged
        Dim result As Single = 0
        Dim result2 As Integer = 0
        If Single.TryParse(txtCompute.Text, result) Then
            result2 = CalcCompute.findReqClock(currentUarch, nudComputeUnitsa.Value, result)
            lblReqClock.Text = result2 & "MHz"
        Else
            lblReqClock.Text = "INVALID INPUT"
        End If
    End Sub

    Private Sub cbUarchb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUarchb.SelectedIndexChanged
        Select Case cbUarchb.SelectedIndex
            Case 0
                currentUarch = CalcCompute.uarches.NvidiaFermi
                computeUnitName = "SMs"
            Case 1
                currentUarch = CalcCompute.uarches.NvidiaKepler
                computeUnitName = "SMs"
            Case 2
                currentUarch = CalcCompute.uarches.NvidiaMaxwell
                computeUnitName = "SMs"
            Case 3
                currentUarch = CalcCompute.uarches.NvidiaPascal
                computeUnitName = "SMs"
            Case 4
                currentUarch = CalcCompute.uarches.NvidiaTuring
                computeUnitName = "SMs"
            Case 5
                currentUarch = CalcCompute.uarches.NvidiaAmpere
                computeUnitName = "SMs"
            Case 6
                currentUarch = CalcCompute.uarches.AMDGCN1
                computeUnitName = "CUs"
            Case 7
                currentUarch = CalcCompute.uarches.AMDGCN2
                computeUnitName = "CUs"
            Case 8
                currentUarch = CalcCompute.uarches.AMDGCN3
                computeUnitName = "CUs"
            Case 9
                currentUarch = CalcCompute.uarches.AMDGCN4
                computeUnitName = "CUs"
            Case 10
                currentUarch = CalcCompute.uarches.AMDVega
                computeUnitName = "CUs"
            Case 11
                currentUarch = CalcCompute.uarches.AMDRDNA1
                computeUnitName = "CUs"
            Case 12
                currentUarch = CalcCompute.uarches.AMDRDNA2
                computeUnitName = "CUs"
            Case 13
                currentUarch = CalcCompute.uarches.Intelgen8
                computeUnitName = "EUs"
            Case 14
                currentUarch = CalcCompute.uarches.Intelgen9
                computeUnitName = "EUs"
            Case 15
                currentUarch = CalcCompute.uarches.Intelgen11
                computeUnitName = "EUs"
            Case 16
                currentUarch = CalcCompute.uarches.IntelAlchemist
                computeUnitName = "EUs"
        End Select

        Dim result As Single = 0
        Dim result2 As Integer = 0
        If Single.TryParse(txtComputeb.Text, result) Then
            lblReqCU.Text = CalcCompute.findReqCUs(currentUarch, tbClockSpeedb.Value, result) & " " & computeUnitName
        Else
            lblReqCU.Text = "INVALID INPUT"
        End If
    End Sub

    Private Sub tbClockSpeedb_Scroll(sender As Object, e As EventArgs) Handles tbClockSpeedb.Scroll
        lblClockb.Text = "Clock Speed:  " & tbClockSpeedb.Value & " MHz"
        Dim result As Single = 0
        Dim result2 As Integer = 0
        If Single.TryParse(txtComputeb.Text, result) Then
            lblReqCU.Text = CalcCompute.findReqCUs(currentUarch, tbClockSpeedb.Value, result) & " " & computeUnitName
        Else
            lblReqCU.Text = "INVALID INPUT"
        End If
    End Sub

    Private Sub txtComputeb_TextChanged(sender As Object, e As EventArgs) Handles txtComputeb.TextChanged
        Dim result As Single = 0
        Dim result2 As Integer = 0
        If Single.TryParse(txtComputeb.Text, result) Then
            lblReqCU.Text = CalcCompute.findReqCUs(currentUarch, tbClockSpeedb.Value, result) & " " & computeUnitName
        Else
            lblReqCU.Text = "INVALID INPUT"
        End If
    End Sub
End Class
