using System;

namespace _08_parsing_dates
{
    class Program
    {
        static void Main(string[] args)
        {
           // Convert.ToDateTime()  
            string dateString = null;  
            
            // Convert a null string.  
            DateTime dateTime10 = Convert.ToDateTime(dateString); // 1/1/0001 12:00:00 AM  
            dateString = "not a date";  
            // Exception: The string was not recognized as a valid DateTime. 
            // There is an unknown word starting at index 0.  
            DateTime dateTime11 = Convert.ToDateTime(dateString);  
                        
            dateString = "Tue Dec 30, 2015";  
            // Exception: String was not recognized as a valid DateTime because the day of week was incorrect.  
            DateTime dateTime12 = Convert.ToDateTime(dateString);  
        }
    }
}
