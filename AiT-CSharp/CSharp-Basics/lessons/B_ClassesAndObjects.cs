using System;
using NUnit.Framework;

namespace CSharpBasics.lessons
{
    public class B_ClassesAndObjects
    {
        [Test]
        public void CreateANewObject()
        {
            //Underneath this class, you'll see I've made a new class called Car.
            //Car has a single variable on it called name, and I've set to be 'Richards Car'.

            //In common practice to not have many classes in a single file, I'm just doing this as an example.
            //But when you come to write code yourself, I'd encourage you to stick to one class per file.

            //So I want to use the class Car in my code here, therefore I need to make an instance of that class.
            //So I have to create an object which will be of the type Car, it will be a variable so I have to give it a name.

            //Here I've declared a variable called myCar which is of the type Car. I've then used the new keyword to say I want a new instance of the class Car.
            Car myCar = new Car();

            //I now have a new instance of the Car class, so I have access to its public variables and methods
            //Here I'm just asking C# to print a line to the console when the program runs
            //The value I'm asking it to print is what the Car class returns when I asked for the variable 'name'.
            //So we should see 'Richards Car' in the console if we run this test
            Console.WriteLine(myCar.name);

            //We learn more about variables and methods later
        }
    }

    public class Car
    {
        public String name = "Richards Car";
    }
}