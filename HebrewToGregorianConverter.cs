using System;
using System.Collections.Generic;
using System.Globalization;

public class HebrewToGregorianConverter
{
    public static void ConvertHebrewToGregorian(string hebrewDate)
    {
        HebrewCalendar hebrewCalendar = new HebrewCalendar();

        // Split the Hebrew date into its components (day, month, and year)
        string[] dateComponents = hebrewDate.Split(' ');
        string dayPart, monthPart, yearPart = "";
        if (dateComponents.Length == 4)
        {
            dayPart = dateComponents[0];
            monthPart = $"{dateComponents[1]} {dateComponents[2]}";
            yearPart = dateComponents[3];
        }
        else
        {
            dayPart = dateComponents[0];
            monthPart = dateComponents[1];
            yearPart = dateComponents[2];
        }

        int day = HebrewDateConverter.GetHebrewDay(dayPart);
        int year = HebrewYearConverter.ConvertHebrewYearToNumeric(yearPart);

        (int, string) latinMonthInfo = HebrewMonthConverter.ConvertHebrewMonthToLatin(monthPart);

        string hebrewDateInt = $"{day} ({latinMonthInfo.Item1} - {latinMonthInfo.Item2}) {year}";

        // Convert Hebrew date to Gregorian date
        DateTime gregorianDate = new DateTime(year, latinMonthInfo.Item1, day, new HebrewCalendar());

        //Console.WriteLine($"{hebrewDate} -> {gregorianDate.ToString("yyyy-MM-dd")}");
        //Console.WriteLine($"{day} {ConvertHebrewToLatin(monthPart)} {year}");
        Console.WriteLine($"Provided Hebrew date: {hebrewDate} -> Result Hebrew date numeric: {hebrewDateInt} - Gregorian date: {gregorianDate.ToString("yyyy-MM-dd")}");
    }

}
