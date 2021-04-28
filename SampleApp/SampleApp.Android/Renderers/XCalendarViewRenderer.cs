using System;
using System.ComponentModel;
using Android.Content;
using Android.Views;
using Com.Haibin.Calendarview;
using SampleApp.Controls;
using SampleApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(XCalendarView), typeof(XCalendarViewRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class XCalendarViewRenderer :ViewRenderer<XCalendarView, CalendarView >
    {
        private CalendarView calendarView;

        private Context context;

        public XCalendarViewRenderer(Context _context):base(_context)
        {
            context = _context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XCalendarView> e)
        {
            calendarView = new CalendarView(context);
            SetNativeControl(calendarView);
        }
    }
}
