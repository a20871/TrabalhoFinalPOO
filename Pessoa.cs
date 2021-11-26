/*
*	<copyright file="TrabalhoFinal" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>Jéssica Costa 20872</author>
*   <date>11/26/2021 11:51:01 AM</date>
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
/// Created on:11/26/2021 11:51:01 AM
/// </summary>
/// 

namespace TrabalhoFinal
{
    /// <summary>
    /// Purpose:
    /// Created by: Jéssica Costa 20872
    /// Created on: 11/26/2021 11:51:01 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Atributos

        protected string nome;
        DateTime dataNascimento;
        Genero genero;
        Distrito morada;


        #endregion


        #region Methods

        #region Constructors

        public Pessoa( string nome, string dataNascimento, Genero genero, Distrito morada)
        {

            this.Nome = nome;
            this.DataNascimento = Convert.ToDateTime(dataNascimento);
            this.Genero = genero;
            this.Morada = morada;


        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade para nome. Não permite atributo vazio
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length > 0)
                    nome = value;
            }

        }

        /// <summary>
        /// Data de Nascimento
        /// </summary>
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value.Date; }
        }


        /// <summary>
        /// Género - escolha opção
        /// </summary>
        public Genero Genero
        {
            get { return genero; }
            set
            {
                if ((value == Genero.MASCULINO) || (value == Genero.FEMININO))
                    genero = value;

            }
        }

        /// <summary>
        /// Distrito de morada - escolha opção
        /// </summary>
        public Distrito Morada
        {
            get { return morada; }
            set
            {
                if ((value == Distrito.Aveiro) || (value == Distrito.Beja) || (value == Distrito.Braga) || (value == Distrito.Braganca) || (value == Distrito.CasteloBranco) || (value == Distrito.Coimbra) || (value == Distrito.Evora) || (value == Distrito.Faro) || (value == Distrito.Guarda) || (value == Distrito.Leiria) || (value == Distrito.Lisboa) || (value == Distrito.Portalegre) || (value == Distrito.Porto) || (value == Distrito.Santarem) || (value == Distrito.Setubal) || (value == Distrito.VianaCastelo) || (value == Distrito.VilaReal) || (value == Distrito.Viseu))
                    morada = value;

            }
        }
        #endregion

        #region Overrides

        #endregion

        #region OtherMethods
        /// <summary>
        /// Calcula idade
        /// </summary>
        /// <returns>Idade em Anos</returns>
        public int CalculaIdade()
        {
            int idade = 0;
            idade = DateTime.Today.Year - dataNascimento.Year;
            if (DateTime.Today.DayOfYear < dataNascimento.DayOfYear)
                idade = idade - 1;
            return idade;
        }

        #endregion



        #endregion
    }


}
