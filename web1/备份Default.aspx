<%@ Page Language="C#" AutoEventWireup="true" CodeFile="备份Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>首页</title>
    <link href="css/common.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id ="top">
        <a  href="Default.aspx">
            <img src="images/niunanlogo.jpg" /><img src="images/tg029logo.gif" />
       </a>
    </div>
        <div id="search">
            搜索条件
            <asp:RadioButton ID="radTitle" GroupName="cond" runat="server" Text="标题" Checked="true" />
            <asp:RadioButton ID="radContent"  GroupName="cond"  runat="server" Text="标题"/>
              <asp:TextBox ID="txtKey" runat="server" CssClass="txtcode"></asp:TextBox>
              <asp:ImageButton ID="ibtnSearch"  ImageUrl="images/search.gif" runat="server" />
        </div> 
        <div id="main">
            <!--新闻分类 -->
            <div id="category" class="commonfrm">
                <h4>新闻分类</h4>
                <ul>
                      <li><a href="#">首页</a></li>
                      <li><a href="#">首页</a></li>
                      <li><a href="#">首页</a></li>
                      <li><a href="#">首页</a></li>
                </ul>
            </div>
             <!-- 最新新闻 -->
        <div id="newnews" class="commonfrm">
             <h4>最新新闻</h4>
            <table>
                <tr>
                     <th>所属类别</th>
                     <th>新闻标题</th>
                     <th >发布时间</th>
                </tr>
                  <tr>
                     <td><a href="#"  class="th_category">新闻类别</a></td>
                     <td><a href="#">新闻标题</a></td>
                   <td class="th_time">新闻时间</td>
                </tr>
                  <tr>
                    <td><a href="#"  class="th_category">新闻类别</a></td>
                     <td><a href="#">新闻标题</a></td>
                    <td  class="th_time">新闻时间</td>
                </tr>
                  <tr>
                    <td><a href="#"  class="th_category">新闻类别</a></td>
                     <td><a href="#">新闻标题</a></td>
                     <td class="th_time">新闻时间</td>
                </tr>
            </table>
        </div>
              <!-- 热点新闻 -->
             <div id="hotnews" class="commonfrm">
             <h4>热点新闻</h4>
            <table>
                <tr>
                     <th>所属类别</th>
                     <th>新闻标题</th>
                     <th >发布时间</th>
                </tr>
                  <tr>
                   <td><a href="#"  class="th_category">新闻类别</a></td>
                     <td><a href="#">新闻标题</a></td>
                     <td  class="th_time">新闻时间</td>
                </tr>
                  <tr>
                  <td><a href="#"  class="th_category">新闻类别</a></td>
                     <td><a href="#">新闻标题</a></td>
                            <td class="th_time">新闻时间</td>
                </tr>
                  <tr>
                    <td><a href="#"  class="th_category">新闻类别</a></td>
                     <td><a href="#">新闻标题</a></td>
                        <td class="th_time">新闻时间</td>
                </tr>
            </table>
        </div>
        </div>
        <div id="footer">
            版权所有: 付建
        </div>
    </form>
</body>
</html>
