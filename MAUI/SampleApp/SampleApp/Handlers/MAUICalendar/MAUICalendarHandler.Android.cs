#if ANDROID
using Android.Views;
using Android.Widget;
using Com.Haibin.Calendarview;
using Java.Util.Zip;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Handlers;
using SampleApp.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Handlers.MAUICalendar
{
    public partial class MAUICalendarHandler:ViewHandler<MAUICalendarView, LinearLayout>
    {
        protected override LinearLayout CreatePlatformView()
        {            
            var inflater = LayoutInflater.From(Context);
            var result = inflater.Inflate(Resource.Layout.calendar_layout,null) as LinearLayout;            
            return result;
        }
    }
}
#endif