using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Acqua : Prodotto
    {
        public static readonly double litriMax = 1.5;
        private double ph;
        private string sorgente;
        private const double gallone = 3.785;
        private double litri;



        public Acqua(string nome, string descrizione, double prezzo, double litri, string sorgente, double ph) : base(nome, descrizione, prezzo)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;

        }


        protected  void LitriDaBere(double litriAssunti)
        {
            double litriDopoBevuta = litriMax - litriAssunti;

            if (litriAssunti < 0)
            {
                Console.WriteLine("l'acqua non è diminuita ,bevi!!");
                return;


            }


            if (litriDopoBevuta < litriMax)
            {
                litriDopoBevuta = litriMax - litriDopoBevuta;
            }
            else
            {
                Console.WriteLine("hai finito l'acqua"+litriDopoBevuta);

               
            }
            
        }



        public double GetLitriMax()
        {
            return litriMax;
        }


        public override void StampaProdottoIntero()
        {
            Console.WriteLine("la bevanda è : " + base.CreaCodiceProdotto + "-" + base.nome + "-" + this.sorgente + "-" + this.ph + "-" + litriMax);
        }



        public void riempi(double litriDaRipempire)
        {
           

            if (litri < 0)
            {
                throw new Exception("Non posso riempire senza mettere l'acqua");
               
            }

            if (litriDaRipempire + this.litri > litriMax)
            {
                Console.WriteLine("la bottiglia è piena"+litriDaRipempire);
                this.litri = litriMax;
            }
            else
            {
                Console.WriteLine("hai fatto uscire l'acqua,la tua bottiglia è piena");
                this.litri=this.litri- litriDaRipempire;
            }


           public void Svuota()
            {

                
                this.litri = 0;
                Console.WriteLine("Hai svuotato la bottiglia");
            }


            public void ConversioniGalloni(double litri)
            {
                double litriInGallone = 0;
                if(litri>0)
                {
                    litriInGallone = gallone*litri;
                    Console.WriteLine("i tuoi galloni sono: " + litriInGallone);
                }
                else 
                {


                    throw new Exception("non puoi convertire una quantità negativa di litri" );
                        

                }
            }



        }
    }

}
