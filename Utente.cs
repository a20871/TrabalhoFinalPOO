/**
 * @Brief Class Utente
 * 
 * 
 * @autor: Jéssica Costa & Sérgio Martins
 * @email: a20871@alunos.ipca.pt; a20872@alunos.ipca.pt
 * @data: $time$
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    /// <summary>
    /// @brief 
    /// @author Sérgio Martins, Jéssica Costa
    /// <p>a20871@alunos.ipca.pt</p>a20872@alunos.ipca.pt
    /// @date 11/16/2021 4:50:51 PM
    /// </summary>
    public class Utente:Pessoa
    {

        #region Attributes

        protected string numeroUtente;
        public List<Estado> n;
        public static int totUtententes = 0;



        #endregion

        #region Constructors

        /// <summary>
        /// Construtor Utente base
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="nome"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="generoU"></param>
        /// <param name="distritoU"></param>
        public Utente(string numero, Estado s, string nome, string dataNascimento, Genero genero, Distrito morada):base(nome, dataNascimento, genero, morada)
        {
            this.NumUtente = numero;
            this.AddEstado(s);//adiciona um estado inicial
            totUtententes++;

        }

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

        public int TempoInternamento()
        {
            DateTime d1 = Convert.ToDateTime("01-01-20").Date;
            DateTime d2 = Convert.ToDateTime("02-10-30").Date;
            foreach (Estado e in n)
            {
                if (e.Sit == Situacao.INTERNADO)
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



        #endregion


        #region Others

      



    }

    #endregion

    #region Destructors


    #endregion


}


