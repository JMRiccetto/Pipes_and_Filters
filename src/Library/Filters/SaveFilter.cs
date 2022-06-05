using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    public class SaveFilter : IFilter
    {
        public int contador = 0;
        public IPicture Filter(IPicture image)
        {
            PictureProvider saveProvider = new PictureProvider();
            saveProvider.SavePicture(image, @$"luke{contador}.jpg");
            contador += 1;
            return image;
        }
    }
}