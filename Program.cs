/*
*	<copyright file="TrabalhoFinal" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>Jéssica Costa 20872 | Sérgio Martins 20871</author>
*   <date>11/22/2021 11:01:02 AM</date>
*	<description> </description>
**/
using System;

namespace TrabalhoFinal
{
    /// <summary>
    /// Execução de código no Main
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)

        {
            //Teste Exception            
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

            //Instanciados Utentes
            Utente a1 = new Utente("123456789", Situacao.LIGEIRO, "Ana", "19-09-1975", Genero.FEMININO, Distrito.Braga);
            Utente a2 = new Utente("765342145", Situacao.INTERNADO, "Bruno", "09-12-1977", Genero.MASCULINO, Distrito.Porto);
            Utente a3 = new Utente("123456788", Situacao.UCI, "Carlos", "09-12-1978", Genero.MASCULINO, Distrito.Braga);
            Utente a4 = new Utente("234567321", Situacao.INTERNADO, "Daniel", "09-12-1981", Genero.MASCULINO, Distrito.VianaCastelo);
            Utente a5 = new Utente("123000001", Situacao.LIGEIRO, "Eva", "09-12-1965", Genero.FEMININO, Distrito.Braga);

            //Lista de Utente
            Utentes u = new Utentes();

            u.AddUTente(a1);
            u.AddUTente(a2);
            u.AddUTente(a3);
            u.AddUTente(a4);
            u.AddUTente(a5);

            //Estados criados com data manipulada para teste de resultados de código
            Estado e1 = new Estado("29-11-2021", Situacao.INTERNADO);
            Estado e2 = new Estado("06-12-2021", Situacao.ALTA);
            Estado e3 = new Estado("21-12-2021", Situacao.ALTA);
            Estado e4 = new Estado("03-12-2021", Situacao.LIGEIRO);
            Estado e5 = new Estado("05-12-2021", Situacao.UCI);
            Estado e6 = new Estado("17-12-2021", Situacao.ALTA);
            Estado e7 = new Estado("28-12-2021", Situacao.OBITO);
            Estado e8 = new Estado("08-12-2021", Situacao.OBITO);
            Estado e10 = new Estado("28-11-2021", Situacao.LIGEIRO);

            //Instanciados Utentes com data de admissão manipulada manualmente
            Utente b1 = new Utente("123156700", e2, "Pedro", "09-12-1958", Genero.MASCULINO, Distrito.Braga);
            Utente b2 = new Utente("123156701", e2, "Quim", "02-12-1995", Genero.MASCULINO, Distrito.Braga);
            Utente b3 = new Utente("123156789", e3, "Quim", "02-12-2005", Genero.MASCULINO, Distrito.Braga);

            u.AddUTente(b1);
            u.AddUTente(b2);
            u.AddUTente(b3);

            //adiciona um Estado a lista de um utente
            a1.AddEstado(e1);
            a1.AddEstado(e5);
            //a1.AddEstado(e6);
            a1.AddEstado(e7);
            a2.AddEstado(e6);
            a3.AddEstado(e8);
            a4.AddEstado(e3);
            a5.AddEstado(e3);
            

            //Instanciados Pessoa
            Pessoa p1 = new Pessoa("Ana", "19-09-1975", Genero.FEMININO, Distrito.Braga);
            Pessoa p2 = new Pessoa("Pedro", "09-12-1958", Genero.MASCULINO, Distrito.Braga);

            //Teste de resultados
            Console.WriteLine("\nLista de utentes admitidos (tiveram COVID):");
            u.MostraListaNomeUtente();

            Console.WriteLine($"\nEstado do utente {a1.Nome}:");
            a1.MostraEstadoUtente();

            Console.WriteLine($"\nEstado do utente {a2.Nome}:");
            a2.MostraEstadoUtente();

            Console.WriteLine($"\nEstado do utente {a3.Nome}:");
            a3.MostraEstadoUtente();

            Console.WriteLine($"\nEstado do utente {a4.Nome}:");
            a4.MostraEstadoUtente();

            Console.WriteLine($"\nEstado do utente {a5.Nome}:");
            a5.MostraEstadoUtente();
            
            Console.WriteLine("\nNumero de dias internado/UCI:"+ a1.ContaNumeroDiasInternado(Situacao.INTERNADO));
            

            Console.WriteLine("\nNome do utente 123456789:\n"+ u.MostraNomeUtente("123456789"));
            

            Console.WriteLine("\nNúmero de óbitos:"+u.ContaUtententeNumaSituacao(Situacao.OBITO).ToString());


            Console.WriteLine($"\nTempo de internamento de {a1.Nome}: {a1.ContaNumeroDiasInternado(Situacao.INTERNADO)} dias.");

            //Mostra idade de um determinado utente (Override ToString()).
            Console.WriteLine(a1.ToString());

            u.MostraListaOrdenadaTempoInternamento(Situacao.INTERNADO);

            Console.WriteLine($"\nMenor numero de dias de internamento: {u.MenorTempoInternado(Situacao.INTERNADO)}");

            Console.WriteLine("\nMedia Tempo Internamento: " + u.MediaTempoInternamento(Situacao.INTERNADO).ToString());

            u.MostraUtenteMaisTempoInternamento(Situacao.INTERNADO);

            Console.WriteLine($"\nNumero de utentes internados:{u.ContaUtentesInternadosNumaData("10-12-2021", Situacao.INTERNADO)}");

            Console.WriteLine($"\nNumero de utentes com sintomas ligeiros em 28-11-2021: {u.ContaUtentePorEstado(Situacao.LIGEIRO, "28-11-2021")}");

            Console.WriteLine($"\nContem estado: {a1.FiltraUtentePorEstado("28-11-2021",Situacao.LIGEIRO)}");

            Console.WriteLine("\nNúmero de óbitos: "+ u.ContaUtententeNumaSituacao(Situacao.OBITO).ToString());

            Console.WriteLine("\nNúmero de doentes com idades entre 44 e 46: "+u.DivideIdades(44,46));

            Console.WriteLine($"\nNúmero de doentes do género {Genero.MASCULINO}= "+ u.ContaGenero(Genero.MASCULINO));

            //Verifica se 2 utentes são o mesmo utente (mesmo nº de utente)
            Console.WriteLine(a1.Equals(a3));

            Console.ReadKey();

        }
    }
}
