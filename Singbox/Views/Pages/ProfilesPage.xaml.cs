using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Singbox.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace Singbox.Views.Pages
{
    /// <summary>
    /// ProfilesPage.xaml 的交互逻辑
    /// </summary>
    public partial class ProfilesPage : INavigableView<ProfilesViewModel>
    {
        public ProfilesViewModel ViewModel { get; }
        public ProfilesPage(ProfilesViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
