using System.Globalization;
using System.Threading;

namespace SystemWrapper.Threading
{
    /// <summary>
    /// Wrapper for <see cref="System.Threading.Thread"/> class.
    /// </summary>
    public class ThreadWrap : IThreadWrap
    {
        private global::System.Threading.Thread _thread;

        public ThreadWrap(Thread thread)
        {
            _thread = thread;
        }

        public ThreadWrap(ThreadStart threadStart)
        {
            _thread = new global::System.Threading.Thread(threadStart);
        }

        public ThreadWrap(ParameterizedThreadStart parameterizedThreadStart)
        {
            _thread = new global::System.Threading.Thread(parameterizedThreadStart);
        }

        /// <inheritdoc />
        public CultureInfo CurrentCulture
        {
            get
            {
                return _thread.CurrentCulture;
            }
            set
            {
                _thread.CurrentCulture = value;
            }
        }

        /// <inheritdoc />
        public bool IsAlive
        {
            get { return _thread.IsAlive; }
        }
        /// <inheritdoc />
        public ThreadState ThreadState
        {
            get { return _thread.ThreadState; }
        }
        /// <inheritdoc />
        public bool IsBackground
        {
            get { return _thread.IsBackground; }
            set { _thread.IsBackground = value; }
        }
        /// <inheritdoc />
        public ThreadPriority Priority
        {
            get { return _thread.Priority; }
            set { _thread.Priority = value; }
        }
        /// <inheritdoc />
        public int ManagedThreadId
        {
            get { return _thread.ManagedThreadId; }
        }
        /// <inheritdoc />
        public void Abort()
        {
            _thread.Abort();
        }
        /// <inheritdoc />
        public void SetApartmentState(ApartmentState state)
        {
            _thread.SetApartmentState(state);
        }
        /// <inheritdoc />
        public void Start()
        {
            _thread.Start();
        }
        /// <inheritdoc />
        public void Start(object parameter)
        {
            _thread.Start(parameter);
        }
        /// <inheritdoc />
        public void Join()
        {
            _thread.Join();
        }
    }
}
