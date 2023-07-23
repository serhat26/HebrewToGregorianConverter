public static class HebrewMonthConverter
{
    private static Dictionary<string, (int, string)> hebrewToLatinMonthMapping = new Dictionary<string, (int, string)>
    {
        { "תשרי", (1, "Tishrei") },
        { "חשוון", (2, "Cheshvan") },
        { "כסלו", (3, "Kislev") },
        { "טבת", (4, "Tevet") },
        { "שבט", (5, "Shevat") },
        { "אדר", (6, "Adar") },
        { "אדר א", (6, "Adar") },
        { "אדר ב", (7, "Adar Bet") },
        { "ניסן", (8, "Nisan") },
        { "אייר", (9, "Iyar") },
        { "סיוון", (10, "Sivan") },
        { "תמוז", (11, "Tammuz") },
        { "אב", (12, "Av") },
        { "אלול", (13, "Elul") },
    };

    public static (int, string) ConvertHebrewMonthToLatin(string hebrewMonth)
    {
        int currentYear = DateTime.Now.Year; // Get the current year
        bool isLeapYear = IsHebrewLeapYear(currentYear);

        if (hebrewToLatinMonthMapping.TryGetValue(hebrewMonth, out var result))
        {
            if (isLeapYear && hebrewMonth == "אדר")
            {
                result.Item2 = "Adar Bet";
                result.Item1 = 7;
            }
            else if (isLeapYear && hebrewMonth == "אדר א")
            {
                result.Item2 = "Adar";
                result.Item1 = 6;
            }

            return result;
        }
        else
        {
            throw new ArgumentException("Invalid Hebrew month name.");
        }
    }

    public static bool IsHebrewLeapYear(int year)
    {
        // Hebrew leap years occur in the 3rd, 6th, 8th, 11th, 14th, 17th, and 19th years of the 19-year Metonic cycle.
        // The 19th year is a leap year if it is not one of the other leap years in the cycle.
        int rem = year % 19;
        return rem == 3 || rem == 6 || rem == 8 || rem == 11 || rem == 14 || rem == 17 || rem == 0 && year % 4 == 0;
    }
}