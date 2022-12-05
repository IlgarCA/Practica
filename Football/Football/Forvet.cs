using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Forvet : Futbolcu
    {
        private int Bitiricilik;
        private int IlkDokunus;
        private int Kafa;
        private int OzelYetenek;
        private int SogukKanlilik;

        public Forvet(string adSoyad, int formaNo)
        {
            this.AdSoyad = adSoyad;
            this.FormaNo = formaNo;
            Hiz = RastgeleSayi.Next(70, 100);
            Dayaniklilik = RastgeleSayi.Next(70, 100);
            Pas = RastgeleSayi.Next(70, 100);
            Sut = RastgeleSayi.Next(70, 100);
            Yetenek = RastgeleSayi.Next(70, 100);
            Kararlilik = RastgeleSayi.Next(70, 100);
            DogalForm = RastgeleSayi.Next(70, 100);
            Sans = RastgeleSayi.Next(70, 100);
            Bitiricilik = RastgeleSayi.Next(70, 100);
            IlkDokunus = RastgeleSayi.Next(70, 100);
            Kafa = RastgeleSayi.Next(70, 100);
            OzelYetenek = RastgeleSayi.Next(70, 100);
            SogukKanlilik = RastgeleSayi.Next(70, 100);

        }
    }
}
