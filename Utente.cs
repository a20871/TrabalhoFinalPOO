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
    public class Utente 
    {
       
        #region Attributes

        protected string numeroUtente;
        protected string nome;
        DateTime dataNascimento;
        Genero generoU;
        Distrito distritoU;
        List <Estado> n ;



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
        public Utente(string numero, string nome, string dataNascimento, Genero generoU, Distrito distritoU, Situacao s)
        {
            this.NumUtente = numero;
            this.Nome = nome;
            this.DataNascimento = Convert.ToDateTime(dataNascimento);
            this.GeneroU = generoU;
            this.DistritoU = distritoU;
            this.AddEstado(s,DateTime.Today);

        }

        /// <summary>
        /// Novo estado do doente
        /// </summary>
        /// <param name="e"></param>
        /// <returns>True or False</returns>
        public bool RegistaEstdoUtente(Estado e)
        {
            //foreach(Utente u in uteb) 
            return this.AddEstado(e);
            
        }


        #region GereEStado

        /// <summary>
        /// Adiciona Estado a lista ou cria lista caso ainda não exista
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool AddEstado(Estado e)
        {
            if (n == null) n = new List<Estado>();
            n.Add(e);
            return true;
        }

        public bool ConsultaEstado(Utente u, List<Utente> listagem)
        {

            foreach(Utente item in listagem)
            {
                Console.WriteLine(u.NovoEstado.ToString());
            }
            return true;
          
        }

        /// <summary>
        /// Adiciona estado com respetiva situação clínica e data atual
        /// </summary>
        /// <param name="novaSit"></param>
        /// <param name="novaData"></param>
        /// <returns></returns>
        public bool AddEstado( Situacao novaSit, DateTime novaData)
        {
            if (n == null) n = new List<Estado>();
            Estado novo = new Estado();
            novo.DataNovoEstado = novaData;
            novo.Sit = novaSit;

            n.Add(novo);
            return true;
        }

        #endregion



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

        public Estado NovoEstado
        {  get;
            set;
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


    public class Utentes
    {
        List<Utente> doentes;
        

        public Utentes() { doentes = new List<Utente>(); }

        public bool AddUTente(Utente u)
        {
            if (!doentes.Contains(u)) doentes.Add(u); return true;
        }


        public bool RegistaEstdoUtente(Estado e, string numero)
        {
            foreach (Utente u in doentes)
            {
                if (u.NumUtente==numero)
                {
                    return u.RegistaEstdoUtente(e);
                }
            }
            return false;
        }
    }
}