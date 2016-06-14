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
    }
}
