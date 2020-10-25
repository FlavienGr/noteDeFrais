using Microsoft.VisualStudio.TestTools.UnitTesting;
using notedefrais;
using System;

namespace NoteTests
{
    [TestClass]
    public class FraisNuiteTest
    {
        [TestMethod]
        public void CalculMontantARembourserTest()
        {
            ICommercial commercial = new Commercial("Alan", "Bod", 8, 'A');
            INote note = new FraisNuite(new DateTime(2020, 10, 22), commercial, 46, 2);

            INote noteTwo = new FraisNuite(new DateTime(2020, 10, 22), commercial, 80, 3);


            Assert.AreEqual(46m, note.GetMontantARembourser());
            Assert.AreEqual(74.75m, noteTwo.GetMontantARembourser());
        }
    }
}
