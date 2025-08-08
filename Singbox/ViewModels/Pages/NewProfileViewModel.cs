namespace Singbox.ViewModels.Pages
{
    public partial class NewProfileViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _TypeSelectionIndex = 0;
        public Visibility IsLocalVisible => _TypeSelectionIndex == 0 ? Visibility.Visible : Visibility.Collapsed;
        public Visibility IsRemoteVisible => _TypeSelectionIndex == 1 ? Visibility.Visible : Visibility.Collapsed;


        partial void OnTypeSelectionIndexChanged(int value)
        {
            OnPropertyChanged(nameof(IsLocalVisible));
            OnPropertyChanged(nameof(IsRemoteVisible));
        }
        [RelayCommand]
        private void OnTest()
        {
            MessageBox.Show("命令被触发了！");
        }

    }
}
