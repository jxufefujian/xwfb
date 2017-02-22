<%@ Control Language="C#" CodeFile="Enumeration.ascx.cs" Inherits="EnumerationFilter" %>

<asp:DropDownList runat="server" ID="DropDownList1" AutoPostBack="True" CssClass="DDFilter"
    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
  <asp:ListItem Text="全部" Value="" />
</asp:DropDownList>

