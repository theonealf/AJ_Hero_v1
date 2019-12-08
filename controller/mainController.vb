Public Class mainController

    Private _dalobj As New aj_Hero_v1_DAL

    Public Function getModueldata(moduleid As Integer) As aj_hero_v1_Info
        Dim retobj As aj_hero_v1_Info = _dalobj.getHeroData(moduleid)

        Return retobj
    End Function
    Public Function addModueldata(heroObj As aj_hero_v1_Info) As aj_hero_v1_Info
        Dim retobj As New aj_hero_v1_Info
        retobj.Status = _dalobj.addHeroData(heroObj)

        Return retobj
    End Function
    Public Function updModueldata(heroObj As aj_hero_v1_Info) As aj_hero_v1_Info
        Dim retobj As New aj_hero_v1_Info
        retobj.Status = _dalobj.updHeroData(heroObj)

        Return retobj
    End Function
End Class
