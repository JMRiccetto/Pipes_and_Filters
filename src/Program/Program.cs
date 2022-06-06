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

            /* PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");
        
            IPipe pipeNull = new PipeNull();

            IFilter twitterFilter = new TwitterFilter();
            IPipe pipeSerial6 = new PipeSerial(twitterFilter, pipeNull);

            IFilter saveFilter = new SaveFilter();
            IPipe pipeSerial5 = new PipeSerial(saveFilter, pipeSerial6);
            
            IFilter negativeFilter = new FilterNegative();
            IPipe pipeSerial4 = new PipeSerial(negativeFilter, pipeSerial5);
            
            IPipe pipeSerial3 = new PipeSerial(twitterFilter, pipeSerial4);
            
            IPipe pipeSerial2 = new PipeSerial(saveFilter, pipeSerial3);
            
            IFilter greyScaleFilter = new FilterGreyscale();
            IPipe pipeSerial = new PipeSerial(greyScaleFilter, pipeSerial2);
            
            IPicture result = pipeSerial.Send(picture); */

            //Ejercicio 4:

            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");
        
            IPipe pipeNull = new PipeNull();

            IFilter twitterFilter = new TwitterFilter();
            IPipe pipeSerial6 = new PipeSerial(twitterFilter, pipeNull);

            IFilter saveFilter = new SaveFilter();
            IPipe pipeSerial5 = new PipeSerial(saveFilter, pipeSerial6);
            
            IFilter negativeFilter = new FilterNegative();
            IPipe pipeSerial4 = new PipeSerial(negativeFilter, pipeSerial5);
            
            IPipe pipeSerial3 = new PipeSerial(twitterFilter, pipeSerial4);
            
            IPipe pipeSerial2 = new PipeSerial(saveFilter, pipeSerial3);
            
            IFilter conditionalFilter = new FaceFilter();
            IPipe conditionalForkPipe = new PipeFork(conditionalFilter, pipeSerial2, pipeNull);

            IFilter greyScaleFilter = new FilterGreyscale();
            IPipe pipeSerial = new PipeSerial(greyScaleFilter, pipeSerial2);
            
            IPicture result = pipeSerial.Send(picture);
        }
    }
}