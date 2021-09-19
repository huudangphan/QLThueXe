using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLThueXe.Services.Interfaces;
namespace QLThueXe
{
    public interface IUnitOfWork: IDisposable
    {
        ITest test { get; }
    }
}
