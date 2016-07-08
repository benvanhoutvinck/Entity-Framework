using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCursus
{
    public partial class Docent
    {
       
        public void Opslag(decimal bedrag)
        {
            Wedde += bedrag;
        }
    }
}
