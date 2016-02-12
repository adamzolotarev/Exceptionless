using System;
using System.Collections.Generic;

namespace Exceptionless.Core.Models.Stats {
    public class NumbersTimelineStatsResult : NumbersStatsResult {
        public NumbersTimelineStatsResult() {
            Timeline = new List<NumbersTimelineItem>();
        }

        public ICollection<NumbersTimelineItem> Timeline { get; private set; }
        public DateTime FirstOccurrence { get; set; }
        public DateTime LastOccurrence { get; set; }
    }
}