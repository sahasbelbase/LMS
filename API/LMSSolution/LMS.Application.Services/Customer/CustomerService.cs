using HARS.Application.Model;
using LMS.Application.Service.Customer;
using LMS.Application.Service.DataAccess;
using LMS.LLBL.DatabaseSpecific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        public string GetCustomer(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpCustomerMembershipSelCallAsQuery(Json))?.FirstOrDefault().Json;  
        }


    }
}
