using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice_1
{
    class ContactInfo
    {
        //Get and Set has an auto-implemented property (Getter and Setter Functions)
        public int ID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        //Print
        public override string ToString()
        {
            return Email + ", " + Phone;
        }
    }
}
