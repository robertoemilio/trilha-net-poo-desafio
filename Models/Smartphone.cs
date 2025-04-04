namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        //IMPLEMENTADO!!! - Roberto - 25-03-2025
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;

        public Smartphone(string numero,  string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            //IMPLEMENTADO!!! - Roberto - 25-03-2025
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}