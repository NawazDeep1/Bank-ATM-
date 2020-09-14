using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjBankAccount
{
    public class clsTime
    {
        //declaration of fields
        private int vHour;
        private int vMinute;
        private int vSecond;

        public int Hour
        {
            get
            {
                return vHour;
            }

            set
            {
                vHour = (value >= 0 && value <= 23) ? value : 0;
            }
        }
        public int Minute
        {
            get
            {
                return vMinute;
            }
            set
            {
                vMinute = (value >= 0 && value <= 59) ? value : 0;
            }
        }

        public int Second
        {
            get
            {
                return vSecond;
            }
            set
            {
                vSecond = (value >= 0 && value <= 59) ? value : 0;
            }
        }

      //  Declaration of public methods
        public void Adjust(int aHour, int aMinute, int aSecond)
        {
            if (aHour >= 0 && aHour <= 23)
            {
                Hour = aHour;
            }
            else
            {
                Hour = 0;
            }
            //or
            Minute = (aMinute >= 0 && aMinute <= 59) ? aMinute : 0;
        }
        public string DisplayUniversal()
        {
            return Hour + ":" + Minute + ":" + Second;
        }

        public string DisplayStandard()
        {
            //if (Hour < 12)
            //{
            //    return Hour + ":" + Minute + ":" + Second + " AM";
            //}
            //else if(Hour>12)
            //{
            //    return (Hour -12) + ":" + Minute + ":" + Second + " PM";
            //}
            //else if (Hour == 12)
            //{
            //    return Hour  + ":" + Minute + ":" + Second + " PM";
            //}
            //return  "" ;
            return ((Hour > 12) ? (Hour - 12) : Hour) + ":" + Minute + ":" + Second + ((Hour > 12) ? "PM" : "AM");
        }


    }
}
