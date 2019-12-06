using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;


namespace finalproject
{
    public class HTTP__Page
    { 
        /* i have taken this code from Christine Bittle's code.*/
        /*
          These fields are private cannot be accessed normally
          will NOT be able to 
             set like Student.Fname = "Christine"
             get like Student.Fname ==> returns "Christine"
          */
        private string Title;
        private string Body;
        private DateTime Date;

        /*
         we can build special methods which get and set values for our class
         the methods are public, but the fields themselves are private.
         this technique is known as "encapsulation"
        */

        //methods which return the private content requested
        //if we want the firstname we use
        //student.GetFname(); ==> returns "Christine"
        public string GetTitle()
        {
            return Title;
        }
        public string GetBody()
        {
            return Body;
        }
        public DateTime GetDate()
        {
            return Date;
        }

        //These methods are used to set values in an object
        //i.e. if I want to change the last name to Bittle
        //student.SetLname("Bittle")
        public void SetTitle(string value)
        {
            Title = value;
        }
        public void SetBody(string value)
        {
            Body = value;
        }
        public void SetDate(DateTime value)
        {
            Date = value;
        }

    }
}











