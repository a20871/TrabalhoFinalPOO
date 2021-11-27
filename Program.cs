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
            DateTime date = Convert.ToDateTime("02/09/20");
            
            try
            {
                Estado e9 = new Estado("g", Situacao.LIGEIRO);
            }
            catch (DataExcepcoes e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Utente a1 = new Utente("123456789", Situacao.LIGEIRO, "Ana", "09-12-1975", Genero.FEMININO, Distrito.Braga);
            Utente a2 = new Utente("765342145", Situacao.INTERNADO, "Bruno", "09-12-1977", Genero.MASCULINO, Distrito.Porto);
            Utente a3 = new Utente("123456788", Situacao.UCI, "Carlos", "09-12-1978", Genero.FEMININO, Distrito.Braga);
            Utente a4 = new Utente("234567321", Situacao.OBITO, "Daniel", "09-12-1981", Genero.FEMININO, Distrito.VianaCastelo);
            Utente a5 = new Utente("123000001", Situacao.OBITO, "Eva", "09-12-1965", Genero.FEMININO, Distrito.Braga);

            Utentes u = new Utentes();

            u.AddUTente(a1);
            u.AddUTente(a2);
            u.AddUTente(a3);
            u.AddUTente(a4);
            u.AddUTente(a5);

            Estado e1 = new Estado("29-11-2021", Situacao.INTERNADO);
            Estado e2 = new Estado("30-11-2021", Situacao.ALTA);
            Estado e3 = new Estado("01-12-2021", Situacao.ALTA);
            Estado e4 = new Estado("03-12-2021", Situacao.LIGEIRO);
            Estado e5 = new Estado("05-12-2021", Situacao.UCI);
            Estado e6 = new Estado("07-12-2021", Situacao.ALTA);
            Estado e7 = new Estado("08-12-2021", Situacao.OBITO);


            a1.AddEstado(e1);//adiciona um estado a lista de um utente
            a1.AddEstado(e5);
            a1.AddEstado(e6);
            a1.AddEstado(e7);
            a2.AddEstado(e4);


            Pessoa p1 = new Pessoa("Ana", "09-12-1975", Genero.FEMININO, Distrito.Braga);
            Pessoa p2 = new Pessoa("Pedro", "09-12-1975", Genero.MASCULINO, Distrito.Braga);

            Utente b1 = new Utente("123156789", e2, "Pedro", "09-12-1975", Genero.MASCULINO, Distrito.Braga);
            Utente b2 = new Utente("123156789", e2, "Quim", "02-12-1975", Genero.MASCULINO, Distrito.Braga);
            Utente b3 = new Utente("123156789", e3, "Quim", "02-12-1975", Genero.MASCULINO, Distrito.Braga);

            u.AddUTente(b1);
            u.AddUTente(b2);
            u.AddUTente(b3);





            Console.WriteLine("\nLista de utentes admitidos (tiveram COVID):");
            u.MostraListaNomeUtente();

            Console.WriteLine($"\nEstado do utente {a1.Nome}:");
            a1.MostraEstadoUtente();

            Console.WriteLine($"\nEstado do utente {a2.Nome}:");
            a2.MostraEstadoUtente();

            Console.WriteLine("\nNome do utente 123456789:\n"+ u.MostraNomeUtente("123456789"));
            

            Console.WriteLine("\nNúmero de óbitos:"+u.ContaUtententeNumaSituacao(Situacao.OBITO).ToString());


            Console.WriteLine($"\nTempo de internamento de {a1.Nome}: {a1.TempoInternamento(Situacao.INTERNADO)} dias.");

            //Mostra idade de um determinado utente (Override ToString()).
            Console.WriteLine(a1.ToString());
            u.MostraListaOrdenadaTempoInternamento(Situacao.INTERNADO);
            //u.RegistaEstadoUtente(estado1, "123456789");

            //Verifica se 2 utentes são o mesmo utente (mesmo nº de utente)
            Console.WriteLine(a2.Equals(a3));

            Console.ReadKey();

        }
    }
}
