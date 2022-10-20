using Microsoft.Maui;
using Microsoft.Maui.Handlers;
using SampleApp.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if ANDROID
using Com.Haibin.Calendarview;
using static Android.Provider.MediaStore;
#endif
namespace SampleApp.Handlers.MAUICalendar
{
    public partial class MAUICalendarHandler
    {
#if ANDROID
        public static IPropertyMapper<MAUICalendarView, MAUICalendarHandler> PropertyMapper = new PropertyMapper<MAUICalendarView, MAUICalendarHandler>(ViewHandler.ViewMapper)
        {
        };
        public MAUICalendarHandler() : base(PropertyMapper)
        {
        }
#endif
    }
}