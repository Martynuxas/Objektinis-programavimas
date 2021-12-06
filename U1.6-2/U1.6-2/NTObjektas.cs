using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1._6_2
{
    class NTObjektas
    {
        // Įmonės kuri parduoda namus pavadinimas
        public string Ipav { get; set; }

        // Įmonės kuri parduoda namus adresas
        public string Iadr { get; set; }

        // Įmonės kuri parduoda namus telefono numeris
        public string Itel { get; set; }

        // Namo rajonas
        public string Rajonas { get; set; }

        // Namo gatvė
        public string Gatve { get; set; }

        // Namo numeris
        public double Namonr { get; set; }

        // Namo tipas
        public string Tipas { get; set; }

        // Namo pastatymo metai
        public double Metai { get; set; }

        // Namo plotas
        public double Plotas { get; set; }

        // Namo kambarių skaičius
        public double Kambariai { get; set; }

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
        public NTObjektas(string ipav, string iadr, string itel, string rajonas, string gatve, double namonr, string tipas,
                     double metai, double plotas, double kambariai)
        {
            Ipav = ipav;
            Iadr = iadr;
            Itel = itel;
            Rajonas = rajonas;
            Gatve = gatve;
            Namonr = namonr;
            Tipas = tipas;
            Metai = metai;
            Plotas = plotas;
            Kambariai = kambariai;
        }
        public override string ToString()
        {
            return String.Format("{0};{1} g.;{2};{3};{4}m;{5}kv.m.;{6};", Rajonas, Gatve, Namonr, Tipas, Metai, Plotas, Kambariai, Encoding.UTF8);
        }
        // '==' Užklojimas
        public static bool operator ==(NTObjektas obj1, NTObjektas obj2)
        {
            if (ReferenceEquals(obj1, obj2))
            {
                return true;
            }

            if (ReferenceEquals(obj1, null))
            {
                return false;
            }
            if (ReferenceEquals(obj2, null))
            {
                return false;
            }

            return (obj1.Rajonas == obj2.Rajonas &&
                    obj1.Gatve == obj2.Gatve &&
                    obj1.Namonr == obj2.Namonr &&
                    obj1.Tipas == obj2.Tipas &&
                    obj1.Metai == obj2.Metai &&
                    obj1.Plotas == obj2.Plotas &&
                    obj1.Kambariai == obj2.Kambariai);
        }

        // '!=' Užklojimas
        public static bool operator !=(NTObjektas obj1, NTObjektas obj2)
        {
            return !(obj1 == obj2);
        }
    }
}

