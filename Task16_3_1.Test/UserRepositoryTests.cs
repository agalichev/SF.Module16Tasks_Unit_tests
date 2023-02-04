using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;

namespace Task16_3_1.Test
{
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void FindAllMustReturnCorrectValue()
        {
            var personList = new List<User>()
            {
                new User(){ Name = "Антон" },
                new User(){ Name = "Иван" },
                new User(){ Name = "Алексей" }
            };

            Mock<IUserRepository> mock = new Mock<IUserRepository>();

            mock.Setup(r => r.FindAll()).Returns(personList);

            Assert.That(mock.Object.FindAll().Any(u => u.Name == "Антон"));
            Assert.That(mock.Object.FindAll().Any(u => u.Name == "Иван"));
            Assert.That(mock.Object.FindAll().Any(u => u.Name == "Алексей"));
        }
    }
}
