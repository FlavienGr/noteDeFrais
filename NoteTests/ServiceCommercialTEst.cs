using Microsoft.VisualStudio.TestTools.UnitTesting;
using notedefrais;
using System;

namespace NoteTests
{
    [TestClass]
    public class ServiceCommercialTEst
    {
        [TestMethod]
        public void NombreFraisNonRembourser()
        {
            ICommercial commercialOne, commercialTwo;
            Note noteOne, noteTwo, noteThree, noteFour, noteFive;

            ServiceCommercial sc = new ServiceCommercial();
            commercialOne = new Commercial("Tech", "Franck", 25, 'A');
            commercialTwo = new Commercial("Steel", "Man", 10, 'B');

            sc.AjouterCommercial(commercialOne);
            sc.AjouterCommercial(commercialTwo);

            noteOne = new Note(new DateTime(2020, 10, 23), commercialOne);
            noteTwo = new Note(new DateTime(2020, 10, 24), commercialOne);
            noteOne.SetGiveMoneyBack();

            noteThree = new Note(new DateTime(2020, 10, 23), commercialTwo);
            noteFour = new Note(new DateTime(2020, 10, 24), commercialTwo);
            noteThree.SetGiveMoneyBack();

            noteFive = new Note(new DateTime(2020, 10, 23), commercialTwo);
            noteFive.SetGiveMoneyBack();
            Assert.AreEqual(2, sc.NombreFraisNonRembourser());
        }
    }
}
