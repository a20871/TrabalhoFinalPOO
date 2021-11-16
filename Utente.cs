using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    /// <summary>
    /// @brief 
    /// @author Sérgio Martins
    /// <p>a20871@alunos.ipca.pt</p>
    /// @date 11/16/2021 4:50:51 PM
    /// </summary>
    public class Utente
    {
        public enum Genero { MASCULINO, FEMININO };
        public enum Distrito { Aveiro, Beja, Braga, Braganca, CasteloBranco, Coimbra, Evora, Faro, Guarda, Leiria, Lisboa, Portalegre, Porto, Santarem, Setubal, VianaCastelo, VilaReal, Viseu }
        #region Attributes

        string numUtente;
        string nome;
        DateTime dataNascimento;
        Genero generoU;
        Distrito distritoU;

        #endregion

        #region Constructors

        public Utente()
        {

        }
        public Utente(string numero, string nome, DateTime dataNascimento, Genero generoU, Distrito distritoU)
        {


        }

        #endregion

        #region Properties


        public string NumUtente
        {
            get { return numUtente; }
            set
            {
                //Verifica se tem 9 caracteres e todos são algarismos
                if (value.Length != 9 || !numUtente.All(char.IsDigit))
                {
                    Console.WriteLine("Erro na inserção.");
                    return;

                }
                else
                    numUtente = value;
            }
        }

        public string Nome
        {
            get { return nome; }

        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value.Date; }
        }

        public Genero GeneroU
        {
            get { return generoU; }
            set
            {
                if ((value == Genero.MASCULINO) || (value == Genero.FEMININO))
                    generoU = value;

            }
        }

        public Distrito DistritoU
        {
            get { return distritoU; }
            set { if ((value == Distrito.Aveiro) || (value==Distrito.Beja) || (value==Distrito.Braga) || (value==Distrito.Braganca) || (value==Distrito.CasteloBranco) || (value==Distrito.Coimbra) || (value==Distrito.Evora) || (value==Distrito.Faro) || (value==Distrito.Guarda) || (value==Distrito.Leiria) || (value==Distrito.Lisboa) || (value==Distrito.Portalegre) || (value==Distrito.Porto) || (value==Distrito.Santarem) || (value==Distrito.Setubal) || (value==Distrito.VianaCastelo) || (value==Distrito.VilaReal) || (value==Distrito.Viseu) )
                    distritoU = value;
            }
        }

            #endregion

            #region Others



            #endregion

            #region Destructors


            #endregion

        
    }
}