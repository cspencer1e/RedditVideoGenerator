using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using RedditSharp;
using RedditSharp.Things;
using RedditVideoGenerator.Models;
using RestSharp;

namespace RedditVideoGenerator.Tools
{
    public static class RedditTools
    {
        public static InitializationState InitState { get; private set; }
        public static Reddit client;

        public static bool NeedRestart { get => (DateTime.Now - timeSinceInitialization).Duration().TotalSeconds > 3600; }

        static DateTime timeSinceInitialization;

        public static void Initialize()
        {
            if (InitState == InitializationState.INITIALIZED) return;
            Console.WriteLine("Initializing reddit tools...");
            InitState = InitializationState.INITIALIZING;
            
            client = new Reddit(GetToken("309124630807-kvLMu76XzXQ5lcpvyUbXfy2SFbY"));
            timeSinceInitialization = DateTime.Now;

            //Console.WriteLine(JsonConvert.SerializeObject(GetPost("memes", FromTime.Day, 15, 20, "https://www.reddit.com/r/AskMen/comments/m2u2dc/what_did_you_not_know_or_realize_until_after/")));

            InitState = InitializationState.INITIALIZED;
            Console.WriteLine("Reddit tools initialized.");
        }
        
        public static string GetToken(string refreshtoken)
        {
            string requestUrl = "https://www.reddit.com/api/v1/access_token";

            RestClient rc = new RestClient();
            RestRequest request = new RestRequest(requestUrl, RestSharp.Method.POST);
            string encoded = System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes("2EmuTu7q2_dvHg:pdR3MgpIOqTEMycvdylFUPxUVL8"));
            request.AddHeader("Authorization", "Basic " + encoded);

            request.AddParameter("grant_type", "refresh_token");
            request.AddParameter("refresh_token", refreshtoken);

            request.RequestFormat = RestSharp.DataFormat.Json;

            RestResponse restResponse = (RestResponse)rc.Execute(request);
            ResponseStatus responseStatus = restResponse.ResponseStatus;

            return ((dynamic)JsonConvert.DeserializeObject(restResponse.Content)).access_token;
        }

        public static RedditPost GetPost(string sub, FromTime timePeriod, int commentCount, int postDepth, string postID = null)
        {
            //new Random().Next(0,30)
            var post = postID != null ? client.GetPost(new Uri(postID)) : client.GetSubreddit(sub).GetTop(timePeriod).Where(p => !p.NSFW && !p.Url.ToString().Contains("v.redd.it")).Take(postDepth).ToArray()[new Random().Next(0, postDepth)];
            var postObject = new RedditPost(post.Title, post.Url.ToString().Contains("reddit.com") ? post.SelfText : post.Url.ToString(), post.AuthorName, post.Score);

            postObject.comments = new RedditComment[commentCount];
            var comments = post.Comments.Take(commentCount).ToArray();
            for (int i=0;i<commentCount;i++)
            {
                if (i == comments.Length) break;
                postObject.comments[i] = new RedditComment(comments[i].Body, comments[i].AuthorName, comments[i].Score);
            }

            return postObject;
        }
    }
}
