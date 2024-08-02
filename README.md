# TCMB Exchange Rate Information

This project is developed to fetch exchange rate information from the Central Bank of the Republic of Turkey (CBRT) EVDS web service.

## API Information

- **Base URL:** `https://evds2.tcmb.gov.tr`
- **API Key:** `*******` 
  - To create an API key, register on the [EVDS website](https://evds2.tcmb.gov.tr) and get the API information from the profile section.
- **Exchange Rates Endpoint:** `TP_DK_USD_A-TP.DK.USD.S` 
  - You can determine the currency codes from the EVDS website.
- **Start Date:** `01-08-2024` 
  - The date from which the requested exchange rates will start.
- **End Date:** `02-08-2024` 
  - The date up to which the requested exchange rates will continue from the start date.

## Documentation

For detailed information, please refer to the [EVDS Web Service User Guide](https://evds2.tcmb.gov.tr/help/videos/EVDS_Web_Servis_Kullanim_Kilavuzu.pdf).

---

## Example Usage

```csharp
private const string baseUrl = "https://evds2.tcmb.gov.tr"; 
private const string apiKey = "*****"; 
private const string exchangeRates = "TP_DK_USD_A-TP.DK.USD.S"; 
private const string startDate = "01-08-2024"; 
private const string endDate = "02-08-2024"; 
