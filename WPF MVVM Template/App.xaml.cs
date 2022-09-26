using System.Windows;
using WPF_MVVM_Template.ViewModels;
using WPF_MVVM_Template.Views;

namespace WPF_MVVM_Template
{
    public partial class App : Application
    {
        public App()
        {
            
            //Initialize Application
            MainView appView = new MainView();
            MainViewModel appViewModel = new MainViewModel();

            appView.DataContext = appViewModel;
            appView.Show();
        }
    }
}