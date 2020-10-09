using System;

namespace Core.Domain.Entities
{
    public partial class Communication
    {
        public DateTimeOffset? DateSent { get; set; }

        public string From { get; set; }

        public int Id { get; set; }

        public string Message { get; set; }

        public string Subject { get; set; }

        public string To { get; set; }
    }
}