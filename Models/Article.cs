using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MVCApiCall.Models
{
    public class Article
    {
        public string Display_Title { get; set; }
        public string MPAA_Rating { get; set; }
        public string Headline { get; set; }
        public string Summary_Short { get; set; }
        public string Publication_Date { get; set; }
        
        public static List<Article> GetReviews(string apiKey)
        {
            var apiCallTask = ApiHelper.ApiCall(apiKey);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            List<Article> articleList = JsonConvert.DeserializeObject<List<Article>>(jsonResponse["results"].ToString());

            return articleList;
        }
    }
}