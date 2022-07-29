using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorCalendar.Web.Data
{
    ///<summary>
    ///  Сущность для событий
    ///</summary>
    public class EventData {
        public int Id {get; set;}

        [Required]
        public string Text {get; set;}

        public bool IsAllDay {get; set;}

        [Required]
        public DateTime? Date {get; set;}

        public TimeSpan? TimeSpan {get; set;}
    }
}