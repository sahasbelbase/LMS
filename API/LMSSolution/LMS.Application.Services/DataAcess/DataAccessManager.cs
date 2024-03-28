using LMS.LLBL.DatabaseSpecific;

namespace LMS.Application.Service.DataAccess
{

    public class DataAccessManager : DataAccessAdapter
    {
        public DataAccessManager() : base() { }

        public DataAccessManager(bool keepConnectionOpen) : base(true) { }


    }
}
