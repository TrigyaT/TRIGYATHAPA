using System;

class Program
{
    static void Main()
    {
        
        int year = 2024;  
        int month = 8;    

        
        DateTime firstDay = new DateTime(year, month, 1); 
        int daysInMonth = DateTime.DaysInMonth(year, month); 
        int startDay = (int)firstDay.DayOfWeek;

        
        int[][] calendar = new int[6][]; 
        int currentDay = 1; 

      
        for (int week = 0; week < calendar.Length; week++) 
        {
            calendar[week] = new int[7]; 

            for (int day = 0; day < 7; day++) 
            {
                
                if ((week == 0 && day < startDay) || currentDay > daysInMonth)
                {
                    calendar[week][day] = 0; 
                }
                else
                {
                    calendar[week][day] = currentDay++; 
                }
            }
        }

        
        Console.WriteLine($"Calendar for {firstDay:MMMM yyyy}"); 
        Console.WriteLine("Su Mo Tu We Th Fr Sa"); 
        
        foreach (var week in calendar)
        {
            
            foreach (var day in week)
            {
                
                Console.Write(day == 0 ? "   " : $"{day,2} ");
            }
            Console.WriteLine(); 
        }
    }
}
