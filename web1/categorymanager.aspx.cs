using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

public partial class categorymanager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] != null && Session["admin"].ToString() == "fujian")
        {
            // 已登陆
            if (!Page.IsPostBack)
            {
                // 页面第一次加载时，绑定类别列表
                DataTable dt = new CategoryManager().SelectAll();
                repCategory.DataSource = dt;
                repCategory.DataBind();
            }
        }
        else
        {
            // 未登陆
            Response.Redirect("login.aspx");
        }
    }

    // 添加类别
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        CategoryManager cm = new CategoryManager();
        string name = txtCaname.Text.Trim();
        // 判断类别名是否已经存在
        if (cm.IsExists(name))
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('类别名称已经存在，请重新输入！');</script>");
            txtCaname.Text = "";
            return;
        }

        // 添加类别
        bool b = cm.Insert(name);
        if (b)
        {
            // 清空文本框
            txtCaname.Text = "";

            // 添加成功，重新绑定类别列表
            DataTable dt = cm.SelectAll();
            repCategory.DataSource = dt;
            repCategory.DataBind();
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('类别添加失败，请联系管理员！');</script>");
        }
    }



    // 删除按钮
    protected void lbtnDelCa_Click(object sender, EventArgs e)
    {
        // 当前点击的按钮
        LinkButton lb = (LinkButton)sender;
        // 获取传过来的commentId
        string caId = lb.CommandArgument;
        // 删除该类别
        bool b = new CategoryManager().Delete(caId);
        if (b)
        {
            // 重新绑定新闻类别
            DataTable dt = new CategoryManager().SelectAll();
            repCategory.DataSource = dt;
            repCategory.DataBind();
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('类别删除失败，请联系管理员！');</script>");
        }

    }

}
