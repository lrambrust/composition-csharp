using System;
using System.Collections.Generic;

namespace Course.Entities
{
    class Department
    {
        public string Name { get; set; }

        //Consctructor #1
        public Department()
        {

        }

        //Constructor #2
        public Department(string name)
        {
            Name = name;
        }
    }
}
