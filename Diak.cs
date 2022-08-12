using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Karesz
{
    public partial class Form1 : Form
    {
        void DIÁK_ROBOTJAI()
        {
            Robot karesz = Robot.Get("Karesz");

            karesz.Feladat = delegate ()
            {
                Lépj();
                Lépj();
                //Lépj();

                Fordulj(jobbra);

                for (int i = 0; i < 8; i++)
                {
                    Lépj();
                }

                Fordulj(balra);

                for (int i = 0; i < 7; i++)
                {
                    Lépj();
                }

                Fordulj(balra);

                Lépj();
                Lépj();

                /*while (karesz.UltrahangSzenzor() == 2)
                {
                    karesz.Várj();
                }

                Lépj();
                Vegyél_fel_egy_kavicsot();*/

                for (int i = 0; i < 10; i++)
                {
                    while (karesz.UltrahangSzenzor() == 2)
                    {
                        karesz.Várj();
                    }

                    Lépj();
                    Vegyél_fel_egy_kavicsot();
                    Fordulj(jobbra);
                    Fordulj(jobbra);
                    Lépj();
                    Fordulj(jobbra);
                    Fordulj(jobbra);
                }
                Lépj();
                Fordulj(jobbra);

                karesz.Lőjj();
                karesz.Várj();
                Lépj();
                Lépj();
                Fordulj(jobbra);
                Lépj();
                Fordulj(jobbra);
                Fordulj(jobbra);

                while (karesz.UltrahangSzenzor() == 2)
                {
                    karesz.Várj();
                }

                Lépj();
                Fordulj(jobbra);
                karesz.Lőjj();
                karesz.Várj();
                Lépj();
                Lépj();
                Fordulj(balra);
                Lépj();
                Fordulj(jobbra);
                Fordulj(jobbra);

                while (karesz.UltrahangSzenzor() == 2)
                {
                    karesz.Várj();
                }

                Lépj();
                Fordulj(balra);
                karesz.Lőjj();
                karesz.Várj();
                Lépj();
                Lépj();
                Fordulj(jobbra);
                Lépj();
                Fordulj(balra);
                Fordulj(balra);

                while (karesz.UltrahangSzenzor() == 2)
                {
                    karesz.Várj();
                }

                Lépj();
                Fordulj(jobbra);
                karesz.Lőjj();
                karesz.Várj();
                Lépj();
                Lépj();
                Lépj();
                Fordulj(balra);
                Lépj();
                for (int i = 0; i < 2; i++)
                {
                    Lépj();
                    Lépj();
                    Fordulj(jobbra);
                }
                karesz.Lőjj();
                karesz.Várj();
                Lépj();
                Lépj();
                Lépj();
                Fordulj(balra);
                for (int i = 0; i < 5; i++)
                {
                    Lépj();
                }
                Fordulj(jobbra);

                for (int i = 0; i < 8; i++)
                {
                    Lépj();
                }

                for (int i = 0; i < 3; i++)
                {
                    while (karesz.UltrahangSzenzor() > 1)
                    {
                        karesz.Várj();
                    }

                    Lépj();
                    Lépj();
                }

                for (int i = 0; i < 5; i++)
                {
                    Lépj();
                }

                Fordulj(jobbra);

                for (int i = 0; i < 3; i++)
                {
                    Lépj();
                }

                Fordulj(balra);

                for (int i = 0; i < 3; i++)
                {
                    Lépj();
                }

                Fordulj(jobbra);

                for (int i = 0; i < 3; i++)
                {
                    Lépj();
                }
                Fordulj(balra);

                /*Lépj();
                Lépj();
                Fordulj(balra);*/

                Lépj();
                Lépj();
                Fordulj(jobbra);

                Lépj();
                Lépj();
                Fordulj(jobbra);

                Lépj();
                Lépj();
                Fordulj(balra);

                Lépj();
                Lépj();
                Fordulj(balra);

                Lépj();
                Lépj();
                Fordulj(jobbra);

                Lépj();
                Lépj();
                Fordulj(jobbra);

                Lépj();

                while (karesz.UltrahangSzenzor() == 2)
                {
                    karesz.Várj();
                }
                Lépj();
                Fordulj(balra);

                for (int i = 0; i < 3; i++)
                {
                    karesz.Lőjj();
                    karesz.Várj();
                    Lépj();
                    Lépj();
                }
                karesz.Lőjj();
                karesz.Várj();
                Lépj();
                Lépj();
                Fordulj(jobbra);

                for (int i = 0; i < 2; i++)
                {
                    Lépj();
                    Lépj();
                    Fordulj(balra);
                }

                Lépj();
                Lépj();
                Fordulj(jobbra);

                Lépj();
                Lépj();

                Fordulj(jobbra);
                Lépj();
                Lépj();
                int irany = balra;
                for (int i = 0; i < 3; i++)
                {
                    Vegyél_fel_egy_kavicsot();
                    Lépj();
                    Vegyél_fel_egy_kavicsot();
                    Lépj();
                    Vegyél_fel_egy_kavicsot();

                    if (i != 2)
                    {
                        Fordulj(irany);
                        Lépj();
                        Fordulj(irany);
                        irany = -irany;
                    }
                    
                }

                Fordulj(jobbra);
                Fordulj(jobbra);
                for (int i = 0; i < 6; i++)
                {
                    Lépj();
                }
                Fordulj(balra);
                karesz.Lőjj();

                Lépj();
                Fordulj(balra);
                Lépj();
                Vegyél_fel_egy_kavicsot();
            };
        }
    }
}

/* LEGFONTOSABB PARANCSOK

MOZGÁSOK

karesz.Lépj();                          -------- Karesz előre lép egyet.
karesz.Fordulj(jobbra);                 -------- Karesz jobbra fordul.
karesz.Fordulj(balra);                  -------- Karesz balra fordul.
karesz.Vegyél_fel_egy_kavicsot();       -------- Karesz felvesz egy kavicsot.
karesz.Tegyél_le_egy_kavicsot();        -------- Karesz letesz egy fekete kavicsot
karesz.Tegyél_le_egy_kavicsot(piros);   -------- Karesz letesz egy piros kavicsot.

Minden mozgás után a robot köre véget ér és a következő robot jön. 



SZENZOROK

karesz.Előtt_fal_van();                 -------- igaz, ha Karesz fal előtt áll, egyébként hamis.
karesz.Ki_fog_lépni_a_pályáról();       -------- igaz, ha Karesz a pálya szélén kifele néz, egyébként hamis.
karesz.Alatt_van_kavics();              -------- igaz, ha Karesz épp kavicson áll, egyébként hamis.
karesz.Köveinek_száma_ebből(piros)      -------- Karesz piros köveinek a száma.
karesz.Alatt_ez_van();                  -------- a kavics színe, amin Karesz áll. (Ez igazából egy szám!)
karesz.UltrahangSzenzor();              -------- a Karesz előtt található tárgy távolsága. Ez a tárgy lehet fal vagy másik robot is. 
karesz.SzélesUltrahangSzenzor();        -------- ugyanaz, mint az ultrahangszenzor, de ez nem csak a Karesz előtti mezőket pásztázza, hanem a szomszédos mezőket is. Egy számhármast ad vissza. 
karesz.Hőmérő();                        -------- a Karesz által mért hőmérséklet. A láva forrása 1000 fok, amitől lépésenként távolodva a hőmérséklet 200 fokonként hűl. Az alapértelmezett hőmérséklet 0 fok.

A szenzorokat bármennyiszer használhatja a robot a saját körén belül.

*/