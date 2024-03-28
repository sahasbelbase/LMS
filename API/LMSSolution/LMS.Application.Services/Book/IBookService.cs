using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Services.Book
{
    public interface IBookService
    {
        public string GetBook(string Json);

        public string BookTsk(string Json);
        public string BookIssue(string Json);
        public string GetUserBook(string Json);
        
    }
}
