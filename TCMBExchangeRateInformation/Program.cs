using RestSharp;
using System;
using System.Threading.Tasks;

class Program
{
    private const string baseUrl = "https://evds2.tcmb.gov.tr"; //Api url
    private const string apiKey = "**********"; //To create an ApiKey, you can register to https://evds2.tcmb.gov.tr ​​and get the api information from the profile section.
    private const string exchangeRates = "TP_DK_USD_A-TP.DK.USD.S"; // You can determine the currency codes that will come here from the evds2 website.
    private const string startDate = "01-08-2024"; //You should enter the information on which day the currency codes requested above will start here.
    private const string endDate = "02-08-2024"; // You should enter the information on which day the currency codes requested above will continue from the start date to the next day here.

    static async Task Main(string[] args)
    {
        try
        {
            var response = await GetExchangeRatesAsync(exchangeRates, startDate, endDate);
            if (response.IsSuccessful)
                Console.WriteLine(response.Content);
            else
                Console.WriteLine($"Error: {response.StatusCode} - {response.ErrorMessage}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception occurred: {ex.Message}");
        }
    }

    private static async Task<RestResponse> GetExchangeRatesAsync(string exchangeRates, string startDate, string endDate)
    {
        var client = new RestClient(new RestClientOptions(baseUrl) { MaxTimeout = -1, });
        var request = new RestRequest($"/service/evds/series={exchangeRates}&startDate={startDate}&endDate={endDate}&type=json", Method.Get);
        request.AddHeader("key", apiKey);
        return await client.ExecuteAsync(request);
    }
}