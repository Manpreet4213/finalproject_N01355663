using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalproject
{
    public partial class deletePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
                bool valid = true;
                string pageid = Request.QueryString["pageid"];
                if (String.IsNullOrEmpty(pageid)) valid = false;

                BLOCKDB db = new BLOCKDB();

                //deleting the page from the system
                if (valid)
                {
                    db.deletePage(Int32.Parse(pageid));
                    Response.Redirect("ListPages.aspx");
                }
            }
    }
}