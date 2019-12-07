using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace finalproject
{
    public class BLOCKDB
    {
        /* I  have taken help from Christine Bittle's code in order to write the coding.As i don't have 
         * any experience of coding.*/
        //for a database, we need to know
        // - A connection (url, port)
        // - A username
        // - A password
        // - A database
        //we are to open the PHP MYADMIN to know all this.There one chart will be given to know this.
        
        
        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }
        private static string Database { get { return "block"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        //ConnectionString provides connection with the database
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }

        //returns a result set
       //these are the list of dictionaries and present us the result set thaat we want to see.
        public List<Dictionary<String, String>> List_Query(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            //here , according to our string query, the result set will be provided.
            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();

            // try{} catch{} tries to do thingx inside try but when error occurs then the catch part 
            //works and it prevents the crashing of the system.
            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query" + query);
                //to open database connection
                Connect.Open();
                //now query for connection is given
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //getting the result set.
                MySqlDataReader resultset = cmd.ExecuteReader();


                //for every row in the result set
                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                    //for every column in the row
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));

                    }

                    ResultSet.Add(Row);
                }//end row
                resultset.Close();


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;
        }


        //this method provides us a particular page with a given integer id.
        //It gives us the result set like key value pairs.
        public Dictionary<String, String> FindPage(int id)
        {
            //use  connection string
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            //creating a blank page in case we are unsuccessful to get the page data.
            Dictionary<String, String> page = new Dictionary<String, String>();

            //now, we will try to find that page otherwise we will check the output window to know error message.
            try
            {
                //query with id information.
                string query = "select * from PAGES where pageid = " + id;
                Debug.WriteLine("Connection Initialized...");
                //open databse connection
                Connect.Open();
                //Run out query against the database
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();

                //list of pages is created even we need only 1 page.
                List<Dictionary<String, String>> Pages = new List<Dictionary<String, String>>();

                //read through the result set
                while (resultset.Read())
                {
                    //for the single data will be stored.
                    Dictionary<String, String> Page = new Dictionary<String, String>();

                    //Look at each column in the result set row, add both the column name and the column value to our Student dictionary
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Debug.WriteLine("Attempting to transfer data of " + resultset.GetName(i));
                        Debug.WriteLine("Attempting to transfer data of " + resultset.GetString(i));
                        Page.Add(resultset.GetName(i), resultset.GetString(i));

                    }
                    //Add the page to the list of pages
                    Pages.Add(Page);
                }

                page = Pages[0]; //get the first page

            }
            catch (Exception ex)
            {
                //if the try block is unsuccessful, then the catch block works.
                Debug.WriteLine("Something went wrong in the find Page method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return page;
        }


        //ADDPAGE METHOD
        //we will add a page to the system instead of looking for a page.
        public void AddPage(HTTP__Page new_page)
        {
            
            //this is the better way of injecting data.
            string query = "insert into pages (pagetitle, pagebody, pagedate) values ('{0}','{1}', curdate())";
            query = String.Format(query, new_page.GetTitle(), new_page.GetBody());

            
            //now, again use connection string

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the AddPage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }


        //; updatepage method
        public void UpdatePage(int pageid, HTTP__Page new_page)
        {
         //it is better way of updating data.
            string query = "update PAEGS set pagetitle='{0}', pagebody='{1}' where pageid={2}";
            query = String.Format(query, new_page.GetTitle(), new_page.GetBody(), new_page.GetDate(), pageid);
            //this is also sensitive technique to sql queries.

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                
                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + query);
            }
            catch (Exception ex)
            {
                //If that doesn't seem to work, check Debug>Windows>Output for the below message
                Debug.WriteLine("Something went wrong in the UpdatePage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }
        // deletepage method
        public void deletePage(int pageid)
        {
            

            //now, deleting the pages from a database.We don't have any another table associated.So, it will be easy for us to 
            //delete page as we don't need to care about other pages.

            //delete primary key of page that we want to delete.
            string removepage = "delete from pages where pageid = {0}";
            removepage = String.Format(removepage, pageid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            //this command removes a particular page from the system.
            MySqlCommand cmd_removepage = new MySqlCommand(removepage, Connect);
            try
            {
                
                Connect.Open();
                //removing record of the page
                cmd_removepage.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_removepage);
            }
            catch (Exception ex)
            {
                //if this isn't working as intended, you can check debug>windows>output for the error message.
                Debug.WriteLine("Something went wrong in the delete Page Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }


    }
}





