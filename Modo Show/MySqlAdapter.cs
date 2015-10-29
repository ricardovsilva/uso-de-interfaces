using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModoShow
{
    public class MySqlAdapter : IDatabase
    {
        private MySql _mySql;

        public MySqlAdapter()
        {
            _mySql = new MySql();
        }

        public void SaveData(string data)
        {
            _mySql.Save(data);
        }

        public int SelectData(string data)
        {
            return _mySql.Select(data);
        }

        public void UpdateData(string oldData, string newData)
        {
            _mySql.Update(oldData, newData);
        }

        public void DeleteData(string data)
        {
            _mySql.Delete(data);
        }
    }
}
