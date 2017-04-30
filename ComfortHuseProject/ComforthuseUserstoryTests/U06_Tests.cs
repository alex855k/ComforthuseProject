using Comforthuse.Models;
using Comforthuse.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ComforthuseUserstoryTests
{
    [TestClass]
    public class U06Tests
    {
        [TestMethod]
        public void CaseListIsNotEmpty()
        {
            ICaseRepository caseRepository = new CaseRepository();

            caseRepository.AddCase(new Case());
            caseRepository.AddCase(new Case());

            List<Case> listOfCases = caseRepository.GetListOfCases();

            Assert.IsTrue(listOfCases.Count > 0);


        }

        [TestMethod]
        public void CaseListIsEmpty()
        {
            ICaseRepository caseRepository = new CaseRepository();

            List<Case> listOfCases = caseRepository.GetListOfCases();

            Assert.AreEqual(0, listOfCases.Count);
        }

        [TestMethod]
        public void CheckIfListHasCorrectNumberOfCases()
        {
            ICaseRepository caseRepository = new CaseRepository();

            caseRepository.AddCase(new Case());
            caseRepository.AddCase(new Case());
            caseRepository.AddCase(new Case());

            List<Case> listOfCases = caseRepository.GetListOfCases();

            Assert.AreEqual(3, listOfCases.Count);
        }
    }
}
