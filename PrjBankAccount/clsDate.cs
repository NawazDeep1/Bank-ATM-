using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjBankAccount
{
    public class clsDate
    {
        private int vDay;
        private int vMonth;
        private int vYear;


        public clsDate()
        {
            vDay = 1;
            vMonth = 1;
            vYear = 1;
        }
        public clsDate(int aDay, int aMonth, int aYear)
        {
            Day = aDay;
            Month = aMonth;
            Year = aYear;
        }
        public int Day
        {
            get
            {
                return vDay;
            }
            set
            {
                vDay = (value >= 0 && value <= 30) ? value : 0;
            }
        }
        public int Month
        {
            get
            {
                return vMonth;
            }
            set
            {
                vMonth = (value >= 0 && value <= 12) ? value : 0;
            }
        }
        public int Year
        {
            get
            {
                return vYear;
            }
            set
            {
                vYear = (value >0 && value <=9999)? value: 0;
            }
        }

        public void Initialize(int aDay, int aMonth, int aYear)
        {
            //vDay = (aDay >= 1 && aDay<= 31) ? aDay: DateTime.Today.Day;
            //vMonth = (aMonth >= 1 && aMonth<= 12) ? aMonth: DateTime.Today.Month;
            //vYear = (aYear > 1 && aYear <= 9999) ? aYear : DateTime.Today.Year;
            //or

            Day = aDay;
            Month = aMonth;
            Year = aYear;
        }


        public string toNumber()
        {
            return Day +"/" +Month +"/"+Year;
        }

        public  string ToLetter()
        {
            string info = "";
            //declare array
            string[] DaysNames = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string[] MonthsName = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "september", "Octuber", "November", "December" };
            DateTime mdate = new DateTime(Year, Month, Day);
            int indxWeekDay = Convert.ToInt32(mdate.DayOfWeek);
            info = DaysNames[indxWeekDay] + Day + "of " + MonthsName[Month - 1] + Year;


            return info;
        }

    }
}
