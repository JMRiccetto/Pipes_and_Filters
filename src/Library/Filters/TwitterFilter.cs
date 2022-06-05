using TwitterUCU;

namespace CompAndDel.Filters
{
    public class TwitterFilter : IFilter
    {
        public int contador = 0;
        public IPicture Filter(IPicture image)
        {
            var twitter = new TwitterImage();
            twitter.PublishToTwitter("Juan Riccetto", @$"luke{contador}.jpg");
            contador +=1;
            return image;
        }
    }
}