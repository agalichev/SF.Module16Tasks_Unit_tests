using NUnit.Framework;
using UserTicketService.Services;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        public void GetTicketPriceMustReturnNotNullableValue()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
        }

        [Test]
        public void GetTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws < TicketNotFoundException > (() => ticketServiceTest.GetTicketPrice(100));
        }

        [Test]
        public void GetTicketMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicket(1));
        }
    }
}