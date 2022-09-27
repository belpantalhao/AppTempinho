using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppTempinho.Model;

namespace AppTempinho.Services
{
    class DataService
    {
        public static async Task<Tempo> GetPrevisaoDoTempo(string cidade)
        {
            string appId = "55f956f2188a48e78195d2bfa3018ebe";

            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + cidade + "&units=metric" + "&appid=" + appId;
            dynamic resultado = await getDataFromSrevice(queryString).ConfigureAwait(false);

        }
    }
}
