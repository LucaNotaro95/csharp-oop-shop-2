using csharp_oop_shop_2;
/*string risposta;
bool ciclo = true;
while (true)
{
    Console.WriteLine("inserisci Il nome del prodotto:");
    string NomeProdotto = Console.ReadLine();

    Console.WriteLine("inserisci la descrizine del prodotto:");
    string DescrizioneProdotto = Console.ReadLine();

    Console.WriteLine("inserisci Il Prezzo del prodotto:");
    double PrezzoProdotto = double.Parse(Console.ReadLine());


    Prodotto Prodotto1 = new Prodotto(NomeProdotto, DescrizioneProdotto, PrezzoProdotto);

    Prodotto1.CalcolaPrezzoIva(PrezzoProdotto);
    Prodotto1.StampaProdottoIntero();

    Console.WriteLine("PREMI (F) per NON inserire più i prodotti Oppure qualsiasi input per continuare");
    risposta = Console.ReadLine().ToLower();
    if (risposta == "f")
    {
        ciclo = false;
    }
}
*/

Acqua miaBottiglia = new Acqua("acqua", "botiglietta d'acqua",1.0,1.5 ,"Sorgente di Patrella" ,7.2);

miaBottiglia.StampaProdottoIntero();