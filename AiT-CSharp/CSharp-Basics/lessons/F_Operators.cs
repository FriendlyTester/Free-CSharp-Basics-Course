using System;
namespace CSharpBasics.lessons
{
    public class F_Operators
    {
        //Arithmetic
        public void Plus()
        {
            //With numbers the + takes on its math behaviour
            int a = 4 + 4; //This would equal 8

            //With strings, it combines the string
            String b = "rich" + "ard"; //This would equal richard
            Console.WriteLine(b);
        }

        public void Minus()
        {
            //Again with number it takes on its math behaviour
            int a = 10 - 5; //This would equal 5
            Console.WriteLine(a);
        }

        public void Multiple()
        {
            //Again with number it takes on its math behaviour
            int a = 10 * 5; //This would equal 50
            Console.WriteLine(a);
        }

        public void Divide()
        {
            //Again with number it takes on its math behaviour
            int a = 10 / 5; //This would equal 2
            Console.WriteLine(a);
        }

        public void Mod()
        {
            //Again with number it takes on its math behaviour
            int a = 10 % 4; //This would equal 2
            Console.WriteLine(a);
        }

        //Logical
        public void And()
        {
            //Ampersand
            Console.WriteLine(true & false); //This will print false, as they don't match
        }

        public void AndAnd()
        {
            //And and And. This is a great example but imagine true/false were methods
            //We'd been saying both need to be true in order to proceed
            Console.WriteLine(true & false && true & true); //This will print false, as they don't match
        }

        public void Or()
        {
            //We'll look at Control Flow in a future lesson, but the || means OR.
            //So if either of the arguments is true, we'd enter the flow.
            Console.WriteLine(false || true);
        }

        public void Not()
        {
            Console.WriteLine(!true); //If this value is NOT true, proceed.
        }

        //Relational
        public void EqualTo()
        {
            Console.WriteLine("richard" == "richard"); //If the values are equal, proceed
        }

        public void NotEqual()
        {
            Console.WriteLine("richard" != "sarah"); //If the values are NOT equal, proceed
        }

        public void LessThan()
        {
            Console.WriteLine(1 < 5); //If 1 is LESS THAN 5, proceed
        }

        public void GreaterThan()
        {
            Console.WriteLine(10 > 5); //If 10 is GREATER THAN 5, proceed
        }

        public void LessThanEqualTo()
        {
            Console.WriteLine(1 <= 5); //If 1 is LESS THAN or equal to 5, proceed
        }

        public void GreaterThanEuqalTo()
        {
            Console.WriteLine(10 >= 5); //If 10 is GREATER THAN or equal to 5, proceed
        }

        //Assignment
        public void Assignment()
        {
            //The = sign means assign this value to this variable
            int a = 10;
            Console.WriteLine(a);
        }

        public void NewKeyword()
        {
            //We use the 'new' keyword to create a new instance of an object.
            //So if we have a clas called Car and we wanted to make a new one we could use
            //Car richardsCar = new Car();
        }
    }
}
