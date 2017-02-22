<%@ Page Title="新闻列表" Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true" CodeFile="list.aspx.cs" Inherits="list" %>

<%@ Register src="control/NewsCategory.ascx" tagname="NewsCategory" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <!--新闻分类 -->
             <uc1:NewsCategory ID="NewsCategory1" runat="server" />
             <!-- 新闻列表 -->

        <div id="newslist" class="commonfrm">
             <h4>新闻类别</h4>
                <div id="emptydata" class="replay" runat="server">
            <p>该新闻类别暂没有新闻！</p>
        </div>
        <asp:gridview id="gvNews" runat="server" AutoGenerateColumns="False"  BorderWidth="0" GridLines="None" >
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

