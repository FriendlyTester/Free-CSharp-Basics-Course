using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpBasics.nunitlessons
{
    public class D_Constraints
    {
        [Test]
        public void TestOne()
        {
            int c = 5 * 5;

            Assert.AreEqual(25, c);
            Assert.That(c, Is.EqualTo(25));

            //The first thing to note is the switching of actual and expected.
            //In the assert its expected followed by actual
            //In the matcher its actual followed by expected
            //In also reads better in my opinion. 'Assert that c is equal to 25' vs 'assert equals 25 c'
        }

        [Test]
        public void testAssertBothContainString()
        {
            Assert.That("richard", Does.Contain("a").And.Contain("d"));
            Assert.That("richard", Contains.Substring("a").And.Contain("d"));
        }

        [Test]
        public void testAssertThatListHasItems()
        {
            //Create a new list of strings, and add the following strings to the list.
            var myList = new List<string>() { "one", "two", "three" };
            Assert.That(myList, Contains.Item("one").And.Contains("two"));
            Assert.That(myList, Has.Member("one").And.Member("two"));
        }

        [Test]
        public void testAssertThatListDoesntHaveItems()
        {
            //Create a new list of strings, and add the following strings to the list.
            var myList = new List<string>() { "one", "two", "three" };
            Assert.That(myList, Does.Not.Contain("four").And.Contains("two"));
            Assert.That(myList, Has.No.Member("four").And.Member("two"));
            Assert.That(myList, Has.No.Member("four").And.Not.Member("five"));
        }

        [Test]
        public void testAssertWithOr()
        {
            //Assert that it contains 'a' OR 'z'. It will pass if either is true
            Assert.That("richard", Does.Contain("a").Or.Contain("z"));
        }
    }
}