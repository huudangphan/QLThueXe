using QLThueXe.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Services.Repositor;

namespace QLThueXe
{
    public class UnitOfWork : IUnitOfWork
    {
        ITest IUnitOfWork.test => new TestRe();

        

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
