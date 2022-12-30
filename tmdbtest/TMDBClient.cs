using System;
using System.Collections.Generic;
using System.Text;
using tmdbtest.ExtensionMethods;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace tmdbtest
{
    class TMDBClient : HttpClient
    {
        private string _key = "?api_key=692ba3c361bb2af594aac5a5be010159"; //private key


        public TMDBClient(string key)
        {
            _key = key;
            BaseAddress = new Uri("https://api.themoviedb.org/3/");
        }

        public TMDBClient()
        {
            var a = new HttpClient();
            a.GetFromJsonAsync();
        }

        public async Task SearchMovieByTitleAsync(string title)
        {
            var query = $"&query={title.ReplaceSpacesWithPluses()}";

            var requestString = AssembleRequestString("search/movie", query);
            Console.WriteLine(requestString);
            using HttpResponseMessage response = await base.GetFromJsonAsync(requestString);
            
            try
            {

            }
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            return 
        }
        public string SearchShowByTitle(string title)
        {
            var query = $"&query={title.ReplaceSpacesWithPluses()}";

            var requestString = AssembleRequestString("search/show", query);
            Console.WriteLine("requestString");
            return "";
        }




        private string AssembleRequestString(string requestType, List<string> queries)
        {
            var queriesString = "";

            foreach (var q in queries) {
                queriesString += q;
            }
            var reqString = $"{requestType}{ _key}{queriesString}";

            return reqString;
        }

        //overload to allow single query string
        private string AssembleRequestString(string requestType, string query)
        {
            return AssembleRequestString(requestType, new List<string> { query });
        }





    }
}
