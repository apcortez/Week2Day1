using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1
{
    class Person
    {
        //public string FirstName; //campi di default private
        public string LastName;
        private string _firstName;
      
        public Person(string FirstName, string LastName)
        {
            //keyword this
            this.FirstName = FirstName;
            this.LastName = LastName;
            
        }
        public Person(string FirstName, string LastName, int Age)
        {
            //keyword this
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;

        }
        public Person()
        {

        }

        //proprietà
        public string FirstName
        {
            get 
            {
                return _firstName;
            }
            set 
            {
                if (value == string.Empty)
                {
                    _firstName = "Nessun nome";
                }
                else
                {
                    _firstName = value;
                }
            }
        }

        public string Lastname { get; set; }


        public int Age { get; private set; }

        //public void MetodoACaso()
        //{
        //    int a = 25;
        //    Age = a; //posso setterlo nella classe perchè private
        //}

        public string BioData
        {
            get
            {
                return FirstName + " " + Lastname + " " + Age;
            }
        }
        
        public HomeAddress Address { get; set; }
    }
}
