using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End
{
    public enum kindServise{ Clinics=1,Emergency,Medicines }
    class Service
    {
        private kindServise kServise;
        private double sumServise;
        public bool Happiness { get; set; }
        private DateTime date;
        public kindServise KServise
        {
            get
            {
                return kServise;
            }
            set
            {
                if (Enum.IsDefined(typeof(kindServise), value))
                {
                    kServise = value;
                }
            }
        }
        public double SumServise
        {
            get { return sumServise; }
            set { if (value > 0)
                    sumServise = value;
            }
        }
       
        public DateTime Date
        {
            get { return date; }
            set { if (value > DateTime.Now)
                    date = value;
            }
        }
        public Service(Service s):this(s.KServise,s.SumServise,s.Happiness,s.Date)
        {
            
        }
        public Service(kindServise kServise,double sumServise,bool Happiness, DateTime date)
        {
            KServise = kServise;
            SumServise = sumServise;
            this.Happiness = Happiness;
            Date = date;
        }

    }
}
