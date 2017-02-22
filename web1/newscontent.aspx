<%@ Page Title="新闻内容" Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true" CodeFile="newscontent.aspx.cs" Inherits="newscontent"  MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script language="javascript" type="text/javascript">
function changeCode() {   
    var imgNode = document.getElementById("vimg");   
    imgNode.src = "handler/WaterMark.ashx?t=" + (new Date()).valueOf();  // 这里加个时间的参数是为了防止浏览器缓存的问题   
}  
</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <div id="newscontent" class="commonfrm">
             <h4>    <asp:Repeater id="repNewsContentTitle" runat="server">
                       <ItemTemplate>
                            <%# Eval("title")%>
                       </ItemTemplate>
                      </asp:Repeater> 
             </h4>
            <p class="con">
                 <asp:Repeater id="repNewsContentContent" runat="server">
                       <ItemTemplate>
                            <%# Eval("content")%>
                       </ItemTemplate>
                      </asp:Repeater> 
            </p>
           <p class="con_time">发布时间: <asp:Repeater id="repNewsContentCreateTime" runat="server">
                       <ItemTemplate>
                            <%# Eval("createTime")%>
                       </ItemTemplate>
                      </asp:Repeater> </p>
             <a href="#com">我要评论</a>
        </div>
       <div id="newsreplay" class="commonfrm">
           <h4>新闻评论</h4>
             <div id="emptydata" class="replay" runat="server">
            <p>该新闻目前暂无评论！</p>
        </div>
             <asp:Repeater id="repComment" runat="server">
                  <ItemTemplate>
                    <div class="replay">
            <p  class="con">
             <%# Eval("content")%>
          </p>
                <p class="replay_info">
                    <asp:LinkButton ID="lbtnDelComment" onclick="lbtnDelComment_Click" CommandArgument='<%# Eval("id") %>' runat="server" OnClientClick="return confirm('是否要真的删除该评论？')">删除</asp:LinkButton>
                    评论者：<%# Eval("userIp").ToString().Substring(0, Eval("userIp").ToString().LastIndexOf(".")+1) + "*"%>&nbsp;评论时间：<%# Eval("createTime")%></p>
                <hr />
           </div>
                </ItemTemplate>
               </asp:Repeater> 

          <div class="addcomment">
              <asp:TextBox ID="txtComment" runat="server"  ValidationGroup="pinglun"  TextMode="MultiLine" Text="请在此输入评论内容！"  CssClass="comment_con" onclick="this.select();"></asp:TextBox>
              <p>验证码：<a name="com">&nbsp;</a><img src="handler/WaterMark.ashx" id="vimg" alt="" onclick="changeCode()" />
                   <asp:TextBox ID="txtCode"  ValidationGroup="pinglun"  runat="server" CssClass="txtcode"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  ValidationGroup="pinglun"  ControlToValidate="txtCode"  runat="server" ErrorMessage="请输入验证码：" Text="*"></asp:RequiredFieldValidator>
                     <asp:Button ID="btnSub" runat="server" Text="提交" OnClick="btnSub_Click" />
                  <asp:ValidationSummary ValidationGroup="pinglun" ID="ValidationSummary1" runat="server" ShowMessageBox="true" ShowSummary="false" />
          </div>
      </div>
</asp:Content>

