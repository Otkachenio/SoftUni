using System;

class TranslateInput
{
    public int toNumber(string input)
    {
        switch (input)
        {
            case "CHU":
                return 0;
            case "TEL":
                return 1;
            case "OFT":
                return 2;
            case "IVA":
                return 3;
            case "EMY":
                return 4;
            case "VNB":
                return 5;
            case "POQ":
                return 6;
            case "ERI":
                return 7;
            case "CAD":
                return 8;
            case "K-A":
                return 9;
            case "IIA":
                return 10;
            case "YLO":
                return 11;
            case "PLA":
                return 12;
            default:
                return 0;
        }
    }
}

