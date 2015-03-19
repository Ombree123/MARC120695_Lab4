using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static Banane creerBanane()
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

        static Pomme creerPomme()
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

        static Fraise creerFraise()
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

        static CaisseBananes caisseB()
        {
            bool verification=true;

            Random rnd = new Random();

            CaisseBananes caisseBananes = new CaisseBananes();

            //Taille Aléatoire
            caisseBananes.caisseBananes(rnd.Next(20, 101));

            do
            {
              verification = caisseBananes.ajouterBanane(creerBanane());
            } while (verification);

            return (caisseBananes);
        }

        static CaissePommes caisseP()
        {
            bool verification = true;

            Random rnd = new Random();

            CaissePommes caissePomme = new CaissePommes();

            //Taille Aléatoire
            caissePomme.caissePommes(rnd.Next(20, 101));

            do
            {
                verification = caissePomme.ajouterPomme(creerPomme());

            } while (verification);

            return (caissePomme);
        }

        static CasseauFraises cassF()
        {
            bool verification = true;

            Random rnd = new Random();

            CasseauFraises casseauFraise = new CasseauFraises();

            //Taille Aléatoire
            casseauFraise.casseauFraises(rnd.Next(20, 101));

            do
            {
                verification = casseauFraise.ajouterFraise(creerFraise());
            } while (verification);

            return (casseauFraise);
        }

        static void Main(string[] args)
        {
            bool verification = true;
            Random rnd = new Random();
            Camion camion = new Camion();

           //Remplir Camion

            do
            {
                switch (1)                   //a rechanger pour rnd.Next(1,4)
                {
                    case 1:
                        {
                            verification = camion.charger(caisseB());
                            break;
                        }
                    case 2:
                        {
                            verification = camion.charger(caisseP());
                            break;
                        }
                    case 3:
                        {
                            verification = camion.charger(caisseP());
                            break;
                        }

                }
            } while (verification);
            
            
            

        }
      }
   }

