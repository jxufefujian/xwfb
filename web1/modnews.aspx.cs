using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;

public partial class modnews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) { 
    // 判断session里面是否存在管理员
        if (Session["admin"] != null && Session["admin"].ToString() == "fujian")
        {
            // 已登陆
            if (!Page.IsPostBack)
            {
                // 绑定新闻分类
                DataTable dt = new CategoryManager().SelectAll();
                ddlCategory.DataSource = dt;
                ddlCategory.DataTextField = "name";
                ddlCategory.DataValueField = "id";
                ddlCategory.DataBind();

            }
        }
        else
        {
            // 未登陆
            Response.Redirect("login.aspx");
        }
    }

    //修改新闻按钮
    protected void btnAdd_Click(object sender, EventArgs e)
{
    string newsid = Request.QueryString["newsid"];
    string title = txtTitle.Text.Trim();
    string content = ftbContent.Text.Trim();
    string caid = ddlCategory.SelectedValue;

    News n = new News(newsid, title, content, caid);

    bool b = new NewsManager().Update(n);

    if (b)
    {
        Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('新闻修改成功！');</script>");
    }
    else
    {
        Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('新闻修改失败，请联系管理员！');</script>");
    }

    // 清空标题和内容
    txtTitle.Text = "";
    ftbContent.Text = "";
}
}