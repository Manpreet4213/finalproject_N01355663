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
            // for update the link is provided on the list pages page.
            if (!Page.IsPostBack)
            {
                //this connection instance is for showing data
                BLOCKDB db = new BLOCKDB();
                ShowPageInfo(db);
            }
        }

        protected void Update_Page(object sender, EventArgs e)
        {

            //this connection instance is for editing data
            BLOCKDB db = new BLOCKDB();

            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;
            if (valid)
            {
                HTTP__Page new_page = new HTTP__Page();
                //set that page data
                new_page.SetTitle(page_title1.Text);
                new_page.SetBody(page_body.Text);
                

                //add the page to the database
                try
                {
                    db.UpdatePage(Int32.Parse(pageid), new_page);
                    Response.Redirect("ShowPage.aspx?pageid=" + pageid);
                }
                catch
                {
                    valid = false;
                }

            }

            if (!valid)
            {
                updatePage.InnerHtml = "There was an error updating that page.";
            }

        }

        protected void ShowPageInfo(BLOCKDB db)
        {

            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            //We will attempt to get the record we need
            if (valid)
            {

                HTTP__Page page_record = db.FindPage(Int32.Parse(pageid));//i tried a lot figure out this.But, i don't know why it is happening.
                page_title.InnerHtml = page_record.GetTitle();
                page_body.Text = page_record.GetBody();
                
                
            }

            if (!valid)
            {
                updatePage.InnerHtml = "There was an error finding that page.";
            }
        }

    }
}