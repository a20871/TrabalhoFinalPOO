/**
 * @Brief Main Class
 * 
 * 
 * @autor: Jéssica Costa & Sérgio Martins
 * @email: a20871@alunos.ipca.pt; a208721lunos.ipca.pt
 * @data: $time$
 */
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
            
            Utente a1 = new Utente("123456789","Ana", "09-12-1975", Genero.FEMININO, Distrito.Braga, Situacao.ALTA);
            Utente a2 = new Utente("119234562", "Sérgio Martins", "07-12-81", Genero.MASCULINO, Distrito.Porto, Situacao.LIGEIRO);

            a1.AddEstado(Situacao.LIGEIRO, DateTime.Today );
            a1.AddEstado(Situacao.INTERNADO, DateTime.Today);
            a1.AddEstado(Situacao.UCI, DateTime.Today);
            a2.AddEstado(Situacao.OBITO, DateTime.Today);

            

            Utentes covids = new Utentes();

            covids.AddUTente(a1);

            Estado a11 = new Estado(DateTime.Today, Situacao.INTERNADO);

            a1.ConsultaEstado(a1, covids);







            Console.WriteLine(a1.DistritoU);
            Console.WriteLine(a1.GeneroU);
            Console.WriteLine(a1.DataNascimento.ToString());
            
            //Console.WriteLine(b.ContaDias(123456789));
          
            Console.WriteLine(a1.CalculaIdade().ToString());



            Console.ReadKey();

        }
    }
}
