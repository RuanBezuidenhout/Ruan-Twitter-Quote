//Ruan Bezuidenhout Twitter bot that post a tweet with a random selected quote from a list 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace Ruan_Twitter_Quote
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //THE FOLLOWING 4 VARAIBLES WILL REQUIRE THE API TOKENS OF THE ACCOUNT YOU WISH TO TWEET ON
            string consumer_key = "";
            string consumer_secret = "";
            string access_token = "";
            string access_secret = "";

            Random RandNum = new Random();

            string[] RuanHappyQuotes =
            {
                "Things are not always as they seems.",
                "The first appearance deceives many.",
                "If you don't like your destiny, don't accept it.",
                "The time is now.",
                "Doubt kills more dreams than failure ever will.",
                "Only one thing can heal the heart, and that is love.",
                "Weak people wants revenge, while strong people will forgive",
                "The fool wonders, while wize men asks.",
                "Every end marks a new beginning",
                "Don't let other define your fate."
            };

            TwitterClient myUserClient = new TwitterClient(consumer_key, consumer_secret, access_token, access_secret);
            var tweet = await myUserClient.Tweets.PublishTweetAsync(new PublishTweetParameters(RuanHappyQuotes[RandNum.Next(5)] + " #RuanQuotes"));

        }
    }
}
