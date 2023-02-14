using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace spbftu.Model
{
    public class NavigationButton 
    {
        public Page NavigationPage { get; private set; }
        public String Title { get; private set; }
        public String ImagePath { get; private set; }
        public NavigationButton(string title, Page navigationPage, string imagePath)
        {
            Title = title;
            NavigationPage = navigationPage;
            ImagePath = imagePath;
        }
    }
}
