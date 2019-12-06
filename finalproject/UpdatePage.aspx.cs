using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalproject
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLOCKDB db = new BLOCKDB();
            ShowStudentInfo(db);
        }

        protected void ShowStudentInfo(BLOCKDB db)
        {

            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            //We will attempt to get the record we need
            if (valid)
            {

                Dictionary<String, String> page_record = db.FindPage(Int32.Parse(pageid));

                if (page_record.Count > 0)
                {
                    page_title.InnerHtml = page_record["PAGETITLE"]; 
                    //page_title.Text = page_record["PAGETITLE"];
                    //page_body.Text = page_record["PAGEBODY"];
                   

                }
                else
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                //page.InnerHtml = "There was an error finding that page.";
            }
        }


    }
}