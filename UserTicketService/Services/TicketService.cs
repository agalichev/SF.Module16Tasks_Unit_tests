﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Services
{
    public class TicketService : ITicketService
    {
        public int GetTicketPrice(int ticketId)
        {
            var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
            return (ticket is null) ?
                throw new TicketNotFoundException() : ticket.Id;
        }

        public Ticket GetTicket(int ticketId)
        {
            //return new Ticket(1, "", 1); // второй этап - минимальный код для завершия теста
            var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
            return (ticket is null) ?
                throw new TicketNotFoundException() : ticket;
        }

        private IEnumerable<Ticket> FakeBaseData
        {
            get {
                return new List<Ticket>
                {
                    new Ticket(1, "Москва - Санкт-Петербург", 3500),
                    new Ticket(2, "Челябинск - Магадан", 3500),
                    new Ticket(3, "Норильск - Уфа", 3500)
                };
            }
        }
    }

    public class TicketNotFoundException : Exception
    {
    }
}
