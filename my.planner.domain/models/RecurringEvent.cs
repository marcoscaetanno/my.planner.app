using System.ComponentModel.DataAnnotations.Schema;
using my.planner.domain.enums;

namespace my.planner.domain.models
{
    [Table("TB_RECURRING_EVENT")]
    public class RecurringEvent
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("isRecurring")]
        public bool IsRecurring { get; set; }
        
        [Column("frequence")]
        public FrequenceEnum Frequence { get; set; }
    }
}