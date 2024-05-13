using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace CreatePage.Models
{
    public static class Generator
    {
        public static Dictionary<Type, UIElement> elements = new Dictionary<Type, UIElement>()
        {
            { typeof(bool), new CheckBox() },
            { typeof(ImageSource), new Image() }
            
        };
    }
}
