using System.Collections.Generic;

namespace FlutterBinding.UI
{
    /// Tracks iteration from one segment of a path to the next for measurement.
    public class PathMetricIterator : List<PathMetric>
    {
        internal PathMetricIterator(PathMetric pathMetric)
        {
            _pathMetric = pathMetric;
        }

        private PathMetric _pathMetric;
        private bool _firstTime = true;

        public PathMetric Current => _firstTime ? null : _pathMetric;

        public bool MoveNext()
        {
            // PathMetric isn't a normal iterable - it's already initialized to its
            // first Path.  Should only call MoveNext when done with the first one.
            if (_firstTime)
            {
                _firstTime = false;
                return true;
            }
            if (_pathMetric?.MoveNext() == true)
                return true;

            _pathMetric = null;
            return false;
        }
    }
}