namespace OOP
{
    // Polimorfismo
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
            : base(nome, voltagem) { }

        public CafeteiraEspressa()
            : base(nome: "Padrao", voltagem: 200) { }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            // ETC...
        }

        public override void Testar()
        {
            // teste de cafeteira
        }

        public override void Ligar()
        {
            // Verificar recipiente da agua
        }

        public override void Desligar() 
        {
            // Resfriar aquecedor
        }
    }
}
