using System.Collections.ObjectModel;
using Wpf.Ui.Controls;

namespace Singbox.ViewModels.Windows
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _applicationTitle = "Sing-box";

        [ObservableProperty]
        private ObservableCollection<object> _menuItems = new()
        {
            new NavigationViewItem()
            {
                Content = "Overview",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Table24 },
                TargetPageType = typeof(Views.Pages.OverviewPage)
            },
            new NavigationViewItem()
            {
                Content = "Group",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Group24 },
                TargetPageType = typeof(Views.Pages.GroupsPage)
            }
        };

        [ObservableProperty]
        private ObservableCollection<object> _footerMenuItems = new()
        {
            new NavigationViewItem()
            {
                Content = "Logs",
                Icon = new SymbolIcon { Symbol = SymbolRegular.DocumentData24 },
                TargetPageType = typeof(Views.Pages.LogsPage)
            },
            new NavigationViewItem()
            {
                Content = "Profiles",
                Icon = new SymbolIcon { Symbol = SymbolRegular.DocumentBulletList24 },
                TargetPageType = typeof(Views.Pages.ProfilesPage)
            },
            new NavigationViewItem()
            {
                Content = "Settings",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                TargetPageType = typeof(Views.Pages.SettingsPage)
            },
            new NavigationViewItem()
            {
                Content = "NewProfile",
                TargetPageType = typeof(Views.Pages.NewProfilePage),
                Visibility = Visibility.Collapsed
            },
        };

        [ObservableProperty]
        private ObservableCollection<MenuItem> _trayMenuItems = new()
        {
            new MenuItem { Header = "Home", Tag = "tray_home" }
        };
    }
}
