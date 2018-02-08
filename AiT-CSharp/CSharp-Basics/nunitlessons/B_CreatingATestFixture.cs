using System;
using NUnit.Framework;

namespace CSharpBasics.nunitlessons
{
    [TestFixture]
    public class B_CreatingATestFixture
    {
        //This method will be called before each test
        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("I'm doing something to setup the system ready for the test");
        }

        //This method will be called after each test
        [TearDown]
        public void Teardown()
        {
            Console.WriteLine("I'm doing something to tidy up after the test");
        }

        [Test]
        public void TestOne()
        {
            Console.WriteLine("I'm a test doing some stuff");
        }

        /**
         * The output of running with just the above code would be
         *
         * I'm doing something to setup the system ready for the test
         * I'm a test doing some stuff
         * I'm doing something to tidy up after the test
         */

        //We can go one step further.
        //NUnit also has [OneTimeSetUp] and [OneTimeTearDown], these have to be static.

        [OneTimeSetUp]
        public static void SuiteSetUp()
        {
            Console.WriteLine("I'm doing something to setup the system ready for this test fixture");
        }

        //This method will be called after each test
        [OneTimeTearDown]
        public static void SuiteTeardown()
        {
            Console.WriteLine("I'm doing something to tidy up after this test fixture");
        }

        /**
         * The output of running with just the above code would be
         *
         * I'm doing something to setup the system ready for this test fixture
         * I'm doing something to setup the system ready for the test
         * I'm a test doing some stuff
         * I'm doing something to tidy up after the test
         * I'm doing something to tidy up after this test fixture
         */
    }
}