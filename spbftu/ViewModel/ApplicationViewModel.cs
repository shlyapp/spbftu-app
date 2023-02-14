using spbftu.Model;
using spbftu.View.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using Menu = spbftu.View.Pages.Menu;

namespace spbftu.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private double _animationSpeed;
        private double _frameOpacity;

        private Page _currentPage;

        private Menu _menuPage;

        private static ApplicationViewModel _instanse;

        public async void SlowOpacityAmimation(Page page)
        {
            await Task.Factory.StartNew(() =>
            {
                for (double i = 1.0; i > 0.0; i -= _animationSpeed)
                {
                    FrameOpacity = i;
                    Thread.Sleep(20);
                }
                CurrentPage = page;
                for (double i = 0; i < 1.1; i += _animationSpeed)
                {
                    FrameOpacity = i;
                    Thread.Sleep(20);
                }
            });
        }

        private void LoadPages()
        {
            _menuPage = new Menu();
        }

        private ApplicationViewModel()
        {
            FrameOpacity = 1;
            _animationSpeed = 0.05;

            LoadPages();
            SlowOpacityAmimation(_menuPage);
        }

        public static ApplicationViewModel GetInstance()
        {
            if (_instanse == null)
            {
                _instanse = new ApplicationViewModel();
            }

            return _instanse;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public Page CurrentPage
        {
            get
            {
                return _currentPage;
            }
            private set
            {
                _currentPage = value;
                OnPropertyChanged("CurrentPage");
            }
        }

        public double FrameOpacity
        {
            get
            {
                return _frameOpacity;
            }
            private set
            {
                _frameOpacity = value;
                OnPropertyChanged("FrameOpacity");
            }
        }

        public RelayCommand NavigatedToHome
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    SlowOpacityAmimation(_menuPage);
                });
            }
        }
    }
}
