/**
 * @Brief Classe de Exceptions personalizadas
 * 
 * 
 * @autor: Jéssica Costa & Sérgio Martins
 * @email: a20871@alunos.ipca.pt; a20872@alunos.ipca.pt
 * @data: $time$
 */
using System;


namespace TrabalhoFinal
{
    /// <summary>
    /// @brief Exceptions para inserção incorreta de datas.
    /// @author Sérgio Martins
    /// <p>a20871@alunos.ipca.pt</p>
    /// @date 11/25/2021 10:12:57 AM
    /// </summary>
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

