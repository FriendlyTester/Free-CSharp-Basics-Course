using System;
using NUnit.Framework;

namespace CSharpBasics.nunitlessons
{
    public class C_Assertions
    {
        [Test]
        public void TestOne()
            {
                int c = 5 * 5;

                //So our first assertion is using the Assert class from NUnit.
                //The first parameter is the ExpectedResult, the second parameter is the actual value.
                //So here I'm expecting our calculation above to be 25.
                Assert.AreEqual(25, c);

                //We can also add a contextual message. NUnit will display this message upon failure
                //Creating good contextual messages can really speed up debugging
                Assert.AreEqual(25, c, "contextual message on failure here");
                //We can use assertEquals for strings, ints, objects

                //NUnit then also gives us many other options

                //Assert.IsFalse(); Checking something is false
                //Assert.AreNotEqual (); Doesn't matter what the value is along as its not this value
                //Assert.NotNull() Isn't null
                //Assert.AreNotSame() Same as NotEquals
                //Assert.AreSame(); Same as equals above
                //Assert.IsTrue(); Checking something is true
            }
    }
}