using System;

namespace Course.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //Constructor #1
        public HourContract()
        {
                
        }

        //Constructor #2
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //method TotaValue()
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
