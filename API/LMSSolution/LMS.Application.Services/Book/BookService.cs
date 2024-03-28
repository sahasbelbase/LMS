using HARS.Application.Model;
using LMS.Application.Service.DataAccess;
using LMS.LLBL.DatabaseSpecific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Services.Book
{
    public class BookService : IBookService
    {
        public string? GetBook(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpBookSelCallAsQuery(Json))?.FirstOrDefault().Json;
        }
        public string BookTsk(string Json)
        {
            using (var adpater = DataAccessHelper.GetAdapter())
            {
                string param = Json;
                ActionProcedures.SpBookTsk(ref Json, adpater);
                adpater.CloseConnection();
            }
            return Json;
        }

        public string BookIssue(string Json)
        {
            using (var adpater = DataAccessHelper.GetAdapter())
            {
                string param = Json;

                ActionProcedures.SpBookIssueTsk(ref Json, adpater);
                adpater.CloseConnection();
            }
            return Json;
        }

        public string? GetUserBook(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpUserBookSelCallAsQuery(Json))?.FirstOrDefault().Json;
        }


    }
}
