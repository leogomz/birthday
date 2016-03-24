//Leonard Gomez
//6/3/2015
//BIT 142
//Assignment 2.0

using System;
// if you want to use the instructor's version of "MyDate":
//using Date_SOLUTION; // leave this line UNcommented
using A3_Date_StudentWork;  // and comment this line out.

//If you want to use your version of "MyDate" then comment out using Date_SOLUTION; and UNcomment using A3_Date_StudentWork;

namespace A3_Date
{
    class Birthday
    {
        static void Main(string[] args)
        {
  
            int todayMonth;
            int todayDay;

      
            int bdayMonth;
            int bdayDay;

            Console.WriteLine("What is today's month?");
            todayMonth = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What is today's day?");
            todayDay = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What is your birthday month?");
            bdayMonth = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What is your birthday day?");
            bdayDay = Int32.Parse(Console.ReadLine());

            MyDate today = new MyDate(todayMonth, todayDay);
            MyDate bday = new MyDate(bdayMonth, bdayDay);
            int daysTilBirthday = 0;
            MyDate temp = new MyDate(today.getMonth() ,today.getDay());

            Console.WriteLine("There are {0} days in month #{1}", today.daysInMonth(), bday.getMonth());

            if(today.equals(bday))
            {
                Console.WriteLine("Happy Birthday!");
            } else
            {
                int count = temp.getMonth();
                
                while(count != bday.getMonth())
                {
                    daysTilBirthday = daysTilBirthday + temp.daysInMonth();
                    if (count == 12)
                    {
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                    temp.setDate(count, 1);
                }
                daysTilBirthday = daysTilBirthday + Math.Abs((today.getDay() - bday.getDay()));
                Console.WriteLine("Number of days until birthday {0}: {1}", bday.toString(), daysTilBirthday);
            }
        }
    }
}
