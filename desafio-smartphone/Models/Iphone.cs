namespace DesafioPOO.Models
{
    // FEITO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        // AJUSTADO: construtores 
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        // FEITO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone...");
        }
    }
}