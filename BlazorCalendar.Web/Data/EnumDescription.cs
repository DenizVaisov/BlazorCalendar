using System;
using System.ComponentModel;
using System.Linq;

namespace BlazorCalendar.Web.Data
{
    public static class EnumDescription 
    {
        ///<summary>
        ///  Получение описания из DescriptionAttribute Enum
        ///</summary>
        public static string GetEnumDescription(this Enum e)
        {
            var descriptionAttribute = e.GetType().GetMember(e.ToString())[0]
                .GetCustomAttributes(typeof(DescriptionAttribute), inherit: false)[0] 
                as DescriptionAttribute;

            return descriptionAttribute.Description;
        }
    }
}
