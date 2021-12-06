using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Definirajte klasu KlasaC sa sljedećim članicama:
• metoda
int Zbroj(int []) koja će vratiti zbroj svih članova proslijeñenog niza.
double Prosjek(int []) koja će vratiti prosječnu vrijednost svih članova
proslijeñenog niza.
Definirajte objekt tipa KlasaC, zatražite od korisnika da unese 5 cijelih brojeva koje spremite u
niz tipa int veličine 5 članova. Taj niz proslijedite metodama Zbroj i Prosjek koje ćete pozvati
za definirani objekt, te povratne vrijednosti spremite u lokalne varijable zbroj i prosjek.
*/
namespace app
{
    class KlasaC
    {
        public int Zbroj(int[] arr)
        {int zbr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                zbr += arr[i];
            }
         
            return zbr; 
        }
        public double Prosjek(int[] prosjek) 
        {int sum = 0;
            for (int i = 0; i < prosjek.Length; i++)
            {
                sum += prosjek[i];
            }
         
            return sum / prosjek.Length;
        }

    }
}
