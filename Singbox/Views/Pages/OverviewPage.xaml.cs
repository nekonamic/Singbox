using Singbox.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace Singbox.Views.Pages
{
    public partial class OverviewPage : INavigableView<OverviewViewModel>
    {
        public OverviewViewModel ViewModel { get; }

        public OverviewPage(OverviewViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
