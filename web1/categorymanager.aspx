<%@ Page Title="" Language="C#" MasterPageFile="~/m_common.master" AutoEventWireup="true" CodeFile="categorymanager.aspx.cs" Inherits="categorymanager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="M_ContentPlaceHolder" Runat="Server">
       <div id="camanager" class="round2">
        <h3>类别管理</h3>
        <div class="con">
             <span class="fontcolor"> 提示：点击类别名称可以直接修改，点击回车按钮或者其他地方修改生效！！！！</span>
               <table class="m_table">
                   <tr>
                       <th class="xuhao">序号</th>
                       <th>类别名称</th>
                       <th class="del">删除</th>
                   </tr>
                       <asp:Repeater ID="repCategory" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td >
                                <%# Eval("id")%>
                            </td>
                            <td class="caname">
                                <%# Eval("name")%>
                            </td>
                            <td>
                                <asp:LinkButton ID="lbtnDelCa" runat="server" CommandArgument='<%# Eval("id")%>' OnClientClick="return confirm('删除类别会使其下新闻及评论全都删除，是否真的要删除？')" onclick="lbtnDelCa_Click">删除</asp:LinkButton>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
               </table>
                   <div id="test"></div> 
        </div>
            <div class="footer"><p> &nbsp;</p></div>
    </div>
     <div id="addca" class="round2">
        <h3>添加类别</h3>
        <div class="con">
            请输入类别名称：<asp:TextBox ID="txtCaname" runat="server" ValidationGroup="addCa"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="addCa" ControlToValidate="txtCaname" runat="server" ErrorMessage="请输入类别名字！" Text="*"></asp:RequiredFieldValidator>
            <asp:Button ID="btnAdd" ValidationGroup="addCa" UseSubmitBehavior="false" runat="server" Text="添加类别" 
                onclick="btnAdd_Click" />
            <asp:ValidationSummary ID="ValidationSummary1"  ValidationGroup="addCa" ShowMessageBox="true" ShowSummary="false" runat="server" />
        </div>
             <div class="footer"><p> &nbsp;</p></div>
    </div>
</asp:Content>

