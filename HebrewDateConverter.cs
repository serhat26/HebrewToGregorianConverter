
public static class HebrewDateConverter
{
    public static int GetHebrewDay(string hebrewDay)
    {
        switch (hebrewDay)
        {
            case "א": return 1;
            case "ב": return 2;
            case "ג": return 3;
            case "ד": return 4;
            case "ה": return 5;
            case "ו": return 6;
            case "ז": return 7;
            case "ח": return 8;
            case "ט": return 9;
            case "י": return 10;
            case "יא": return 11;
            case "יב": return 12;
            case "יג": return 13;
            case "יד": return 14;
            case "טו": return 15;
            case "טז": return 16;
            case "יז": return 17;
            case "יח": return 18;
            case "יט": return 19;
            case "כ": return 20;
            case "כא": return 21;
            case "כב": return 22;
            case "כג": return 23;
            case "כד": return 24;
            case "כה": return 25;
            case "כו": return 26;
            case "כז": return 27;
            case "כח": return 28;
            case "כט": return 29;
            case "ל": return 30;
            default: throw new ArgumentException("Invalid Hebrew day.");
        }
    }
}

