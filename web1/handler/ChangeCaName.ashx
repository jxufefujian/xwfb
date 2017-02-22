<%@ WebHandler Language="C#" Class="ChangeCaName" %>

using System;
using System.Web;
using BLL;
using Model;

public class ChangeCaName : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";

        string caid = context.Request.QueryString["caid"];
        string caname = context.Server.UrlDecode(context.Request.QueryString["caname"]);
        // 判断数据库中是否已经存在同名类别
        if (new CategoryManager().IsExists(caname))
        {
            context.Response.Write("false");
            return;
        }
        // 更改数据库类别名
        Category ca = new Category(caid, caname);
        bool b = new CategoryManager().Update(ca);
        if (b)
        {
            context.Response.Write("true");
        }
        else
        {
            context.Response.Write("false");
        }

    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}