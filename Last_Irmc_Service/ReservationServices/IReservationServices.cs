using Last_Irmc_Domain;
using Last_Irmc_SPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Irmc_Service.ReservationServices
{
   public interface IReservationServices : IService<reservation>
    {
         int GetPlaces(string ReservationDate);
        bool ValidReservation(string ReservationDate);
    }
}
