<%@ Page Title="类别管理" Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true" CodeFile="备份categorymanager.aspx.cs" Inherits="categorymanager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/manager_common.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="m_category" class="round2">
        <h3>管理中心</h3>
        <div class="con">
                 <p><a href="categorymanager.aspx"> 类别管理</a></p> 
                 <p><a href="newsmanager.aspx"> 新闻管理</a></p> 
                 <p><a href="addnews.aspx"> 添加新闻</a></p>              
        </div>
        <div class="footer"><p> &nbsp;</p></div>
    </div>
      <div id="camanager" class="round2">
        <h3>类别管理</h3>
        <div class="con">
             <span class="fontcolor"> 提示：点击类别名称可以直接修改！！！！</span>
               <table class="m_table">
                   <tr>
                       <th class="xuhao">序号</th>
                       <th>类别名称</th>
                       <th class="del">删除</th>
                   </tr>
                   <tr>
                       <td>1</td>
                       <td>财大新闻</td>
                       <td><a href="#">删除</a></td>
                   </tr>

               </table>
                  
        </div>
            <div class="footer"><p> &nbsp;</p></div>
    </div>
     <div id="addca" class="round2">
        <h3>添加类别</h3>
        <div class="con">
               请输入类别名称：<asp:TextBox ID="txtCaname" runat="server"></asp:TextBox>
               <asp:Button ID="btnAdd" runat="server" Text="添加类别" />
        </div>
             <div class="footer"><p> &nbsp;</p></div>
    </div>
</asp:Content>

