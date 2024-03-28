using HARS.Application.Model;
using LMS.Application.Service.DataAccess;
using LMS.LLBL.DatabaseSpecific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Services.Membership
{
    public class MembershipService : IMemebershipService
    {
        public string GetMembership(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpMembershipSelCallAsQuery(Json))?.FirstOrDefault()?.Json;
        }

       
    }
}
