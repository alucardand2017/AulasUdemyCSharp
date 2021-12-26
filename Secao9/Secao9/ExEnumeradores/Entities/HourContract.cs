﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExEnumeradores.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }
    
        public double TotalValue()
        {
            return ValuePerHour * Hour;
        }

    }

}