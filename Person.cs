using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_övning_och_repetition
{
    class Person
    {
        public string Name;
        public int Age;
        public DateTime BirthDate;
        private bool CanGetMarried;
        public bool canGetMarried
        {
            get
            {
                return Age >= 18;
            }
        }

        private bool CanRetireByAge;

        public bool canRetireByAge
        {
            get
            {
                return Age >= 62;
            }
        }
        // public bool CanGetMarried { get;{set Age >= 18;} }
        //  public bool CanRetireByAge { get;{set Age >= 62;} }

      // försökte delegera private method till en func..  Func<int, DateTime> _updateYears = new Func<int, DateTime>(GetDateForAge);

        public Person(string name,DateTime birthDate)
        {
            Name = name;
           Age = GetAge(birthDate);
           
        }

        private int GetAge(DateTime birthDate)
        {
            return (int) ((DateTime.Now - birthDate).TotalDays / 365.2425);
        }

      /*  private DateTime GetDateForAge(int years)
        {
            return DateTime.Now.AddYears(-years);
            
        } */
    }
}
