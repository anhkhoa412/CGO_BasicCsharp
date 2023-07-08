using System;

public class Program
{
    public static void Main()
    {
        int wrongtime = 2;
        string s = (wrongtime < 3) ? "hehe" : "haha";
        Console.WriteLine(s);
   
    Input_dob:
        Console.Write("Input your birthday ") ;
        string input = Console.ReadLine() ; 

        DateTime dob;
        
        if (! DateTime.TryParse(input,out dob))
        {
            Console.WriteLine("Input again follow the form yyyy/mm/dd");
            wrongtime--;
            if (wrongtime > 0) 
            { 
                goto Input_dob; 
            } else
            {
                Console.ReadKey();
            }
            
        }

        DateTime dob_year = new DateTime(DateTime.Now.Year, dob.Month, dob.Day) ;
       
        if (dob_year > DateTime.Now)
        {
            Console.WriteLine("Con "+ ( dob_year - DateTime.Now).TotalDays + "se toi sinh nhat cua ban");
        } else if (dob_year == DateTime.Now.Date)
        {
            Console.WriteLine("Wjbu");
        } else 
        {
            dob_year = dob_year.AddYears(1) ;
            Console.WriteLine("Con lau moi toi sinh nhat " + (dob_year - DateTime.Now).TotalDays);
        }
    }
}