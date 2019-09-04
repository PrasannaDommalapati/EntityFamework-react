using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDev.Library.Data
{
    public class UnitOfWork: IDisposable
    {

        private bool Disposed;

        protected IDataContext DataContext { get; }

        public UnitOfWork(IDataContext dataContext)
        {
            DataContext = dataContext.ValidateForNotNull();
        }

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
