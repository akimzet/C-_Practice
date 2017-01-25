using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice_1
{
    class Student
    {
        //Get and Set has an auto-implemented property (Getter and Setter Functions)
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }

        //Store Scores for each student (5)
        public List<int> Scores;

        //Print
        public override string ToString()
        {
            return First + " " + Last + ": " + ID;
        }
    }
}
