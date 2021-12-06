using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1._6_2
{
    class NamuKonteineris
    {
        private int dydis = 999;

        private NTObjektas[] Objektai { get; set; } //Masyvas pagal klasės NTObjektai šabloną
        // Konstruktorius klasės masyvui sukurti

        // Klasės masyvo dydžio skaitliukas
        public int Count { get; private set; }

        // Konstruktorius be nustatyto dydžio (jam pritaikomas numatytasis)
        public NamuKonteineris()
        {
            Objektai = new NTObjektas[dydis];
            Count = 0;
        }

        // Konstruktorius sukurti naujam butų konteineriui
        public NamuKonteineris(int dydis)
        {
            Objektai = new NTObjektas[dydis];
            Count = 0;
        }

        // Konstruktorius naujoms reikšmėms į konteinerį įdėti
        public void PridetiNama(NTObjektas objektas)
        {
            Objektai[Count++] = objektas;
        }
        public void PridetiButa(NTObjektas objektas)
        {
            Objektai[Count++] = objektas;
        }

        // Konstruktorius į konteinerį įdėti (ar jį papildyti) naujomis reikšmėmis kartu su jų indeksais
        public void PridetiNama(NTObjektas objektas, int indeksas)
        {
            Objektai[indeksas] = objektas;
        }
        public NTObjektas GautiObjekta(int indeksas)
        {
            return Objektai[indeksas];
        }
        // Konstruktorius gauti reikiamoms reikšmėms iš konteinerio
        public NTObjektas GautiNama(int indeksas)
        {
            return Objektai[indeksas];
        }
    }
}
