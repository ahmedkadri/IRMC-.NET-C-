
using Last_Irmc_DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Irmc_DATA.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        IrmcContext DataContext { get; }
    }
}
