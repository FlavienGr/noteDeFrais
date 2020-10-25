using Microsoft.VisualStudio.TestTools.UnitTesting;
using notedefrais;
using System;

namespace NoteTests
{
    [TestClass]
    public class FraisTransportTest
    {
        [TestMethod]
        public void CalculMontantARembourserTest()
        {
            ICommercial commercial = new Commercial("Alan", "Bod", 8, 'A');
            INote note = new FraisTransport(new DateTime(2020, 10, 22), commercial, 250);

            Assert.AreEqual(50, note.GetMontantARembourser());
        }
    }
}
