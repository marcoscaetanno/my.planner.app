using System;
using my.planner.domain.models;

namespace my.planner.domain.DTOs
{
    public class EventDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public RecurringEvent RecurringEvent { get; set; }
        public DateTime Alert { get; set; }
        public string Local { get; set; }
    }
}