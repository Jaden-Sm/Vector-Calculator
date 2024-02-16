using System;

namespace Vector_Calculator
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Please input 6 different numbers seperated by an enter. Not putting in a number will error it out.");
            Vector test1 = new Vector(0, 0, 0);
            Vector test2 = new Vector(0, 0, 0);
            int counter = 0;
            while (true)
            {

                counter++;
                if (counter >= 7)
                {
                    break;
                }
                 int input = Convert.ToInt32(Console.ReadLine());
                if(counter <= 3)
                {
                    if (counter % 3 == 1)
                    {
                        test1.x = input;

                    }
                    else if (counter % 3 == 2)
                    {
                        test1.y = input;
                    }
                    else
                    {
                        test1.z = input;
                    }
                } else if(counter >= 3)
                {
                    if (counter % 3 == 1)
                    {
                        test2.x = input;
                    }
                    else if (counter % 3 == 2)
                    {
                        test2.y = input;
                    }
                    else
                    {
                        test2.z = input;
                    }
                }
                
            }
            Console.WriteLine("First vector");
            Console.WriteLine(test1);
            Console.WriteLine("Second vector");
            Console.WriteLine(test2);
            Console.WriteLine("Add the two vectors");
            Console.WriteLine(Vector.Add(test1, test2));
            Console.WriteLine("Subtract vector1 by vector2");
            Console.WriteLine(Vector.Subtract(test1, test2));
            Console.WriteLine("Negate first vector.");
            Console.WriteLine(Vector.Negate(test1));
            Console.WriteLine("Scale first vector by 3");
            Console.WriteLine(Vector.Scale(test1, 3));
            Console.WriteLine("Normalize first vector");
            Console.WriteLine(Vector.Normalize(test1));
            Console.WriteLine("Dot product of the 2 vectors");
            Console.WriteLine(Vector.DotProduct(test1, test2));
            Console.WriteLine("Cross product of the 2 vectors");
            Console.WriteLine(Vector.CrossProduct(test1, test2));
            Console.WriteLine("Angle between vectors");
            Console.WriteLine(Vector.AngleBetween(test2, test1));
            Console.WriteLine("Project first onto second.");
            Console.WriteLine(Vector.ProjectOnto(test1, test2));
        }
    }
}
