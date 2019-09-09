using System;

namespace RestApiDev.Library.Data.Entity
{
    public class PromotedItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
