using System;

namespace Exercise5
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int day, int month, int year)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public string DisplayDate()
        {
            return $"{_day}/{_month}/{_year}";
        }
    }
}
