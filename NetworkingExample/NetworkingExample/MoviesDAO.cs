using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace NetworkingExample
{
    public class MoviesDAO
    {
        public MoviesDAO()
        {
        }

        public static async void GetMovies(Action<MovieModel[]> success,
                                     Action error)
        {

            String url = "https://baas.kinvey.com/appdata/kid_SyXkBdMVM/movies";

            HttpWebRequest request =
                (HttpWebRequest)WebRequest.Create(new Uri(url));

            request.Headers["Authorization"] = "Basic a2lkX1N5WGtCZE1WTTowMmIxM2Y1MzYzOGU0NjZkYTI2YTI3Y2IxYzNkNTNkNg==";
            request.Headers["X-Kinvey-API-Version"] = "3";

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader reader = new StreamReader(stream);
                    String json = reader.ReadToEnd();

                    MovieModel[] movies = JsonConvert.DeserializeObject<MovieModel[]>(json);

                    success(movies);

                }
            }
        }

    }
}
