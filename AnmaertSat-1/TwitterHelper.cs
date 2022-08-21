using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace AnmaertSat_1
{
    class TwitterHelper
    {
        private TwitterClient _twitterClient { get; set; }
        public TwitterHelper(string apikey, string apiSecret, string accessToken, string accessScret)
        {
            _twitterClient = new TwitterClient(apikey, apiSecret, accessToken, accessScret);
        }
    }
}
