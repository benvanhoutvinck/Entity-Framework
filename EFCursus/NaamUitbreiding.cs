using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCursus
{
    public partial class Naam
    {
        public override string ToString()
        {
            return Voornaam + ' ' + Familienaam;
        }
        public string InformeleBegroeting
        {
            get
            {
                return "Hallo " + Voornaam;
            }
        }
        public string FormeleBegroeting
        {
            get
            {
                return "Geachte " + Voornaam + ' ' + Familienaam;
            }
        }
    }
}
