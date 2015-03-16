using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {

        static void Main(string[] args)
        {
            Camion camion = new Camion();
            int taille;
            Random rnd = new Random();
            sbyte variete;//variete 1-2-3
            DateTime dateCueillette;
            sbyte murete;//0-100
            bool contientUnVer;
            bool possedeSaFeuille;
            int range;
            
            //Generation Contenu
            do
            {
                CaisseBananes caisseBanane = new CaisseBananes();
                CaissePommes caissePomme = new CaissePommes();
                CasseauFraises casseauFraise = new CasseauFraises();

            //Bananes
            do
            {
                taille = caisseBanane.getTaille();

                if(taille> 0)
                {
                #region banane
                Banane banane = new Banane();

                variete = sbyte.Parse(Convert.ToString(rnd.Next(0,4)));
                
                dateCueillette = new DateTime(1995, 1, 1);
                range = (DateTime.Today - dateCueillette).Days; 
                dateCueillette = dateCueillette.AddDays(rnd.Next(range));

                murete = sbyte.Parse(Convert.ToString(rnd.Next(0,101)));

                banane.banane(variete,dateCueillette);

                banane.murir(murete);


                #endregion
                }
                

               taille = caisseBanane.getTaille(); //Faire generation au dessus de cette ligne
            }while(taille > 0);

            //Pommes
            do
            {
                taille = caissePomme.getTaille();

                if(taille>0)
                {
                #region Pomme
                Pomme pomme = new Pomme();

                #endregion
                }

                taille = caissePomme.getTaille();

            }while(taille>0);

            //Fraises
            do
            {
                taille = casseauFraise.getTaille();
                
                if(taille>0)
                {
                #region fraise
                #endregion
                }

                taille = casseauFraise.getTaille();
            }while(taille>0);

            }
        }
    }
}
