using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1:

            /* PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");
            IFilter negativeFilter = new FilterNegative();
            IFilter greyScaleFilter = new FilterGreyscale();
            IPipe pipeNull = new PipeNull();
            IPipe pipeSerial2 = new PipeSerial(negativeFilter, pipeNull);
            IPipe PipeSerial = new PipeSerial(greyScaleFilter, pipeSerial2);
            IPicture result = pipeSerial2.Send(picture);
            provider.SavePicture(result, @"lukefinal.jpg"); */

            //Ejercicio 2:

            /* PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");
            IFilter negativeFilter = new FilterNegative();
            IFilter saveFilter = new SaveFilter();
            IFilter greyScaleFilter = new FilterGreyscale();
            IPipe pipeNull = new PipeNull();
            IPipe pipeSerial3 = new PipeSerial(negativeFilter, pipeNull);
            IPipe pipeSerial2 = new PipeSerial(saveFilter, pipeSerial3);
            IPipe pipeSerial = new PipeSerial(greyScaleFilter, pipeSerial2);
            IPicture result = pipeSerial.Send(picture);
            provider.SavePicture(result, @"lukefinal.jpg"); */

            //Ejercicio 3:

            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");
            IFilter negativeFilter = new FilterNegative();
            IFilter saveFilter = new SaveFilter();
            IFilter greyScaleFilter = new FilterGreyscale();
            IFilter twitterFilter = new TwitterFilter();    
            IPipe pipeNull = new PipeNull();
            IPipe pipeSerial4 = new PipeSerial(twitterFilter, pipeNull);
            IPipe pipeSerial3 = new PipeSerial(negativeFilter, pipeSerial4);
            IPipe pipeSerial2 = new PipeSerial(saveFilter, pipeSerial3);
            IPipe pipeSerial = new PipeSerial(greyScaleFilter, pipeSerial2);
            IPicture result = pipeSerial.Send(picture);
            provider.SavePicture(result, @"lukefinal.jpg");
        }
    }
}