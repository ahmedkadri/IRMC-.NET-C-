using Last_Irmc_DATA.Infrastructure;
using Last_Irmc_Domain;
using Last_Irmc_SPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Irmc_Service.OffreService
{
   public class OffreServices : Service<offre>, IOffreServices
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);
        public OffreServices() : base(ut)
        {
        }

        public int getstatEmpl()
        {
            var listeoffre = ut.getRepository<offre>().GetAll();

            int x = listeoffre.Count();
            int nbreemp = 0;
            foreach (var item in listeoffre)
            {
                if (item.offretype.Equals("Employment"))
                {
                    nbreemp++;
                   
                }
            }
            return nbreemp ;

        }

        public int getstatScholarship()
        {
            var listeoffre = ut.getRepository<offre>().GetAll();

            int x = listeoffre.Count();
            int nbreemp = 0;
            foreach (var item in listeoffre)
            {
                if (item.offretype.Equals("Scholarship"))
                {
                    nbreemp++;

                }
            }
            return nbreemp ;
        }

        public int getstatTraining()
        {
            var listeoffre = ut.getRepository<offre>().GetAll();

            int x = listeoffre.Count();
            int nbreemp = 0;
            foreach (var item in listeoffre)
            {
                if (item.offretype.Equals("Training"))
                {
                    nbreemp++;

                }
            }
            return nbreemp ;
        }
    }
}
