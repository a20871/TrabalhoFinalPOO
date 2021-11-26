/*
*	<copyright file="TrabalhoFinal" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>Jéssica Costa 20872</author>
*   <date>11/24/2021 7:28:24 PM</date>
*	<description> </description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose:
/// Created by:Jéssica Costa 20872
/// Created on:11/24/2021 7:28:24 PM
/// </summary>
/// 

namespace TrabalhoFinal
{
    /// <summary>
    /// Purpose:
    /// Created by: Jéssica Costa 20872
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
        public int ContaUtentePorEstado(Estado e)
        {
            List<Utente> a = FiltraEstado(e);
            return a.Count();
        }

        /// <summary>
        /// Cria uma lista com os utentes que estiveram internados
        /// </summary>
        /// <returns></returns>

        public List<Utente> CriaListaTempoInternamento()
        {
            List<Utente> internado = new List<Utente>();
            foreach (Utente u in doentes)
            {
                if (u.TempoInternamento() > 0)
                    internado.Add(u);

            }
            return internado;
        }



        /* public string UtenteMaisTempoInternado()
         {
             List<Utente> internado = CriaListaTempoInternamento();
             int i = 0;
             int j = 0;
             foreach (Utente u in internado)
             {
                 i = u.TempoInternamento();
                 if (i > j)
                 {
                     int aux = j;
                     j = i;
                     i = aux;
                 }
             }*/
        //continuar amanha




    }




    #endregion



        #endregion
    }



