using spbftu.Model;
using spbftu.Properties;
using spbftu.View.Pages.ContextPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace spbftu.ViewModel
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        private NavigationButton _selectedNavigationButton;

        public List<NavigationButton> NavigationButtons { get; private set; }

        public NavigationButton SelectedNavigationButton
        {
            get
            {
                return _selectedNavigationButton;
            }
            set
            {
                ApplicationViewModel.GetInstance().SlowOpacityAmimation(value.NavigationPage);
                OnPropertyChanged("SelectedNavigationButton");
            }
        }

        public MenuViewModel()
        {
            NavigationButtons = new List<NavigationButton>
            {
                new NavigationButton("Поступления", new Admission(), "../../Resources/postuplenie.jpg"),
                new NavigationButton("Институты", new Institutions(), "../../Resources/instituty.jpg"),
                new NavigationButton("Аспирантура", new PhD(), "../../Resources/aspirantura.jpg"),
                new NavigationButton("Колледж", new Colleges(), "../../Resources/kolledzh.jpg"),
                new NavigationButton("Центр помощи", new StudentHelpCenter(), "../../Resources/pomosh.jpg"),
                new NavigationButton("О нас", new About(), "../../Resources/Logo_SPbFTU_RGB_rus.png"),
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
