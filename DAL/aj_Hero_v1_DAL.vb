Public Class aj_Hero_v1_DAL

#Region "DATA LINQ SETUP"
    Private connectionObj As New connectionStringHandler
    Private _linqObj As New aj_hero_LinqDataContext(connectionObj.CurrentConnectionString)
#End Region


    Public Function getHeroData(modID As Integer) As aj_hero_v1_Info

        Dim obj As New aj_hero_v1_Info
        'Try
        Dim ret = (From i In _linqObj.tbl_aj_hero_v1s
                       Select i
                       Where i.ModuleId = modID).Single

            obj.HeroId = ret.heroid
            obj.Itemblock1 = ret.Itemblock1
            obj.Itemblock2 = ret.Itemblock2
        'Catch ex As Exception

        'End Try


        Return obj

    End Function
    Public Function addHeroData(addobj As aj_hero_v1_Info) As Boolean
        Try
            Dim heroobj As New tbl_aj_hero_v1
            heroobj.Itemblock1 = addobj.Itemblock1
            heroobj.Itemblock2 = addobj.Itemblock2
            heroobj.CreatedOnDate = Date.Now
            heroobj.LastModifiedOnDate = Date.Now
            heroobj.ModuleId = addobj.ModuleId
            heroobj.LastModifiedByUserId = addobj.LastModifiedByUserId
            heroobj.CreatedByUserId = addobj.CreatedByUserId

            _linqObj.tbl_aj_hero_v1s.InsertOnSubmit(heroobj)

            _linqObj.SubmitChanges()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function updHeroData(updobj As aj_hero_v1_Info) As Boolean

        Dim retobj As Boolean = False
        Try
            Dim questlist = From i In _linqObj.tbl_aj_hero_v1s
                            Select i
                            Where i.heroid = updobj.HeroId

            For Each itm In questlist
                itm.Itemblock1 = updobj.Itemblock1
                itm.Itemblock2 = updobj.Itemblock2
                itm.LastModifiedOnDate = Date.Now
                itm.LastModifiedByUserId = updobj.LastModifiedByUserId
                retobj = True
            Next

            _linqObj.SubmitChanges()
        Catch ex As Exception

        End Try

        Return retobj
    End Function


End Class
