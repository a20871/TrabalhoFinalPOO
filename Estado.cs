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
    public class List<Estado>
    {

        #region Attributes

        DateTime dataNovoEstado;
        string motivo;

        #endregion

        #region Constructors

        public List<Estado>
        {

        }


        //public Estado(DateTime d, string m)
        //{
        //    this.DataNovoEstado = Convert.ToDateTime(d);
        //    this.Motivo = m;
        //}




        #endregion

        #region Properties
        public DateTime DataNovoEstado
        {
            get { return dataNovoEstado; }
            set { dataNovoEstado = value.Date; }
        }

        public string Motivo{
            get { return motivo; }
            set { motivo = value; }
        }


        #endregion

        #region Others



        #endregion

        #region Destructors


        #endregion

    }
}
