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

Console.WriteLine();

string[] sampleHebrewYears = {
            "תשע\"ט",
            "תשפ\"ב",
            "תשע\"ט",
            "תש\"פ",
            "תשע\"ט",
            "תשע\"ט",
            "תשע\"ט",
            "תשע\"ט",
            "תשע\"ז"
        };

foreach (string hebrewYear in sampleHebrewYears)
{
    int georgianYear = HebrewYearConverter.ConvertHebrewYearToNumeric(hebrewYear);
    Console.WriteLine($"Hebrew year: {hebrewYear}, Georgian year: {georgianYear}");
}

