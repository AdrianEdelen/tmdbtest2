using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace tmdbtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TMDBClient();
            Console.WriteLine(client.SearchMovieByTitle("the matrix"));

        }


        static HttpClient BuildClient()
        {
            using HttpClient client = new HttpClient();
            

            return client;
        }


    }
}
