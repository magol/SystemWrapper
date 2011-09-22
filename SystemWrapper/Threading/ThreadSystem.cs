using System;
using System.Threading;

namespace SystemWrapper.Threading
{
    /// <summary>
    /// Wrapper for static members of <see cref="Thread"/> class.
    /// </summary>
    public class ThreadSystem : IThreadSystem
    {
        /// <inheritdoc />
        public IThreadWrap CurrentThread
        {
            get { return new ThreadWrap(Thread.CurrentThread); }
        }

        /// <inheritdoc />
        public void Sleep(int millisecondsTimeout)
        {
            Thread.Sleep(millisecondsTimeout);
        }

        /// <inheritdoc />
        public void Sleep(TimeSpan timeout)
        {
            Thread.Sleep(timeout);
        }
    }
}