using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPF_MVVM_Template.Models;

namespace WPF_MVVM_Template.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private MainModel _newMain { get; }

    public string WelcomeMessage
    {
        get => _newMain.WelcomeMessage;
        set
        {
            _newMain.WelcomeMessage = value;
            OnPropertyChanged();
        }
    }
    
    public MainViewModel()
    {
        _newMain = new MainModel();
        WelcomeMessage = "This is a Community Toolkit MVVM Project";
    }

    [RelayCommand]
    private void ShowMessage()
    {
        WelcomeMessage = "Welcome to MVVM!";
    }
}