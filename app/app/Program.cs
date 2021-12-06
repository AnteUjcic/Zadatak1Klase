using System;

namespace app
{
    class Program
    {
/*
Definirajte klasu KlasaC sa sljedećim članicama:
• metoda
int Zbroj(int []) koja će vratiti zbroj svih članova proslijeñenog niza.
double Prosjek(int []) koja će vratiti prosječnu vrijednost svih članova
proslijeñenog niza.
Definirajte objekt tipa KlasaC, zatražite od korisnika da unese 5 cijelih brojeva koje spremite u
niz tipa int veličine 5 članova. Taj niz proslijedite metodama Zbroj i Prosjek koje ćete pozvati
za definirani objekt, te povratne vrijednosti spremite u lokalne varijable zbroj i prosjek.
*/
        static void Main(string[] args)
        {
            int[] zbrojPros = new int[5]; 
            
            Console.WriteLine("Upisite 5 cijelih brojeva:"); 
            
            for (int i = 0; i < 5; i++) 
            { 
                string s = Console.ReadLine();
                zbrojPros[i] = Convert.ToInt32(s); 
            }
            
            KlasaC x = new KlasaC(); 
           
            int zbroj = x.Zbroj(zbrojPros);
            double prosjek = x.Prosjek(zbrojPros);
            
            Console.WriteLine("Zbroj "+zbroj+", prosjek "+prosjek);
           
            
            
            
        }
    }
}
