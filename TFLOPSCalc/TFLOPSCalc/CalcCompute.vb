Public Class CalcCompute

    Private Shared shaderMultiplier As Integer = 0

    Public Shared Function calculateCompute(ByVal uarch As uarches, ByVal computeUnits As Integer, ByVal clock As Integer, ByVal giga As Boolean) As Single
        shaderMultiplier = getShadersForUarch(uarch)
        Dim totalShaders As Integer = shaderMultiplier * computeUnits
        If giga Then
            Return (totalShaders * clock * 0.002)
        Else
            Return (totalShaders * clock * 0.000002)
        End If

    End Function

    Public Shared Function findReqClock(ByVal uarch As uarches, ByVal computeUnits As Integer, ByVal compute As Single) As Integer
        Return Integer.Parse(Math.Ceiling(compute / (computeUnits * getShadersForUarch(uarch) * 2) * 1000000))
    End Function

    Public Shared Function findReqCUs(ByVal uarch As uarches, ByVal clock As Integer, ByVal compute As Single) As Integer
        Return Integer.Parse(Math.Ceiling(compute / ((clock / 1000) * 2 * getShadersForUarch(uarch)) * 1000))
    End Function

    Public Shared Function getShadersForUarch(ByVal uarch As uarches) As Integer
        Select Case uarch
            Case uarches.NvidiaFermi
                Return 48
            Case uarches.NvidiaKepler
                Return 192
            Case uarches.NvidiaMaxwell
                Return 128
            Case uarches.NvidiaPascal
                Return 128
            Case uarches.NvidiaTuring
                Return 64
            Case uarches.AMDGCN1
                Return 64
            Case uarches.AMDGCN2
                Return 64
            Case uarches.AMDGCN3
                Return 64
            Case uarches.AMDGCN4
                Return 64
            Case uarches.AMDVega
                Return 64
            Case uarches.AMDRDNA1
                Return 64
            Case uarches.AMDRDNA2
                Return 64
            Case uarches.Intelgen8
                Return 8
            Case uarches.Intelgen9
                Return 8
            Case uarches.Intelgen11
                Return 8
            Case Else
                Return 0
        End Select
    End Function

    Public Enum uarches
        NvidiaFermi
        NvidiaKepler
        NvidiaMaxwell
        NvidiaPascal
        NvidiaTuring
        AMDGCN1
        AMDGCN2
        AMDGCN3
        AMDGCN4
        AMDVega
        AMDRDNA1
        AMDRDNA2
        Intelgen8
        Intelgen9
        Intelgen11
    End Enum

End Class
