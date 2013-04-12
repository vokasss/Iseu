using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;

namespace Iseu.Core.Interfaces
{
    public interface IObjectContext : ISaveable
    {
        IObjectSet<T> CreateObjectSet<T>() where T : class;
        T CreateObject<T>() where T : class;
        void SaveChanges();
    }
}
