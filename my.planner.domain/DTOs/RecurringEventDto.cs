using my.planner.domain.enums;

namespace my.planner.domain.DTOs
{
    public class RecurringEventDto
    {
        public bool IsRecurring { get; set; }
        public FrequenceEnum Frequence { get; set; }
    }
}