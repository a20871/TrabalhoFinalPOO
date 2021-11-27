/*
*	<copyright file="TrabalhoFinal" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>Jéssica Costa 20872</author>
*   <date>11/27/2021 5:37:45 PM</date>
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
/// Created on:11/27/2021 5:37:45 PM
/// </summary>
/// 

namespace TrabalhoFinal
{
    /// <summary>
    /// Purpose:
    /// Created by: Jéssica Costa 20872
    /// Created on: 11/27/2021 5:37:45 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class UtenteAbs : Utente
    {
        #region Atributos
        static List<Utente> doentes;
        #endregion


        #region Methods

        #region Constructors

      
        public  UtenteAbs(string numero, string nome, string dataNascimento, Genero genero, Distrito morada) :base( numero, nome, dataNascimento, genero, morada)
        { 
        
        
        
        }


        #endregion

        #region Properties

        #endregion

        #region Overrides

        #endregion

        #region OtherMethods

        /// <summary>
        /// Cria uma lista com os utentes que estiveram internados
        /// </summary>
        /// <returns></returns>

        public abstract List<Utente> CriaListaUtentesInternados();



        /// <summary>
        /// Ordena os utentes internados pelo tempo de internamento por ordem crescente
        /// </summary>
        /// <returns> listaOrdenadaTempoInternamento</returns>

        public abstract List<Utente> OrdenaTempoInternamento();


        /// <summary>
        /// Mostra uma lista de utentes ordenada por ordem crescente de tempo de internamento
        /// </summary>
        public abstract void MostraListaOrdenadaTempoInternamento();


        /// <summary>
        /// //Determina qual foi o menor tempo de internamento 
        /// //Utilizando-se este metodo pode-se descobrir quais os utentes que tiveram o menor tempo de internamento
        /// </summary>
        /// <returns></returns>
        public abstract int MenorTempoInternado();


        /// <summary>
        /// Ordena os utentes internados pelo tempo de internamento por ordem decrescente
        /// </summary>
        /// <returns></returns>
        public abstract List<Utente> OrdenaTempoInternamentoDecrescente();



        /// <summary>
        /// //Determina qual foi o maior tempo de internamento
        /// //Utilizando-se este metodo pode-se descobrir quais os utentes que tiveram o maior tempo de internamento
        /// </summary>
        /// <returns></returns>
        public abstract int MaiorTempoInternado();

        /// <summary>
        /// Cria uma lista com o utente ou utentes que tiveram o maior numero de dias internados
        /// </summary>
        /// <returns></returns>
        public abstract List<Utente> UtenteMaisTempoInternado();



        public abstract List<Utente> UtenteMenosTempoInternado();
        
          

        /// <summary>
        /// Calcula a media dos tempos de internamento
        /// </summary>
        /// <returns></returns>
        public abstract double MediaTempoInternamento(); 



        #endregion



        #endregion
    }


}
