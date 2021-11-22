using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    /// <summary>
    /// @brief 
    /// @author Sérgio Martins, Jéssica Costa
    /// <p>a20871@alunos.ipca.pt</p>a20872@alunos.ipca.pt
    /// @date 11/16/2021 4:50:51 PM
    /// </summary>
    public class Utente 
    {
        public enum Genero { MASCULINO, FEMININO };
        public enum Distrito { Aveiro, Beja, Braga, Braganca, CasteloBranco, Coimbra, Evora, Faro, Guarda, Leiria, Lisboa, Portalegre, Porto, Santarem, Setubal, VianaCastelo, VilaReal, Viseu };
        #region Attributes

        protected string numeroUtente;
        protected string nome;
        DateTime dataNascimento;
        Genero generoU;
        Distrito distritoU;

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
        public Utente(string numero, string nome, string dataNascimento, Genero generoU, Distrito distritoU)
        {
            this.NumUtente = numero;
            this.Nome = nome;
            this.DataNascimento = Convert.ToDateTime(dataNascimento);
            this.GeneroU = generoU;
            this.DistritoU = distritoU;

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
                }
            }
        }

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
        public Genero GeneroU
        {
            get { return generoU; }
            set
            {
                if ((value == Genero.MASCULINO) || (value == Genero.FEMININO))
                    generoU = value;

            }
        }

        /// <summary>
        /// Distrito de morada - escolha opção
        /// </summary>
        public Distrito DistritoU
        {
            get { return distritoU; }
            set
            {
                if ((value == Distrito.Aveiro) || (value == Distrito.Beja) || (value == Distrito.Braga) || (value == Distrito.Braganca) || (value == Distrito.CasteloBranco) || (value == Distrito.Coimbra) || (value == Distrito.Evora) || (value == Distrito.Faro) || (value == Distrito.Guarda) || (value == Distrito.Leiria) || (value == Distrito.Lisboa) || (value == Distrito.Portalegre) || (value == Distrito.Porto) || (value == Distrito.Santarem) || (value == Distrito.Setubal) || (value == Distrito.VianaCastelo) || (value == Distrito.VilaReal) || (value == Distrito.Viseu))
                    distritoU = value;
               
            }
        }

       

        #endregion

        #region Others
       
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

        #region Destructors


        #endregion


    }
}