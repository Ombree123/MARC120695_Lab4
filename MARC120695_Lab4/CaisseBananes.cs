using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class CaisseBananes
    {
        private DateTime dateEmpaquetage;
        private int taille=100;
        private int espaceInterieur= 100;
        private Banane[] lesBananes = new Banane[100];

        public bool ajouterBanane(Banane banane)
        {
            if (espaceInterieur-- > 0)
            {
                lesBananes[(lesBananes.Count((s => s != null)))] = banane;
                dateEmpaquetage = DateTime.Today;
                return (true);
            }
            else
            {
                return (false);
            }   
        }

        public void ajouterBanane(Banane[] banane)
        {
            if (espaceInterieur >= banane.Count(s => s != null))
            {
                Banane[] lesBananesTemp = new Banane[lesBananes.Length + banane.Length];
                Array.Copy(lesBananes, lesBananesTemp, 0);
                Array.Copy(banane, 0, lesBananesTemp, lesBananes.Length, banane.Length);

                lesBananes = lesBananesTemp;

                espaceInterieur = espaceInterieur - banane.Count(s => s != null);
            }
            else
                Console.WriteLine("ERREUR : Surcharge");
            
        }

        public void caisseBananes()
        {

        }

        public void caisseBananes(int taille)
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

            Array.Resize(ref lesBananes, taille);
        }

        public void caisseBananes(Banane[] banane, int taille)
        {
            bool verification = false;

            if (taille <= 100 && taille > 0)
            {
                this.taille = taille;
                
            }
            else
                do
                {
                    Console.WriteLine("ERREUR taille invalide, veuillez la réentrer");
                    verification = int.TryParse(Console.ReadLine(), out taille);
                    if (taille <= 0 && taille > 100 && verification)
                        verification = false;
                    else
                        this.taille = espaceInterieur;
                }
                while (!verification);
            if (taille >= banane.Count(s => s != null))
                lesBananes = banane;
            else
                Console.WriteLine("ERREUR : Surcharge");
        }

        public void caisseBananes(CaisseBananes caisseBananes)
        {
            dateEmpaquetage = caisseBananes.dateEmpaquetage;
            taille = caisseBananes.taille;
            espaceInterieur = caisseBananes.espaceInterieur;
            lesBananes = caisseBananes.lesBananes;
        }

        public void viderDeSesBananes()
        {
            this.lesBananes = new Banane[taille]; 
            espaceInterieur = taille;
        }

        public int getTaille()
        {
            return (taille);
        }

        public string afficherDescription()
        {
            espaceInterieur = taille - lesBananes.Count(s => s != null);
            return ("La date d'empaquetage est le "+dateEmpaquetage+" il y a de la place total pour "+taille+" bananes et son espace interieur est de "+espaceInterieur+" bananes");
        }


    }
}
