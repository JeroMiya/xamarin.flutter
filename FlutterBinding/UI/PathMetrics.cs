using System.Collections.Generic;

namespace FlutterBinding.UI
{
    /// <summary>
    /// An iterable collection of [PathMetric] objects describing a [Path].
    ///
    /// A [PathMetrics] object is created by using the [Path.computeMetrics] method,
    /// and represents the path as it stood at the time of the call. Subsequent
    /// modifications of the path do not affect the [PathMetrics] object.
    ///
    /// Each path metric corresponds to a segment, or contour, of a path.
    ///
    /// For example, a path consisting of a [Path.lineTo], a [Path.moveTo], and
    /// another [Path.lineTo] will contain two contours and thus be represented by
    /// two [PathMetric] objects.
    ///
    /// When iterating across a [PathMetrics]' contours, the [PathMetric] objects are only
    /// valid until the next one is obtained.
    /// </summary>
    public class PathMetrics : List<PathMetric>
    {
        internal PathMetrics(Path path, bool forceClosed)
        {
            _pathMetricIterator = new PathMetricIterator(new PathMetric(path, forceClosed));
        }

        private readonly PathMetricIterator _pathMetricIterator;
        public IEnumerable<PathMetric> Iterator => _pathMetricIterator;
    }
}