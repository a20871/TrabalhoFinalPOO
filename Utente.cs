/*
*	<copyright file="TrabalhoFinal" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>Jéssica Costa 20872 | Sérgio Martins 20871</author>
*   <date>11/22/2021 14:21:23 AM</date>
*	<description> </description>
**/
using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoFinal
{
    #region ENUMs
    /// <summary>
    /// Enum identificador de Género
    /// </summary>
    public enum Genero { MASCULINO, FEMININO };

    /// <summary>
    /// Enum identificador do Distrito
    /// </summary>
    public enum Distrito { Aveiro, Beja, Braga, Braganca, CasteloBranco, Coimbra, Evora, Faro, Guarda, Leiria, Lisboa, Portalegre, Porto, Santarem, Setubal, VianaCastelo, VilaReal, Viseu };
    #endregion
  
    /// Purpose: Classe Utente que congrega as funcionalidades para Utentes que são diagnosticados com COVID, herda de Pessoa 
    /// Created by: Jéssica Costa 20872 | Sérgio Martins 20871
    /// Created on: 11/26/2021 11:51:01 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Utente : Pessoa
    {
        #region Attributes

        protected string numeroUtente;
        List<Estado> n;
        static int totUtententes = 0;

        #endregion

        #region Constructors

        /// <summary>
        /// Construtor Utente com determinado estado (Estado e data) passados manualmente
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="nome"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="generoU"></param>
        /// <param name="distritoU"></param>
        public Utente(string numero, Estado s, string nome, string dataNascimento, Genero genero, Distrito morada) : base(nome, dataNascimento, genero, morada)
        {
            this.NumUtente = numero;
            this.AddEstado(s);//adiciona um estado inicial
            totUtententes++;

        }

        /// <summary>
        /// Construtor Utente base. Utente diagnosticado com COVID em determinado estado
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="s"></param>
        /// <param name="nome"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="genero"></param>
        /// <param name="morada"></param>
        public Utente(string numero, Situacao s, string nome, string dataNascimento, Genero genero, Distrito morada) : base(nome, dataNascimento, genero, morada)
        {
            this.NumUtente = numero;
            Estado e = new Estado(s);//Adiciona Estado com a data do dia
            this.AddEstado(e);

            totUtententes++;

        }
        #endregion

        #region Properties
        /// <summary>
        /// Propriedade para número de Utente, verifica se tem 9 dígitos
        /// </summary>
        public string NumUtente
        {
            get { return numeroUtente; }
            set
            {

                //Verifica se tem 9 caracteres e todos são algarismos
                {
                    if (value.Length == 9 || numeroUtente.All(char.IsDigit))
                    {
                        numeroUtente = value;
                    }
                    else numeroUtente= "000000000"; //Utente não identificado
                }
            }
        }

        #endregion

        #region GereEStado

        /// <summary>
        /// Adiciona Estado a lista ou cria lista caso ainda não exista
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public void AddEstado(Estado e)
        {
            if (n == null) n = new List<Estado>();
            n.Add(e);
            //return true;
        }

        /// <summary>
        /// Mostra o historico de estados de um doente
        /// </summary>
        public void MostraEstadoUtente()
        {
            foreach (Estado e in n)
                Console.WriteLine($"{e.DataNovoEstado}\t{e.Sit}");
        }

        /// <summary>
        /// Devolve true se um utente tiver estado numa determinada situacao passada por parametro
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool EsteveNumaSituacao(Situacao s)
        {
            foreach (Estado a in n)
            {
                if (a.Sit == s)
                    return true;
            }
            return false;

        }

        /// <summary>
        /// Verifica se um determinado doente esta internado ou em uci numa determinada data
        /// </summary>
        /// <param name="d"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool VerificaSeUtenteEstaInternado(string d, Situacao s)
        {
            DateTime data = Convert.ToDateTime(d).Date;
            foreach (Estado e in n)
            {
                if ((e.Sit == s) && (e.DataNovoEstado >= data))
                    continue;
                if ((e.Sit == Situacao.ALTA) && (e.DataNovoEstado >= data))
                    return true;
            }
            return false;
        }


        /// <summary>
        /// Mostra se um utente esteve ou nao num determinado estado numa determinada data
        /// </summary>
        /// <param name="data"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool FiltraUtentePorEstado(Estado e)
        {

            foreach (Estado a in n)
            {
                if (this.n.Contains(e))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Calcula tempo na situação s
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int TempoInternamento(Situacao s)
        {
            DateTime d1 = Convert.ToDateTime("01-01-20").Date;
            DateTime d2 = Convert.ToDateTime("02-10-30").Date;
            foreach (Estado e in n)
            {
                if (e.Sit == s)
                    d1 = e.DataNovoEstado;
                if (e.Sit == Situacao.ALTA)
                    d2 = e.DataNovoEstado;
            }
            if (DateTime.Compare(d1, d2) < 0)
                return (d2 - d1).Days;
            else
                return 0;
        }      

        #endregion

        #region Others
        #region OPERATORS

        /// <summary>
        /// Compara 2 Utentes pelo seu número de Utente
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Utente aux = (Utente)obj;
            if (aux.NumUtente == this.NumUtente)

                return true;
            else return false;
        }

        #endregion

        #endregion

        #region Destructors


        #endregion
    }
}