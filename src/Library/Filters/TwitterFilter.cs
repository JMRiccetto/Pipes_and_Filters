using TwitterUCU;

namespace CompAndDel.Filters
{
    public class TwitterFilter : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            var twitter = new TwitterImage();
            twitter.PublishToTwitter("Luke terminado", @"lukefinal.jpg");

            return image;
        }
    }
}