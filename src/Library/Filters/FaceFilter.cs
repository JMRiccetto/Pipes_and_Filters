using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    public class FaceFilter: IFilter
    {
        public IPicture Filter(IPicture image)
        {
            var CognitiveApi = new CognitiveFace();
            CognitiveApi.Recognize(@"luke.jpg");

            if (CognitiveApi.FaceFound == true)
            {
                IFilter twitter = new TwitterFilter();
                twitter.Filter(image);
            }

            else
            {
                IFilter negativeFilter = new FilterNegative();
                negativeFilter.Filter(image);
            }

            return image;
        }
    }
}