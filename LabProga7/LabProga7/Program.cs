using System;

namespace LabProga7
{
    class Program
    {
        static void Main()
        {
            Interval FirstObject = new Interval();
            Interval SecondObject = new Interval(10,20);
            Interval ThirdObject = new Interval(5, 7);
            Interval FourthObject = new Interval(15, 17.5);
            Interval FifthObject;
            Interval SixthObject = new Interval(9.5, 17.5);
            FirstObject.Beginning = -1;
            FirstObject.End = 1;
            Console.WriteLine($"{FirstObject.GetLength()}"); //exp : 2
            FifthObject = FirstObject + SecondObject;
            Console.WriteLine($"{FifthObject.GetLength()}"); //exp : 12
            FifthObject = SecondObject - FirstObject;
            Console.WriteLine($"{FifthObject.GetLength()}"); //exp : 8
            FifthObject = SecondObject * ThirdObject;
            Console.WriteLine($"{FifthObject.GetLength()}"); //exp : 0
            FifthObject = SecondObject * FourthObject;
            Console.WriteLine($"{FifthObject.GetLength()}"); //exp : 2.5
            FifthObject = SecondObject * SixthObject;
            Console.WriteLine($"{FifthObject.GetLength()}"); //exp : 7.5
            FifthObject++;
            ++FifthObject;
            Console.WriteLine($"{FifthObject.GetLength()}"); //exp : 11.5
            FifthObject--;
            --FifthObject;
            --FifthObject;
            Console.WriteLine($"{FifthObject.GetLength()}"); //exp : 5.5
            Console.WriteLine($"{FourthObject>ThirdObject}"); //exp : True
            Console.WriteLine($"{FourthObject < ThirdObject}"); //exp : False
            FirstObject.Beginning=0;
            FirstObject[1] = 0;
            FifthObject[0] = 10;
            FifthObject.End = 10;
            Console.WriteLine($"{FifthObject == FirstObject}"); //exp : True
            Console.WriteLine($"{FifthObject != SixthObject}"); //exp : True
            Console.WriteLine($"{FourthObject >= SixthObject}"); //exp : False
            Console.WriteLine($"{FourthObject <= SixthObject}"); //exp : True
            if (FirstObject)
            {
                Console.WriteLine($"True"); 
            }
            else
            {
                Console.WriteLine($"False"); //exp : False
            }
            if (SecondObject)
            {
                Console.WriteLine($"True"); //exp : True
            }
            else
            {
                Console.WriteLine($"False");
            }
            Console.WriteLine($"{(double)FourthObject}"); //exp : 2.5
            FifthObject = (Interval)22.5;
            Console.WriteLine($"{FifthObject.Beginning}"); //exp : 0
            Console.WriteLine($"{FifthObject.End}"); //exp : 22.5
            Console.WriteLine($"{ThirdObject.ToString()}"); //exp : Beggining = 5, End = 7, Length = 2 
        }
    }
}
