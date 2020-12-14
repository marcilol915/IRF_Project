using IRF_Project_JJEZ57;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
   public class RegisterTest
    {
        [Test,
             TestCase("Nagy Marton2", false),
    TestCase("Nagy Marton Tamas", false),
    TestCase("Nagy Marton", true),
            ]
        public void TestValidateName(string nev, bool expectedResult)
        {
            Form1 form = new Form1();
           
            var actualresult = form.validatename(nev);
            Assert.AreEqual(expectedResult, actualresult);

        }
        [Test,
            TestCase("12345",false),
            TestCase("123a",false),
            TestCase("1234",true)]
        public void TestValidateAzon(string azon, bool expectdresult)
        {
            Form1 form = new Form1();
            var actualresult = form.validateazonosito(azon);
            Assert.AreEqual(expectdresult, actualresult);
        }
    }
}
