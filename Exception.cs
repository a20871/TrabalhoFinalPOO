/*
*	<copyright file="TrabalhoFinal" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>Jéssica Costa 20872 | Sérgio Martins 20871</author>
*   <date>11/22/2021 14:22:23 AM</date>
*	<description> </description>
**/
using System;


namespace TrabalhoFinal
{
    /// Purpose: Classe Exception Data 
    /// Created by: Jéssica Costa 20872 | Sérgio Martins 20871
    /// Created on: 11/26/2021 11:51:01 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class DataExcepcoes : ApplicationException
    {
        public DataExcepcoes() : base("Erro de data")
        {

        }

        public DataExcepcoes(string s) : base("Data com formato incorreto. Insira dd-mm-aaa.")
        {

        }

        public DataExcepcoes(string s, Exception e) : base("Formato de data inválido")
        {
            throw new DataExcepcoes(e.Message + " - " + s);
        }

    }
}

