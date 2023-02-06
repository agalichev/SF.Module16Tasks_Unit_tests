using Xunit;
using Moq;

namespace Task16_3_2.Tests
{
    public class BookRepositoryTests
    {
        [Fact]
        public void FindAllMustReturnCorrectValue()
        {
            var books = new List<Book>()
            {
                new Book(){ Title = "Война и мир" },
                new Book(){ Title = "Человек-невидимка"},
                new Book(){ Title = "Анна Каренина" }
            };

            Mock<IBookRepository> mock = new Mock<IBookRepository>();
            mock.Setup(v => v.FindAll()).Returns(books);

            Assert.Contains(mock.Object.FindAll(), book => book.Title == "Война и мир");
            Assert.Contains(mock.Object.FindAll(), book => book.Title == "Человек-невидимка");
            Assert.Contains(mock.Object.FindAll(), book => book.Title == "Анна Каренина");
        }

    }
}