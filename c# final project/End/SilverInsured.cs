using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End
{
    class SilverInsured:Insured
    {
        private DateTime dateOfAppointment;
        public static int numOfAnnualRefunds { get; set; }
        public static double extralMonthlyPrice { get; set; }
        public DateTime DateOfAppointment { get { return dateOfAppointment; } set { if (value > DateTime.Now) dateOfAppointment = value; } }
        
    }
}
