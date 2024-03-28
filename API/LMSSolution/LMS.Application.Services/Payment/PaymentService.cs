using HARS.Application.Model;
using LMS.Application.Service.DataAccess;
using LMS.LLBL.DatabaseSpecific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Services.Payment
{
    public class PaymentService : IPaymentService
    {
        public string? GetCustomerPayment(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpUserPaymentSelCallAsQuery(Json))?.FirstOrDefault()?.Json;
        }

        public string GetPayment(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpPaymentSelCallAsQuery())?.FirstOrDefault()?.Json;
        }

        public string PaymentTsk(string Json)
        {
            using (var adapter = DataAccessHelper.GetAdapter())
            {
                string param = Json;

                ActionProcedures.SpPaymentTsk(ref Json, adapter);
                adapter.CloseConnection();
            }
            return Json;
        }
    }
}
