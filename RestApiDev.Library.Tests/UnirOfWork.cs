using RestApiDev.Library.Data;
using System;

namespace RestApiDev.Library.Tests
{
    public class UnitOfWork : IDisposable
    {
        protected UnitOfWork(IDataContext dataContext)
        {
            DataContext = dataContext.ValidateForNotNull();
        }

        private bool Disposed;

        protected IDataContext DataContext { get; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    DataContext.Dispose();
                }
                Disposed = true;
            }
        }
    }
}