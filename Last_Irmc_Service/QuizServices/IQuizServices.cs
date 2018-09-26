using Last_Irmc_Domain;
using Last_Irmc_SPattern;
using System.Collections.Generic;

namespace Last_Irmc_Service.QuizServices
{
    public interface IQuizServices : IService<quiz>
    {
        IEnumerable<question> getthequestion(int id);
         bool ifexiste(string nom);
        quiz getbyname(string nom);
    }
}