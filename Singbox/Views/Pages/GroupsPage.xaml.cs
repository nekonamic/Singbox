using Singbox.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace Singbox.Views.Pages
{
    public partial class GroupsPage : INavigableView<GroupsViewModel>
    {
        public GroupsViewModel ViewModel { get; }

        public GroupsPage(GroupsViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
