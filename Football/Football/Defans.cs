using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Defans : Futbolcu
    {
        private int PozisyonAlma;
        private int Kafa;
        private int Sicrama;

-
        public Defans(string adSoyad, int formaNo)
        {
            this.AdSoyad = adSoyad;
            this.FormaNo = formaNo;
            Hiz = RastgeleSayi.Next(50, 90);
            Dayaniklilik = RastgeleSayi.Next(50, 90);
            Pas = RastgeleSayi.Next(50, 90);
            Sut = RastgeleSayi.Next(50, 90);
            Yetenek = RastgeleSayi.Next(50, 90);
            Kararlilik = RastgeleSayi.Next(50, 90);
            DogalForm = RastgeleSayi.Next(50, 90);
            Sans = RastgeleSayi.Next(50, 90);
            PozisyonAlma = RastgeleSayi.Next(50, 90);
            Kafa = RastgeleSayi.Next(50, 90);
            Sicrama = RastgeleSayi.Next(50, 90  );

        }
    }
}
