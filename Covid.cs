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
    /// @date 11/16/2021 4:52:04 PM
    /// </summary>
    /// 
    public class Covid //: Utente
    {

        //List<Covid> = new 
        //public enum Estado { LIGEIRO, INTERNADO, UCI, MORTO, CURADO }//doente que tem sintomas ligeiros, esta internado ou em cuidados intensivos

        #region Attributes

        DateTime dataDiagnostico;//data em que foi diagnosticado com covid
        int quantidadeContacto;//quantidade de contactos de risco do doente
        //Estado estadoUtente;
        DateTime dataFimDoenca;//data em que a pessoa teve alta ou faleceu
        string motivoFimDoenca;//motivo pelo qual findou o periodo em esteve doente
        int totCovid=0; //total de casos diagnosticados

        #endregion

        #region Constructors
        
        public Covid(string dataDiagnostico, int quantidadeContacto, Estado estadoUtente)//, string dataFimDoenca, string motivoFimDoenca) : base()
        {
            DataDiagnostico = Convert.ToDateTime(dataDiagnostico);
            QuantidadeContacto = quantidadeContacto;
            EstadoDoente = estadoUtente;
            DataFimDoenca = Convert.ToDateTime(dataFimDoenca);
            MotivoFimDoenca = motivoFimDoenca;
            totCovid++;
            
        }
    public Covid(string dataAlteracao, Estado novoEstado, string motivo)
    {

    }

        #endregion

        #region Properties

        public DateTime DataDiagnostico
        {
            get { return dataDiagnostico; }
            set { dataDiagnostico = value.Date; }
        }

        public int QuantidadeContacto
        {
            get { return quantidadeContacto; }
            set
            {
                if (value < 0)
                    quantidadeContacto = value;
                else
                    quantidadeContacto = 0;
            }
        }


        public Estado EstadoDoente
        {
            get { return estadoUtente; }
            set
            {
                if ((value == Estado.LIGEIRO) || (value == Estado.INTERNADO) || (value == Estado.UCI))
                    estadoUtente = value;
            }
        }



        public DateTime DataFimDoenca
        {
            get { return dataFimDoenca; }
            set { dataFimDoenca = value.Date; }
        }

        public string MotivoFimDoenca
        {
            get;
            set;
        }



        #endregion

        #region Others



        /*public static int ContaDias(int num)//vai ter de receber uma lista aqui tambem
        {
            /*while(numUtente!=NumUtente)//para encontrar o utente, tem-se de definir uma lista
            {

            }
            return (DataFimDoenca - DataDiagnostico).Days;
        }*/
        //public int ContaDias(int num)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        #region Destructors


        #endregion

    }
}
