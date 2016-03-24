//Leonard Gomez
//6/3/2015
//BIT 142 
//Assignment 2.0


using System;

namespace A3_Date_StudentWork
{
    class MyDate
    {
        private int month;
        private int day;

        public MyDate(int month, int day)
        {
            this.month = month;
            this.day = day;

        }

        public int getMonth()
        {
            return month;
        }

        public int getDay()
        {
            return day;
        }

        public void setDate(int month, int day)
        {
            this.month = month;
            this.day = day;
        }

        public String toString()
        {
            return month + "/" + day;
        }

        public Boolean equals(MyDate d)
        {
            return (d.getMonth() == month && d.getDay() == day);
        }

        public int daysInMonth()
        {
            switch(month)
            {
                case 2:
                    return 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                    break;
                default:
                    return 31;
                    break;
            }
        }

        public void nextDay()
        {
            if(daysInMonth() > day)
            {
                setDate(getMonth() + 1, 0);
            } else
            {
                setDate(getMonth(), getDay() + 1);
            }
        }


    }
}
