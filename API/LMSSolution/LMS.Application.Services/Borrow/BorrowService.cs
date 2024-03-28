using HARS.Application.Model;
using LMS.Application.Service.DataAccess;
using LMS.LLBL.DatabaseSpecific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Services.Borrow
{
    public class BorrowService : IBorrowService
    {
        public string BookReturnTsk(string Json)
        {
            using (var adpater = DataAccessHelper.GetAdapter())
            {
                string param = Json;
                ActionProcedures.SpBorrowBookReturnTsk(ref Json, adpater);
                adpater.CloseConnection();
            }
            return Json;
        }

        public string BorrowTsk(string Json)
        {
            throw new NotImplementedException();
        }

        public string GetBorrow(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpBorrowSelCallAsQuery(Json))?.FirstOrDefault().Json;
        }
    }
}
