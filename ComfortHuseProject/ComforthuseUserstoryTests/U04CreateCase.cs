using Comforthuse.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ComforthuseUserstoryTests
{
    [TestClass]
    public class UC04CreateCase
    {

        [TestMethod]
        public void CreateCase()
        {
            // Arrange
     
           
            // Act

            // Assert
            //AssertAreEqual();

        }

        [TestMethod]
        public void CaseCreateFails()
        {
            // Arrange
            ICaseRepository caseRep = new CaseRepository();

            // Act 
            CreateCase();
            // Assert
        }


        [TestMethod]
        public void LoadCase()
        {
            // Arrange

            // Act 

            // Assert

        }
    }
}
