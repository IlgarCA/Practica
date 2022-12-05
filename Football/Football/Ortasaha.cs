using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Ortasaha : Futbolcu
    {
        private int UzunTop;
        private int IlkDokunus;
        private int Uretkenlik;
        private int TopSurme;
        private int OzelYetenek;


        public Ortasaha(string adSoyad, int formaNo)
        {
            this.AdSoyad = adSoyad;
            this.FormaNo = formaNo;
            Hiz = RastgeleSayi.Next(60, 100);
            Dayaniklilik = RastgeleSayi.Next(60, 100);
            Pas = RastgeleSayi.Next(60, 100);
            Sut = RastgeleSayi.Next(60, 100);
            Yetenek = RastgeleSayi.Next(60, 100);
            Kararlilik = RastgeleSayi.Next(60, 100);
            DogalForm = RastgeleSayi.Next(60, 100);
            Sans = RastgeleSayi.Next(60, 100);
            UzunTop = RastgeleSayi.Next(60, 100);
            Uretkenlik = RastgeleSayi.Next(60, 100);
            TopSurme = RastgeleSayi.Next(60, 100);
            OzelYetenek = RastgeleSayi.Next(60, 100);
        }
    }
}
