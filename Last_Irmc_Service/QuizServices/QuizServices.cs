using Last_Irmc_DATA.Infrastructure;
using Last_Irmc_Domain;
using Last_Irmc_SPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Irmc_Service.QuizServices
{
    public class QuizServices : Service<quiz>, IQuizServices
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public QuizServices():base(ut)
        {
                
        }

        IEnumerable<question> IQuizServices.getthequestion(int id)
        {
            return ut.getRepository<question>().GetAll().Where(x => x.quiz3_quiz_id == id);
        }

        public bool ifexiste(string nom)
        {
            var liste = ut.getRepository<quiz>().GetAll();
            foreach (var item in liste)
            {
                if (item.quiz_nom.Equals(nom))
                 {
                    return true;
                    }
            }
            return false;

        }

        public quiz getbyname(string nom)
        {
            var liste = ut.getRepository<quiz>().GetAll();
            foreach (var item in liste)
            {
                if (item.quiz_nom.Equals(nom))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
