using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Iseu.Core.Interfaces
{
    public interface ISaveable : IDisposable
    {
        void SaveChanges();
    }
}
