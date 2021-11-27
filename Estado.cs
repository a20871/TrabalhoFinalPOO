/**
 * @Brief
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

    /// <summary>
    /// @brief 
    /// @author Sérgio Martins
    /// <p>a20871@alunos.ipca.pt</p>
    /// @date 11/23/2021 12:42:23 PM
    /// </summary>
    /// 
    public enum Situacao { LIGEIRO, INTERNADO, UCI, ALTA, OBITO };
    public class Estado
    {
       
        #region Attributes

        DateTime dataNovoEstado;
        Situacao sit;

        #endregion

        #region Constructors

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


        #endregion

        #region Properties
        /// <summary>
        /// Propriedade em que se define a data da alteracao do estado
        /// </summary>
        public DateTime DataNovoEstado
        {
            get { return dataNovoEstado; }
            set { dataNovoEstado = value.Date; }
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
        /*public override bool Equals(object obj)
        {
            if(this.Sit==obj)
            return base.Equals(obj);
        }*/

      

        #endregion

        #region Destructors


        #endregion

    }

  
   
}
