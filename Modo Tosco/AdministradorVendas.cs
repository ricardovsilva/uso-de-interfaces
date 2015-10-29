namespace ModoTosco
{
    public class AdministradorVendas
    {
        public AdministradorVendas()
        {
            
        }

        public void FecharCaixa()
        {
            var impostos = 200;
            var database = new SqlServer();
            var vendas = database.Selecionar("Dinheiro em caixa");
            var vendasDeOntem = database.Selecionar("Dinheiro em caixa de ontem");

            var totalDeVendas = vendas - vendasDeOntem;
            totalDeVendas = totalDeVendas - impostos;

            database.Atualizar("vendas líquidas", totalDeVendas.ToString());
            database.Deletar("venda bruta");
        }
    }
}
