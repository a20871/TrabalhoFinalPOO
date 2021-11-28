/*
*	<copyright file="TrabalhoFinal" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>Jéssica Costa 20872 | Sérgio Martins 20871</author>
*   <date>11/22/2021 14:21:30 AM</date>
*	<description> </description>
**/
using System;

namespace TrabalhoFinal
{
    public enum Situacao { LIGEIRO, INTERNADO, UCI, ALTA, OBITO };

    /// Purpose: Classe Estado que contém o Estado e data de novo estado 
    /// Created by: Jéssica Costa 20872 | Sérgio Martins 20871
    /// Created on: 11/22/2021 10:24:21 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Estado
    {
       
        #region Attributes

        DateTime dataNovoEstado;
        Situacao sit;

        #endregion

        #region Constructors
        /// <summary>
        /// Construtor Estado com situação e data manual. Exception para data
        /// </summary>
        /// <param name="d"></param>
        /// <param name="m"></param>
        public Estado(string d, Situacao m)
        {
            try
            {
                this.DataNovoEstado = Convert.ToDateTime(d);
            }

            catch (FormatException e)
            {
                throw new DataExcepcoes(e.Message);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao inserir data");
            }
            this.Sit = m;
        }

        /// <summary>
        /// Construtor Estado com data automática do dia
        /// </summary>
        /// <param name="m"></param>
        public Estado(Situacao m)
        {
            
        this.DataNovoEstado = DateTime.Today.Date;
            
        this.Sit = m;
        }


        #endregion

        #region Properties

        /// <summary>
        /// Propriedade em que se define a data da alteracao do estado
        /// </summary>
        public DateTime DataNovoEstado
        {
            get { return dataNovoEstado; }
            set { dataNovoEstado = value; }
        }

        /// <summary>
        /// Propriedade que define a nova situacao em que se encontra o utente
        /// </summary>
        public Situacao Sit{
            get { return sit; }
            set { sit = value; }
        }

        #endregion

        #region Others

        public override bool Equals(object obj)
        {
            Estado aux = (Estado)obj;
            if ((aux.DataNovoEstado == this.DataNovoEstado) && (aux.Sit == this.Sit))
                return true;
            return false;
        }

            #endregion

            #region Destructors


            #endregion

        } 
   
}
