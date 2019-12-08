<%@ Control Language="vb" AutoEventWireup="true" CodeBehind="Edit.ascx.vb" Inherits="frontdata.Aj_hero_v1.AJ_Hero_v1.Edit" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="texteditor" Src="~/controls/texteditor.ascx" %>
<%@ Register TagPrefix="dnnweb" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>
<%@ Register TagPrefix="dnnweb" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls.Internal" %>
<%@ Register TagPrefix="dnncl" Assembly="DotNetNuke.Web.Client" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" %>

<dnncl:DnnCssInclude ID="customJS" runat="server" FilePath="DesktopModules/HTML/edit.css" AddTag="false" />

<div class="dnnForm dnnEditBasicSettings" id="dnnEditBasicSettings">
    <div class="dnnFormExpandContent dnnRight "><a href="">ExpandAll</a></div>

    <h2 id="dnnSitePanel-BasicSettings" class="dnnFormSectionHead dnnClear">
        <a href="" class="dnnSectionExpanded">
            "Administration</a></h2>
    <fieldset>
        <label>Bildblock</label>
        <div class="dnnFormItem">
            <asp:HiddenField ID="heroID" runat="server"/>
            <dnn:textEditor id="heroImg" runat="server" height="400" width="100%" ChooseMode="false" ></dnn:textEditor>
            
        </div>
    </fieldset>
    <div class="dnnFormExpandContent2 dnnRight "><a href="">Expandblock</a></div>

    <h2 id="dnnSitePanel-BasicSettings2" class="dnnFormSectionHead2 dnnClear">
        <a href="" class="dnnSectionExpanded2">
           text</a></h2>
    <fieldset>
        <label>textblock</label>
        <div class="dnnFormItem">            
            
            <dnn:textEditor id="heroTxt" runat="server" height="400" width="100%" ChooseMode="false" ></dnn:textEditor>
            
        </div>
       </fieldset>
   
</div>
<asp:LinkButton ID="btnSubmit" runat="server"
    OnClick="btnSubmit_Click" resourcekey="btnSubmit" CssClass="dnnPrimaryAction" Text="Spara" />
<asp:LinkButton ID="btnCancel" runat="server"
    OnClick="btnCancel_Click" resourcekey="btnCancel" CssClass="dnnSecondaryAction" Text="Avbryt" />

