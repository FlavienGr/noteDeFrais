using Microsoft.VisualStudio.TestTools.UnitTesting;
using notedefrais;
using System;

namespace NoteTests
{
    [TestClass]
    public class RepasMidiTest
    {
        [TestMethod]
        public void CalculMontantARembourserTest()
        {
            ICommercial commercial = new Commercial("Alan", "Bod", 10, 'B');
            INote note = new RepasMidi(new DateTime(2020, 10, 22), commercial, 35);
            INote noteTwo = new RepasMidi(new DateTime(2020, 10, 22), commercial, 15);


            Assert.AreEqual(22, note.GetMontantARembourser());
            Assert.AreEqual(15, noteTwo.GetMontantARembourser());

        }
    }
}
