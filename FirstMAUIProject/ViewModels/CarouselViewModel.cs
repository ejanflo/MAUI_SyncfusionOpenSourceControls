using FirstMAUIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMAUIProject.ViewModels
{
    public class CarouselViewModel
    {
        private List<Carousel> imageCollection = new List<Carousel>();

        public CarouselViewModel()
        {
            ImageCollection.Add(new Carousel("image1.png"));
            ImageCollection.Add(new Carousel("image2.png"));
            ImageCollection.Add(new Carousel("image3.png"));
            ImageCollection.Add(new Carousel("image4.png"));
            ImageCollection.Add(new Carousel("image5.png"));
        }

        public List<Carousel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
}
