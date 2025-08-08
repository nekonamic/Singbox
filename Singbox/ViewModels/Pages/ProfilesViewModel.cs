using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Singbox.Views.Pages;
using Wpf.Ui;
using Wpf.Ui.Abstractions.Controls;

namespace Singbox.ViewModels.Pages
{
    public partial class ProfilesViewModel(INavigationService navigationService) : ObservableObject, INavigationAware
    {
        public Task OnNavigatedToAsync() => Task.CompletedTask;

        public Task OnNavigatedFromAsync() => Task.CompletedTask;

        [RelayCommand]
        private void NavigateForward()
        {
            _ = navigationService.NavigateWithHierarchy(typeof(NewProfilePage));
        }
    }
}
