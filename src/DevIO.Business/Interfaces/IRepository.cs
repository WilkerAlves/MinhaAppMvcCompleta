
using DevIO.Business.Models;
using System;

namespace DevIO.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {

    }
}
