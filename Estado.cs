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

        public Estado()
        {

        }


        public Estado(DateTime d, Situacao m)
        {
            this.DataNovoEstado = Convert.ToDateTime(d);
            this.Sit = m;
        }




        #endregion

        #region Properties
        public DateTime DataNovoEstado
        {
            get { return dataNovoEstado; }
            set { dataNovoEstado = value.Date; }
        }

        public Situacao Sit{
            get { return sit; }
            set { sit = value; }
        }


        #endregion

        #region Others



        #endregion

        #region Destructors


        #endregion

    }

    public class Estados
    {
        List<Estado> e;
    }
}
