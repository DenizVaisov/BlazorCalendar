using System;

namespace BlazorCalendar.Web.Data
{
    ///<summary>
    ///  Сущность для событий
    ///</summary>
    public class EventData {
        public int Id {get; set;}
        public string Text {get; set;}
        public int Day {get; set;}
        public bool IsAllDay {get; set;}
        public DateTime? Date {get; set;}
        public TimeSpan? TimeSpan {get; set;}
    }
}