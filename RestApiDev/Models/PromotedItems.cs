using System;

namespace RestApiDev.Models
{
    public class PromotedItems
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }

        public DateTime EndDate { get; set; }
    }
}
