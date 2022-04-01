using System;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Fields
{
    public class DataMahasiswa<1302194032_Anwar>
    {
        public string namaDepan, namaBelakang;
        public int nim;
        public string fakultas;
    }

    public class Forecast2
    {
        [JsonInclude]
        public string namadepan, namabelakang;
        [JsonInclude]
        public int nim;
        [JsonInclude]
        public string fakultas;
    }
    public class Program
    {
        public static void Main()
        {
            var json =
            @"{""Date"":""2020-09-06T11:31:01.923395-
07:00"",""TemperatureC"":-1,""Summary"":""Cold""} ";
            Console.WriteLine($"Input JSON: {json}");
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
            };
            var forecast = JsonSerializer.Deserialize<Forecast>(json,
            options);
            Console.WriteLine($"forecast.Date: {forecast.Date}");
            Console.WriteLine($"forecast.TemperatureC:
        { forecast.TemperatureC}
            ");
        Console.WriteLine($"forecast.Summary: {forecast.Summary}");
            var roundTrippedJson =

            KONSTRUKSI PERANGKAT LUNAK 30
        JsonSerializer.Serialize<Forecast>(forecast, options);
            Console.WriteLine($"Output JSON: {roundTrippedJson}");
            options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            var forecast2 = JsonSerializer.Deserialize<Forecast2>(json);
            Console.WriteLine($"forecast2.Date: {forecast2.Date}");
            Console.WriteLine($"forecast2.TemperatureC:
        { forecast2.TemperatureC}
            ");
        Console.WriteLine($"forecast2.Summary: {forecast2.Summary}");
            roundTrippedJson =
            JsonSerializer.Serialize<Forecast2>(forecast2, options);
            Console.WriteLine($"Output JSON: {roundTrippedJson}");
        }
    }
}

}