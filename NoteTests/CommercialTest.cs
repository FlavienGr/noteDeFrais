using Microsoft.VisualStudio.TestTools.UnitTesting;
using notedefrais;
using System;

namespace NoteTests
{
    [TestClass]
    public class CommercialTest
    {
        [TestMethod]
        public void AjouterNoteFrais()
        {
            ICommercial commercial = new Commercial("Tech", "Franck", 25, 'A');
            Note noteOne, noteTwo;

            noteOne = new Note(new DateTime(2020, 10, 23), commercial);
            noteTwo = new Note(new DateTime(2020, 10, 24), commercial);

            Assert.AreEqual(2, commercial.GetNoteDeFrais().Count);

        }
    }
}
