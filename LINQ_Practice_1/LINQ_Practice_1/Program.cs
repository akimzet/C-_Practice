using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice_1
{
    class Program
    {
        //Create 4 Students (Data) - using Student class
        List<Student> student = new List<Student>()
        {

            //Creating new Objects below without the use of a Constructor (Useful)

            new Student {First = "Andrew", Last = "Kim", ID = -10, Scores = new List<int>() {10, 20, 89, 60, 90 }},
            new Student {First = "Bob", Last = "Ross", ID = 15, Scores = new List<int>() {12, 48, 30, 100, 90 }},
            new Student {First = "Charlie", Last = "Bean", ID = -20, Scores = new List<int>() {95, 20, 42, 46, 23 }},
            new Student {First = "Julie", Last = "Penn", ID = 25, Scores = new List<int>() {88, 45, 36, 80, 99 }}
        };

        //Contact Info connected with their ID (Data) - using ContactInfo class
        List<ContactInfo> contact = new List<ContactInfo>()
        {
            new ContactInfo {ID = -10, Email = "ak@gmail.com", Phone = "123-123-0001" },
            new ContactInfo {ID = 15, Email = "br@gmail.com", Phone = "123-123-0002" },
            new ContactInfo {ID = -20, Email = "cb@gmail.com", Phone = "123-123-0003" },
            new ContactInfo {ID = 25, Email = "jp@gmail.com", Phone = "123-123-0004" }
        };

        //Run Program
        static void Main(string[] args)
        {
            //Set Program to manipulate the information however we want
            Program test = new Program();

            //Create a Query to get students with ID greater than 1
            //IEnumerable can iterate over a collection of same types <Student>
            IEnumerable<Student> query1 =
                //Can Create Filters - (Use List made) in (Program) - where (If statement)
                from student in test.student
                where student.ID > 1
                select student;

            //Use The Query - foreach (object) in (Query made above)
            foreach (Student s in query1)
            {
                Console.WriteLine(s.ToString());
            }

            //Create a Query to get contact info with ID greater than 1
            IEnumerable<ContactInfo> query2 =
                from contact in test.contact
                where contact.ID > 1
                select contact;

            //Use Contact Query
            foreach (ContactInfo c in query2)
            {
                Console.WriteLine(c.ToString());
            }

            //Displays everything written
            Console.ReadKey();
        }
    }
}
