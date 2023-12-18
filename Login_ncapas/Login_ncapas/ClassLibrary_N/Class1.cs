using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
namespace ClassLibrary_N
{
    public class Class1
    {
        ClassLibrary_D.Class1 objd = new ClassLibrary_D.Class1();

        public DataTable N_login(ClassLibrary_E.Class1 obje) 
        {
            return objd.D_Login(obje);
        }
    
    }
}
