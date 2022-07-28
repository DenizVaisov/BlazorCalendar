using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace BlazorCalendar.Web.Data
{
    ///<summary>
    ///  Класс репозиторий используется в DI
    ///</summary>
    public class EventRepository : IEventRepository{
       public List<EventData> Events {get; set;} = new();

    ///<summary>
    ///  Инициализация тестовых данных в конструкторе
    ///</summary>
       public EventRepository() 
       {
            Events.Add(new() {
                Id = 1,
                Text = "Тестовое задание",
                TimeSpan = new TimeSpan(20, 0, 0),
                Date = new DateTime(2022, 7, 25)
            });
            Events.Add(new() {
                Id = 2,
                Text = "Продолжаю тестовое",
                TimeSpan = new TimeSpan(11, 0, 0),
                Date = new DateTime(2022, 7, 26)
            });
            Events.Add(new() {
                Id = 3,
                Text = "Чтение",
                TimeSpan = new TimeSpan(21, 0, 0),
                Date = new DateTime(2022, 7, 26)
            });
            Events.Add(new() {
                Id = 4,
                Text = "Прогулка",
                TimeSpan = new TimeSpan(22, 0, 0),
                Date = new DateTime(2022, 7, 26)
            });
            
            Events.Add(new() {
                Id = 5,
                Text = "Продолжаю тестовое",
                TimeSpan = new TimeSpan(10, 50, 0),
                Date = new DateTime(2022, 7, 27)
            });
       }

        ///<summary>    
        ///  Создание события
        ///</summary>
       public async Task CreateEvent(EventData data) 
       {
            data.Id = Events.Max(m => m.Id) + 1;
            Events.Add(data);
            await Task.Yield();
       }

        ///<summary>    
        ///  Удаление события
        ///</summary>
       public async Task DeleteEvent(EventData data) 
       {
          await Task.Yield();
          Events.Remove(data);
       }

        ///<summary>    
        ///  Редактирование события
        ///</summary>
       public async Task EditEvent(EventData data) 
       {
          await Task.Yield();
          int index = Events.IndexOf(data);
          Events[index] = data;
       }

        ///<summary>    
        ///  Загрузка событий
        ///</summary>
       public async Task<List<EventData>> LoadEvents() 
       {
          await Task.Yield();
          return Events;
       }
    }
}