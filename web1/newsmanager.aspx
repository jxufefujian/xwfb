<%@ Page Title="" Language="C#" MasterPageFile="~/m_common.master" AutoEventWireup="true" CodeFile="newsmanager.aspx.cs" Inherits="newsmanager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="M_ContentPlaceHolder" Runat="Server">
      <div id="newsmanager" class="round2">
        <h3>新闻管理</h3>
        <div class="con">
             <div class="fontcolor"> 提示：点击类别名称可以直接修改！！！！</div>
             <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate>
               <table class="m_table">
                   <tr>
                       <th class="xuhao">序号</th>
                       <th >标题</th>
                       <th class="del">修改</th>
                       <th class="del">删除</th>
                   </tr>
           <asp:Repeater ID="repNews" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("id") %></td>
                        <td><a href='newscontent.aspx?newsid=<%#Eval("id") %>' target="_blank"><%#Eval("title") %></a></td>
                        <td><a href='modnews.aspx?newsid=<%#Eval("id") %>' target="_blank">修改</a></td>
                        <td>
                            <asp:LinkButton ID="lbtnDel" OnClientClick="return confirm('删除新闻会连同其下评论一起删除,是否删除?')" OnClick="lbtnDel_Click" CommandArgument='<%#Eval("id") %>' runat="server">删除</asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>        
            
               </table>
                  </ContentTemplate>
                 </asp:UpdatePanel>
        </div>
            <div class="footer"><p> &nbsp;</p></div>
    </div>
</asp:Content>

