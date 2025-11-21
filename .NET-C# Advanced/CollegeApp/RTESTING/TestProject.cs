using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTESTING
{
        [TestClass]
    public class TestProject
    {
        [TestMethod]
        public void SampleTest()
        {
            Assert.AreEqual(2, 1 + 1);
            Assert.AreNotEqual(2, 1 + 2);
        }
    }
    [TestMethod]
    public void TestGetFullName()
    {
        
        }
        [TestMethod]
        public async void TestGetStudentsAsync()
        {
            var student = new student
            {
                ID = 1,
                Name = "Test Student",
                EmailAddressAttribute = "Shivam",
                Address = "Test Address",
                DOB = new DateTime(1997, 9, 1)
            };
            var studentapp=new Mock<IStudentRepository>();
            Assert.IsNotNull(getstudentById);
        }
    }
