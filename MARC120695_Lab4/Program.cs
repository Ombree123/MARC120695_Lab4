﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        //Le programe ne marche pas à cause de GetTaille.  Suggestion : Modelisé, Méthodes dans Program.cs, ne pas vérifier taille dans 

        public Banane creerBanane()
        {
            Random rnd = new Random();
            sbyte variete;//variete 1-2-3
            DateTime dateCueillette;
            sbyte murete;//0-100
            int range;

            Banane banane = new Banane();

            //Variete aléatoire
            variete = sbyte.Parse(Convert.ToString(rnd.Next(1, 4)));

            //Date Aléatoire
            dateCueillette = new DateTime(1995, 1, 1);
            range = (DateTime.Today - dateCueillette).Days;
            dateCueillette = dateCueillette.AddDays(rnd.Next(range));

            //Murete Aléatoire
            murete = sbyte.Parse(Convert.ToString(rnd.Next(1, 101)));

            banane.banane(variete, dateCueillette);

            banane.murir(murete);

            return (banane);
        }

        public Pomme creerPomme()
        {
            Random rnd = new Random();
            sbyte variete;//variete 1-2-3
            DateTime dateCueillette;
            sbyte murete;//0-100
            int range;
            bool contientUnVer = false;

            Pomme pomme = new Pomme();

            //Variete aléatoire
            variete = sbyte.Parse(Convert.ToString(rnd.Next(1, 4)));

            //Date Aléatoire
            dateCueillette = new DateTime(1995, 1, 1);
            range = (DateTime.Today - dateCueillette).Days;
            dateCueillette = dateCueillette.AddDays(rnd.Next(range));

            //Murete Aléatoire
            murete = sbyte.Parse(Convert.ToString(rnd.Next(1, 101)));

            //contientUnVer Aléatoire
            range = rnd.Next(1, 3);

            if (range == 2)
                pomme.unVerSiInfiltre();

            pomme.pomme(variete, dateCueillette, contientUnVer, murete);



            return (pomme);

            
        }

        public Fraise creerFraise()
        {
            Random rnd = new Random();
            sbyte variete;
            DateTime dateCueillette;
            sbyte murete;
            int range;
            bool possedeSaFeuille=true;

            Fraise fraise = new Fraise();

            //Variete aléatoire
            variete = sbyte.Parse(Convert.ToString(rnd.Next(1, 4)));

            //Date Aléatoire
            dateCueillette = new DateTime(1995, 1, 1);
            range = (DateTime.Today - dateCueillette).Days;
            dateCueillette = dateCueillette.AddDays(rnd.Next(range));

            //Murete Aléatoire
            murete = sbyte.Parse(Convert.ToString(rnd.Next(1, 101)));

            //Possede sa feuille Aléatoire
            range = rnd.Next(1, 3);

            if (range == 2)
                fraise.arracherFeuille();

            fraise.fraise(variete, dateCueillette, possedeSaFeuille);
            fraise.setMurete(murete);

            return (fraise);

        }

        public CaisseBananes caisseB()
        {
            Random rnd = new Random();

        }


        static void Main(string[] args)
        {
            
        }
      }
   }

