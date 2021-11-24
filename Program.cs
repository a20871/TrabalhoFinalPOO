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
            
           
            //Utente a2 = new Utente("119234562", "Sérgio Martins", "07-12-81", Genero.MASCULINO, Distrito.Porto, Situacao.LIGEIRO);

            //a1.AddEstado(Situacao.LIGEIRO, DateTime.Today );
            Utentes hospital = new Utentes();

            //hospital.AddUTente(a1);





            //Console.WriteLine(a1.Nome);
            //Console.WriteLine(a1.GeneroU);
            //Console.WriteLine(a1.DataNascimento.ToString());

            //Console.WriteLine(b.ContaDias(123456789));

            //Console.WriteLine(a1.CalculaIdade().ToString());
            DateTime date = Convert.ToDateTime("02/09/20");
            Estado estado1 = new Estado(date, Situacao.LIGEIRO);
            Estado estado2 = new Estado(date, Situacao.ALTA);
            
            Utente a1 = new Utente("123456789", "Ana", "09-12-1975", Genero.FEMININO, Distrito.Braga, estado2);
            Utente a2 = new Utente("123156789", "Pedro", "09-12-1975", Genero.MASCULINO, Distrito.Braga, estado1);
            a1.AddEstado(estado1);//adiciona um estado a lista de um utente
            a2.AddEstado(estado2);
            Utentes u = new Utentes();

            u.AddUTente(a1); 
            u.AddUTente(a2);
            u.MostraListaNomeUtente();
            a1.MostraEstadoUtente();
            a2.MostraEstadoUtente();
            Console.WriteLine(u.MostraNomeUtente("123456789"));
            //u.RegistaEstadoUtente(estado1, "123456789");

            Console.ReadKey();

        }
    }
}
