using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalproject
{
    public partial class ListPages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //reset search results
            search_results.InnerHtml = "";

            string searchTerms = "";

            if (Page.IsPostBack)
            {
                searchTerms = page_search.Text;
            }

            string query = "select * from Pages";

            if (searchTerms != "")
            {
                query += " where PAGETITLE like '%" + searchTerms + "%' or PAGEBODY like '%" + searchTerms + "%' or PAGEDATE like '%" + searchTerms + "%' ";
            }

            query += " order by PAGETITLE";
            //for debugging
           //debug.InnerHtml = query;

            var db = new BLOCKDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                //start table row
                search_results.InnerHtml += "<div class=\"table-row\">";

                string pageid = row["pageid"];

                //table cells
                string pagetitle = row["pagetitle"];
                search_results.InnerHtml += "<div class=\"table-cell\">" + pagetitle + "</div>";

                string pagebody = row["pagebody"];
                search_results.InnerHtml += "<div class=\"table-cell\">" + pagebody + "</div>";

                string pagedate = row["pagedate"];
                search_results.InnerHtml += "<div class=\"table-cell\">" + pagedate + "</div>";

                //put links into one cell
                search_results.InnerHtml += "<div class=\"table-cell\">";
                //links to be styled as buttons
              
                search_results.InnerHtml += "<div class=\"button\"><a href=\"UpdatePage.aspx?studentid=" + pageid + "\">Update</a></div>";
                search_results.InnerHtml += "<div class=\"button\"><a href=\"deletepage.aspx?studentid=" + pageid + "\">Delete</a></div>";
                //close table cell
                search_results.InnerHtml += "</div>";

                //close table row
                search_results.InnerHtml += "</div>";
            }
        }
    }
}