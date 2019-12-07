using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalproject
{
    public partial class Navigation : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            navigation.InnerHtml = "";
            BLOCKDB db = new BLOCKDB();
            NAVIGATION(db);
        }

        protected void NAVIGATION(BLOCKDB db)
        {
            //query the most popular classes (most students)
            string query = "Select pagetitle, pageid from pages";
            List<Dictionary<String, String>> rs = db.List_Query(query);

            foreach (Dictionary<String, String> row in rs)
            {
                string pageid = row["pageid"];
                string pagetitle = row["pagetitle"];
                navigation.InnerHtml += "<li> <a href=\"ShowPage.aspx?pageid=" + pageid + "\"> " + pagetitle + " </a></Li>";


            }
        }
    }
}