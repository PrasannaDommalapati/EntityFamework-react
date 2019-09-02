using System;

namespace RestApiDev.Library.Data.Entity
{
    public class FinishedItems
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }

        public DateTime FinishedDate { get; set; }
    }
}
