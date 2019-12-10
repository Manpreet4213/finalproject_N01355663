using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalproject
{
    public partial class ShowPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            

            //We will attempt to get the record we need
            if (valid)
            {
                var db = new BLOCKDB();
                Dictionary<String, String> page_record = db.FindPage(Int32.Parse(pageid));

                if (page_record.Count > 0)
                {
                    page_title.InnerHtml = page_record["pagetitle"];
                    page_body.InnerHtml = page_record["pagebody"];
                    page_date.InnerHtml = page_record["pagedate"];
                }
                else
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                ipage.InnerHtml = "There was an error finding that page.";
            }
        }
    }
    
}