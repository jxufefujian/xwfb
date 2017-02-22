using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;


public partial class newscontent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            string newsid = Request.QueryString["newsid"];

            NewsManager nm = new NewsManager();

            repNewsContentContent.DataSource = nm.SelectById(newsid);
            repNewsContentContent.DataBind();

            repNewsContentCreateTime.DataSource = nm.SelectById(newsid);
            repNewsContentCreateTime.DataBind();

            repNewsContentTitle.DataSource = nm.SelectById(newsid);
            repNewsContentTitle.DataBind();
            //查看评论
                 DataTable dt  = new CommentManager().SelectByNewsId(newsid);
            if (dt.Rows.Count == 0)
            {
                // 无新闻评论
                emptydata.Visible = true;
            }
            else
            {
                // 有新闻评论
                emptydata.Visible = false;
                repComment.DataSource = dt;
                repComment.DataBind();
            }


        }
    }

    // 删除按钮
    protected void lbtnDelComment_Click(object sender, EventArgs e)
    {
        // 当前点击的按钮
        LinkButton lb = (LinkButton)sender;
        // 获取传过来的commentId
        string comId = lb.CommandArgument;
        // 删除该评论
        bool b = new CommentManager().Delete(comId);
        if (b)
        {
            // 重新绑定新闻评论
            string newsid = Request.QueryString["newsid"];
            repComment.DataSource = new CommentManager().SelectByNewsId(newsid);
            repComment.DataBind();
        }

    }

    //添加评论按钮事件
    protected void btnSub_Click(object sender, EventArgs e)
    {
        string code = txtCode.Text.Trim();
        String rightCode = Session["Code"].ToString();
        if (code != rightCode)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('验证码输入错误！');</script>");
            return;
        }

        string com_content = txtComment.Text;
        string newsid = Request.QueryString["newsid"];
        string userIp = Request.ServerVariables["REMOTE_ADDR"];
        Response.Write(userIp);
        Comment com = new Comment(com_content, userIp, newsid);
        bool b = new CommentManager().Insert(com);
        if (b) {
             // 清空文本框
            txtComment.Text = "";
            txtCode.Text = "";

            // 隐藏"该新闻目前暂无评论！"
            emptydata.Visible = false;

            // 重新绑定新闻评论
            repComment.DataSource = new CommentManager().SelectByNewsId(newsid);
            repComment.DataBind();
        }else{
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('评论添加失败，请联系管理员！');</script>");
        }
    }
}