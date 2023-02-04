using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16_3_2
{
    public interface IBookRepository
    {
        IEnumerable<Book> FindAll();
    }
}
