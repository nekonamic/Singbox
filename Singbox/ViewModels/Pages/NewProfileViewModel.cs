using System.IO;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace Singbox.ViewModels.Pages
{
    public partial class NewProfileViewModel(INavigationService navigationService) : ObservableObject
    {
        [ObservableProperty]
        private int _typeSelectionIndex = 0;
        public Visibility IsLocalVisible => TypeSelectionIndex == 0 ? Visibility.Visible : Visibility.Collapsed;
        public Visibility IsRemoteVisible => TypeSelectionIndex == 1 ? Visibility.Visible : Visibility.Collapsed;


        partial void OnTypeSelectionIndexChanged(int value)
        {
            OnPropertyChanged(nameof(IsLocalVisible));
            OnPropertyChanged(nameof(IsRemoteVisible));
        }

        [ObservableProperty]
        private string _fileName = string.Empty;

        [RelayCommand]
        private void OnCreateProfile()
        {
            try
            {
                string configDir = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    ".config",
                    "sing-box"
                    );

                if (!Directory.Exists(configDir))
                {
                    Directory.CreateDirectory(configDir);
                }

                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

                string filePath = Path.Combine(configDir, $"{FileName}_{timestamp}.json");
                File.WriteAllText(filePath, "{}");
                navigationService.GoBack();
            }
            catch (Exception ex)
            {

            }
        }

    }
}
