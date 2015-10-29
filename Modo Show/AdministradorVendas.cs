namespace ModoShow
{
    public class AdministradorVendas
    {
        public AdministradorVendas()
        {
            
        }

        public void FecharCaixa(IDatabase database)
        {
            var impostos = 200;
            var vendas = database.SelectData("Dinheiro em caixa");
            var vendasDeOntem = database.SelectData("Dinheiro em caixa de ontem");

            var totalDeVendas = vendas - vendasDeOntem;
            totalDeVendas = totalDeVendas - impostos;

            database.UpdateData("vendas líquidas", totalDeVendas.ToString());
            database.DeleteData("venda bruta");
        }
    }
}
