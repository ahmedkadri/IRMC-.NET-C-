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
     public class QuestionServices : Service<question>, IQuestionServices
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public QuestionServices():base(ut)
        {

        }

    }
}
