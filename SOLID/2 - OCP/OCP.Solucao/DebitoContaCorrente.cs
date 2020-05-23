namespace SOLID.OCP.Solucao
{
    class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debita Conta Corrente
            return FormatarTransacao();
        }
    }
}
