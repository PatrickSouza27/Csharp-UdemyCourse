using System.Globalization;
namespace ex
{
    static class DateTimeExtension
    {
        public static string ElapsedTime(this DateTime ObjTime)
        {
            TimeSpan x = DateTime.Now - ObjTime;

            if (x.TotalHours < 24)
            {
                return x.TotalHours.ToString("F2", CultureInfo.InvariantCulture) + "Hours";
            }
            else
            {
                return x.TotalDays.ToString("F2", CultureInfo.InvariantCulture) + "Days";
            }
        }
    }
}
