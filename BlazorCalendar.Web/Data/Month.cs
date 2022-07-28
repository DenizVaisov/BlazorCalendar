using System;
using System.ComponentModel;

namespace BlazorCalendar.Web.Data
{
    ///<summary>
    ///  Перечисление для отображения названий месяцев
    ///</summary>
    public enum Month
    {
        [Description("Январь")] 
        January = 1,

        [Description("Февраль")] 
        February = 2,

        [Description("Март")] 
        March = 3,

        [Description("Апрель")] 
        April = 4,

        [Description("Май")] 
        May = 5,

        [Description("Июнь")] 
        June = 6,

        [Description("Июль")] 
        July = 7,

        [Description("Август")] 
        August = 8,

        [Description("Сентябрь")] 
        September = 9,

        [Description("Октябрь")] 
        October = 10,

        [Description("Ноябрь")] 
        November = 11,
        
        [Description("Декабрь")] 
        December = 12
    }
}