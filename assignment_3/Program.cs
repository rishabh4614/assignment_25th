using System;


/*3.Create an Abstract class Student with Name, StudentId, Grade as members and also an abstract method Boolean Ispassed(grade) which takes grade
 * as an input and checks whether student passed the course or not.  
Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method

For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. For the Grad class, 
if the grade is above 80.0, then isPassed returns true, otherwise returns false.

*/

namespace assignment_3
{
    abstract class Student
    {
        public abstract string Name { get; set; }
        public abstract int StudentId { get; set; }
        public abstract double Grade { get; set; }

        public abstract bool Ispassed(double Grade);
        
    }
    
    class Graduate : Student
    {
        string name;  int studentid; double grade;
        public override string Name
        { 
            
            get { return name; }
            set { name = value; }
        }

        public override int StudentId
        {
            get { return studentid; }
            set { studentid = value; }
        }

        public override double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public override bool Ispassed(double Grade)                             // for Graduate
        {
            if (Grade > 80.0) { return true; }
            else { return false; }
        }
    }

    class Undergraduage : Student
    {
        string name; int studentid; double grade;
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override int StudentId
        {
            get { return studentid; }
            set { studentid = value; }
        }

        public override double Grade
        {
            get { return grade; }
            set { grade = value; }
        }


        public override bool Ispassed(double Grade)                 //for Undergraduate
        {
            if (Grade > 70.0) { return true; }
            else { return false; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter 1 for Graduation ");
            Console.WriteLine("Enter 2 for Undergraduation");
            choice = Convert.ToInt32(Console.ReadLine());
            
              switch(choice)
            {
                case 1:
                    Graduate gra = new Graduate();
            Console.WriteLine("Enter Name: ");
            gra.Name = Console.ReadLine();
            Console.WriteLine("Enter Student ID: ");
            gra.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Grade: ");
            gra.Grade = Convert.ToDouble(Console.ReadLine());
            bool pass = gra.Ispassed(gra.Grade);
            if (pass == true) { Console.WriteLine("You are Passed.."); }
            else { Console.WriteLine("You failed.."); }
                    break;
            case 2:
                Undergraduage ugra = new Undergraduage();
            Console.WriteLine("Enter Name: ");
            ugra.Name = Console.ReadLine();
            Console.WriteLine("Enter Student ID: ");
            ugra.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Grade: ");
            ugra.Grade = Convert.ToDouble(Console.ReadLine());
            bool pass1 = ugra.Ispassed(ugra.Grade);
            if (pass1 == true) { Console.WriteLine("You are Passed.."); }
            else { Console.WriteLine("You failed.."); }
                    break;
            }
                  



        }
    }
}
