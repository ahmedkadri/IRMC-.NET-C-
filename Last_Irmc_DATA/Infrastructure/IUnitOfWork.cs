using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Irmc_DATA.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        IRepository<T> getRepository<T>() where T : class;
    }

}

