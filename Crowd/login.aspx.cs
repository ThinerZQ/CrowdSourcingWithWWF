using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text.Equals("zq")){
            string username= TextBox1.Text;
            Server.Transfer("deployTask.aspx?username=" + username);
        }else{
            string username = TextBox1.Text;
            Server.Transfer("viewTask.aspx?username=" + username);
        }
    }
}