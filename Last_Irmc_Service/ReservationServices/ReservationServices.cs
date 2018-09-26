using Last_Irmc_DATA.Infrastructure;
using Last_Irmc_Domain;
using Last_Irmc_SPattern;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Irmc_Service.ReservationServices
{
    public class ReservationServices : Service<reservation>, IReservationServices
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);
        public ReservationServices() : base(ut)
        {
        }



        public int GetPlaces(string ReservationDate)
        {

            int rst =2;
            var liste = ut.getRepository<reservation>().GetAll();
        
            foreach (var item in liste)
            {
               

                if (item.reservationDate.Equals(ReservationDate))
                {
                    rst--;
                    return rst;
                }
            }


            return rst;
        }

        public bool ValidReservation(string ReservationDate)



        {


            DateTime oDate = DateTime.ParseExact(ReservationDate, "dd/mm/yyyy", null);


         
            var x = (oDate - DateTime.Now).TotalDays;
            if (x<2)
            {
                return false;
            }
            return true;
        }
    }
}
