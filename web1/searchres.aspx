<%@ Page Title="搜索结果" Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true" CodeFile="searchres.aspx.cs" Inherits="searchres" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          <!-- 搜索结果 -->
        <div id="searchres" class="commonfrm">
             <h4>搜索结果</h4>
        <asp:gridview id="gvNews" PageSize="50" runat="server" AutoGenerateColumns="False"  BorderWidth="0" GridLines="None" >
                 <Columns>           
                     <asp:TemplateField HeaderText="所属类别"  HeaderStyle-CssClass="th_category">
                         <ItemTemplate>
                             <a class="td_category" href='list.aspx?caid=<%#Eval("caId") %>'><%# Eval("name") %></a>
                         </ItemTemplate>
                      </asp:TemplateField>
                     <asp:TemplateField HeaderText="新闻标题">
                         <ItemTemplate>
                              <a href='newscontent.aspx?newsid=<%#Eval("id") %>' target="_blank" title='<%# Eval("title") %>'><%# StringTruncat( Eval("title").ToString(), 18 , "...") %></a>
                         </ItemTemplate>
                     </asp:TemplateField>
                     <asp:TemplateField HeaderText="发布时间"  HeaderStyle-CssClass="th_time" ItemStyle-CssClass="td_time">
                      
                         <ItemTemplate >
                             <asp:Label ID="Label3" runat="server" Text='<%# Bind("createTime") %>'></asp:Label>
                         </ItemTemplate>
                     </asp:TemplateField>
                
                </Columns>
            </asp:gridview>
        </div>
         
</asp:Content>

