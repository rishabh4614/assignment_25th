using System;

namespace assignment_2nd
{
 /*   2. Create a class called student which has data members like rollno, name, class, SEM, branch,int [] marks=new int marks [5](marks of 5 subjects )
-Write a method called displayresult, which should calculate the average marks
-If marks of any one subject is less than 35 print result as failed
-If marks of all subject is >35 but average is < 50 then also print result as failed
-If avg > 50 then print result as passed.
-Pass the details of student like rollno, name, class, SEM, branch in constructor
-Write a Display Data method to display all values.

*/
    class Student
    {
        private int roll_no;
        private string name;
        private int sem;
        private string branch;
        private int[] marks = new int[5];

        public void displayresult()
        {

            int sum = 0, avg = 0;
            for (int i = 0; i < 5; ++i)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + marks[i];
            }
            avg = sum / 5;

            for (int i =0; i<5; ++i)
            {

                if(marks[i]<35)
                {
                    Console.WriteLine("You failed..");
                    break;
                }
                else if(avg < 50)
                {
                    Console.WriteLine("You failed.."); 
                    break;
                }
                else { Console.WriteLine("You passed.."); break; }
            }
        }

        public Student(ref int rollNo, ref string naMe, ref int Sem,ref string Branch)
        {
            roll_no = rollNo;
            name = naMe;
            sem = Sem;
            branch = Branch;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Welcome to ABC School----------------");
            Console.Write("Enter Roll Number: ");
            int ro = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Enter your Name: ");
            string na = (Console.ReadLine());
            Console.Write("Enter Semester: ");
            int se = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Enter Branch: ");
            string ba = (Console.ReadLine());
            Student su = new Student(ref ro,ref na,ref se,ref ba);
            Console.WriteLine("Enter marks of subjects: ");
            su.displayresult();
        }
    }
}
