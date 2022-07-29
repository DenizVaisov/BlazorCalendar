using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace  BlazorCalendar.Web.Data
{
    ///<summary>
    ///  Интерфейс репозитория используется в DI
    ///</summary>
    public interface IEventRepository
    {
        Task CreateEvent(EventData data);   
        Task<List<EventData>> LoadEvents(); 
        Task EditEvent(EventData data);
        Task DeleteEvent(EventData data);
    }
}