

using Last_Irmc_DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Irmc_DATA.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private IrmcContext dataContext;
        public IrmcContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new IrmcContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }
}
