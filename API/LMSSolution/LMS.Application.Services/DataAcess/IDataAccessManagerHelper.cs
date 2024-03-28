using LMS.Application.Service.DataAccess;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Services.DataAcess
{
    public interface IDataAccessManagerHelper
    {
        

    List<T> FetchDerivedModel<T>(IRetrievalQuery qry);
        DataAccessManager GetAdapter();
    }
}

