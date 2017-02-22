<%@ Page Title="" Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register src="control/NewsCategory.ascx" tagname="NewsCategory" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <!--新闻分类 -->
             <uc1:NewsCategory ID="NewsCategory1" runat="server" />
             <!-- 最新新闻 -->
        <div id="newnews" class="commonfrm">
             <h4>最新新闻</h4>
            <asp:gridview id="gvNewNews" runat="server" AutoGenerateColumns="False"  BorderWidth="0" GridLines="None" >
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
           <!-- 热点新闻 -->
          <div id="hotnews" class="commonfrm">
             <h4>热点新闻</h4>
       <asp:gridview id="gvHotNews" runat="server" AutoGenerateColumns="False"  BorderWidth="0" GridLines="None" >
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
                             <asp:Label ID="Label1" runat="server" Text='<%# Bind("createTime") %>'></asp:Label>
                         </ItemTemplate>
                     </asp:TemplateField>
                
                </Columns>
            </asp:gridview>
        </div>
</asp:Content>

