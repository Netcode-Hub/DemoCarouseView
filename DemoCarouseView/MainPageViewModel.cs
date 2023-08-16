using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCarouseView
{
    public partial class MainPageViewModel : ObservableObject
    {
        public ObservableCollection<CarouselItem> CarouselItems { get; set; } = new();
        public MainPageViewModel()
        {
            CarouselItems.Add(new CarouselItem()
            {
                Title = "We delivery it where ever you are",
                Description = "Our pizza is one of the best you can try",
                Image = "slide4.png"
            });

            CarouselItems.Add(new CarouselItem()
            {
                Title = "Tasty Pizza",
                Description = "Our pizza is very tasty and delicious and you would love it",
                Image = "slide1.png"
            });

            CarouselItems.Add(new CarouselItem()
            {
                Title = "Register Today",
                Description = "Create an account with us to have access to our pizza bay",
                Image = "slide3.png"
            });
        }
    }
}
