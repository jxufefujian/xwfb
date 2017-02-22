using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // 登陆按钮
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // 判断验证码是否输入正确
        string code = txtCode.Text.Trim().ToUpper();
        string rightCode = Session["Code"].ToString();
        if (code != rightCode)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('验证码输入错误！');</script>");
            return;
        }

        string name = txtName.Text.Trim();
        string pwd = txtPassword.Text.Trim();

        // 把密码转为MD5码的形式
        pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "MD5");

        bool b = LoginManager.Login(name, pwd);
        if (b)
        {
           //  登陆成功
           Session["admin"] = name;
           Response.Redirect("categorymanager.aspx");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('登陆失败，用户名或者密码错误！');</script>");
        }

    }
}