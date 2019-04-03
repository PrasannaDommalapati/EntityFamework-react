using System;

namespace RestApiDev.Library.Models
{
    public class PromotionModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }
    }
}
