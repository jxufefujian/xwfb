using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class common : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string key = txtKey.Text.Trim();

        string action = radTitle.Checked ? "bytitle" : "bycontent";
        Response.Redirect("searchres.aspx?key=" + Server.UrlEncode(key) + "&action=" + action);

    }
}
