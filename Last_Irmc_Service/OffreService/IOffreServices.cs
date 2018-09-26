using Last_Irmc_Domain;
using Last_Irmc_SPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Irmc_Service.OffreService
{
    public interface IOffreServices : IService<offre>
    {
        int getstatTraining();
        int getstatScholarship();
        int getstatEmpl();
    }
}
