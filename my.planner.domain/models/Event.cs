using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace my.planner.domain.models
{
    [Table("TB_EVENT")]
    public class Event
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        
        [Column("description")]
        public string Description { get; set; }
        
        [Column("startDate")]
        public DateTime StartDate { get; set; }
        
        [Column("endDate")]
        public DateTime EndDate { get; set; }
        
        [Column("")]
        public RecurringEvent RecurringEvent { get; set; }
        
        [Column("alert")]
        public DateTime Alert { get; set; }
        
        [Column("local")]
        public string Local { get; set; }
    }
}