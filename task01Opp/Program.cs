using System;
using System.ComponentModel;
using System.Reflection;
using System.Threading.Channels;
using System.Xml.Linq;

namespace console
{
    #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
    //public struct Person
    //{
    //    private string Name;
    //    private int Age;

    //    public string name
    //    {
    //        get { return Name; }
    //        set { Name = value; }
    //    }

    //    public int age
    //    {
    //        get { return Age; }
    //        set { Age = value; }
    //    }
    //}
    #endregion

    #region 6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
    //public struct Point
    //{
    //   private double X;
    //   private double Y;

    //   public double x
    //   {
    //       get { return X; }
    //       set { X = value; }
    //   }

    //    public double y
    //    {
    //        get { return Y; }
    //        set { Y = value; }
    //    }
    //}
    #endregion

    #region 7.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
    //public struct Person
    //{
    //private string Name;
    //private int Age;

    //public string name
    //{
    //    get { return Name; }
    //    set { Name = value; }
    //}

    //public int age
    //{
    //    get { return Age; }
    //    set { Age = value; }
    //}
    //}
    #endregion
    class program
    {
        #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
        //public enum WeekDays
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
        #endregion

        #region 3.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
        //public enum Season
        //{
        //    Spring,
        //    Summer,
        //    Autumn,
        //    Winter
        //}

        #endregion

        #region 4.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
        //public enum Permissions
        //{
        //    Read = 1,
        //    Write = 2,
        //    Delete = 4,
        //    Execute = 8
        //}

        #endregion

        #region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
        //public enum Colors
        //{
        //    Red,
        //    Green,
        //    Blue
        //}
        #endregion

        #region 7.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

        //static Person FindOldestPerson(Person[] persons)
        //{
        //    Person oldestPerson = persons[0];

        //    for (int i = 1; i < persons.Length; i++)
        //    {
        //        if (persons[i].age > oldestPerson.age)
        //        {
        //            oldestPerson = persons[i];
        //        }
        //    }
        //    return oldestPerson;
        //}
        #endregion


        static void Main(string[] args)
        {
            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //for (int i = 0; i < Enum.GetValues(typeof(WeekDays)).Length; i++)
            //{
            //    Console.WriteLine(Enum.GetValues(typeof(WeekDays)).GetValue(i));
            //}
            #endregion

            #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] persons = new Person[3]
            //{
            //new Person { name = "Mohamed Bassem" , age = 35 },
            //new Person { name = "Ahmed Bassem"   , age = 28 },
            //new Person { name = "Ahmed Ali"      , age = 42 }
            //};

            //Console.WriteLine("Person Details:");

            //foreach (Person person in persons)
            //{
            //    Console.WriteLine($"Name: {person.name}  , Age: {person.age}");
            //}

            #endregion

            #region 3.Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members.Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.Write("Enter a season (Spring, Summer, Autumn, or Winter): ");
            //string userInput = Console.ReadLine();

            //if (Enum.TryParse(userInput, true, out Season selectedSeason))
            //{
            //    switch (selectedSeason)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}
            #endregion

            #region 4.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

            //Permissions currentPermissions = Permissions.Read | Permissions.Write;

            //currentPermissions |= Permissions.Delete;
            //Console.WriteLine("Current permissions: " + currentPermissions);

            //currentPermissions &= ~Permissions.Write;
            //Console.WriteLine("Current permissions: " + currentPermissions);

            //if ((currentPermissions & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Delete permission is set");
            //}
            //else
            //{
            //    Console.WriteLine("Delete permission is not set");
            //}


            #endregion

            #region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.Write("Enter a color (Red, Green, or Blue): ");
            //string userInput = Console.ReadLine();

            //if (Enum.TryParse(userInput, true, out Colors selectedColor))
            //{
            //    if (selectedColor == Colors.Red || selectedColor == Colors.Green || selectedColor == Colors.Blue)
            //    {
            //        Console.WriteLine($"{selectedColor} is a primary color.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{selectedColor} is not a primary color.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid color entered.");
            //}

            #endregion

            #region 6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Console.Write("Enter the X coordinate of the first point: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter the Y coordinate of the first point: ");
            //double y1 = double.Parse(Console.ReadLine());
            //Point point1 = new Point { x = x1, y = y1 };

            //Console.Write("Enter the X coordinate of the second point: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter the Y coordinate of the second point: ");
            //double y2 = double.Parse(Console.ReadLine());
            //Point point2 = new Point { x = x2, y = y2 };

            //double dx = point2.x - point1.x;
            //double dy = point2.y - point1.y;
            //double distance = Math.Sqrt(dx * dx + dy * dy);

            //Console.WriteLine($"The distance between the two points is: {distance:F2}");


            #endregion

            #region 7.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] persons = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for Person {i + 1}:");
            //    Console.Write("Name: ");
            //    persons[i].name = Console.ReadLine();
            //    Console.Write("Age: ");
            //    persons[i].age = int.Parse(Console.ReadLine());
            //}

            //Person oldestPerson = FindOldestPerson(persons);

            //Console.WriteLine($"The old person is {oldestPerson.name} ,is {oldestPerson.age} years old.");

            #endregion





        }

    }
}
