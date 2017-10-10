using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture4.Models
{
    class Person
    {
        #region Getting Started


        //private string _Name;

        //public string Name
        //{
        //    get
        //    {
        //        return _Name;
        //    }

        //    set
        //    {
        //        if (value == null)
        //        {
        //            throw new NullReferenceException($"Field {Name} cannot be null");
        //        }

        //        value = _Name;
        //    }
        //}

        //public int Age
        //{
        //    get
        //    {
        //        TimeSpan span = DateTime.Now - DateOfBirth;
        //        return Convert.ToInt32(span.Days / 365);

        //    }
        //}
        ////auto implemented property
        //public DateTime DateOfBirth { get; set; }

        ////constructor

        //public Person(string name)
        //{
        //    _Name = name;
        //}

        #endregion
        #region MoreInterestingPerson

        public DateTime Birthday { get; set; }
        public List<Person> Children { get; set; }
        public int Age { get; set; }

        //public string Name { get; set; }
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value; 
            }
        }

        public string SayName()
        {
            return $"My name is {this.Name}"; 
        }

        public void AddOneToAge()
        {
            this.Age = this.Age + 1;
        }

        public string GetAllInformation()
        {
            string information = "";

            information += $"Name: {this.Name} \n";
            information += $"Age: {this.Age} \n";
            information += $"Birthday: {this.Birthday.ToString()} \n";

            return information;
        }

        public void ChangeName(string newName)
        {
            this.Name = newName;
        }
        #endregion



    }
}
