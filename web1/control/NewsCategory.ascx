<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewsCategory.ascx.cs" Inherits="control_NewsCategory" %>
   <div id="category" class="commonfrm">
                <h4>新闻分类</h4>
                <ul>
                      <li><a href="Default.aspx">首    页</a></li>
                    <asp:Repeater id="repCategory" runat="server">
                       <ItemTemplate>
                            <li><a href='list.aspx?caid=<%# Eval("id")%>'><%# Eval("name")%></a></li>
                       </ItemTemplate>
                      </asp:Repeater>      
                </ul>
            </div>