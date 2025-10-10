namespace MinuKonspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello, World!");


            ////Muutujad, Matemaatilised tehted, IF, ELSE IF ja ELSE:

            ////1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
            //Console.WriteLine("Tere kasutaja, mis on sinu nimi");
            //string nimi = Console.ReadLine();

            //if (nimi == "")
            //{
            //    Console.WriteLine("Kasutaja ei sisestanud oma nime");
            //}
            //else if (nimi != "")
            //{
            //    Console.WriteLine("Tere " + nimi + "!");

            //}
            //else
            //{
            //    Console.WriteLine("Kasutaja ei sisestanud oma nime");
            //}

            ////2.tuvasta arvuvahemik, võrdluses piirväärtustega, int/double/float andmetüüp
            //Console.WriteLine(nimi + ", mis on sinu vanus?: ");
            //int kasutajavanus = int.Parse(Console.ReadLine());

            ////2.1 mitu tingimust pesastatud if-ide abil
            ////if (kasutajavanus > 0)
            ////{
            ////    if (kasutajavanus < 18)
            ////    {
            ////        Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma 😔");
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("Saad osta Monsterit, YIPPIE ✨✨");
            ////    }
            ////}

            ////2.2 mitu tingimust ühe ifi sees kasutades loogilist tehet "and", vältides pesastamist
            //if (kasutajavanus > 0 && kasutajavanus < 18)
            //{
            //    Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma 😔");
            //}
            //else 
            //{
            //    Console.WriteLine("Saad osta Monsterit, YIPPIE ✨✨");
            //}
            ////2.3 mitu vahemikku, if-elseif abil, double/float
            //Console.WriteLine("Sisesta oma pikkus ka, palun, "+nimi+":");
            //double pikkus = double.Parse(Console.ReadLine());
            //if (pikkus < 1.00d)
            //{
            //    Console.WriteLine("Oled juntsu");
            //}
            //else if (pikkus <1.25d && pikkus > 1.00d)
            //{
            //    Console.WriteLine("Oled peaaegu allameetrimees");
            //}
            //else if (pikkus <1.50d && pikkus >1.25d)
            //{
            //    Console.WriteLine("Oioi, päkapikk enam ei olegi "+nimi+" !");
            //}
            //else if (pikkus <1.75d && pikkus >1.5d)
            //{
            //    Console.WriteLine("Oled enamasti standardpikkuses, kui mitte just natuke lühike");
            //}
            //else if (pikkus <2.00d && pikkus >1.75d)
            //{
            //    Console.WriteLine("Pikk kolge, vaata et sa pead vastu uksepiita ära ei löö.");
            //}
            //else if (pikkus > 2.00d)
            //{
            //    Console.WriteLine("Täielik tulnukas, kuidas pilved välja näevad?");
            //}
            //else
            //{
            //    Console.WriteLine("pikkust ei tunta");
            //}

            ////3 kalkulaator ifi ja elsifidega
            //Console.WriteLine("Tere. Sisesta esimene arv");
            //int arv1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere. Sisesta teine arv");
            //int arv2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sisesta tehtemärk: / * + -");
            //string tehtetyyp = Console.ReadLine();

            //int tulemus = 0;
            //if (tehtetyyp == "+")
            //{
            //    tulemus = arv1 + arv2;
            //}
            //else if (tehtetyyp == "-")
            //{
            //    tulemus = arv1 - arv2;
            //}
            //else if (tehtetyyp == "/")
            //{
            //    tulemus = arv1 / arv2;
            //}
            //else if (tehtetyyp == "*")
            //{
            //    tulemus = arv1 * arv2;
            //}
            //else if (tehtetyyp == "*")
            //{
            //    tulemus = (int)Math.Pow(arv1, arv2);
            //}
            //else
            //{
            //    Console.WriteLine("Palun sisesta tehe, mida kalkulaator tuvastada oskab");
            //}

            //if (tulemus != 0)
            //{
            //    Console.WriteLine(tulemus);
            //}
            //else
            //{
            //    Console.WriteLine("Tulemus on 0, või üritasid teha tehet, mida kalkulaator ei tunne");
            //}

            ////4 parool, if ja string andmetüüp
            //Console.WriteLine("Programmi edasiseks tööks sisesta palun parool:");
            //string password = Console.ReadLine();

            //if (password == "simsalabim")
            //{
            //    Console.WriteLine("Parool on õige, aarete laegas avaneb");
            //}
            //else if (password == "saatana" || password == "1234")
            //{
            //    Console.WriteLine("Parool on sobimatu, palun mingi muu");
            //}
            //else
            //{
            //    Console.WriteLine("Parool on vale, proovi uuesti");
            //}

            ////5 värvituvastus
            //Console.WriteLine("Milline värv sulle kõige rohkem meeldib?:");
            //string favouriteColour = Console.ReadLine();
            //if(favouriteColour == "punane")
            //{
            //    Console.BackgroundColor = ConsoleColor.Red;
            //}
            //if (favouriteColour == "oranz")
            //{
            //    Console.WriteLine("Kahjuks oranzi ei ole");
            //}
            //if(favouriteColour == "kollane")
            //{
            //    Console.BackgroundColor = ConsoleColor.Yellow;
            //}
            //if (favouriteColour == "roheline")
            //{
            //    Console.BackgroundColor = ConsoleColor.Green;
            //}
            //else 
            //{
            //    Console.WriteLine("Värvi ei tunne");
            //}
            //Console.WriteLine("Värv muudetud!");

            ////    |
            ////   \v/ ISESEISEV TÖÖ LÄHEB SIIA

            ////# Kolija kalkulaator - Kirjuta programm mis:
            ////#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
            //Console.WriteLine("Kas sa tahad mõõta kasti või tünni?");
            //string sisend = Console.ReadLine();
            ////#    - olenevalt kasutaja sisestusest küsib ta:

            ////#    - - tünni jaoks:
            //if (sisend == "tünn")
            //{
            ////#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
            //    Console.WriteLine("Kas sa tead tünni raadiust R või läbimõõtu D");
            //    string rvõid = Console.ReadLine();
            //    Console.WriteLine("Mis on selle raadius/läbimõõt? meetrites");
            //    double kasutajamõõt = double.Parse(Console.ReadLine());
            ////#    - - - tünni kõrgust
            //    Console.WriteLine("Kui kõrge on su tünn? meetrites");
            //    double kõrgus = double.Parse(Console.ReadLine());
            ////#    - - - kaane paksus, kuna kaan võtab tünni sisust natuke ruumi)
            //    Console.WriteLine("Kui paks on su tünni kaas? meetrites");
            //    double kaanepaksus = double.Parse(Console.ReadLine());
            //    //#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
            //    double Sp = 0;
            //    if (rvõid == "R")
            //    {
            //        Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
            //    }
            //    else if (rvõid == "D")
            //    {
            //        kasutajamõõt = kasutajamõõt / 2;
            //        Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
            //    }
            //    double V = 0;
            //    kõrgus = kõrgus - kaanepaksus;
            //    V = Sp * kõrgus;
            //    //Tünni ruumala on olemas. arvutame küljepindala
            //    kõrgus += kaanepaksus;
            //    double Sk = 2 * Math.PI * kasutajamõõt * kõrgus;
            //    //Tünni küljepindala on olemas. arvutame tünni kogupindala
            //    double S = Sp + Sk;
            //    Console.WriteLine($"Sinu tünn mahutab {V}\nTünni küljepindala on{Sk}\nTünni kogupindala on{S}");
            //}

            ////#    - - kasti jaoks:
            //else if (sisend == "kast")
            //{
            ////#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
            ////#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
            ////#    - - - - kui on risttahukas siis küsib kasutajalt:
            ////#    - - - - - pikima külje pikkust, 
            ////#    - - - - - lühima külje pikkust ja
            ////#    - - - - - kasti kõrgust
            ////#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)
            //}

            Console.WriteLine(/*abc*/"hapukapsas");
            // "Console"    -> on moodul C# mida me adresserime, Console aitab teha tegevusi käsureal
            // .            -> näitab, et meil on vaja adresseerida mingisugust funktsiooni või meetodit
            //                 mooduli "Console" seest.
            // "WriteLine"  -> Funktsioon mida me parasjagu kasutame.
            // ()           -> sulupaar mis omab funktsiooni tööks vajalikku infot
            // []           -> tähistab massiive
            // {}           -> koodiplokk, tavaliselt kas pärast (if, else if) tingimust, namespacei või
            //                 funktsiooni kirjeldust
            // "hapukapsas" -> parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
            //          -> Taane aitab arendajal aru saada, kuskohas millise koodiploki sees kood
            //             asub, see on vajalik ka kompilaatorile samal eesmärgil.
            // ;            -> kõik koodilaused lõppevad komakooloniga, mis tähistavad lause lõppu
            // //           -> tähistab üherealist kommentaari
            // /**/         -> tähistab mitmerealist kommentaari või kommentaariregiooni

            int muutuja = 3;
            // int          -> on muutuja nime ees olev andmetüübi kirjeldus mis näitab ära, millist
            //                 tüüpi andmed selle muutuja sees on.
            // "muutuja"    -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava
            //                 sõnaga, ja mille abil saab neid addresseerida koodi sees.
            // =            -> üksik võrdusmärk omistab muutuja sisse vastava väärtuse mis asub
            //                 teiselpool võrdusmärki.
            // 3            -> muutujale omistatav väärtus.

            /* Võimalikud andmetüübid mida vaja võib minna: */
            int a = 1; // int on täisarv
            decimal b = 2.1M; // decimal on kümnendsüsteemis olev komakohaga arv
            float c = 3.9f; // float on 32-bitine komakohaga arv
            double d = 5.6d; // double on 64-bitine komakohaga arv
            char c1 = 'a'; // üksainus täht või tähemärk mis tähistatakse ülakomadga ''
            string s = "tekst"; //tähtedest koosnev sõna või tekst, tähistatakse jutumärkidega ""
            var x = "abc"; //var on ebamäärase andmetüübiga kohalik muutuja
            var y = 123;   //ta võib omada endas teisi andmetüüpe
            const int z = 9; // konstant-tüüpi muutujaid ei saa muuta, nende sisu on read-only

            //põhilised matemaatilised tehted
            int liitmine = 1 + 1; //liitmine, kaks arvu liidetakse kokku
            int lahutamine = 1 - 1; //lahutamine, kus esimesest arvust lahutatakse maha teine
            double korrutamine = 1 * 2; //korrutamine, kus teine arv korrutatakse esimese arvu kordi.
            double jagamine = 1 / 2; //jagamine. esimene arv jagatakse teise arvuga.
            double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
            double juurimine = Math.Sqrt(2); //ruutjuur, parameetrina juuritav arv

            //muutuja nimed
            int arv = 0; //sobib
            string sõne = "abc"; //sobib
                                 //string string = "abc"; //kaitstud sõna kasutada ei saa

            // muutuja nimeks ei sobi järgnevad sõnad:
            //abstract, as, base, bool, break, byte, case,
            //catch, char, checked, class, count, continue, decimal,
            //default, delegate, do, double, else, enum, event,
            //explicit, extern, false, finally, fixed, float, for
            //foreach, goto, if, implicit, in, int, interface, internal
            //is, lock, long, namespace, new, null, object, operator,
            //out, override, params, private, protected, public, readonly,
            //ref, return, sbyte, sealed, short, sizeof, stackalloc,
            //static, string, struct, switch, this, throw, try, typeof,
            //uint, ulong, unchecked, unsafe, ushort, using, virtual, 
            //void, volatile, while.

            //3 kalkulaator ifi ja elsifidega
            Console.WriteLine("Tere. Sisesta esimene arv");
            //Adresserime moodulit "Console", punkti abil ütleme, et kasutame funktsiooni WriteLine
            //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
            //ümbritsetuna jutumärkidega. Kasutajale esitatav sõnum on "Tere. Sisesta esimene arv".
            //Lause lõppeb lauselõpumärgiga ";".

            int arv1 = int.Parse(Console.ReadLine());
            //instantsieerime muutuja nimega "arv1", ning selle ette anname andmetüübiks "int", see
            //ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            //väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit
            //Aga seekord on funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv programmile
            //tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme
            //ReadLine funktsiooni Parse() sulgude vahele. Lause lõppeb lauselõpumärgiga ";".

            Console.WriteLine("Tere. Sisesta teine arv");
            //Adresserime moodulit "Console", punkti abil ütleme, et kasutame funktsiooni WriteLine
            //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
            //ümbritsetuna jutumärkidega. Kasutajale esitatav sõnum on "Tere. Sisesta teine arv".
            //Lause lõppeb lauselõpumärgiga ";".

            int arv2 = int.Parse(Console.ReadLine());
            //instantsieerime muutuja nimega "arv2", ning selle ette anname andmetüübiks "int", see
            //ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            //väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit
            //Aga seekord on funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv programmile
            //tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme
            //ReadLine funktsiooni Parse() sulgude vahele. Lause lõppeb lauselõpumärgiga ";".

            Console.WriteLine("Sisesta tehtemärk: / * + -");
            //Adresseerime moodulit "Console" koos "WriteLine" funktsiooniga, et esitada kasutajale
            //küsimuse "Sisesta tehtemärk: / * + -". Punkti abil saame moodulist Console, funktsiooni
            //WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
            //jutumärkidega. Lause lõppeb lauselõpumärgiga ";".

            string tehtetyyp = Console.ReadLine();
            //instantsieerime muutuja nimega "tehtetyyp", mille ette kirjutame andmetüübiks "string".
            //Omistame võrdusmärgi abil, sellesse muutujasse kasutajalt sisendi mille saame kasutade
            //"Console" moodulis oleva ReadLine() funktsiooni abil. Lause lõppeb lauselõpumärgiga ";".

            int tulemus = 0;
            //instantsieerime muutuja nimega "tulemus", andmetüübiga int, ning omistame talle algse
            //väärtuse võrdusmärgi abil, milleks on 0. Lause lõppeb lauselõpumärgiga ";".

            if (tehtetyyp == "+")
                //teeme tingimuslause if, ning selle tingimuse määrame ära sulgudega, mille vahel on
                //võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid samal kujul
                //nagu võrdusmärkidest teisel pool olev tekst "+". Siin lause ei lõppe, kuna tegu ei
                //ole koodiga mis midagi kindlalt veel ära teeb.
            {
                tulemus = arv1 + arv2;
            }
            //peale tingimust on koodiplokk {} sulgude vahel, mis sialdab endas ühte koodirida.
            //selles lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse,
            //kus liidame kokku muutuja "arv1" ja muutuja "arv2" sisu. Lause lõppeb lauselõpumärgiga ";".

            else if (tehtetyyp == "-")
                //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
                //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid 
                //samal kujul nagu võrdusmärkidest teisel pool olev tekst "-" kui eelnev tingimus ei
                //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                tulemus = arv1 - arv2;
            }
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil lahutustehte
            //tulemuse, kus lahutame muutuja "arv" sees olevast väärtusest maha "arv2" muutujas
            //oleva väärtuse. Lause lõppeb lauselõpumärgiga ";".

            else if (tehtetyyp == "/")
                //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
                //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
                //samal kujul nagu võrdusmärkidest teisel pool olev tekst "/" kui eelnev tingimus ei
                //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                tulemus = arv1 / arv2;
            }
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil jagamistehte
            //tulemuse, kus jagame muutujas "arv1" oleva väärtuse, muutujas "arv2" oleva jagajaga 
            //Lause lõppeb lauselõpumärgiga ";".

            else if (tehtetyyp == "*")
                //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
                //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
                //samal kujul nagu võrdusmärkidest teisel pool olev tekst "*" kui eelnev tingimus ei
                //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                tulemus = arv1 * arv2;
            }
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil korrutustehte
            //tulemuse, kus korrutame muutujas "arv2" oleva väärtuse muutujas "arv1" oleva väärtuse
            //kordi. Lause lõppeb lauselõpumärgiga ";".
            else if (tehtetyyp == "^")
                //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
                //Sulgude vahel on võrdsuskontroll, kontrollime kas muutuja "tehtetyyp" omab andmeid
                //samal kujul nagu võrdusmärkidest teisel pool olev tekst "^" kui eelnev tingimus ei
                //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                tulemus = (int)Math.Pow(arv1, arv2);
            }
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. Selles lauses omistatakse võrdusmärgi abil muutujasse "tulemus" mille saame
            //"Math" moodulist pärineva funktsiooni "Pow()" abil. Math.Pow() võtab parameetritena
            //sisse muutjad "arv1" ja "arv2". Esimene parameeter on astendatav, teine parameeter
            //on astendaja. Funktsiooni Math.Pow() ees on kiirteisendus (int), kuna muutuja
            //"tulemus" andmetüüp on täisarv. Math.Pow() väljund teisendatakse nii täisarvuks.
            //Lause lõppeb lauselõpumärgiga ";".
            else
                //peale kõiki järeltingimusi on meil tingimuslause osa "else" mida täidetakse kõikide
                //muude tingimuslause osade mittetäitumisel. Siin eraldi tingimust välja ei kirjutada
                //ning sellest tulenevalt ei ole ka sulge. Järgneb ainult koodiplokk.
            {
                Console.WriteLine("Palun sisesta tehe, mida kalkulaator tuvastada oskab");
            }
            //peale "else" on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. Selles koodireas kasutame moodulist "Console" punkti abil funktsiooni
            //"WriteLine" et öelda kasutajale "Palun sisesta tehe, mida kalkulaator tuvastada
            //oskab". Koodirida lõppeb lauselõpumärgiga ";".

            Console.WriteLine(tulemus);
            //Kasutame moodulist "Console" punkti abil funktsiooni "WriteLine" et kuvada kasutajale
            //tehte tulemus. Selle jaoks on WriteLine funktsioonis parameetrina pandud muutuja
            //"tulemus" ilma tekstiks teisendamata. Lause lõppeb lauselõpumärgiga ";".

        }
    }
}
