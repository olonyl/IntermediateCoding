using System;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
    }
}
