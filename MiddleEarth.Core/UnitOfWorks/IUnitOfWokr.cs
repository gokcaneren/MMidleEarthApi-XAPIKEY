using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Core.UnitOfWorks
{
    public interface IUnitOfWokr
    {
        Task CommitAsync();
        void Commit();
    }
}
