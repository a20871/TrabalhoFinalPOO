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
            

            //Console.WriteLine(a1.CalculaIdade().ToString());
            DateTime date = Convert.ToDateTime("02/09/20");
            try
            {
                Estado e1 = new Estado("g", Situacao.LIGEIRO);
            }
            catch(DataExcepcoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Estado e2 = new Estado("17-11-2021", Situacao.INTERNADO);
            Estado e3 = new Estado("26-11-2021", Situacao.ALTA);
            Estado e4 = new Estado("28-11-2021", Situacao.ALTA);
            Estado e5 = new Estado("09-11-2021", Situacao.LIGEIRO);
            //List<Estado> n = new List<Estado>();
            Utente a1 = new Utente("123456789", "Ana", "09-12-1975", Genero.FEMININO, Distrito.Braga, e2);
            Utente a2 = new Utente("123156789", "Pedro", "09-12-1975", Genero.MASCULINO, Distrito.Braga, e5);
            a1.AddEstado(e3);//adiciona um estado a lista de um utente
            //a2.AddEstado(e1);
            
            Utentes u = new Utentes();
            
            u.AddUTente(a1); 
            u.AddUTente(a2);
            u.MostraListaNomeUtente();
            a1.MostraEstadoUtente();
            a2.MostraEstadoUtente();
            Console.WriteLine(u.MostraNomeUtente("123456789"));
            Console.WriteLine(u.ContaUtentePorEstado(e5));
            Console.WriteLine(a1.TempoInternamento());
            
            //u.RegistaEstadoUtente(estado1, "123456789");

            Console.ReadKey();

        }
    }
}
