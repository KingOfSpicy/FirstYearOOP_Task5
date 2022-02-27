using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_task5
{
    class Student : IEquatable<Student>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        //without constructor
        //public Student(string name, string address, DateTime dateOfBirth)
        //{
        //    Name = name;
        //    Address = address;
        //    DateOfBirth = dateOfBirth;
        //}

        public Student(string name, string address, DateTime dateOfBirth)
        {
            Name = name;
            Address = address;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Address: " + Address + ", Birthday: " + DateOfBirth.ToLongDateString();
            //return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Student);
        }

        public bool Equals(Student other)
        {
            return other != null &&
                   Name == other.Name &&
                   Address == other.Address &&
                   DateOfBirth == other.DateOfBirth;
        }

        public override int GetHashCode()
        {
            var hashCode = 1069516934;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + DateOfBirth.GetHashCode();
            return hashCode;
        }
    }
}
