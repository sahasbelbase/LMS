using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Services.Common
{
    public interface ICommonService
    {
        public string GetNavigation(string Json);
        public string GetCustomerNavigation(string Json);

        public string GetUserPerson(string Json);

        public string GetUser(string Json);
        public string UserTsk(string Json);
        public string GetUserDashboard(string Json);
        public string GetDashboard(string Json);


        public string UserPersonTsk(string Json);

    }
}
