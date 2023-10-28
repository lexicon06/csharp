using System;

namespace Steam
{
    public class SteamIdConverter
{
    private const long steamId64Base = 76561197960265728;

    public static string ConvertToSteamId(long steamId64)
    {
        long steamIdPart = steamId64 - steamId64Base;
        long a = steamIdPart % 2;
        long b = steamIdPart / 2;

        return $"STEAM_0:{a}:{b}";
    }

    public static long ConvertToSteamId64(string steamId)
    {
        string[] parts = steamId.Split(':');
        long a = long.Parse(parts[1]);
        long b = long.Parse(parts[2]);

        return steamId64Base + (b * 2) + a;
    }
}


}