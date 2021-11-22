using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Utente a = new Utente("123456789","Ana", "09-12-1975", Utente.Genero.FEMININO, Utente.Distrito.Braga);
            Utente a1 = new Utente("119234562", "Sérgio Martins", "07-12-81", Utente.Genero.MASCULINO, Utente.Distrito.Porto);
            Covid b = new Covid("10-12-2020", 12, Covid.Estado.LIGEIRO, "23-12-2020", "alta");
            Console.WriteLine(a1.Nome);
            Console.WriteLine(a.GeneroU);
            Console.WriteLine(a.DataNascimento.ToString());
            Console.WriteLine(b.DataDiagnostico.ToString());
            //Console.WriteLine(b.ContaDias(123456789));
          
            Console.WriteLine(a.CalculaIdade().ToString());



            Console.ReadKey();

        }
    }
}
