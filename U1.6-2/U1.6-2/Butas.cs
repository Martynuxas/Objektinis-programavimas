using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1._6_2
{
    class Butas : NTObjektas
    {
        public int Aukstas { get; set; }

        /// <param name="ipav">Įmonės kuri parduoda namus pavadinimas</param>
        /// <param name="iadr">Įmonės kuri parduoda namus adresas</param>
        /// <param name="itel">Įmonės kuri parduoda namus telefono numeris</param>
        /// <param name="rajonas">Namo rajonas</param>
        /// <param name="gatve">Namo gatvė</param>
        /// <param name="namonr">Namo numeris</param>
        /// <param name="tipas">Namo tipas</param>
        /// <param name="metai">Namo pastatymo metai</param>
        /// <param name="plotas">Namo plotas</param>
        /// <param name="kambariai">Namo kambarių skaičius</param>
        public Butas(string ipav, string iadr, string itel, string rajonas, string gatve, double namonr, string tipas,
                     double metai, double plotas, double kambariai, int aukstas) : base(ipav, iadr, itel, rajonas, gatve, namonr, tipas,
                     metai, plotas, kambariai)
        {
            Aukstas = aukstas;
        }
        // ToString() užklojimas
        public override string ToString()
        {
            return String.Format("{0};{1} g.;{2};{3};{4}m;{5}kv.m.;{6};{7}", Rajonas, Gatve, Namonr, Tipas, Metai, Plotas, Kambariai, Aukstas, Encoding.UTF8);
        }
    }
}
