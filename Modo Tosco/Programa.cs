using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModoTosco
{
    public static class Programa
    {
        //Aqui é onde o programa inicia
        public static void Main(string[] args)
        {
            var admin = new AdministradorVendas();
            admin.FecharCaixa();
        }
    }
}
