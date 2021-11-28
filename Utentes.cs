/*
*	<copyright file="TrabalhoFinal" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>Jéssica Costa 20872 | Sérgio Martins 20871</author>
*   <date>11/23/2021 18:31:24 AM</date>
*	<description> </description>
**/
using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Purpose:
/// Created by:Jéssica Costa 20872 | Sérgio Martins 20871
/// Created on:11/24/2021 7:28:24 PM
/// </summary>
namespace TrabalhoFinal
{
    /// <summary>
    /// Purpose: Classe Utentes que contém lista de Utente
    /// Created by: Jéssica Costa 20872 | Sérgio Martins 20871
    /// Created on: 11/24/2021 7:28:24 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class Utentes
    {
        #region Atributos
        List<Utente> doentes;
        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Construtor da lista Utentes com Utente
        /// </summary>
        public Utentes()
        { this.doentes = new List<Utente>(); }
        #endregion

        #region Properties

        #endregion

        #region Overrides

        #endregion

        #region OtherMethods

        /// <summary>
        /// Adiciona um utente a lista de utentes caso este nao esteja na lista
        /// </summary>
        /// <param name="u"></param>
        /// <returns>true caso o utente seja inserido</returns>
        public bool AddUTente(Utente u)
        {
            if (!doentes.Contains(u))
                doentes.Add(u);
            return true;
        }

        /// <summary>
        /// Mostra uma lista com o numero e respetivo nome de utente
        /// </summary>
        public void MostraListaNomeUtente()
        {
            foreach (Utente u in doentes)
                Console.WriteLine($"{ u.NumUtente}\t{u.Nome}");
        }

        /// <summary>
        /// Mostra o nome de um determinado utente
        /// </summary>
        /// <param name="num"></param>
        /// <returns> nome do utente</returns>
        public string MostraNomeUtente(string num)
        {
            string s = "";
            foreach (Utente u in doentes)
            {
                if (u.NumUtente == num)
                    return u.Nome;
            }
            return s;
        }

        /// <summary>
        /// Cria uma lista com os utentes que tiveram um determinado novo estado
        /// </summary>
        /// <param name="data"></param>
        /// <param name="e"></param>       
        public List<Utente> FiltraEstado(Estado e)
        {
            List<Utente> alta = new List<Utente>();
            foreach (Utente u in doentes)
            {
                if (u.FiltraUtentePorEstado(e) == true)
                    alta.Add(u);
            }
            return alta;
        }

        /// <summary>
        /// Conta o numero de utentes a que lhe foi atribuido um determinado novo estado
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public int ContaUtentePorEstado(Situacao s, string data)
        {
            Estado e = new Estado(data, s);
            List<Utente> a = FiltraEstado(e);
            return a.Count();
        }

        /// <summary>
        /// Cria uma lista com todos os utentes que estiveram internados desde o inicio da pandemia
        /// </summary>
        /// <returns>Lista de Internados</returns>
        public List<Utente> CriaListaTodosUtentesInternados(Situacao s)
        {
            List<Utente> internado = new List<Utente>();
            foreach (Utente u in doentes)
            {
                if (u.TempoInternamento(s) > 0)
                    internado.Add(u);

            }
            return internado;
        }

        /// <summary>
        /// Ordena os utentes internados pelo tempo de internamento por ordem crescente
        /// </summary>
        /// <returns> listaOrdenadaTempoInternamento</returns>
        public List<Utente> OrdenaTempoInternamOrdemCrescente(Situacao s)
        {
            List<Utente> internado = CriaListaTodosUtentesInternados(s);
            internado.OrderBy(u => u.TempoInternamento(s));
            return internado;
        }

        /// <summary>
        /// Mostra uma lista de utentes ordenada por ordem crescente de tempo de internamento
        /// </summary>
        public void MostraListaOrdenadaTempoInternamento(Situacao s)
        {
            List<Utente> internado = OrdenaTempoInternamOrdemCrescente(s);
            foreach (Utente u in internado)
            {
                Console.WriteLine($"{u.NumUtente}\t{u.Nome}\t{u.TempoInternamento(s)}");
            }
        }

        /// <summary>
        /// Determina qual foi o menor tempo de internamento 
        /// Utilizando este metodo pode-se descobrir quais os utentes que tiveram o menor tempo de internamento
        /// </summary>
        /// <returns></returns>
        public int MenorTempoInternado(Situacao s)
        {
            List<Utente> internadoOrdenado = OrdenaTempoInternamOrdemCrescente(s);
            Utente u = internadoOrdenado.First();
            return u.TempoInternamento(s);
        }


        /// <summary>
        /// Ordena os utentes internados pelo tempo de internamento por ordem decrescente
        /// </summary>
        /// <returns></returns>
        public List<Utente> OrdenaTempoInternamentoDecrescente(Situacao s)
        {
            List<Utente> internado = CriaListaTodosUtentesInternados(s);
            internado.OrderByDescending(u => u.TempoInternamento(s));
            return internado;
        }

        /// <summary>
        /// Determina qual foi o maior tempo de internamento
        /// Utilizando-se este metodo pode-se descobrir quais os utentes que tiveram o maior tempo de internamento
        /// </summary>
        /// <returns>Utente com menor tempo de internamento</returns>
        public int MaiorTempoInternado(Situacao s)
        {
            List<Utente> internadoOrdenado = OrdenaTempoInternamentoDecrescente(s);
            Utente u = internadoOrdenado.First();
            return u.TempoInternamento(s);
        }

        /// <summary>
        /// Cria uma lista com o utente ou utentes que tiveram o maior numero de dias internados
        /// </summary>
        /// <returns></returns>
        public List<Utente> UtenteMaisTempoInternado(Situacao s)
        {
            List<Utente> internadoMaisTempo = new List<Utente>();
            List<Utente> internado = CriaListaTodosUtentesInternados(s);
            foreach (Utente u in internado)
            {
                if (MaiorTempoInternado(s) == u.TempoInternamento(s))
                {
                    internadoMaisTempo.Add(u);
                }
            }
            return internadoMaisTempo;
        }

        /// <summary>
        /// Cria lista com o utente ou utentes menos tempo internados
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public List<Utente> UtenteMenosTempoInternado(Situacao s)
        {
            List<Utente> internadoMenosTempo = new List<Utente>();
            List<Utente> internado = CriaListaTodosUtentesInternados(s);
            foreach (Utente u in internado)
            {
                if (MenorTempoInternado(s) == u.TempoInternamento(s))
                {
                    internadoMenosTempo.Add(u);
                }
            }
            return internadoMenosTempo;
        }

        /// <summary>
        /// Calcula a media dos tempos de internamento
        /// </summary>
        /// <returns></returns>
        public double MediaTempoInternamento(Situacao s)
        {
            List<Utente> internado = CriaListaTodosUtentesInternados(s);
            double soma = 0.0;
            foreach (Utente u in doentes)
            {
                soma = +u.TempoInternamento(s);
            }
            return soma / internado.Count();
        }

        /// <summary>
        /// Cria uma lista de utentes que estao em internamento ou UCI numa determinada data
        /// </summary>
        /// <param name="d"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public List<Utente> CriaListaUtentesInternadosNumaData(string d, Situacao s)
        {
            List<Utente> a = new List<Utente>();
            foreach (Utente u in doentes)
            {
                if (u.VerificaSeUtenteEstaInternado(d, s) == true)
                    a.Add(u);
            }
            return a;
        }

        /// <summary>
        /// Conta o numero de utentes que estao em internamento numa determinada data
        /// </summary>
        /// <param name="d"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public int ContaUtentesInternadosNumaData(string d, Situacao s)
        {
            List<Utente> a = CriaListaUtentesInternadosNumaData(d, s);
            return a.Count();
        }

        /// <summary>
        /// Mosta o numero e respetivo nome dos utentes que estao internados ou em UCI numa dada data
        /// </summary>
        /// <param name="d"></param>
        /// <param name="s"></param>
        public void MostraUtenteInternado(string d, Situacao s)
        {
            List<Utente> a = CriaListaUtentesInternadosNumaData(d, s);
            foreach (Utente u in a)
                Console.WriteLine($"{u.NumUtente}\t{u.Nome}");
        }

        /// <summary>
        /// Devolve q número de utentes que esteve numa determinada situação
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int ContaUtententeNumaSituacao(Situacao s)
        {
            List<Utente> a = new List<Utente>();
            foreach (Utente u in doentes)
            {
                if (u.EsteveNumaSituacao(s) == true)
                    a.Add(u);
               
            }
            return a.Count();
        }

        /// <summary>
        /// Determina o número de infetados num intervalo de idades específico
        /// </summary>
        /// <param name="menor"></param>
        /// <param name="maior"></param>
        /// <returns>Numero de infetados no intervalo de idades especificados</returns>
        public int DivideIdades(int menor, int maior)
        {
            List<Utente> a = new List<Utente>();
            foreach (Utente n in doentes)
            {
                int i;
                i=n.CalculaIdade();
                if ((i >= menor) && (i <= maior))
                {
                    a.Add(n);
                }
        
            }
            return a.Count();
        }

        /// <summary>
        /// Contabiliza o número de infetados por género especificado
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public int ContaGenero(Genero g)
        {
            List<Utente> a = new List<Utente>();
            foreach (Utente n in doentes)
            {
              
                if (n.Genero==g)
                {
                    a.Add(n);
                }

            }
            return a.Count();
        }

        #endregion

    }

    #endregion
}
