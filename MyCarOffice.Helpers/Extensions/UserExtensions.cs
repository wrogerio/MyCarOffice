namespace MyCarOffice.Helpers.Extensions;

public static class UserExtensions
{
    public static string Format_year_yyyy(this DateTime dt) => dt.ToString("yyyy");
    public static string Format_month_mmm(this DateTime dt) => dt.ToString("mmm");
    public static string Format_month_year_MMyyyy(this DateTime dt) => dt.ToString("MM/yyyy");
    public static string Format_date_ddMMyyyy(this DateTime dt) => dt.ToString("dd/MM/yyyy");
    public static string Format_date_hour_ddMMyyyyHH(this DateTime dt) => dt.ToString("dd/MM/yyyy HH");
    public static string Format_date_hour_minute_ddMMyyyyHHmm(this DateTime dt) => dt.ToString("dd/MM/yyyy HH:mm");
    public static string Format_date_time_ddMMyyyyHHmmss(this DateTime dt) => dt.ToString("dd/MM/yyyy HH:mm:ss");
    public static string Format_time_HHmmss(this DateTime dt) => dt.ToString("HH:mm:ss");
}