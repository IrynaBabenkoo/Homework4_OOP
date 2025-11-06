using System;

public class Converter
{
    private decimal usdRate;
    private decimal eurRate;

    public Converter(decimal usd, decimal eur)
    {
        usdRate = usd;
        eurRate = eur;
    }

    public decimal UahToUsd(decimal uahAmount)
    {
        if (usdRate == 0) return 0;
        return uahAmount / usdRate;
    }

    public decimal UahToEur(decimal uahAmount)
    {
        if (eurRate == 0) return 0;
        return uahAmount / eurRate;
    }

    public decimal UsdToUah(decimal usdAmount)
    {
        return usdAmount * usdRate;
    }

    public decimal EurToUah(decimal eurAmount)
    {
        return eurAmount * eurRate;
    }
}
