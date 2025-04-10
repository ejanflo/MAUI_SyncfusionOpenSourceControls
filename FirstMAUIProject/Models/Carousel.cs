using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMAUIProject.Models
{
    public class Carousel
    {
        private string _image;

        public Carousel(string imageString)
        {
            Image = imageString;
        }

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
