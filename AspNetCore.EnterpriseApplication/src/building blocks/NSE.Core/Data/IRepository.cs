using NSE.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSE.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
    }
}
