Public Class CalcCompute

    Private Shared shaderMultiplier As Integer = 0
    Private Shared OpsPerCycleMultiplier As Integer = 0

    Public Shared Function calculateCompute(ByVal uarch As uarches, ByVal computeUnits As Integer, ByVal clock As Integer, ByVal giga As Boolean) As Single
        shaderMultiplier = getShadersForUarch(uarch)
        OpsPerCycleMultiplier = getIPC(uarch)
        Dim totalShaders As Integer = shaderMultiplier * computeUnits
        If giga Then
            Return (totalShaders * clock * (OpsPerCycleMultiplier / 1000))
        Else
            Return (totalShaders * clock * (OpsPerCycleMultiplier / 1000000))
        End If

    End Function

    Public Shared Function findReqClock(ByVal uarch As uarches, ByVal computeUnits As Integer, ByVal compute As Single) As Integer
        If computeUnits = 0 Then
            computeUnits = 1
        End If
        Return Integer.Parse(Math.Ceiling(compute / (computeUnits * getShadersForUarch(uarch) * getIPC(uarch)) * 1000000))
    End Function

    Public Shared Function findReqCUs(ByVal uarch As uarches, ByVal clock As Integer, ByVal compute As Single) As Integer
        If clock = 0 Then
            clock = 1
        End If
        Return Integer.Parse(Math.Ceiling(compute / ((clock / 1000) * getIPC(uarch) * getShadersForUarch(uarch)) * 1000))
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
            Case uarches.NvidiaAmpere
                Return 128
            Case uarches.NvidiaAda
                Return 128
            Case uarches.NvidiaBlackwell
                Return 128
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
            Case uarches.AMDRDNA3
                Return 64 '64 shaders per CU but they do 4 ops/cycle instead of usual 2
            Case uarches.AMDRDNA4
                Return 64 '64 shaders per CU but they do 4 ops/cycle instead of usual 2
            Case uarches.AMDRDNA5
                Return 64 '64 shaders per CU but they do 4 ops/cycle instead of usual 2 (WIP)
            Case uarches.Intelgen8
                Return 8
            Case uarches.Intelgen9
                Return 8
            Case uarches.Intelgen11
                Return 8
            Case uarches.IntelAlchemist
                Return 128
            Case uarches.IntelBattlemage
                Return 128
            Case uarches.IntelCelestial 'WIP
                Return 128
            Case uarches.IntelDruid 'WIP
                Return 128
            Case Else
                Return 0
        End Select
    End Function

    Public Shared Function getIPC(ByVal uarch As uarches) As Integer
        Select Case uarch
            Case uarches.NvidiaFermi
                Return 2
            Case uarches.NvidiaKepler
                Return 2
            Case uarches.NvidiaMaxwell
                Return 2
            Case uarches.NvidiaPascal
                Return 2
            Case uarches.NvidiaTuring
                Return 2
            Case uarches.NvidiaAmpere
                Return 2
            Case uarches.NvidiaAda
                Return 2
            Case uarches.NvidiaBlackwell
                Return 2
            Case uarches.AMDGCN1
                Return 2
            Case uarches.AMDGCN2
                Return 2
            Case uarches.AMDGCN3
                Return 2
            Case uarches.AMDGCN4
                Return 2
            Case uarches.AMDVega
                Return 2
            Case uarches.AMDRDNA1
                Return 2
            Case uarches.AMDRDNA2
                Return 2
            Case uarches.AMDRDNA3
                Return 4 '64 shaders per CU but they do 4 ops/cycle instead of usual 2
            Case uarches.AMDRDNA4
                Return 4 '64 shaders per CU but they do 4 ops/cycle instead of usual 2
            Case uarches.AMDRDNA5
                Return 4 '64 shaders per CU but they do 4 ops/cycle instead of usual 2 (WIP)
            Case uarches.Intelgen8
                Return 2
            Case uarches.Intelgen9
                Return 2
            Case uarches.Intelgen11
                Return 2
            Case uarches.IntelAlchemist
                Return 2
            Case uarches.IntelBattlemage
                Return 2
            Case uarches.IntelCelestial 'WIP
                Return 2
            Case uarches.IntelDruid 'WIP
                Return 2
            Case Else
                Return 0
        End Select
    End Function



    Public Shared Function calcRayBoxMetrics(ByVal uarch As uarches, ByVal computeUnits As Integer, ByVal clock As Integer) As Single
        Return computeUnits * clock * getRayBoxForUarch(uarch) / 1000
    End Function

    Public Shared Function calcRayTriMetrics(ByVal uarch As uarches, ByVal computeUnits As Integer, ByVal clock As Integer) As Single
        Return computeUnits * clock * getRayTriForUarch(uarch) / 1000
    End Function

    ''' <summary>
    ''' Return RayBox per cycle per unit for uarch
    ''' </summary>
    ''' <param name="uarch"></param>
    ''' <remarks>RDNA2, RDNA3 and RDNA4 are known (Xbox Series X Hotchips)
    ''' Alchemist and Battlemage are known (Intel Architecture talks)
    ''' Turing is estimated, Ampere, Ada and Blackwell are using whitepapers relative to this estimation
    ''' </remarks>
    ''' <returns></returns>
    Public Shared Function getRayBoxForUarch(ByVal uarch As uarches) As Integer
        Select Case uarch
            Case uarches.NvidiaTuring
                Return 4
            Case uarches.NvidiaAmpere
                Return 8
            Case uarches.NvidiaAda
                Return 8
            Case uarches.NvidiaBlackwell
                Return 8
            Case uarches.AMDRDNA2
                Return 4
            Case uarches.AMDRDNA3
                Return 4
            Case uarches.AMDRDNA4
                Return 8
            Case uarches.IntelAlchemist
                Return 12
            Case uarches.IntelBattlemage
                Return 18
            Case uarches.IntelCelestial
                Return 0
            Case uarches.IntelDruid
                Return 0
        End Select
    End Function


    ''' <summary>
    ''' Return RayTri per cycle per unit for uarch
    ''' </summary>
    ''' <param name="uarch"></param>
    ''' <remarks>RDNA2, RDNA3 and RDNA4 are known (Xbox Series X Hotchips)
    ''' Alchemist and Battlemage are known (Intel Architecture talks)
    ''' Turing is estimated, Ampere, Ada and Blackwell are using whitepapers relative to this estimation
    ''' </remarks>
    ''' <returns></returns>
    Public Shared Function getRayTriForUarch(ByVal uarch As uarches) As Integer
        Select Case uarch
            Case uarches.NvidiaTuring
                Return 1
            Case uarches.NvidiaAmpere
                Return 2
            Case uarches.NvidiaAda
                Return 4
            Case uarches.NvidiaBlackwell
                Return 4
            Case uarches.AMDRDNA2
                Return 1
            Case uarches.AMDRDNA3
                Return 1
            Case uarches.AMDRDNA4
                Return 2
            Case uarches.AMDRDNA5 'WIP
                Return 0
            Case uarches.IntelAlchemist
                Return 1
            Case uarches.IntelBattlemage
                Return 2
            Case uarches.IntelCelestial 'WIP
                Return 0
            Case uarches.IntelDruid 'WIP
                Return 0
        End Select
    End Function


    ''' <summary>
    ''' Return cycles per BVH traversal per unit for uarch.  -1 means traversal is handled in softare
    ''' </summary>
    ''' <param name="uarch"></param>
    ''' <remarks>Turing is known (Nvidia whitepaper)
    ''' RDNA2, RDNA3, RDNA4 is known (Xbox Series X Hotchips, AMD slidedecks)
    ''' Alchemist, Battlemage are unknown but have HW acceleration (noted as 1 cycle for now)
    ''' </remarks>
    ''' <returns></returns>
    Public Shared Function getTraverseCyclesForUarch(ByVal uarch As uarches) As Integer
        Select Case uarch
            Case uarches.NvidiaTuring
                Return 1
            Case uarches.NvidiaAmpere
                Return 1
            Case uarches.NvidiaAda
                Return 1
            Case uarches.NvidiaBlackwell
                Return 1
            Case uarches.AMDRDNA2
                Return -1
            Case uarches.AMDRDNA3
                Return -1
            Case uarches.AMDRDNA4
                Return -1
            Case uarches.AMDRDNA5 'WIP
                Return 0
            Case uarches.IntelAlchemist
                Return 1
            Case uarches.IntelBattlemage
                Return 1
            Case uarches.IntelCelestial 'WIP
                Return 0
            Case uarches.IntelDruid 'WIP
                Return 0
        End Select
    End Function

    Public Enum uarches
        NvidiaFermi
        NvidiaKepler
        NvidiaMaxwell
        NvidiaPascal
        NvidiaTuring
        NvidiaAmpere
        NvidiaAda
        NvidiaBlackwell
        AMDGCN1
        AMDGCN2
        AMDGCN3
        AMDGCN4
        AMDVega
        AMDRDNA1
        AMDRDNA2
        AMDRDNA3
        AMDRDNA4
        AMDRDNA5 'WIP
        Intelgen8
        Intelgen9
        Intelgen11
        IntelAlchemist
        IntelBattlemage
        IntelCelestial 'WIP
        IntelDruid 'WIP
    End Enum

End Class
