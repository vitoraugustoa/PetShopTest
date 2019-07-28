using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Helper.Definition;

namespace TestePratico.Domain.Helper
{
    public class Helpers : IHelpers
    {
        public bool IsWeekend(DateTime date)
        {
            return (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) ? true : false;
        }
    }
}
