using HARS.Application.Model;
using LMS.Application.Service.DataAccess;
using LMS.Application.Services.DataAcess;
using LMS.LLBL.DatabaseSpecific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Services.Common
{
    public class CommonService : ICommonService
    {
        public string? GetCustomerNavigation(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpCustomerNavigationSelCallAsQuery(Json))?.FirstOrDefault()?.Json;
        }

        public string? GetNavigation(string json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpNavigationSelCallAsQuery(json))?.FirstOrDefault()?.Json;
        }
        public string? GetUser(string Json)
        {
            string? result = DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpUserSelCallAsQuery(Json))?.FirstOrDefault()?.Json;
            return result ?? string.Empty;
        }

        public string? GetUserPerson(string Json)
        {
            string? result = DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpUserPersonSelCallAsQuery(Json))?.FirstOrDefault()?.Json;
            return result ?? string.Empty;
        }

        public string? UserPersonTsk(string Json)
        {
            using (var adapter = DataAccessHelper.GetAdapter())
            {
                string param = Json;

                ActionProcedures.SpUserPersonTsk(ref Json, adapter);
                adapter.CloseConnection();
            }
            return Json;
        }

        public string UserTsk(string Json)
        {
            using (var adapter = DataAccessHelper.GetAdapter())
            {
                string param = Json;

                ActionProcedures.SpUserTsk(ref Json, adapter);
                adapter.CloseConnection();
            }
            return Json;
        }
        public string GetUserDashboard(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpUserDashboardCallAsQuery(Json))?.FirstOrDefault().Json;
        }

        public string? GetDashboard(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpDashboardCallAsQuery(Json))?.FirstOrDefault().Json;
        }
    }
}
