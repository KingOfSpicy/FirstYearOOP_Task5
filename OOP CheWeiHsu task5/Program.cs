using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_task5
{
    class Program
    {
        public static ObservableCollection<Student> Students;
        static void Main(string[] args)
        {
            Students = new ObservableCollection<Student>();
            //event needed:
            //打+=之後 Tab
            Students.CollectionChanged += Students_CollectionChanged;
            Console.WriteLine();
            AddSomeItems();
            Console.WriteLine("After adding:");
            Console.WriteLine();
            foreach (var s in Students)
                Console.WriteLine(s.Name);
            Console.WriteLine();
            RemoveSomeItems();
            Console.WriteLine("After removing:");
            Console.WriteLine();
            foreach (var s in Students)
                Console.WriteLine(s.Name);


            //bool stillMore = false;
            //Generic Collection of type List<>:
            //List<Student> studentGroup = new List<Student>()
            //{
            //        new Student("Juha Sipilä", "Uimahallintie 45 A 55", new DateTime(1987,11,23)),
            //        new Student("Ella Eronen", "Niittypolku 5", new DateTime(2001, 12, 24)),
            //        new Student("Esko Jylhä", "Hallituskatu 77", new DateTime(1985, 6, 18)),
            //        new Student("Juha Sipilä", "Uimahallintie 45 A 55", new DateTime(1987, 11, 23)),
            //        new Student("Juha Sipilä", "Uimahallintie 45 A 55", new DateTime(1987, 11, 23))

            //};
            //Console.WriteLine(studentGroup);
            //Make interactive:
            //No Constructor:

            //List<Student> studentGroup = new List<Student>()
            //{
            //    new Student{Name="Reijo Vuohelainen", Address="Kielokallio 34 E 33", DateOfBirth= new DateTime(1992,12,10)},
            //    new Student{Name="Minna Jaakkola", Address="Hopeasalmentie 33 M 33", DateOfBirth= new DateTime(1995-10-25)}
            //};

            //do
            //{
            //    Console.Write("Name: ");
            //    string receivedName = Console.ReadLine();

            //    Console.Write("Address: ");
            //    string receivedAddress = Console.ReadLine();

            //    Console.Write("Date of birth: ");
            //    DateTime receivedDOB;
            //    string nextDOB = Console.ReadLine();
            //    //Make sue it is of type DateTime:
            //    while (!DateTime.TryParse(nextDOB, out receivedDOB))
            //    {
            //        Console.Write("Invalid, please give correct type: ");
            //        nextDOB = Console.ReadLine();
            //    }
            //    //One step at a time...
            //    Student thisTime = new Student(receivedName, receivedAddress, receivedDOB);
            //    studentGroup.Add(thisTime);
            //    //...or everything immediately:
            //    //studentGroup.Add(new Student(receivedName, receivedAddress, receivedDOB));

            //    Console.Write("More(Y/N)?: ");
            //    string moreOfThis = Console.ReadLine().ToUpper();

            //    if (moreOfThis.StartsWith("Y"))
            //    {
            //        stillMore = true;
            //    }
            //    else
            //    {
            //        stillMore = false;
            //    }


            //    } while (stillMore);
            //All the object in your collection:
            //foreach(Student item in studentGroup)

            //foreach (var item in studentGroup)
            //    Console.WriteLine(item);

            ////use var to let system decide what the variable type is.
            //Console.WriteLine("Name: " + item.Name + ", Address: " + item.Address + ", Birthday: " + item.DateOfBirth.ToString("d"));



        }
        //同上RemoveSomeItems()系統修正其錯誤後產出!
        private static void RemoveSomeItems()
        {
            //throw new NotImplementedException();
            Students.Remove(new Student("Timo Hynninen", "Nuijamiestentie 44 A 22", new DateTime(1991, 10, 5)));
        }

        //必須是static因為只在這個Program.cs裡使用，上面的AddItems()，在系統自動修正後產出!
        private static void AddSomeItems()
        {
            //throw new NotImplementedException();
            Students.Add(new Student("Timo Hynninen", "Nuijamiestentie 44 A 22", new DateTime(1991, 10, 5)));
            Students.Add(new Student("Ella Eronen", "Niittypolku 5", new DateTime(2001, 12, 24)));
            Students.Add(new Student("Esko Jylhä", "Hallituskatu 77", new DateTime(1985, 6, 18)));
            Students.Add(new Student("Juha Sipilä", "Uimahallintie 45 A 55", new DateTime(1987, 11, 23)));
        }

        //上面+= Tab之後自動產出的
        private static void Students_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.NewItems != null)
            {
                //something has been added....
                foreach (Student s in e.NewItems)
                {
                    Console.WriteLine("Collection changed. New Student added:");
                    Console.WriteLine(s.Name);
                }

            }
            else
            {
                foreach (Student s in e.OldItems)
                {
                    Console.WriteLine("Collection changed. New Student removed:");
                    Console.WriteLine(s.Name);
                }
            }
        }

    }
}
