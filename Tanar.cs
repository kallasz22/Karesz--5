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
        string betöltendő_pálya = "palya_01_Mat.txt";

        void TANÁR_ROBOTJAI()
        {
            new Robot("Karesz", 0, 0, 0, 0, 1, 2, 28, 0);


            Robot janesz = new Robot("Janesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 7, 8, 2);

            janesz.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    janesz.Lőjj();
                    janesz.Várj();
                    janesz.Várj();
                    janesz.Várj();
                    janesz.Várj();
                    janesz.Várj();
                    janesz.Várj();
                }               
            };

            Robot anti = new Robot("Anti", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 18, 12, 0);

            anti.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    anti.Lőjj();
                    anti.Várj();
                    anti.Várj();
                    anti.Várj();
                    anti.Várj();
                }   
            };

            Robot gagyi = new Robot("Gagyi", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 16, 12, 0);

            gagyi.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    gagyi.Lőjj();
                    gagyi.Várj();
                    gagyi.Várj();
                    gagyi.Várj();
                    gagyi.Várj();
                }   
            };

            Robot zsici = new Robot("Zsici", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 20, 12, 0);

            zsici.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    zsici.Lőjj();
                    zsici.Várj();
                    zsici.Várj();
                    zsici.Várj();
                    zsici.Várj();
                }   
            };

            Robot imi = new Robot("Imi", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 25, 6, 3);
            
            imi.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    imi.Lőjj();
                    imi.Várj();
                    imi.Várj();
                    imi.Várj();
                    imi.Várj();
                }   
            };

            Robot laccci = new Robot("Laccci", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 29, 23, 0);

            laccci.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    laccci.Lőjj();
                    laccci.Várj();
                    laccci.Várj();
                    laccci.Várj();
                    laccci.Várj();
                    laccci.Várj();
                    laccci.Várj();
                    laccci.Várj();
                    laccci.Várj();

                }   
            };

            Robot gucci = new Robot("Gucci", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 31, 28, 3);

            gucci.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    gucci.Lőjj();
                    gucci.Várj();
                    gucci.Várj();
                    gucci.Várj();
                    gucci.Várj();


                }   
            };
            
        }
    }
}