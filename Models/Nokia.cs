using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeapp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeapp} em seu Smartphone Nokia");
        }

    }
}