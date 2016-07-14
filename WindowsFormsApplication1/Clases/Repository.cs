using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Clases
{
    abstract class Repository
    {
        public DataBase db = DataBase.Instance;

        public long toLong(object e)
        {
            if (e.ToString() == "")
            {
                return 0;
            }
            return Convert.ToInt32(e);
        }
        public double toDouble(object e)
        {
            return Convert.ToDouble(e);
        }

        public DateTime toDate(object e)
        {
            if (e.ToString() == "")
            {
                return Sistema.Instance.getDate();
            }

            return Convert.ToDateTime(e);
        }

        public int toInt(object e)
        {
            if (e.ToString()=="")
            {
                return 0;
            }
            return Convert.ToInt16(e);
        }

        public bool toBool(object e)
        {
            return Convert.ToBoolean(e);
        }
    }
}
