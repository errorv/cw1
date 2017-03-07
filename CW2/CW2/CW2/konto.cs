using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    class konto
    {
        public string ImieNazwisko { get; private set; }
        public string NrKonta { get; private set; }
        public int FunduszeKonta { get; private set; }
        public int ID { get; private set; }
        public bool UsunKonto { get; private set; }

        public konto(string imienazwisko, string nrkonta, int fundusze, int id, bool usunkonto=false)
            {
            ImieNazwisko = imienazwisko;
            NrKonta = nrkonta;
            FunduszeKonta = fundusze;
            ID = id;
            UsunKonto = usunkonto;
            }
        public  void WplacPieniadze(int ilosc)
        {
            FunduszeKonta += ilosc;
        }
        public void WyplacPieniadze(int ilosc)
        {
            FunduszeKonta -= ilosc;
        }
        public void UsuńKonto(List<konto> lista, int id)
        {
            lista.RemoveAt(id);
        }
        public void KontoUsuniete(bool status)
        {
            status = true;
        }
        public void ZmienFunduszeKont(int procent)
        {
            FunduszeKonta += FunduszeKonta * procent / 100;
        }
        public override string ToString()
        {
            return " Użytkownik " + ImieNazwisko.ToString() + "ma" + FunduszeKonta.ToString() + "zl na koncie bankowym";
         }
    }
}
