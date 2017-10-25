using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnesLogic;

namespace NUnitTest
{
   [TestFixture]
   public class TestClass
   {
      [Test]
      public void TestMethod()
      {
         // TODO: Add your test code here
         Assert.Pass("Your first passing test");
      }

      [Test]
      public void TestHasCutSurface()
      {
         Checks check = new Checks();


         Assert.IsTrue(check.hasCutSurface(new int[] { 1, 4, 4, 1 }, new int[] { 3, 6, 6, 3 }));

      }
   }
}
