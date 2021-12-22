using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanjjeevWorkouts
{
    class Person
    {
        private string name; // field
        private int age; // field

        public string Name // property
        {
            get { return name; }
            set { name = value; } 
        }

        public int Age // Automatic property (short hand )
        {
            get; set;
        }

    }
}
