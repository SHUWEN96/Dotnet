using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int clickscount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
               {
                TextBox1.Text = "0";
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if(ViewState["Clicks"]!=null)
            //{
            //clickscount = (int)ViewState["Clicks"] + 1;
            //}

            //TextBox1.Text = clickscount.ToString();
            //ViewState["Clicks"] = clickscount;
            //clickscount = clickscount + 1;
            //int clickscount = Convert.ToInt32(TextBox1.Text) + 1;
            //TextBox1.Text = clickscount.ToString();




        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("The Text Has been Changed!");
        }
    }
}