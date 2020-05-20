namespace OOP
{
    // A classe só pode ser herdada e nunca instanciada
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;

        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        // abstract obriga a implementação
        public abstract void Ligar();
        public abstract void Desligar();

        // virtual tem um comportamento padrão, mas pode ser sobrescrito
        public virtual void Testar()
        {
            // teste do equipamento
        }
    }
}
