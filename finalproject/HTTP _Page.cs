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
       /* we can get and set values for class..Methods can give us information that we want.    */
        private string Title;
        private string Body;
        private DateTime Date;

        

        
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

       //these methods are used to change values to what we want.
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











