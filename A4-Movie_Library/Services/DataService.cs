using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A4_Movie_Library.Dao;

namespace A4_Movie_Library.Services
{
    internal class DataService : IDataServices
    {
        private IDataDao _dao;

        public DataService(IDataDao dao)
        {
            _dao = dao;
        }

        public void Invoke()
        {
            _dao.Read();
        }
    }
}
