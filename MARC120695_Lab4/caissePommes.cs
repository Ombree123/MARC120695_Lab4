﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class CaissePommes
    {
        private Pomme[] lesPommes = new Pomme[100];
        private DateTime dateEmpaquetage;
        private int taille=100;
        private int espaceInterieur = 100;

        public bool ajouterPomme(Pomme pomme)
        {
            if (espaceInterieur-- > 0)
            {
                lesPommes[(lesPommes.Count((s => s != null)))] = pomme;
                dateEmpaquetage = DateTime.Today;
                return (true);
            }
            else
            {
                return (false);
            }
                
        }

        public void ajouterPomme(Pomme[] pomme)
        {
            if (espaceInterieur >= pomme.Count(s => s != null))
            {
                Pomme[] lesPommesTemp = new Pomme[lesPommes.Length + pomme.Length];
                Array.Copy(lesPommes, lesPommesTemp, 0);
                Array.Copy(pomme, 0, lesPommesTemp, lesPommes.Length, pomme.Length);

                lesPommes = lesPommesTemp;

                espaceInterieur = espaceInterieur - pomme.Count(s => s != null);
            }
            else
                Console.WriteLine("ERREUR : Surcharge");  
        }

        public void caissePommes()
        {

        }

        public void caissePommes (int taille)
        {
            bool verification = false;

            if (taille <=100 && taille > 0)
            {
                this.taille = taille;
                espaceInterieur = this.taille;
            }
            else
                do
                {
                    Console.WriteLine("ERREUR taille invalide, veuillez la réentrer");
                    verification = int.TryParse(Console.ReadLine(), out taille);
                    if (taille <= 0 && taille > 100 && verification)
                        verification = false;
                    else
                        espaceInterieur = this.taille;
                }
                while (!verification);

            Array.Resize(ref lesPommes, taille);
        }

        public void caissePommes(Pomme[] pomme, int taille)
        {
            bool verification = false;

            if (taille <= 100 && taille > 0)
            {
                this.taille = taille;
                espaceInterieur = taille;
            }
            else
                do
                {
                    Console.WriteLine("ERREUR taille invalide, veuillez la réentrer");
                    verification = int.TryParse(Console.ReadLine(), out taille);
                    if (taille <= 0 && taille > 100 && verification)
                        verification = false;
                    else
                        espaceInterieur = taille;
                }
                while (!verification);

            if (taille >= pomme.Count(s => s != null))
                lesPommes = pomme;
            else
                Console.WriteLine("ERREUR : Surcharge");
        }

        public void caissePommes(CaissePommes caissePommes)
        {
            dateEmpaquetage = caissePommes.dateEmpaquetage;
            taille = caissePommes.taille;
            espaceInterieur = caissePommes.espaceInterieur;
            lesPommes = caissePommes.lesPommes;
        }

        public void viderDeSesPommes()
        {
            lesPommes = new Pomme[taille];
            espaceInterieur = taille;
        }

        public int getTaille()
        {
            return(taille);
        }

        public string afficherDescription()
        {
            espaceInterieur = taille - lesPommes.Count(s => s != null);
            return ("La date d'empaquetage est le " + dateEmpaquetage + " il y a de la place total pour " + taille + " pommes et son espace interieur est de " + espaceInterieur + " pommes");
        }
    }
}
