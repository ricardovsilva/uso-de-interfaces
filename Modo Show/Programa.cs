namespace ModoShow
{
    public static class Programa
    {
        //Aqui é onde o programa inicia
        public static void Main(string[] args)
        {
            var sqlServer = new SqlServerAdapter();
            var mySql = new MySqlAdapter();

            var admin = new AdministradorVendas();
            admin.FecharCaixa(sqlServer);
            admin.FecharCaixa(mySql);
        }
    }
}
