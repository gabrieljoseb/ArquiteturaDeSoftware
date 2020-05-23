namespace SOLID.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // Logica de negocio para debito em conta de investimento
            return debitoConta.FormatarTransacao();
        }
    }
}
