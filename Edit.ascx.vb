' Copyright (c) 2019  frontdata.se
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
Imports DotNetNuke.Entities.Modules.Actions
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Services.Exceptions
Imports DotNetNuke.Services.Localization

''' <summary>
''' The View class displays the content
''' 
''' Typically your view control would be used to display content or functionality in your module.
''' 
''' View may be the only control you have in your project depending on the complexity of your module
''' 
''' Because the control inherits from AJ_Hero_v1ModuleBase you have access to any custom properties
''' defined there, as well as properties from DNN such as PortalId, ModuleId, TabId, UserId and many more.
''' 
''' </summary>
Public Class Edit
    Inherits AJ_Hero_v1ModuleBase

    Private _isUpdate As Boolean = False
    Private _maincont As New mainController

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Page_Load runs when the control is loaded
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try


            Dim dataobj As aj_hero_v1_Info = _maincont.getmodueldata(ModuleId)
            If dataobj IsNot Nothing Then
                _isUpdate = True
                heroID.Value = dataobj.HeroId
                heroImg.Text = dataobj.Itemblock1
                heroTxt.Text = dataobj.Itemblock2
            End If
        Catch exc As Exception
            Exceptions.ProcessModuleLoadException(Me, exc)
        End Try

    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim tmpheroinfo As New aj_hero_v1_Info
        tmpheroinfo.HeroId = heroID.Value
        tmpheroinfo.Itemblock1 = heroImg.Text
        tmpheroinfo.Itemblock2 = heroTxt.Text
        tmpheroinfo.LastModifiedByUserId = UserId
        tmpheroinfo.ModuleId = ModuleId
        Try
            If _isUpdate Then
                Dim dataobj As aj_hero_v1_Info = _maincont.updModueldata(tmpheroinfo)
            Else
                tmpheroinfo.CreatedByUserId = UserId
                Dim dataobj As aj_hero_v1_Info = _maincont.addModueldata(tmpheroinfo)

            End If
        Catch ex As Exception

        End Try

        Response.Redirect(DotNetNuke.Common.Globals.NavigateURL())
    End Sub
    Protected Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Response.Redirect(DotNetNuke.Common.Globals.NavigateURL())
    End Sub


End Class