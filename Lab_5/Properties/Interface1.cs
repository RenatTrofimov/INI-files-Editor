using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Properties
{
    interface ICRUD
    {
        void Create();
        void Read(String str);
        void Update(String str);
        void Delete(String str);
    }
}
