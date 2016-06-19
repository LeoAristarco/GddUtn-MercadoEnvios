using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Clases
{
    class Sistema
    {
        #region Singleton
        private static volatile Sistema instancia = null;

        public static Sistema Instance
        {
            get
            { return newInstance(); }
        }

        internal static Sistema newInstance()
        {
            if (instancia != null) { }
            else
            {
                instancia = new Sistema();
            }
            return instancia;
        }
        private Sistema() { }

        #endregion

        internal DateTime getDate()
        {
            return DateTime.Now.Date;//POR AHORA NADA
        }

    }
}
