using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End
{
    class Insured:Person
    {
       
        private List<Service> listServise;
        private static int young_insured;
        private static int insured;
        private static int adult_insured;
        static Insured()
        {
            young_insured = 40;
            insured = 60;
            adult_insured = 55;
        }
       
        public List<Service> ListServise { get;  }
        public static int Young_insured { get; set; }
        public static int IInsured { get; set; }
        public static int Adult_insured { get; set; }
        public Insured() : base("123456789")
        {

        }
        public Insured(string id, DateTime birthDate, string firstName, string lastName,int young,int middle,int adualt) : base(id, birthDate, firstName, lastName)
        {
            Young_insured = young;
            IInsured = middle;
            Adult_insured = adualt;
        }
        public static double SumNewFriend(DateTime birthDate)
        {
            if (DateTime.Now.Year - birthDate.Year > 60)
                return Adult_insured;
            if (DateTime.Now.Year - birthDate.Year < 18)
                return Young_insured;
            return IInsured;
        }
        public virtual bool Eligible_for_advice()
        {
            return false;
        }
        public bool 
    }
}
