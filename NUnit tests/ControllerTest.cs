using NUnit.Framework;
using SkaikySolutions.Controllers;
using System.Web.Mvc;
using SkaikySolutions.Models;

namespace SkaikySolutions.NUnit_tests
{
    public class ControllerTest
    {
       /*********** CHECK VIEWS TESTS *******************/
        [Test]
        public void TestHomeControllerIndex()
        {
            var obj = new HomeController();

            var actResult = obj.Index() as ViewResult;

            Assert.That(actResult.ViewName, Is.EqualTo("Index"));
        }

        [Test]
        public void TestHomeControllerEmployee()
        {
            var obj = new HomeController();

            var actResult = obj.Index() as ViewResult;

            Assert.That(actResult.ViewName, Is.EqualTo("Employee"));
        }

        [Test]
        public void TestHomeControllerEmployeeData()
        {
            var obj = new HomeController();

            var actResult = obj.Index() as ViewResult;

            Assert.That(actResult.ViewName, Is.EqualTo("Employee Data"));
        }

        [Test]
        public void TestHomeControllerContact()
        {
            var obj = new HomeController();

            var actResult = obj.Index() as ViewResult;

            Assert.That(actResult.ViewName, Is.EqualTo("Contact"));
        }
        /***********END OF VIEWS TESTS *******************/

         // to test adding new employee function
        [Test]
        public void TestEmployeeCreateErrorView()
        {
            var obj = new EmployeeController();

            ViewResult result = obj.Create(new Employee()
            {
                PRI = 21354,
                FirstName = "Hasan",
                LastName = "Skaiky"
                
            }) as ViewResult;

            Assert.That(result.ViewName, Is.EqualTo("Error"));
        }
    }
}

