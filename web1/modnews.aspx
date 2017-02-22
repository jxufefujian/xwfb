<%@ Page Title="" Language="C#" MasterPageFile="~/m_common.master" AutoEventWireup="true" CodeFile="modnews.aspx.cs" Inherits="modnews" ValidateRequest="false" %>

<%@ Register assembly="FreeTextBox" namespace="FreeTextBoxControls" tagprefix="FTB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="M_ContentPlaceHolder" Runat="Server">
    <div id="addnews" class="round2">
    <h3>修改新闻</h3>
    <div class="con">
        <p>
        新闻分类：<asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList>
        </p>
        <p>新闻标题：<asp:TextBox ID="txtTitle" runat="server" CssClass="newstitle"></asp:TextBox></p>
        <p>新闻内容：</p>
        <p>
        <FTB:FreeTextBox Text="" Language="zh-CN" ToolbarStyleConfiguration="OfficeMac" ID="ftbContent" Width="500" Height="200" runat="server">
            </FTB:FreeTextBox>
        </p>
        <p><asp:Button ID="btnAdd" runat="server" Text="修改新闻" onclick="btnAdd_Click" /></p>        
    </div>
    <div class="footer">
        <p>&nbsp;</p>
    </div>
</div>

</asp:Content>

