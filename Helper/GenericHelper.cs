namespace MoopelObjects.Helper;

public class GenericHelper
{
    #region Time Helper
    public static string UtcToString()
    {
        return DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
    }
    public static string EstToString()
    {
        string timeZoneId;

        if (OperatingSystem.IsWindows())
        {
            timeZoneId = "Eastern Standard Time";
        }
        else
        {
            timeZoneId = "America/New_York";
        }

        TimeZoneInfo estZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        DateTime estTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, estZone);
        return estTime.ToString("yyyy-MM-dd HH:mm:ss");
    }
    #endregion
}
