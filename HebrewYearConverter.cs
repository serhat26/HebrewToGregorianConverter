using System;
using System.Collections.Generic;

public static class HebrewYearConverter
{
    // Custom mapping of Hebrew year characters to numeric equivalents
    private static readonly Dictionary<char, int> hebrewYearMap = new Dictionary<char, int>
    {
        { 'ת', 400 },
        { 'ש', 300 },
        { 'ר', 200 },
        { 'ק', 100 },
        { 'צ', 90 },
        { 'פ', 80 },
        { 'ע', 70 },
        { 'ס', 60 },
        { 'נ', 50 },
        { 'מ', 40 },
        { 'ל', 30 },
        { 'כ', 20 },
        { 'י', 10 },
        { 'ט', 9 },    // Changed from 9 to 9 + 3000
        { 'ח', 8 },
        { 'ז', 7 },
        { 'ו', 6 },
        { 'ה', 5 },
        { 'ד', 4 },
        { 'ג', 3 },
        { 'ב', 2 },
        { 'א', 1 },
        { 'ך', 5000 }, // Adding mapping for the thousands digit
        { 'ם', 6000 }, // Adding mapping for final mem (5000 + 1000)
        { 'ן', 7000 }, // Adding mapping for final nun (5000 + 2000)
        { 'ף', 8000 }, // Adding mapping for final pe (5000 + 3000)
        { 'ץ', 9000 }, // Adding mapping for final tzadi (5000 + 4000)
    };

    public static int ConvertHebrewYearToNumeric(string hebrewYear)
    {
        int georgianYear = 0;

        bool isAfter5000 = false;

        // The Hebrew year text should be in the format of "נתשע\"ט".
        // We assume that the last character is the final digit of the year, and the preceding characters represent the thousands, hundreds, and tens.
        // For example, "נתשע\"ט" represents 7000 + 400 + 300 + 70 + 9 = 5779.
        for (int i = 0; i < hebrewYear.Length; i++)
        {
            char currentChar = hebrewYear[i];
            if (i == 0 && currentChar == 'ת')
            {
                isAfter5000 = true;
            }

            if (hebrewYearMap.TryGetValue(currentChar, out int value))
            {
                if (i + 1 < hebrewYear.Length && hebrewYearMap.TryGetValue(hebrewYear[i + 1], out int nextValue) && nextValue > value)
                {
                    georgianYear += (nextValue - value);
                    i++; // Skip the next character as it has already been processed
                }
                else
                {
                    georgianYear += value;
                }
            }
            else if (currentChar != '"') // Ignore quote mark
            {
                // If a character is not found in the mapping, you might want to handle it based on your specific requirements.
                throw new ArgumentException("Invalid Hebrew year character: " + currentChar);
            }
        }

        if (isAfter5000)
        {
            georgianYear = georgianYear + 5000;
        }

        return georgianYear;
    }
}
