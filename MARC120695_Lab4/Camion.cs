using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Camion
    {
        private double tailleCoffre=10000, tailleLibre=10000;
        private CaisseBananes[] contenuBananes = new CaisseBananes[10000];
        private CaissePommes[] contenuPommes = new CaissePommes[10000];
        private CasseauFraises[] contenuFraises = new CasseauFraises[10000];

        public bool charger(CaisseBananes caisse)
        {
            if ((tailleLibre - caisse.getTaille()) >= 0)
            {
                contenuBananes[(contenuBananes.Count((s => s != null))) ] = caisse;
                tailleLibre = tailleLibre - caisse.getTaille();
                return (true);
            }
            else
            {
                return (false);
            }
                
            
        }

        public bool charger(CaisseBananes[] caisses)
        {
            double tailleCharge=0;

            for (int i = 0; i < caisses.Count(s => s != null); i++)
            {
                tailleCharge = tailleCharge + caisses[i].getTaille();
            }

            if ((tailleLibre - tailleCharge) >= 0)
            {
                contenuBananes = caisses;
                return (true);
            }
            else
            {
                return (false);
            }
                
        }

        public bool charger(CaissePommes caisse)
        {
            if ((tailleLibre - caisse.getTaille()) >= 0)
            {
                contenuPommes[contenuPommes.Count(s => s != null)] = caisse;
                tailleLibre = tailleLibre - caisse.getTaille();
                return (true);
            }
            else
            {
                return (false);
            }    
        }

        public bool charger(CaissePommes[] caisses)
        {
            double tailleCharge = 0;

            for (int i = 0; i < caisses.Count(s => s != null); i++)
            {
                tailleCharge = tailleCharge + caisses[i].getTaille();
            }

            if ((tailleLibre - tailleCharge) >= 0)
            {
                contenuPommes = caisses;
                return (true);
            }
                
            else
            {
                return (false);
            }
                
        }

        public bool charger(CasseauFraises casseau)
        {
            if ((tailleLibre - casseau.getTaille()) >= 0)
            {
                contenuFraises[contenuFraises.Count(s => s != null)] = casseau;
                tailleLibre = tailleLibre - casseau.getTaille();
                return (true);
            }
            else
            {
                return (false);
            }
                
        }

        public bool charger(CasseauFraises[] casseaux)
        {
            double tailleCharge = 0;

            for (int i = 0; i < casseaux.Count(s => s != null); i++)
            {
                tailleCharge = tailleCharge + casseaux[i].getTaille();
            }

            if ((tailleLibre - tailleCharge) >= 0)
            {
                contenuFraises = casseaux;
                return (true);
            }
                
            else
            {
                return (false);
            }     
        }

        public void dechargerPommes()
        {
            double tailleCharge = 0;

            for (int i = 0; i < contenuPommes.Count(s => s != null); i++)
            {
                tailleCharge = tailleCharge + contenuPommes[i].getTaille();
            }

            tailleLibre = tailleLibre + tailleCharge;

            contenuPommes = null;

        }

        public void dechargerBananes()
        {
            double tailleCharge = 0;

            for (int i = 0; i < contenuBananes.Count(s => s != null); i++)
            {
                tailleCharge = tailleCharge + contenuBananes[i].getTaille();
            }

            tailleLibre = tailleLibre + tailleCharge;

            contenuBananes = null;
        }

        public void dechargerFraises()
        {
            double tailleCharge = 0;

            for (int i = 0; i < contenuFraises.Count(s => s != null); i++)
            {
                tailleCharge = tailleCharge + contenuFraises[i].getTaille();
            }

            tailleLibre = tailleLibre + tailleCharge;

            contenuFraises = null;
        }

        public string afficherDescription()
        {
            return ("Le camion a une taille de "+tailleCoffre+" et "+tailleLibre+"d'espace libre.");
        }
    }
}
