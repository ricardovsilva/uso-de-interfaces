using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModoShow
{
    public class SqlServerAdapter : IDatabase
    {
        private SqlServer _sqlServer;

        public SqlServerAdapter()
        {
            _sqlServer = new SqlServer();
        }


        public void SaveData(string data)
        {
            _sqlServer.Salvar(data);
        }

        public int SelectData(string data)
        {
            return _sqlServer.Selecionar(data);
        }

        public void UpdateData(string oldData, string newData)
        {
            _sqlServer.Atualizar(oldData, newData);
        }

        public void DeleteData(string data)
        {
            _sqlServer.Deletar(data);
        }
    }
}
