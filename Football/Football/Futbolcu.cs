using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Futbolcu
    {
        public Random RastgeleSayi = new Random();

        protected string AdSoyad;
        protected int FormaNo;
        protected int Hiz;
        protected int Dayaniklilik;
        protected int Pas;
        protected int Sut;
        protected int Yetenek;
        protected int Kararlilik;
        protected int DogalForm;
        protected int Sans;

        
        public Futbolcu(string adSoyad, int formaNo)
        {
            this.AdSoyad = adSoyad;
            this.FormaNo = formaNo;
            Hiz = RastgeleSayi.Next(50, 100);
            Dayaniklilik = RastgeleSayi.Next(50, 100);
            Pas = RastgeleSayi.Next(50, 100);
            Sut = RastgeleSayi.Next(50, 100);
            Yetenek = RastgeleSayi.Next(50, 100);
            Kararlilik = RastgeleSayi.Next(50, 100);
            DogalForm = RastgeleSayi.Next(50, 100);
            Sans = RastgeleSayi.Next(50, 100);
        }
        public Futbolcu()
        {
        }
        public virtual Boolean PassVer()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + Sans * 0.2);

            if (PasSkor > 60)
                return true;
            else
                return false;
        }
    }
}
