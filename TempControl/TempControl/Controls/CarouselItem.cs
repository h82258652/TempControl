using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace TempControl.Controls
{
    public class CarouselItem : SelectorItem
    {
        public CarouselItem()
        {
            this.DefaultStyleKey = typeof(CarouselItem);
        }
    }
}