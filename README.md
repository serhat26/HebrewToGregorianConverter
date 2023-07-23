# Hebrew to Gregorian Date Converter

This repository contains C# code for converting Hebrew dates to Gregorian dates. The code provides four main classes to facilitate the conversion process: `HebrewToGregorianConverter`, `HebrewYearConverter`, `HebrewMonthConverter`, and `HebrewDateConverter`.

## HebrewToGregorianConverter

The `HebrewToGregorianConverter` class includes a method `ConvertHebrewToGregorian(string hebrewDate)` to convert full Hebrew dates ("יד טבת תשע\"ט") to Gregorian dates. It utilizes the `HebrewYearConverter`, `HebrewMonthConverter`, and `HebrewDateConverter` to convert the Hebrew year, month and day, respectively. The resulting Gregorian date is displayed in the format "yyyy-MM-dd."

## HebrewYearConverter

The `HebrewYearConverter` class includes methods to convert Hebrew year characters to their numeric equivalents. It uses a custom mapping of Hebrew year characters to handle different forms of Hebrew years, including those after 5000.

**Sample Output**

Here are some sample conversions of Hebrew year characters to their numeric equivalents:

1. Hebrew year: תשע"ט, Georgian year: 5779
2. Hebrew year: תשפ"ב, Georgian year: 5782

## HebrewMonthConverter

The `HebrewMonthConverter` class includes methods to convert Hebrew month names to their Latin (Gregorian) equivalents. It handles leap years and maps the correct month numbers based on the Hebrew month names.

## HebrewDateConverter

The `HebrewDateConverter` class includes a method `GetHebrewDay(string hebrewDay)` to convert Hebrew day characters to their numeric equivalents.

## Usage

1. Import the required classes from the respective namespaces: `HebrewToGregorianConverter`, `HebrewYearConverter`, `HebrewMonthConverter`, and `HebrewDateConverter`.
2. Use the `HebrewToGregorianConverter.ConvertHebrewToGregorian(string hebrewDate)` method, passing a Hebrew date as a string in the format "day month year" like "יד טבת תשע\"ט"

**Note:** The output will be printed to the console. If you wish to use the converted date in your code, you have two options:
- Store it in a variable and use it as needed.
- Modify the `ConvertHebrewToGregorian` method to return the Gregorian date as a `DateTime` object.

**Note:** Ensure that the Hebrew date is correctly formatted, and the Hebrew month names are spelled correctly.

Feel free to use and modify this code according to your specific requirements. If you encounter any issues or need further assistance, please reach out. Happy coding!

You can use the provided code to perform similar conversions for your own Hebrew dates.

## Example

```csharp
using System;

class Program
{
    static void Main()
    {
        string[] hebrewDates = {
            "יד טבת תשע\"ט",
            "כז אייר תשפ\"ב",
            "כו אדר א תשע\"ט",
            "יח ניסן תש\"פ",
            "כט אדר ב תשע\"ט",
            "כ שבט תשע\"ט",
            "יד אדר ב תשע\"ט",
            "כ טבת תשע\"ט",
            "כב טבת תשע\"ז",
            "כד תמוז תשע\"ו",
            "ז שבט תשע\"ז"
        };

        foreach (string hebrewDateStr in hebrewDates)
        {
            HebrewToGregorianConverter.ConvertHebrewToGregorian(hebrewDateStr);
        }
    }
}

```

## Sample Output

Here are some sample conversions of Hebrew dates to Gregorian dates:

1. Provided Hebrew date: יד טבת תשע"ט -> Result Hebrew date numeric: 14 (4 - Tevet) 5779 - Gregorian date: 2018-12-22
2. Provided Hebrew date: כז אייר תשפ"ב -> Result Hebrew date numeric: 27 (9 - Iyar) 5782 - Gregorian date: 2022-05-28
3. Provided Hebrew date: כו אדר א תשע"ט -> Result Hebrew date numeric: 26 (6 - Adar) 5779 - Gregorian date: 2019-03-03
4. Provided Hebrew date: יח ניסן תש"פ -> Result Hebrew date numeric: 18 (8 - Nisan) 5780 - Gregorian date: 2020-05-12
5. Provided Hebrew date: כט אדר ב תשע"ט -> Result Hebrew date numeric: 29 (7 - Adar Bet) 5779 - Gregorian date: 2019-04-05
6. Provided Hebrew date: כ שבט תשע"ט -> Result Hebrew date numeric: 20 (5 - Shevat) 5779 - Gregorian date: 2019-01-26
7. Provided Hebrew date: יד אדר ב תשע"ט -> Result Hebrew date numeric: 14 (7 - Adar Bet) 5779 - Gregorian date: 2019-03-21
8. Provided Hebrew date: כ טבת תשע"ט -> Result Hebrew date numeric: 20 (4 - Tevet) 5779 - Gregorian date: 2018-12-28
9. Provided Hebrew date: כב טבת תשע"ז -> Result Hebrew date numeric: 22 (4 - Tevet) 5777 - Gregorian date: 2017-01-20
10. Provided Hebrew date: כד תמוז תשע"ו -> Result Hebrew date numeric: 24 (11 - Tammuz) 5776 - Gregorian date: 2016-07-30
11. Provided Hebrew date: ז שבט תשע"ז -> Result Hebrew date numeric: 7 (5 - Shevat) 5777 - Gregorian date: 2017-02-03

