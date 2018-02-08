using System;
using NUnit.Framework;

namespace CSharpBasics.nunitlessons
{
    public class A_CreatingATest
    {
        //In order to use NUNit we need to add the package to our Project
        //So as covered in Lesson 2 of C# Basics we can do that using NuGet

        //Then we have two option, we can just write 'using NUnit.Framework;' at the top of our class
        //Or if you just type [Test] and place the cursor after the t and press Cmd/Ctrl + K 
        //VS will recommend packages for you to use, the top on should be NUnit and it will add it to the class
        [Test]
        public void MultipleNumbers()
        {
            int c = 5 * 6;
            Console.WriteLine(c);
        }
    }
}
