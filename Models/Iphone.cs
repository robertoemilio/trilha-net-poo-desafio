namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //IMPLEMENTADO!!! - Roberto - 25-03-2025
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //IMPLEMENTADO!!! - Roberto - 25-03-2025
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalado o aplicativo "+nomeApp+" no Nokia");
        }
    }
}