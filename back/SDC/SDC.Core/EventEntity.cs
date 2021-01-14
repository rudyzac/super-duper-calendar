using System;

namespace SDC.Core
{
    public class EventEntity
    {
        public Guid Id { get; }
        public string Title { get; private set; }

        public EventEntity(Guid id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}