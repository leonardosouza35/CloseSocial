using CloseSocial.Application.Interfaces;
using CloseSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace CloseSocial.Application.AppServices
{
    public class AppServiceBase<TEntity> : IDisposable, Interfaces.IServiceBase<TEntity> where TEntity : class
    {
        private readonly Domain.Interfaces.Services.IServiceBase<TEntity> _serviceBase;
        
        public AppServiceBase(Domain.Interfaces.Services.IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity entity)
        {
            _serviceBase.Add(entity);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void Remove(TEntity entity)
        {
            _serviceBase.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _serviceBase.Update(entity);
        }
    }
}
