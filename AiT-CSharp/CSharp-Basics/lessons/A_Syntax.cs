﻿//This is how we import another library or class in our class.
using System;
//In this instance we are using the System library of .NET which gives us basic objects like Strings.
using NUnit.Framework;
//So in this instance, we want to use the NUnit library, specifically the framework namespace

//A name space is a way of group similair classes, sometimes inferred by the folder structure, other time by behaviour
namespace CSharpBasics.lessons
{
    //We need to open our class. We start with public class followed by the name of our class.
    //So in this instance our class is called A_Syntax.
    public class A_Syntax

    //We then open curly braces. This means everything inside this brace is part of the class Syntax.
    {
        //Here we have a variable. But the syntax is as follows
        //We start with the access modifier, followed by the Type, and then the name of our variable.
        //We then have to end the line. This is so the compiler knows where the line ends, in C# we do this with a semicolon
        public String testName;

        //Here we are declaring a method. Again we start with the modifier, followed by the Type and a name.
        //The difference here is the brackets (). These tell the compiler that the following code is a method
        public void FakeTest()
        //We then open braces as we did with the Class, to inform the compiler that the code in this braces belongs to the method
        {
            //We do some cool stuff here

            //Then we close the brace to say that is the end of our method
        }

        //Then we close our very first brace to inform the compiler that this is the end of our class
    }
}   