using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using Iseu.Core.Interfaces;

namespace Iseu.Core.Repositories
{
    public class StudentsRepository : Repository<Student>, IStudentsRepository
    {
        public StudentsRepository(IObjectContext context)
            : base(context)
        {

        }
    }

    public interface IStudentsRepository : IRepository<Student>
    {
    }
}
