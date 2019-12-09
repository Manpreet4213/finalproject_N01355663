using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace finalproject
{
    public partial class NewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Add_Page(object sender, EventArgs e)
        {

            //I am doubting that I am reaching this method
            Debug.WriteLine("I have reached the Add_Page Method");


            //create connection
            BLOCKDB db = new BLOCKDB();

            //create a new particular page
            HTTP__Page new_page = new HTTP__Page();
            //set that page data
            new_page.SetTitle(page_title.Text);
            new_page.SetBody(page_body.Text);
            new_page.SetDate(DateTime.Now);

            //add the page to the database
            //make this page to rerect to list page.
            db.AddPage(new_page);


            Response.Redirect("ListPages.aspx");
        }
    }
}