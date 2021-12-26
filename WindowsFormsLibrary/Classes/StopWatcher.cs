using System;
using System.Diagnostics;

namespace WindowsFormsLibrary.Classes
{
    /// <summary>
    /// Single instance class for a StopWatch useful for validating elapsed time
    /// from a single instance.
    /// </summary>
    public sealed class StopWatcher
    {
        /// <summary>
        /// Creates a thread safe instance of this class
        /// </summary>
        private static readonly Lazy<StopWatcher> Lazy = new(() => new StopWatcher());

        /// <summary>
        /// StopWatch for measuring time.
        /// </summary>
        private readonly Stopwatch _stopwatch;

        /// <summary>
        /// Inaccessible constructor
        /// </summary>
        private StopWatcher()
        {
            _stopwatch = new Stopwatch();
        }

        /// <summary>
        /// Start timer
        /// </summary>
        /// <remarks>
        /// First reset the stop watch to get fresh calculations
        /// </remarks>
        public void Start()
        {
            _stopwatch.Reset();
            _stopwatch.Start();
        }

        /// <summary>
        /// Stop for measuring stop watch Elapsed time
        /// </summary>
        public void Stop() => _stopwatch.Stop();

        /// <summary>
        /// Get elapsed time as a TimeSpan
        /// </summary>
        public TimeSpan Elapsed
        {
            get
            {
                Stop();
                return _stopwatch.Elapsed;
            }
        }

        /// <summary>
        /// Format elapsed time to minutes, seconds, milliseconds
        /// </summary>
        public string ElapsedFormatted
        {
            get
            {
                Stop();
                return Elapsed.ToString("mm\\:ss\\.fff");
            }
        }

        /// <summary>
        /// Access point to methods and properties
        /// </summary>
        public static StopWatcher Instance => Lazy.Value;

    }
}
